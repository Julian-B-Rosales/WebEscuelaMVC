using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebEscuelaMVC.Validations
{
    public class CheckNumber:ValidationAttribute
    {

        public CheckNumber() 
        {
            ErrorMessage = "El numero debe ser mayor a 100";
        }

        public override bool IsValid(object value)
        {
            int numero = (int) value;
            if (numero > 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}