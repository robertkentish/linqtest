using System;
using System.Linq;
using LinqTest;
using LinqToTerraServerProvider;

namespace linqtest
{
    class Program
    {
        static void Main(string[] args)
        {
            var places = new QueryableTerraServerData<Place>();

                                  \]]avar test = places.Where(x => x.State == "VIC").ToList();


        }
    }
}
