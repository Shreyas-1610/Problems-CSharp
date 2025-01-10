using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotPrac
{
    internal class User
    {
        [Required(ErrorMessage ="Username is required")]
        [StringLength(20,ErrorMessage ="Length should be less than 20")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Password required")]
        [MinLength(6,ErrorMessage ="Password should be of atleast 6 size")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Email required")]
        [EmailAddress(ErrorMessage ="Invalid format")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Birthdate Required")]
        [Range(18,100,ErrorMessage ="Less than 18")]
        public int BirthDate { get; set; }
        public static void verify()
        {
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();
            Console.WriteLine("ENter password:");
            string password = Console.ReadLine();
            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter birthdate");
            int birthDate = int.Parse(Console.ReadLine());

            var user = new User { 
                Username = username,
                Password = password,
                Email = email,
                BirthDate = birthDate };
            var context = new ValidationContext(user);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(user, context, results, true);

            if (isValid)
            {
                Console.WriteLine("Data valid");
            }
            else
            {
                foreach (var error in results)
                {
                    Console.WriteLine($"{error.ErrorMessage}");
                }
            }

        }
    }
}
