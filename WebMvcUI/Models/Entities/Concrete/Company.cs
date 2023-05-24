using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebMvcUI.Models.Entities.Abstract;

namespace WebMvcUI.Models.Entities.Concrete
{
    public class Company : BaseEntity
    {
        [MaxLength(100)]
        [DisplayName("Şirket Adı")]
        [Required(ErrorMessage = "Lütfen şirket adını giriniz!")]
        public string Name { get; set; }

        [DisplayName("Şirket Unvanı")]
        public string Title { get; set; }
        [DisplayName("Bağlı Bulunduğu Şirket")]
        public int? ParentCompanyID { get; set; }

        [Required(ErrorMessage = "Lütfen email adresinizi giriniz!")]
        [EmailAddress]
        [DisplayName("Şirket Maili")]
        public string Email { get; set; }
        [DisplayName("Paket")]
        [Required(ErrorMessage = "Lütfen paket seçiniz!")]
        public int PackageID { get; set; }

        [DisplayName("Paket Başlangıç Tarihi")]
        [Required(ErrorMessage = "Lütfen paket başlangıç tarihini giriniz!")]
        public DateTime PackageStartingDate { get; set; }

        [DisplayName("Paket Bitiş Tarihi")]
        public DateTime? PackageEndDate { get; set; }

        [DisplayName("Paket Süresi")]
        [Required(ErrorMessage = "Lütfen paket süresini giriniz!")]
        public int PackageTime { get; set; }

        [DisplayName("Paket Adı")]
        public string PackageName { get; set; }
        [DisplayName("Maksimum Kullanıcı Sayısı")]
        public int PackageNumberOfUsers { get; set; }

        [DisplayName("Toplam Paket Tutarı")]
        public string PackageTotalPrice { get; set; }
        public virtual User User { get; set; }

        [DisplayName("Paket")]
        public virtual Package Package { get; set; }
        public bool Informed { get; set; } // Paket bitim tarihine az kaldığıyla ilgili bilgilendirme maili gitti mi?

        [DisplayName("Üst Şirket")]
        public virtual Company ParentCompany { get; set; }
        public virtual List<PersonalPermit> PersonalPermits { get; set; }
        public virtual List<PersonalAdvance> PersonalAdvances { get; set; }
        public virtual List<PersonalExpense> PersonalExpenses { get; set; }

        public Company()
        {
            PersonalPermits = new List<PersonalPermit>();
            PersonalAdvances = new List<PersonalAdvance>();
            PersonalExpenses = new List<PersonalExpense>();
        }
    }
}
