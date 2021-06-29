using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.Net;

namespace Team_Project_Paint
{
    public partial class RemoteSaveForm : Form
    {
        public RemoteSaveForm()
        {
            InitializeComponent();
            cmbImageFormat.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            BoolStringType saveImageResult= SaveImage(txtFileName.Text, cmbImageFormat.Text);
            if (saveImageResult.BooleanValue)
            {
                RequeryRemoteFilesList();
            }
            else
            {
                MessageBox.Show("Save Image Error\n" + saveImageResult.StringValue);
            }
            
        }


        private void RemoteSaveForm_VisibleChanged(object sender, System.EventArgs e)
        {
            if (Visible)
            {
                RequeryRemoteFilesList();
            }
        }

        private GetFilesListResultData GetFilesList(GetFilesListInfo getFilesListInfo)
        {
            var request = new GetFilesListRequestGen<GetFilesListInfo, GetFilesListResultData>(getFilesListInfo, StaticNet.NetLogic.PaintServerUrl);
            if (request.Execute() == System.Net.HttpStatusCode.OK)
            {
                return request.LastResponceDTO;
            }
            else
            {
                GetFilesListResultData getFilesListResultData = new GetFilesListResultData()
                {
                    GetFilesListResult = false,
                    GetFilesListResultMessage = ((int)request.LastHttpStatusCode).ToString() + request.LastHttpStatusCode.ToString() + request.LastHttpStatusText,
                    SavedFileInfo = new List<SavedFileInfo>()
                };
                return getFilesListResultData;
            }
        }

        private void FillFilesDataGrid(List<SavedFileInfo> savedFilesList)
        {
            dataGridRemoteImages.Rows.Clear();

            
            foreach (var el in savedFilesList)
            {
                var i = dataGridRemoteImages.Rows.Add();

                dataGridRemoteImages.Rows[i].Cells[0].Value = el.ImageId;
                dataGridRemoteImages.Rows[i].Cells[1].Value = el.ImageName;
                dataGridRemoteImages.Rows[i].Cells[2].Value = el.ImageType;
                dataGridRemoteImages.Rows[i].Cells[3].Value = el.CreateDate;
                dataGridRemoteImages.Rows[i].Cells[4].Value = el.FileSize;
                dataGridRemoteImages.Rows[i].Cells[5].Value = "Delete";
            }
            
        }

        private BoolStringType SaveImageRaster(string fileName, string fileType)
        {
            var mainForm = FormsManager.mainForm;
            var image = mainForm._bl.RemoteSaveBitmap(mainForm._currentBitmap, fileType);

            SaveImageInfo saveImageInfo = new SaveImageInfo()
            {
                Name = fileName,
                ImageType = fileType,
                FileSize = image.Length * 2,
                UserId = StaticNet.NetLogic.UserID,
                ImageData = image,
            };
            return StaticNet.NetLogic.SaveImageGen(saveImageInfo);
        }
        private BoolStringType SaveImageJSON(string fileName, string fileType)
        {
            var mainForm = FormsManager.mainForm;
            JsonLogic jsonLogic = new JsonLogic();
            jsonLogic.JsonSerialize(mainForm._bl._storage.GetAll());
            SaveImageInfo saveImageInfo = new SaveImageInfo()
            {
                Name = fileName,
                ImageType = fileType,
                FileSize = jsonLogic.File.Length * 2,
                UserId = StaticNet.NetLogic.UserID,
                ImageData = jsonLogic.File,
            };
            return StaticNet.NetLogic.SaveImageGen(saveImageInfo);

        }


        private BoolStringType SaveImage(string fileName, string fileType)
        {
            if (fileType == "bmp" || fileType == "png" || fileType == "jpeg")
            {

                return SaveImageRaster(fileName, fileType);
            }
            else
            {
                return SaveImageJSON(fileName, fileType);
            }
        }


        private BoolStringType DeleteRemoteImage(int imageId, int userId)
        {
            DeleteImageInfo deleteImageInfo = new DeleteImageInfo()
            {
                ImageId = imageId,
                UserId = userId
            };
            var deleteImageRequest = new DeleteImageRequestGen<DeleteImageInfo, DeleteImageResultData>(deleteImageInfo, StaticNet.NetLogic.PaintServerUrl);
             
            if (deleteImageRequest.Execute()==System.Net.HttpStatusCode.OK)
            {
                var response = new BoolStringType()
                {
                    BooleanValue = true,
                    StringValue = deleteImageRequest.LastHttpStatusText
                };
                return response;
            }
            else
            {
                var response = new BoolStringType()
                {
                    BooleanValue = false,
                    StringValue = deleteImageRequest.LastHttpStatusText
                };
                return response;
            }

        }

        private void RequeryRemoteFilesList()
        {
            GetFilesListInfo getFilesListInfo = new GetFilesListInfo()
            {
                UserId = StaticNet.NetLogic.UserID
            };

            GetFilesListResultData getFilesListResultData = GetFilesList(getFilesListInfo);
            
            if (getFilesListResultData.GetFilesListResult)
            {
                FillFilesDataGrid(getFilesListResultData.SavedFileInfo);
            }
            else
            {
                MessageBox.Show("Cant load saved files list\n" + getFilesListResultData.GetFilesListResultMessage);
            }
            
        }

        private void dataGridRemoteImages_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex != 5)
            {
                string imageType = dataGridRemoteImages.Rows[e.RowIndex].Cells[2].Value.ToString();
                string imageName = dataGridRemoteImages.Rows[e.RowIndex].Cells[1].Value.ToString();
                int imageId = Convert.ToInt32(dataGridRemoteImages.Rows[e.RowIndex].Cells[0].Value.ToString());

                var result = MessageBox.Show("Выбранный файл будет перезаписан", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var deleteImageResult = DeleteRemoteImage(imageId, StaticNet.NetLogic.UserID);
                    if (deleteImageResult.BooleanValue )
                    {
                        BoolStringType saveImageResult = SaveImage(imageName, imageType);
                        if (saveImageResult.BooleanValue)
                        {
                            RequeryRemoteFilesList();
                        }
                        else
                        {
                            MessageBox.Show("Cant save image after deletion\n" + saveImageResult.StringValue);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cant delete saved image\n" + deleteImageResult.StringValue );
                    }

                }
                else
                {
                    MessageBox.Show("Something goes wrong");
                }
            }
        }

        private void dataGridRemoteImages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex==5)
            {
                var msgBoxResult = MessageBox.Show("Do you really want to delete this picture?",
                                "Confirm Deletion", MessageBoxButtons.YesNo);
                if (msgBoxResult == DialogResult.Yes)
                {
                   var deleteImageResult= DeleteRemoteImage(Convert.ToInt32(dataGridRemoteImages.Rows[e.RowIndex].Cells[0].Value), StaticNet.NetLogic.UserID);
                    if (deleteImageResult.BooleanValue)
                    {
                        RequeryRemoteFilesList();
                    }
                    else
                    {
                        MessageBox.Show("Cant delete this image\n" + deleteImageResult.StringValue);
                    }
                }   
            }
        }
    }
}
