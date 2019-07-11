using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShop.Models
{ 
    public class Item
    {
        [Key]
        public int ItemId { get; set; }

        [DisplayName("Category")]
        public int CategoryId { get; set; }
        [DisplayName("Product")]
        public int ProductId { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        [DisplayName("Description")]
        public string Descript { get; set; }

        [Required]
        [StringLength(1024)]
        public string Image { get; set; }

        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}