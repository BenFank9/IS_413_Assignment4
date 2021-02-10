using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS_413_Assignment4.Models
{
    public class UserSuggestions
    {
        [Required (ErrorMessage ="You must Enter your Name") ]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must enter a Restaruant Name")]
        public string RestaurantName { get; set; }

        [Required(ErrorMessage ="You must enter your Favorite Dish")]
        public string FavoriteDish { get; set; } = "It's all Tasty!";

        [Required(ErrorMessage = "You must enter a valid phone number ###-###-####")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-]?([0-9]{3})[-]?([0-9]{4})$")]
        public string PhoneNumber { get; set; }

    }
}
