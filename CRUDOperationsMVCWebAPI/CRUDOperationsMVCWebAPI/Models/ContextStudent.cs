using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDOperationsMVCWebAPI.Models
{
    public class ContextStudent:DbContext
    {
        public ContextStudent():base(){


        }

        public DbSet<Student> StudentsOperations { get; set; }
    }
}