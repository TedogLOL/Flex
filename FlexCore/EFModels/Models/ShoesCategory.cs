﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EFModels.Models
{
    public partial class ShoesCategory
    {
        public ShoesCategory()
        {
            CustomizedShoesPos = new HashSet<CustomizedShoesPo>();
        }

        public int ShoesCategoryId { get; set; }
        public string ShoesCategoryName { get; set; }

        public virtual ICollection<CustomizedShoesPo> CustomizedShoesPos { get; set; }
    }
}