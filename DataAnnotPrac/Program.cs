using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace DataAnnotPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UrlVal.Validity();
            //YearVal.Validity();
            //ReplaceMult.spaces();
            //PassVal.Validity();
            //PhoneVal.Validity();
            //EmailVal.Validity();

            //User.verify();

            ////string pattern = @"^[0-9]{10}$";
            ////Regex regex = new Regex(pattern);

            //Console.WriteLine("Enter firstname");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("ENter lastname:");
            //string lastName = Console.ReadLine();
            //Console.WriteLine("Enter phone: ");
            //string phone = Console.ReadLine();
            ////if (regex.IsMatch(phone))
            ////{
            ////    Console.WriteLine("valid");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Mobile should be 10 digits");
            ////}
            //Console.WriteLine("Enter email:");
            //string email = Console.ReadLine();

            //var user = new Customer { FirstName = firstName, LastName = lastName, Email = email, Phone = phone };
            //var context = new ValidationContext(user);
            //var results = new List<ValidationResult>();
            //bool isValid = Validator.TryValidateObject(user, context, results, true);

            //if (isValid)
            //{
            //    Console.WriteLine("Data valid");
            //}
            //else
            //{
            //    foreach (var error in results)
            //    {
            //        Console.WriteLine($"{error.ErrorMessage}");
            //    }
            //}

        }
    }

    public class Customer
    {
        [Required(ErrorMessage ="Firstname Required")]
        [StringLength(50,ErrorMessage ="Should be less than 50")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lastname Required")]
        [StringLength(50, ErrorMessage = "Should be less than 50")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Email required")]
        [EmailAddress(ErrorMessage ="Invalid format")]
        public string Email { get; set; }
        [Required]
        [Length(10,10,ErrorMessage ="Should be 10 digits")]
        public string Phone { get; set; }
    }
}
