using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotPrac
{
    internal class DataAnnot
    {
            [Required(ErrorMessage = "Name cannot be null")]
            [StringLength(20, MinimumLength = 3, ErrorMessage = "Length should be between 3-20")]
            public string Name { get; set; }

            [Range(18, 70, ErrorMessage = "Age must be between 18 and 70")]
            public int Age { get; set; }

            [Required(ErrorMessage = "Email cannot be null")]
            [EmailAddress(ErrorMessage = "Invalid email")]
            public string Email { get; set; }

        public static void verify()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("ENter age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();

            var user = new DataAnnot { Name = name, Age = age, Email = email };
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
