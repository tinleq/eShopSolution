using eShopSolution.ApiIntegration;
using eShopSolution.Ultilities.Constants;
using eShopSolution.ViewModel.Sales;
using eShopSolution.WebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.WebApp.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductApiClient _productApiClient;

        public CartController(IProductApiClient productApiClient)
        {
            _productApiClient = productApiClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetListItems()
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            return Ok(currentCart);
        }

        public async Task<IActionResult> AddToCart(int id, string languageId)
        {
            var product = await _productApiClient.GetById(id, languageId);
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);

            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if(session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            }

            int quantity = 1;
            if(currentCart.Any(x => x.ProductId == id))
            {
                quantity = currentCart.First(x => x.ProductId == id).Quantity + 1;
            }

            var cartItem = new CartItemViewModel() 
            {
                ProductId = id,
                Description = product.Description,
                Image = product.ThumbnailImage,
                Name = product.Name,
                Price = product.Price,
                Quantity = quantity
            };

            currentCart.Add(cartItem);

            HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(currentCart));
            return Ok();
        }


        public IActionResult UpdateCart(int id, int quantity)
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);

            foreach (var item in currentCart)
            {
                if (item.ProductId == id)
                {
                    if (quantity == 0)
                    {
                        currentCart.Remove(item);
                        break;
                    }
                    item.Quantity = quantity;
                }
            }

            HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(currentCart));
            return Ok(currentCart);
        }

        public IActionResult CheckOut()
        {
            return View(GetCheckOutViewModel());
        }

        [HttpPost]
        public IActionResult CheckOut(CheckOutViewModel request)
        {
            var model = GetCheckOutViewModel();

            var orderDetails = new List<OrderDetailVM>();
            foreach(var item in model.CartItems)
            {
                orderDetails.Add(new OrderDetailVM() 
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                }); 
            }

            var checkoutRequest = new CheckOutRequest()
            {
                Address = request.CheckOutModel.Address,
                Name = request.CheckOutModel.Name,
                Email = request.CheckOutModel.Email,
                PhoneNumber = request.CheckOutModel.PhoneNumber,
                OrderDetails = request.CheckOutModel.OrderDetails
            };

            TempData["SuccessMrg"] = "Order puschased successful";
            return View(model);
        }

        private CheckOutViewModel GetCheckOutViewModel()
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();

            if(session!= null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            }
            var checkoutVM = new CheckOutViewModel() 
            {
                CartItems = currentCart,
                CheckOutModel = new CheckOutRequest()
            };
            return checkoutVM;
        }
    }
}
