﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class CustomersViewModel
    {
        public List<Customer> Customers { get; set; } = new List<Customer>();
    }
}