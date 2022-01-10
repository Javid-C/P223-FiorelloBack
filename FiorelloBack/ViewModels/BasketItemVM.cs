using FiorelloBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloBack.ViewModels
{
    public class BasketItemVM
    {
        public Flower Flower{ get; set; }
        public int Count { get; set; }
    }
}
