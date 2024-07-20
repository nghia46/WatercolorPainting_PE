﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Dto
{
    public class WatercolorsPaintingDto
    {
        [RegularExpression("^[A-Z][a-zA-Z0-9]*$", ErrorMessage = "The first letter must be uppercase, and only letters and numbers are allowed.")]

        public required string PaintingName { get; set; } = null!;

        public required string PaintingDescription { get; set; }

        public required string PaintingAuthor { get; set; }

        public required decimal Price { get; set; }

        public required int PublishYear { get; set; }
        public required string StyleId { get; set; }
    }
}
