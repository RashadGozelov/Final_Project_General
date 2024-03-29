﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Final_Projectt.DAL;
using Final_Projectt.Models;
using Final_Projectt.ViewModel;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace Final_Projectt.Controllers
{
    public class CartController : Controller
    {
        private AppDbContext _context;

        public CartController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //products = _context.Products.Include(p=>p.ProductImages);

            string cart = HttpContext.Session.GetString("cart");

            List<BasketProduct> products = new List<BasketProduct>();

            if (cart != null)
            {
                products = JsonConvert.DeserializeObject<List<BasketProduct>>(cart);
            }

            return View(products);

        }

        public async Task<IActionResult> Add(int id)
        {
            Product product = await _context.Products.Include(x=>x.ProductImages).FirstOrDefaultAsync(p=>p.Id==id);

            BasketProduct basket = product;

            string cart = HttpContext.Session.GetString("cart");

            List<BasketProduct> products = new List<BasketProduct>();

            if (cart != null)
            {
                products = JsonConvert.DeserializeObject<List<BasketProduct>>(cart);

            }

            var selected= products.FirstOrDefault(p => p.Id == id);

            if (selected == null)
            {
                products.Add(basket);
            }
            else
            {
                selected.Quantity++;
            }


            string productJson = JsonConvert.SerializeObject(products);
            HttpContext.Session.SetString("cart", productJson);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Remove(int id)
        {
           
            string cart = HttpContext.Session.GetString("cart");
            
            List<Product> products = new List<Product>();

            if (cart != null)
            {
                products = JsonConvert.DeserializeObject<List<Product>>(cart);
            }
            Product product = products.FirstOrDefault(p => p.Id == id);

            products.Remove(product);

            string productJson = JsonConvert.SerializeObject(products);
            HttpContext.Session.SetString("cart", productJson);

            return RedirectToAction(nameof(Index));
        }

        

       
    }
}