
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
            var mainForm = FormsManager.mainForm;
            bool saveResult = false;
            var image = mainForm._bl.RemoteSave(mainForm._currentBitmap, cmbImageFormat.Text);
            if (cmbImageFormat.Text == "bmp" || cmbImageFormat.Text == "png" || cmbImageFormat.Text == "jpeg")
            {
                SaveImageInfo saveImageInfo = new SaveImageInfo()
                {
                    Name = txtFileName.Text,
                    ImageType = cmbImageFormat.Text,
                    FileSize = image.Length,
                    UserId = StaticNet.NetLogic.UserID,
                    ImageData = image,
                };
                saveResult = StaticNet.NetLogic.SaveImage(saveImageInfo);
                if (saveResult)
                {
                    MessageBox.Show("Ваша картинка сохранена успешно");
                }
                else
                {
                    MessageBox.Show("Ваша картинка не сохранена");
                }
            }
            else
            {
                JsonLogic jsonLogic = new JsonLogic();
                jsonLogic.JsonSerialize(mainForm._bl._storage.GetAll());
                SaveImageInfo saveImageInfo = new SaveImageInfo()
                {
                    Name = txtFileName.Text,
                    ImageType = cmbImageFormat.Text,
                    FileSize = jsonLogic.File.Length*2,
                    UserId = StaticNet.NetLogic.UserID,
                    ImageData = jsonLogic.File,
                };
                saveResult = StaticNet.NetLogic.SaveImage(saveImageInfo);
                if (saveResult)
                {
                    MessageBox.Show("Ваша картинка сохранена успешно");
                }
                else
                {
                    MessageBox.Show("Ваша картинка не сохранена");
                }
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
