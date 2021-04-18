using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "araç eklendi";
        public static string CarDeleted = "araç silindi";
        public static string CarUpdated = "araç güncellendi";
        public static string CarNameInValid = "araç açıklaması hatalı";
        public static string CarDailyPriceInValid = "aracın fiyatı hatalı";
        public static string CarsListed = "araçlar listelendi";

        //public static string MaintenanceTime="sistem bakımda";

        public static string BrandsListed = "modeller listelendi";
        public static string BrandAdded = "model eklendi";
        public static string BrandDeleted = "model silindi";
        public static string BrandUpdated = "model güncellendi";

        public static string ColorsListed = "renkler listelendi";
        public static string ColorAdded = "renk eklendi";
        public static string ColorDeleted = "renk silindi";
        public static string ColorUpdated = "renk güncellendi";

        public static string CustomersListed = "müşteriler listelendi";
        public static string CustomerAdded = "müşteri eklendi";
        public static string CustomerDeleted = "müşteri silindi";
        public static string CustomerUpdated = "müşteri güncellendi";

        public static string RentalsListed = "kiralama işlemleri listelendi";
        public static string RentalAdded = "kiralama işlemi eklendi";
        public static string RentalDeleted = "kiralama işlemi silindi";
        public static string RentalUpdated = "kiralama işlemi güncellendi";

        public static string UserAdded = "kullanıcı eklendi!";
        public static string UserDeleted = "kullanıcı silindi!";
        public static string UserUpdated = "kullanıcı güncellendi!";
        //public static string UserNameInvalid = "kullanıcı ismi geçersiz!";
        public static string UsersListed = "kullanıcılar listelendi";

        public static string CarImageCountLimitExceeded = "5 tane arabadan fazla yükleyemezsin" ;
        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string UserRegistered="Kayıt oldu.";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Parola hatası";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string AccessTokenCreated="access token oluşturuldu";
    }
}
