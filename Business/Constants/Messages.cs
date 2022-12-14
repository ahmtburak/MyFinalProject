using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed= "Ürünler Listelendi.";
        public static string UnitPriceInvalid = "Ürün Fiyatı geçersiz";
        public static string ProductCountOfCategoryError = "Bu kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Ürün ismi zaten var.";
        public static string CategoryLimitExceded = "Bu kategorideki ürün limiti aşıldı.";
    }
}
