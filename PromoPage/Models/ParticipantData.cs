using System.ComponentModel.DataAnnotations;

namespace PromoPage.Models
{
    public class ParticipantData
    {       
        [Required(ErrorMessage = "Укажите имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Укажите фамилию")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Укажите отчество")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Укажите агентство")]
        public string TourAgency { get; set; }

        [Required(ErrorMessage = "Укажите ИНН")]
        [MaxLength(10, ErrorMessage = "ИНН состоит из 10 цифр")]
        public string INN { get; set; }

        [Required(ErrorMessage = "Укажите позицию")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Укажите город")]
        public string City { get; set; }

        [Required(ErrorMessage = "Укажите телефон")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^((\+7|7|8)+([0-9]){10})$", ErrorMessage = "Номер указан неверно")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Укажите email")]
        public string Email { get; set; }
    }
}