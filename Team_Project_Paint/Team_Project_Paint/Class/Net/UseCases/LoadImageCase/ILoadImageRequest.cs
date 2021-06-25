using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project_Paint.Net
{
    public interface ILoadImageRequest
    {
        LoadImageResultData LastLoadImageResultData { get; }
        HttpStatusCode LastHttpStatusCode { get; }
        bool Execute();
    }
}
