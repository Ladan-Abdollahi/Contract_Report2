using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace  Contract_Report2.CommonLayer.PublicClass
{
    public interface IUploadFiles
    {
        string UploadFileFunc(IEnumerable<IFormFile> files, string uploadPath);
        string UploadAttachamentFunc(IEnumerable<IFormFile> files, string uploadPath, string username);
    }
}
