using System.Collections.Generic;

namespace Team_Project_Paint.Net
{
    public class StatisticResultData
    {
        public bool StatisticResult { get; set; }
        public string StatisticResultMessage { get; set; }
        public List<StatisticItem> StatisticItems { get; set; }

        public StatisticResultData()
        {
            StatisticItems = new List<StatisticItem>();
        }
     
    }
}
