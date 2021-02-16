using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class CarMessages
    {
        public static string CarsListed = "Tüm arabalar listelendi";
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba bilgileri güncellendi";
        public static string CarDescriptionInvalid = "Eklenen araba açıklaması en az 2 harften oluşmalıdır.";
        public static string CarDailyPriceInvalid = "Araba günlük fiyatı 0 dan büyük olmalıdır.";
        public static string CarUndelivered = "Araba teslim edilmemiştir, kiralanamaz.";
        public static string CarRented = "Araba kiralandı.";
        public static string CarNotDeleted = "Araba silinemedi!";
    }
}
