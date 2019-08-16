using System.ComponentModel.DataAnnotations;

namespace ABPsinglePageProj1.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}