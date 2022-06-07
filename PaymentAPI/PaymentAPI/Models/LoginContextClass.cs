using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaymentAPI.Models;
namespace PaymentAPI.Models
{
        public class LoginContextClass : DbContext
        {
            public LoginContextClass(DbContextOptions<LoginContextClass> options) : base(options)
            {

            }

            public DbSet<Login> PaymentDetails { get; set; }
        }
}
