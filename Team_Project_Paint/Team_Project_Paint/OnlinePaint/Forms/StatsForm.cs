using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team_Project_Paint.Net;

namespace Team_Project_Paint
{
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {

            FormsManager.mainForm.Show();
            Hide();
        }

        private void StatsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormsManager.mainForm.Show();
            Hide();
        }
        private void RequeryRemoteStatistics()
        {
            StatisticInfo statisticsInfo = new StatisticInfo()
            {
                UserId = StaticNet.NetLogic.UserID
            };

           StatisticResultData statisticResultData = GetStatistics(statisticsInfo);
            FillStatisticsDataGrid(statisticResultData.StatisticItems);
        }
        private void FillStatisticsDataGrid(List<StatisticItem> statisticItems)
        {
            dataGridStatistics.Rows.Clear();


            foreach (var el in statisticItems)
            {
                var i = dataGridStatistics.Rows.Add();

                dataGridStatistics.Rows[i].Cells[0].Value = el.StatisticName;
                dataGridStatistics.Rows[i].Cells[1].Value = el.StatisticValue;
                
            }

        }
        private StatisticResultData GetStatistics(StatisticInfo statisticInfo)
        {
            var request = new StatisticRequest(statisticInfo, StaticNet.NetLogic.PaintServerUrl);
            if (request.Execute())
            {
                return request.LastStatisticResultData;
            }
            else
            {
                StatisticResultData statisticResultData = new StatisticResultData()
                {
                    StatisticResult = false,
                    StatisticResultMessage = "Bad",
                    StatisticItems = new List<StatisticItem>()
                };
                return statisticResultData;
            }
        }

        private void StatsForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                //GetStatistics( new StatisticInfo() { UserId=StaticNet.NetLogic.UserID });
                RequeryRemoteStatistics();
            }
        }
    }
}
