using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebEscuelaMVC.Models;

namespace WebEscuelaMVC.Data
{
    public class DBWebEscuelaContext : DbContext
    {
        public DBWebEscuelaContext():base("keyDBWebEscuela")
        {
        }

        public DbSet<Aula> Aulas { get; set; }
    }
}