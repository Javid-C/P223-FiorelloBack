using FiorelloBack.DAL;
using FiorelloBack.Models;
using FiorelloBack.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloBack.Controllers
{
    public class FlowerController : Controller
    {
        private readonly AppDbContext _context;
        public FlowerController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Details(int id)
        {

            Flower flower = _context.Flowers.Include(f => f.Campaign).Include(f => f.FlowerCategories).ThenInclude(fc => fc.Category).Include(f => f.FlowerTags).ThenInclude(ft => ft.Tag).Include(f => f.FlowerImages).FirstOrDefault(f => f.Id == id);
            return View(flower);
        }

        #region Session

        //public IActionResult setSession(int id)
        //{
        //    Flower flower = _context.Flowers.FirstOrDefault(f => f.Id == id);

        //    HttpContext.Session.SetString("Session", flower.Name);

        //    return RedirectToAction("Index", "Home");
        //}
        //public IActionResult ShowSession()
        //{
        //    var basket = HttpContext.Session.GetString("Session");
        //    return Content(basket);
        //}

        #endregion


        #region Cookie

        //public IActionResult SetCookie(int id)
        //{
        //    Flower flower = _context.Flowers.FirstOrDefault(f => f.Id == id);

        //    HttpContext.Response.Cookies.Append("Cookie", flower.Name);
        //    return RedirectToAction("Index", "Home");
        //}

        //public IActionResult ShowCookie()
        //{
        //    return Content(HttpContext.Request.Cookies["Cookie"]);
        //}
        //public IActionResult DeleteCookie(string key)
        //{
        //    HttpContext.Response.Cookies.Delete(key);
        //    return RedirectToAction("Index", "Home");
        //}

        #endregion

        public IActionResult AddBasket(int id)
        {
            Flower flower = _context.Flowers.FirstOrDefault(f => f.Id == id);

            string basket = HttpContext.Request.Cookies["Basket"];

            //List<Flower> flowers;
            if(basket == null)
            {
                BasketVM basketVM = new BasketVM
                {
                    BasketItems = new List<BasketItemVM>(),
                    TotalPrice = flower.Price,
                    Count = 1

                };

                BasketItemVM basketItemVM = new BasketItemVM
                {
                    Flower = flower,
                    Count = 1
                };

                basketVM.BasketItems.Add(basketItemVM);
                string basketStr = JsonConvert.SerializeObject(basketVM);

                HttpContext.Response.Cookies.Append("Basket", basketStr);
                //flowers = new List<Flower>();
                //flowers.Add(flower);
            }
            else
            {
                BasketVM basketVM = JsonConvert.DeserializeObject<BasketVM>(basket);
                BasketItemVM basketItemVM = basketVM.BasketItems.FirstOrDefault(f => f.Flower.Id == flower.Id);
                if(basketItemVM == null)
                {
                    basketItemVM = new BasketItemVM
                    {
                        Flower = flower,
                        Count = 1
                    };
                    basketVM.BasketItems.Add(basketItemVM);
                    basketVM.Count++;
                }
                else
                {
                    basketItemVM.Count++;
                }

                basketVM.TotalPrice += flower.Price;
                Math.Round(basketVM.TotalPrice, 2);
                string basketStr = JsonConvert.SerializeObject(basketVM);

                HttpContext.Response.Cookies.Append("Basket", basketStr);
                //flowers = JsonConvert.DeserializeObject<List<Flower>>(basket);
                //flowers.Add(flower);
            }
            //string basketStr = JsonConvert.SerializeObject(flowers);
            
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ShowBasket()
        {
            string basketStr = HttpContext.Request.Cookies["Basket"];
            BasketVM basket = JsonConvert.DeserializeObject<BasketVM>(basketStr);
            return Json(basket);
        }
    }
}
