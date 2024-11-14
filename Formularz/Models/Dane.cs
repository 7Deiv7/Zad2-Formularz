using System.ComponentModel.DataAnnotations;
namespace Formularz.Models
{
    public class Dane
    {
        public int Id {  get; set; }

        [Required(ErrorMessage = "Podaj Imię")]
        [MinLength(2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki")]
        public string Imie { get; set; }

        [Required(ErrorMessage ="Podaj Nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Podaj Email")]
        [EmailAddress(ErrorMessage = "Podaj poprawny adres e-mail")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Podaj Hasło")]
        [MinLength(8, ErrorMessage ="Hasło musi mieć co najmniej 8 znaków")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).+$", ErrorMessage = "Hasło musi zawierać co najmniej jedną cyfrę, jedną dużą literę i jedną małą literę")]

        public string Haslo {  get; set; }

        [Required( ErrorMessage ="Potwierdź Hasło")]
        [DataType(DataType.Password)]
        [Compare("Haslo", ErrorMessage ="Hasła nie są takie same!")]
        public string PotwierdzenieHasla { get; set; }

        [Phone( ErrorMessage ="Podaj poprawny numer telefonu")]
        public string NumerTelefonu { get; set; }

        [Range(10,80, ErrorMessage ="Podaj wiek od 10 do 80")]
        public int? Wiek {  get; set; }

        [Required( ErrorMessage="Wybierz miasto")]
        public string Kategoria { get; set; } 
        public enum Kategorie
        {
             Stuttgart = 1,
             Triest = 2,
             Bucharest = 3,
             Izmir = 4,
             Copenhagen = 5

        }
    }
}

