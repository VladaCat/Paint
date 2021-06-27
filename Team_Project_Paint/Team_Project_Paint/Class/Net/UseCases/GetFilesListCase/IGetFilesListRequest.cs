using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project_Paint.Net
{
    public interface IGetFilesListRequest
    {
        GetFilesListResultData LastGetFilesListResultData { get; }
        HttpStatusCode LastHttpStatusCode { get; }
        bool Execute();
    }
}
