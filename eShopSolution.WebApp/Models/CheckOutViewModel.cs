using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopSolution.ViewModel.Sales;

namespace eShopSolution.WebApp.Models
{
    public class CheckOutViewModel
    {
        public List<CartItemViewModel> CartItems { get; set; }

        public  CheckOutRequest CheckOutModel { get; set; }
    }
}
