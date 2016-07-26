﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_2_Matthew_Lane.Models;

namespace Assignment_2_Matthew_Lane.Models
{
    public class FoodType
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public FoodType()
        {

        }

        /// <summary>
        /// This constuctor passes in the name of the food type (Appetizer, main or dessert)
        /// </summary>
        /// <param name="Name"></param>
        public FoodType(string Name)
        {
            this.Name = Name;
        }

        public string Name { get; set; }
    }
}