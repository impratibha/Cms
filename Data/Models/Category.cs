﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Category
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string? UpdatedBy { get; set; }

        //navigation properties
        public List<SubCategory> subCategories { get; set; }

    }
}
