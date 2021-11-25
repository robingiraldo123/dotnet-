using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_api.Models {
    public class Users {

        [Key][Column(TypeName = "nvarchar(45)")]
        public int idUsers { get; set;}

        public int UserXShoppingListID { get; set; }
        public UserXShoppingList UserXShoppingList { get; set; }
    }
}