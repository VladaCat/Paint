using System.Collections.Generic;

namespace Team_Project_Paint.Net
{
    public class GetFilesListResultData
    {
        public bool GetFilesListResult { get; set; }
        public string GetFilesListResultMessage { get; set; }
        public List<SavedFileInfo> SavedFileInfo { get; set; }

        public GetFilesListResultData()
        {
            SavedFileInfo = new List<SavedFileInfo>();
        }
    }
}
