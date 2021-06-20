
using System.Windows.Forms;
using Team_Project_Paint.OnlinePaint.Helpers;

namespace Team_Project_Paint
{
    public partial class RemoteLoadForm : Form
    {
        public RemoteLoadForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var tmp = new RemoteFileInfoSource();
            var list = tmp.GetRemoteFilseList(1);

            foreach (var obj in list)
            {
                var id = dataGridRemoteLoad.Rows.Add();
                dataGridRemoteLoad.Rows[id].Cells[fileNameColumn.Name].Value = obj.FileName;
                dataGridRemoteLoad.Rows[id].Cells[fileSizeColumn.Name].Value = obj.Size;
                dataGridRemoteLoad.Rows[id].Cells[fileIdColumn.Name].Value = obj.Id;
                dataGridRemoteLoad.Rows[id].Cells[createDateColumn.Name].Value = obj.CreateDate;
            }
        }
    }
}
