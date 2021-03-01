using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {

        public static string[] ValidImageFileTypes = { ".JPG",".JPEG",".PNG",".GIF","BMP",".ICO", ".TIF", ".TIFF" };

        public static string InvalidImageExtension = "Dosya uzantısı geçersiz.\nGeçerli dosya uzantıları:" + string.Join(",", ValidImageFileTypes);

        public static string CarAdded = "Araba eklendi";
        public static string CarUpdated = "Araba güncellendi"; 
        public static string CarDeleted = "Araba silindi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarListed = "Araba listelendi";
        public static string CarsListed = "Arabalar listelendi";
        public static string GetColorIdListed = "Renge göre listelendi";
        public static string GetBrandIdListed = "Markaya göre listelendi";
        public static string GetModelIdListed = "Modele göre listelendi";


        public static string ColorAdded = "Renk eklendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorNameInvalid = "Renk ismi geçersiz";
        public static string ColorListed = "Renk listelendi";
        public static string ColorsListed = "Renkler listelendi";
        
        
        public static string BrandAdded = "Marka eklendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string BrandListed = "Marka listelendi";
        public static string BrandsListed = "Markalar listelendi";
        

        public static string ModelAdded = "Model eklendi";
        public static string ModelUpdated = "Model güncellendi";
        public static string ModelDeleted = "Model silindi";
        public static string ModelNameInvalid = "Model ismi geçersiz";
        public static string ModelListed = "Model listelendi";
        public static string ModelsListed = "Modeller listelendi";


        public static string CarImageOutOfExceeded = "Araç resim adedi aşıldı.";
        public static string CarImageMustBeExits = "Verilen resim numarasına ait resim bulunamadı.";
        public static string CarHaveNoImage = "Arabaya ait resim yok.";
    }
}
