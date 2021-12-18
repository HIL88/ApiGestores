using apiGestores.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;


namespace apiGestores.Context
{
    public class AppDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public  AppDbContext(DbContextOptions <AppDbContext> options): base(options)
        {

        }

        public Microsoft.EntityFrameworkCore.DbSet<Gestores_Bd> gestores_bd { get; set;}
       

     
    }
}
