
using System.Windows.Forms;
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
            var bl = FormsManager.mainForm;
            bool saveResult = false;
            var image = bl._bl.RemoteSave(bl._currentBitmap, cmbImageFormat.Text);
            SaveImageInfo saveImageInfo = new SaveImageInfo()
            {
                Name = txtFileName.Text,
                ImageType = "imagetype",
                FileSize = 568,
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

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
