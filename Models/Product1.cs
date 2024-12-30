using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFApp.Models
{
    [Table(name: "tblProduct1")]
    public class Product1
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        int id;


        string? productName;

        DateTime dom;

        int price;

        public Product1()
        {
        }

        public Product1(int id, string? productName, DateTime dom, int price)
        {
            this.Id = id;
            this.ProductName = productName;
            this.Dom = dom;
            this.Price = price;
        }

        public int Id { get => id; set => id = value; }
        public string? ProductName { get => productName; set => productName = value; }
        public DateTime Dom { get => dom; set => dom = value; }
        public int Price { get => price; set => price = value; }
    }
}