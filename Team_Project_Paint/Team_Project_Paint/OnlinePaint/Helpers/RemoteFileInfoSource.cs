using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project_Paint.OnlinePaint.Helpers
{
    public class RemoteFileInfoSource
    {

        public List<RemoteFileInfo> GetRemoteFilseList(int id)
        {
            List<RemoteFileInfo> tmp = new List<RemoteFileInfo>();
            var obj1 = new RemoteFileInfo();
            obj1.CreateDate = "11.06.2021";
            obj1.Size = 155;
            obj1.FileName = "Picture New Apple";
            obj1.Id = 1;
            tmp.Add(obj1);

            obj1 = new RemoteFileInfo();
            obj1.CreateDate = "12.05.2021";
            obj1.Size = 147;
            obj1.FileName = "Picture New Link";
            obj1.Id = 2;
            tmp.Add(obj1);

            obj1 = new RemoteFileInfo();
            obj1.CreateDate = "02.01.2020";
            obj1.Size = 26498;
            obj1.FileName = "Picture New Space";
            obj1.Id = 3;
            tmp.Add(obj1);

            return tmp;
        }
    }
}
