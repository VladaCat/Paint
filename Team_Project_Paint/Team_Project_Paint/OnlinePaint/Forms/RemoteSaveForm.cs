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

        }


        private void RemoteSaveForm_VisibleChanged(object sender, System.EventArgs e)
        {
            if (Visible)
            {
                GetFilesListInfo getFilesListInfo = new GetFilesListInfo()
                {
                    UserId = StaticNet.NetLogic.UserID
                };

                GetFilesListResultData getFilesListResultData = GetFilesList(getFilesListInfo);
                FillFilesDataGrid(getFilesListResultData.SavedFileInfo);
            }
        }

        private GetFilesListResultData GetFilesList(GetFilesListInfo getFilesListInfo)
        {
            var request = new GetFilesListRequest(getFilesListInfo, StaticNet.NetLogic.PaintServerUrl);
            if (request.Execute())
            {
                return request.LastGetFilesListResultData;
            }
            else
            {
                GetFilesListResultData getFilesListResultData = new GetFilesListResultData()
                {
                    GetFilesListResult = false,
                    GetFilesListResultMessage = "Bad",
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

        private bool SaveImageRaster(string fileName, string fileType)
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
            return StaticNet.NetLogic.SaveImage(saveImageInfo);
        }
        private bool SaveImageJSON(string fileName, string fileType)
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
            return StaticNet.NetLogic.SaveImage(saveImageInfo);

        }


        private bool SaveImage(string fileName, string fileType)
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

       
        private bool DeleteRemoteImage(int imageId, int userId)
        {
            DeleteImageInfo deleteImageInfo = new DeleteImageInfo()
            {
                ImageId = imageId,
                UserId = userId
            };
            DeleteImageRequest deleteImageRequest = new DeleteImageRequest(deleteImageInfo, StaticNet.NetLogic.PaintServerUrl);
            return (deleteImageRequest.Execute());

        }

        private void RequeryRemoteFilesList()
        {
            GetFilesListInfo getFilesListInfo = new GetFilesListInfo()
            {
                UserId = StaticNet.NetLogic.UserID
            };

            GetFilesListResultData getFilesListResultData = GetFilesList(getFilesListInfo);
            FillFilesDataGrid(getFilesListResultData.SavedFileInfo);
        }

        private void dataGridRemoteImages_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex != 5)
            {
                string imageType = dataGridRemoteImages.Rows[e.RowIndex].Cells[2].Value.ToString();
                string imageName = dataGridRemoteImages.Rows[e.RowIndex].Cells[1].Value.ToString();
                int imageId = Convert.ToInt32(dataGridRemoteImages.Rows[e.RowIndex].Cells[0].Value.ToString());

                var result = MessageBox.Show("Выбранный файл будет перезписан", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (DeleteRemoteImage(imageId, StaticNet.NetLogic.UserID))
                    {
                        if (SaveImage(imageName, imageType))
                        {
                            MessageBox.Show("Image overwriten succesfully");
                        }
                        else
                        {
                            MessageBox.Show("Something goes wrong");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Something goes wrong");
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

        }
    }
}
