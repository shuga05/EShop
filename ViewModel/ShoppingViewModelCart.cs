using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EShop.Models;

namespace EShop.ViewModel
{
    public class ShoppingViewModelCart
    {
        [Key]
        public int CartId { get; set; }
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }

    }
}