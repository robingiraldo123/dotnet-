using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_api.Models {
    public class Products {

        [Key][Column(TypeName = "nvarchar(45)")]
        public int idProducts { get; set;}

        [Column(TypeName = "nvarchar(100)")]
        public string nameProduct { get; set; }

        public DateTime expirationDate { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        public int barCode { get; set; }


        
        public int CategoriesXProductID { get; set; }
        public CategoriesXProduct CategoriesXProduct { get; set; }

        public int TrademarksID { get; set; }
        public Trademarks Trademarks { get; set; }

    }
}