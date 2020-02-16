using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SP.App_Code.DAL
{
    public class ClassProducts
    {
        public int RowNumb { get; set; }
        public int IdProduct { get; set; } 
        public string ImageProduct { get; set; }
        public string NameProduct { get; set; } 
        public string DescriptionProduct { get; set; }
        public double Price { get; set; }
        public ClassProducts()
        {
            RowNumb = 0;
            IdProduct = 0;
            ImageProduct = string.Empty;
            NameProduct = string.Empty;
            DescriptionProduct = string.Empty;
            Price = 0.0;
        }
        public static ClassProducts Map(DataRow dataRow)
        {
            ClassProducts result = new ClassProducts();
            result.IdProduct = (int)dataRow["IdProduct"];
            result.ImageProduct = dataRow["ImageProduct"].ToString();
            result.NameProduct = dataRow["NameProduct"].ToString();
            result.DescriptionProduct = dataRow["DescriptionProduct"].ToString();
            result.Price = double.Parse(dataRow["Price"].ToString());
            return result;
        }

        public static ClassProducts Map(DataRow dataRow, int index)
        {//метод для подсчета строк в таблице
            ClassProducts result = Map(dataRow);
            result.RowNumb = index;
            return result;
        }
    }
}