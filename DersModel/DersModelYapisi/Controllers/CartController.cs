using DersModelYapisi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DersModelYapisi.Controllers
{
	public class CartController : Controller
	{
		public IActionResult Index()
		{
			var product1 = new ProductViewModel { Id = 1, Name = "Product 1", Price = 10 };
			var product2 = new ProductViewModel { Id = 2, Name = "Product 2", Price = 20 };
			var product3 = new ProductViewModel { Id = 3, Name = "Product 3", Price = 30 };

			var cartProduct1 = new CartProductViewModel { Id = 1, Product = product1, Quantity = 10, Price = 5 };
			var cartProduct2 = new CartProductViewModel { Id = 2, Product = product2, Quantity = 7, Price = 8 };
			var cartProduct3 = new CartProductViewModel { Id = 3, Product = product3, Quantity = 3, Price = 15 };

			var cartProducts = new List<CartProductViewModel> { cartProduct1, cartProduct2, cartProduct3 };


			return View(cartProducts);
		}
	}
}
