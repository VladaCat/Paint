
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Team_Project_Paint.Class.OperationWithFigures;
using Team_Project_Paint.Net;
using Team_Project_Paint.OnlinePaint.Helpers;

namespace Team_Project_Paint
{
    public partial class RemoteLoadForm : Form
    {
        public RemoteLoadForm()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, System.EventArgs e)
        {
            var mainForm = FormsManager.mainForm;

            LoadImageInfo loadImageInfo = new LoadImageInfo()
            {
                UserId = StaticNet.NetLogic.UserID,
                ImageId = Convert.ToInt32(txtImageId.Text)
            };

            LoadImageResultData loadImageResult = LoadImage(loadImageInfo);

            if (loadImageResult.LoadImageResult)
            {
                mainForm._bl.Clear();
                mainForm._currentBitmap = new PaintBitmap(mainForm.pictureBoxMain.Width, mainForm.pictureBoxMain.Height);
                mainForm._bufferedBitmap = mainForm._currentBitmap.Clone() as PaintBitmap;
                mainForm.pictureBoxMain.Image = mainForm._currentBitmap.ToImage();
                mainForm.Repaint();

                if (loadImageResult.ImageType == "json")
                {
                    mainForm._bl.JsonOpen(loadImageResult.ImageData, mainForm._currentBitmap);
                    mainForm.Repaint();
                }
                else if (loadImageResult.ImageType == "jpg" || loadImageResult.ImageType == "png" || loadImageResult.ImageType == "bmp")
                {
                    mainForm.pictureBoxMain.Image = Image.FromStream(mainForm._bl.RemoteLoadBitmap(loadImageResult.ImageData, mainForm._currentBitmap));
                }
            
                Hide();
            }
            else
            {
                MessageBox.Show("Open image failed");
            }

        }

        private LoadImageResultData LoadImage(LoadImageInfo loadImageInfo)
        {
            var request = new LoadImageRequest(loadImageInfo, StaticNet.NetLogic.PaintServerUrl);
            if (request.Execute())
            {
                return request.LastLoadImageResultData;
            }
            else
            {
                LoadImageResultData loadImageResultData = new LoadImageResultData()
                {
                    ImageData = "",
                    ImageType = "",
                    LoadImageResult = false,
                    LoadImageResultMessage = "Bad"
                };
                return loadImageResultData;
            }
        }

        private void btnTemoLoadFiles_Click(object sender, EventArgs e)
        {

            GetFilesListInfo getFilesListInfo = new GetFilesListInfo()
            {
                UserId = StaticNet.NetLogic.UserID
            };

            GetFilesListResultData getFilesListResultData = GetFilesList(getFilesListInfo);
            FillFilesDataGrid(getFilesListResultData.SavedFileInfo);

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
                for (int i = 0; i < savedFilesList.Count; i++)
            {
                dataGridRemoteLoad.Rows.Add();

                dataGridRemoteLoad.Rows[i].Cells[0].Value = savedFilesList[i].ImageId;
                dataGridRemoteLoad.Rows[i].Cells[1].Value = savedFilesList[i].ImageName;
                dataGridRemoteLoad.Rows[i].Cells[2].Value = savedFilesList[i].ImageType;
                dataGridRemoteLoad.Rows[i].Cells[3].Value = savedFilesList[i].CreateDate;
                dataGridRemoteLoad.Rows[i].Cells[4].Value = savedFilesList[i].FileSize;
                

                //dataGridRemoteLoad.Rows[i].Cells["FileName"].Value = savedFilesList[i].ImageId;

            }
        }
    }
}
