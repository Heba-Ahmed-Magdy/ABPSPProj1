﻿using System.ComponentModel.DataAnnotations;

namespace ABPsinglePageProj1.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}
