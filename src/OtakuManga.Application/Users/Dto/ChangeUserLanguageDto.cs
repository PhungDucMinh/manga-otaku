using System.ComponentModel.DataAnnotations;

namespace OtakuManga.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}