using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace dotnet_api.Models {
    public class CategoriesXProduct {

        [Key][Column(TypeName = "nvarchar(45)")]
        public int idCategoriesXProduct { get; set;}

        [Column(TypeName = "nvarchar(45)")]
        public List<Categories> Categories_idCategory { get; set; }

        [Column(TypeName = "nvarchar(45)")]
        public List<Products> Products_idProducts { get; set; } 
    }
}