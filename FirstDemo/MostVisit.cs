using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class MostVisit
    {
        public static void ChangeCase(string FavPlace)
        {
            string FavPlaceUpper = FavPlace.ToUpper();
            Console.WriteLine("The place which you want to visit in Upper Case: "+FavPlaceUpper);

            string FavPlaceLower = FavPlace.ToLower();
            Console.WriteLine("The place which you want to visit in Lower Case: "+FavPlaceLower);
        }
    }
}
