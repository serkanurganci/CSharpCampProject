using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Urun Eklendi";
        public static string ProductNameInvalid = "Urun Eklendi";
        public static string MaintenanceTime = "Sistem Bakimda";
        public static string ProductsListed = "Urunler Listelendi.";
        public static string ProductCountOfCategoryError = "Urun sayisi kategori sinirini asiyor.";
        public static string ProductNameAlreadyExist = "Bu isimde zaten baska bir urun var";
        public static string CategoryLimitExceded = "Kategori Limiti asildi.";
        public static string AuthorizationDenied = "Yetkilendirme Reddedildi";
    }
}
