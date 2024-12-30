using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFApp.Models
{
    public class Joining : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value != null)
            {
                DateTime val = DateTime.Parse(value.ToString());
                DateTime to = DateTime.Now;
                if (val.CompareTo(to) <= 0)
                    return true;
                else
                    return false;

            }
            return false;

        }
    }
}