﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.ViewModels
{
    public class Customer
    {
        public Guid CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
    }
}
