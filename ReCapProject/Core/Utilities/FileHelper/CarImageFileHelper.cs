using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Core.Utilities.FileHelper
{
    public class CarImageFileHelper
    {
        public static string Add(IFormFile file)
        {
            string extesion = Path.GetExtension(file.FileName).ToUpper();
            string newGUID = CreateGuid() + extesion;
            var directory = Directory.GetCurrentDirectory()+"\\wwwroot";
            var path = directory + @"\Images";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string imagePath;
            using (FileStream fileStream = File.Create(path+"\\"+newGUID))
            {
                file.CopyToAsync(fileStream);
                imagePath = path + "\\" + newGUID;
                fileStream.Flush();
                
            }
            return imagePath.Replace("\\", "/");
        }

        public static string Update(IFormFile file,string oldImagePath)
        {
            Delete(oldImagePath);
            return Add(file);
        }
        public static void Delete(string imagePath)
        {
            if (File.Exists(imagePath.Replace("/","\\")) && Path.GetFileName(imagePath)!="default.png")
            {
                File.Delete(imagePath.Replace("/","\\"));
            }

        }


        public static string CreateGuid()
        {
            return Guid.NewGuid().ToString("N") + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" +
                   DateTime.Now.Year;
        }
    }
}
