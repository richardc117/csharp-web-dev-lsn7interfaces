using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.

            var comparer = new FlavorComparer();
            availableFlavors.Sort(comparer);


            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.

            var coneComparer = new ConeComparer();
            availableCones.Sort(coneComparer);



            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.

            foreach (var item in availableFlavors)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("\n");

            foreach (var item in availableCones)
            {
                Console.WriteLine("$"+item.Cost);
            }
        }
    }
}
