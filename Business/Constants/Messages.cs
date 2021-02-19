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

        public static string BrandAdded="Marka eklendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandListed="Markalar listelendi";

        public static string UserDeleted = "kullanıcı silindi";
        public static string UserInserted = "kullanıcı eklendi";
        public static string UserUpdated = "kullanıcı güncellendi";
        public static string UserListed = "kullanıcılar listelendi";

        public static string CustomerDeleted="Müşteri silindi";
        public static string CustomerInserted="Müşteri eklendi";
        public static string CustomerUpdated="müşteri güncellendi";
        public static string CustomerListed="Müşteriler listelendi";

        public static string SuccessDeleted="kiralama kaydı silindi";
        public static string SuccessInserted="kiralama kaydı eklendi";
        public static string SuccessUpdated="kiralama kaydı güncellendi";

        internal static string ErrorInserted="Araç kirada,teslim edilmemiş";
    }
}
