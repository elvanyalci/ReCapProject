using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Araba eklendi";
        public static string ProductNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime="sistem bakımda";
        public static string CarListed="arabalar listelendi";
        public static string CarAdded = "araba eklendi";
        public static string CarUpdated = "araba güncellendi";
        public static string CarDeleted = "araba silindi";

        public static string ColorAdded="renk eklendi";
        public static string ColorUpdated="renk güncellendi";
        public static string ColorDeleted="renk silindi";
        public static string ColorListed="renkler listelendi";

        internal static string BrandAdded="Marka eklendi";
        internal static string BrandUpdated = "Marka güncellendi";
        internal static string BrandDeleted = "Marka silindi";
    }
}
