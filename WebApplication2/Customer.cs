﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication2
{
    public class Customer
    {
        public int Id { get; set; }


        [Required, StringLength(49)]
        public string Name { get; set; }



        

    }
}