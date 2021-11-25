using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_api.Models {
    public class Categories {

        [Key][Column(TypeName = "nvarchar(45)")]
        public int idCategory { get; set;}

        [Column(TypeName = "nvarchar(45)")]
        public string category { get; set; }

        public int CategoriesXProductID { get; set; }
        public CategoriesXProduct CategoriesXProduct { get; set; } 
    }
}