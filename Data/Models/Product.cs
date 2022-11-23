﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]

        public double Price { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string? CreatedBy { get; set; } = "user";

        public DateTime ? UpdatedDate { get; set; }

        public string ? UpdatedBy { get; set; } = "user";
        [ValidateNever]
        public int SubCategoryId { get; set; }
       
        public SubCategory SubCategory { get; set; }

    }
}
