using FiorelloBack.DAL;
using FiorelloBack.Models;
using FiorelloBack.ViewModels;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloBack.Services
{
    public class LayoutServices
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContext;

        public LayoutServices(AppDbContext context,IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContext = httpContextAccessor;
        }

        public Setting getSettingDatas()
        {
            Setting data = _context.Settings.FirstOrDefault();
            return data;
        }
        public BasketVM ShowBasket()
        {
            string basket = _httpContext.HttpContext.Request.Cookies["Basket"];
            BasketVM basketVM = JsonConvert.DeserializeObject<BasketVM>(basket);

            //foreach (var item in basketVM.BasketItems)
            //{
            //    item.Flower = _context.Flowers.FirstOrDefault(f => f.Id == item.Flower.Id);
            //}
            return basketVM;
        }
    }
}
