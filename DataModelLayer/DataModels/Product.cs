using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataModelLayer.DataModels
{
    /// <summary>
    /// کالا
    /// </summary>
   public class Product
    {
        public int Id { set; get; }

        [Display(Name ="نام فارسی")]
        public string FarsiName { set; get; }

        [Display(Name ="نام انگلیسی")]
        public string EnglishName { set; get; }

    }
}
