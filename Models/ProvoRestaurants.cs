using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS_413_Assignment4.Models
{
    public class ProvoRestaurants
    {
        public ProvoRestaurants(int rank)
        {
            Rank = rank;
        }
        
        //"Since we are manageing what is being populated, We don't need to add [Required]
        public int Rank { get; }

        public string RestaurantName { get; set; }
        #nullable enable
        public string? FavoriteDish { get; set; } = "It's all Tasty!"; //this is a property initializer
        #nullable disable
        public string Address { get; set; }

        #nullable enable        
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-]?([0-9]{3})[-]?([0-9]{4})$", ErrorMessage = "You must enter a valid phone number ###-###-####")]
        public string? PhoneNumber { get; set; } = "None";
        #nullable disable   
        #nullable enable
        public string? WebsiteLink { get; set; } = "Coming Soon";
        #nullable disable

        //the thing were going to do applies to the class as a whole
        //method that allows exterior class to access the restaurant data.
        //create the restaurants here but when we pull from a database we wont have this.
        public static ProvoRestaurants[] GetProvoRestaurants()
        {
            ProvoRestaurants r1 = new ProvoRestaurants(1)
            {
                
                RestaurantName = "Tucanos",
                FavoriteDish = "Endless Meat",
                Address = "545 E University Pkwy, Orem, UT 84097",
                PhoneNumber = "801-224-4774",
                WebsiteLink = "https://www.tucanos.com/"
            };

            ProvoRestaurants r2 = new ProvoRestaurants(2)
            {
                
                RestaurantName = "JCW's",
                FavoriteDish = "Pastrami Burger",
                Address = "396 W 2230 N, Provo, UT 84604",
                PhoneNumber = "801-374-5297",
                WebsiteLink = "http://www.jcws.com/"
            };

            ProvoRestaurants r3 = new ProvoRestaurants(3)
            {
                
                RestaurantName = "Communal",
                FavoriteDish = "Grilled Hangar Steak",
                Address = "102 N UNIVERSITY AVE, PROVO, UT 84601",
                PhoneNumber = "801-373-8000",
                
            };

            ProvoRestaurants r4 = new ProvoRestaurants(4)
            {
                
                RestaurantName = "Bam Bams BBQ",
                FavoriteDish = "Brisket",
                Address = "1708 STATE ST, OREM, UT 8405",
                PhoneNumber = "801-225-1324",
                
            };

            ProvoRestaurants r5 = new ProvoRestaurants(5)
            {
               
                RestaurantName = "Chom Burger",
                FavoriteDish = "Green Chile Avacodo Burger",
                Address = "45 W 300 N PROVO, UT 84601",
                PhoneNumber = "385-241-7499",
                
            };

            return new ProvoRestaurants[] { r1, r2, r3, r4, r5 };
        }
    }
}
