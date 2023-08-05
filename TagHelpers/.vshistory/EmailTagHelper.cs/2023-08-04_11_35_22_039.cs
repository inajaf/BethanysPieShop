﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BethanysPieShop.TagHelpers
{
    public class EmailTagHelper: TagHelper
    {
        public string? Address { get; set; }
        public string? Email { get; set; }
    }
}
