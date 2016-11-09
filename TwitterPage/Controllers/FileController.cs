using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TwitterPage.Controllers
{
    public class FileController : Controller
    {
        public FileResult GetFile(string name)
        {


            var dir = Server.MapPath("/Content/Images");
            //ImageFormat imgFormat = GetImageFormat(file.Extension);
            var path = Path.Combine(dir, name + ".png"); //validate the path for security or use other means to generate the path.
            return base.File(path, "image/png");

            //DB.UploadedFile file;

            //file = DB.UploadedFile.GetFile(4, DB.UploadedFile.UploadedFileType.IMAGE, id, name);

            //if (file != null && DB.UploadedFile.IsImage(file.Filename))
            //{
            //    ImageFormat imgFormat = GetImageFormat(file.Extension);

            //    if (imgFormat != ImageFormat.Icon)
            //    {
            //        return File(file.FileContentsAsByteArray, file.ContentType);
            //    }
            //}
            //return null;
        }
    }
}