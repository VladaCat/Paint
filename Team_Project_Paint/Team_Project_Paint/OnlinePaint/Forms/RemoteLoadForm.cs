
using System;
using System.Windows.Forms;
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
                if (loadImageResult.ImageType == "json")
                {
                    mainForm._bl.JsonOpen(loadImageResult.ImageData, mainForm._currentBitmap);
                }
                else if (loadImageResult.ImageType == "jpg" || loadImageResult.ImageType == "png" || loadImageResult.ImageType == "bmp")
                {
                    mainForm._bl.RemoteLoadBitmap(loadImageResult.ImageData, mainForm._currentBitmap);
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
    }
}
