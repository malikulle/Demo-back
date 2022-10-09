using ECommerce.Data.Domain.AddressBook;
using ECommerce.Data.Domain.Configuration;
using ECommerce.Data.Domain.Membership;
using ECommerce.Framework.SharedLibary.Domain.Enums;
using ECommerce.Framework.SharedLibary.Hashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Persistence.Contexts
{
    public static class SeedDatabase
    {
        public static List<Country> GetCountries()
        {
            return new List<Country>()
            {
                new Country(){ID = 1,Name = "Türkite",CodeISO = "TR",CodeISO3 = "TUR",PhoneCode = "90",StatusID = StatusValue.ActiveStatusID}
            };
        }

        public static List<City> GetCities()
        {
            var list = new List<City>()
            {
                new City() { Name = "Adana", CountryID = 1, PlateCode = "01" },
            new City() { Name = "Adıyaman", CountryID = 1, PlateCode = "02" },
            new City() { Name = "Afyon", CountryID = 1, PlateCode = "03" },
            new City() { Name = "Ağrı", CountryID = 1, PlateCode = "04" },
            new City() { Name = "Amasya", CountryID = 1, PlateCode = "05" },
            new City() { Name = "Ankara", CountryID = 1, PlateCode = "06" },
            new City() { Name = "Antalya", CountryID = 1, PlateCode = "07" },
            new City() { Name = "Artvin", CountryID = 1, PlateCode = "08" },
            new City() { Name = "Aydın", CountryID = 1, PlateCode = "09" },
            new City() { Name = "Balıkesir", CountryID = 1, PlateCode = "10" },
            new City() { Name = "Bilecik", CountryID = 1, PlateCode = "11" },
            new City() { Name = "Bingöl", CountryID = 1, PlateCode = "12" },
            new City() { Name = "Bitlis", CountryID = 1, PlateCode = "13" },
            new City() { Name = "Bolu", CountryID = 1, PlateCode = "14" },
            new City() { Name = "Burdur", CountryID = 1, PlateCode = "15" },
            new City() { Name = "Bursa", CountryID = 1, PlateCode = "16" },
            new City() { Name = "Çanakkale", CountryID = 1, PlateCode = "17" },
            new City() { Name = "Çankırı", CountryID = 1, PlateCode = "18" },
            new City() { Name = "Çorum", CountryID = 1, PlateCode = "19" },
            new City() { Name = "Denizli", CountryID = 1, PlateCode = "20" },
            new City() { Name = "Diyarbakır", CountryID = 1, PlateCode = "21" },
            new City() { Name = "Edirne", CountryID = 1, PlateCode = "22" },
            new City() { Name = "Elazığ", CountryID = 1, PlateCode = "23" },
            new City() { Name = "Erzincan", CountryID = 1, PlateCode = "24" },
            new City() { Name = "Erzurum", CountryID = 1, PlateCode = "25" },
            new City() { Name = "Eskişehir", CountryID = 1, PlateCode = "26" },
            new City() { Name = "Gaziantep", CountryID = 1, PlateCode = "27" },
            new City() { Name = "Giresun", CountryID = 1, PlateCode = "28" },
            new City() { Name = "Gümüşhane", CountryID = 1, PlateCode = "29" },
            new City() { Name = "Hakkari", CountryID = 1, PlateCode = "30" },
            new City() { Name = "Hatay", CountryID = 1, PlateCode = "31" },
            new City() { Name = "Isparta", CountryID = 1, PlateCode = "32" },
            new City() { Name = "İçel", CountryID = 1, PlateCode = "33" },
            new City() { Name = "İstanbul", CountryID = 1, PlateCode = "34" },
            new City() { Name = "İzmir", CountryID = 1, PlateCode = "35" },
            new City() { Name = "Kars", CountryID = 1, PlateCode = "36" },
            new City() { Name = "Kastamonu", CountryID = 1, PlateCode = "37" },
            new City() { Name = "Kayseri", CountryID = 1, PlateCode = "38" },
            new City() { Name = "Kırklareli", CountryID = 1, PlateCode = "39" },
            new City() { Name = "Kırşehir", CountryID = 1, PlateCode = "40" },
            new City() { Name = "Kocaeli", CountryID = 1, PlateCode = "41" },
            new City() { Name = "Konya", CountryID = 1, PlateCode = "42" },
            new City() { Name = "Kütahya", CountryID = 1, PlateCode = "43" },
            new City() { Name = "Malatya", CountryID = 1, PlateCode = "44" },
            new City() { Name = "Manisa", CountryID = 1, PlateCode = "45" },
            new City() { Name = "Kahramanmaraş", CountryID = 1, PlateCode = "46" },
            new City() { Name = "Mardin", CountryID = 1, PlateCode = "47" },
            new City() { Name = "Muğla", CountryID = 1, PlateCode = "48" },
            new City() { Name = "Muş", CountryID = 1, PlateCode = "49" },
            new City() { Name = "Nevşehir", CountryID = 1, PlateCode = "50" },
            new City() { Name = "Niğde", CountryID = 1, PlateCode = "51" },
            new City() { Name = "Ordu", CountryID = 1, PlateCode = "52" },
            new City() { Name = "Rize", CountryID = 1, PlateCode = "53" },
            new City() { Name = "Sakarya", CountryID = 1, PlateCode = "54" },
            new City() { Name = "Samsun", CountryID = 1, PlateCode = "55" },
            new City() { Name = "Siirt", CountryID = 1, PlateCode = "56" },
            new City() { Name = "Sinop", CountryID = 1, PlateCode = "57" },
            new City() { Name = "Sivas", CountryID = 1, PlateCode = "58" },
            new City() { Name = "Tekirdağ", CountryID = 1, PlateCode = "59" },
            new City() { Name = "Tokat", CountryID = 1, PlateCode = "60" },
            new City() { Name = "Trabzon", CountryID = 1, PlateCode = "61" },
            new City() { Name = "Tunceli", CountryID = 1, PlateCode = "62" },
            new City() { Name = "Şanlıurfa", CountryID = 1, PlateCode = "63" },
            new City() { Name = "Uşak", CountryID = 1, PlateCode = "64" },
            new City() { Name = "Van", CountryID = 1, PlateCode = "65" },
            new City() { Name = "Yozgat", CountryID = 1, PlateCode = "66" },
            new City() { Name = "Zonguldak", CountryID = 1, PlateCode = "67" },
            new City() { Name = "Aksaray", CountryID = 1, PlateCode = "68" },
            new City() { Name = "Bayburt", CountryID = 1, PlateCode = "69" },
            new City() { Name = "Karaman", CountryID = 1, PlateCode = "70" },
            new City() { Name = "Kırıkkale", CountryID = 1, PlateCode = "71" },
            new City() { Name = "Batman", CountryID = 1, PlateCode = "72" },
            new City() { Name = "Şırnak", CountryID = 1, PlateCode = "73" },
            new City() { Name = "Bartın", CountryID = 1, PlateCode = "74" },
            new City() { Name = "Ardahan", CountryID = 1, PlateCode = "75" },
            new City() { Name = "Iğdır", CountryID = 1, PlateCode = "76" },
            new City() { Name = "Yalova", CountryID = 1, PlateCode = "77" },
            new City() { Name = "Karabük", CountryID = 1, PlateCode = "78" },
            new City() { Name = "Kilis", CountryID = 1, PlateCode = "79" },
            new City() { Name = "Osmaniye", CountryID = 1, PlateCode = "80" },
            new City() { Name = "Düzce", CountryID = 1, PlateCode = "81" },
            };
            for (int i = 1; i <= list.Count; i++)
            {
                var city = list[i - 1];
                city.ID = i;
                city.StatusID = StatusValue.ActiveStatusID;
            }
            return list;
        }

        public static List<Role> GetRoles()
        {
            return new List<Role>()
            {
                new Role(){ ID = 1 ,Name = "Admin",StatusID = StatusValue.ActiveStatusID},
                new Role(){ ID = 2 ,Name = "User",StatusID = StatusValue.ActiveStatusID}
            };
        }

        public static List<User> GetUsers()
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash("admin1234", out passwordHash, out passwordSalt);
            var admin = new User()
            {
                ID = 1,
                Name = "Admin",
                Surname = "Admin",
                FullName = "Admin Admin",
                EmailAddress = "admin@admin.com",
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                RoleID = 1,
                IsGlobalAdmin = true,
                StatusID = StatusValue.ActiveStatusID,
            };

            var user = new User()
            {
                ID = 2,
                Name = "User",
                Surname = "User",
                FullName = "User User",
                EmailAddress = "user@user.com",
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                RoleID = 2,
                IsGlobalAdmin = false,
                StatusID = StatusValue.ActiveStatusID,
            };
            return new List<User>() { admin, user };    
        }

        public static List<Language> GetLanguages()
        {
            return new List<Language>()
            {
                new Language(){ID = 1,Name = "Türkçe", CultureCode = "tr" , IsoCode = "tr",StatusID = StatusValue.ActiveStatusID},
                new Language(){ID = 2,Name = "English", CultureCode = "en" , IsoCode = "en",StatusID = StatusValue.ActiveStatusID}
            };
        }
    }
}
