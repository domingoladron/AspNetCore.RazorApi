using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCore.RazorApi.Pages
{
    public class FruitFinderModel : PageModel
    {
        private static readonly List<string> Fruits = new List<string>();

        static FruitFinderModel()
        {
            //Mocking out some data being returned from a call
            Fruits.Add("apple");
            Fruits.Add("avocado");
            Fruits.Add("banana");
            Fruits.Add("cantaloupe");
            Fruits.Add("cherimoya");
            Fruits.Add("feijoa");
            Fruits.Add("grapefruit");
            Fruits.Add("kumquat");
            Fruits.Add("mango");
            Fruits.Add("orange");
        }

        public JsonResult OnGet()
        {
            var randomIndex = new Random().Next(Fruits.Count - 1);
            return new JsonResult(Fruits[randomIndex]);
        }
    }
}