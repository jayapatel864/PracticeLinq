using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carNames = { "Toyota","Dodge", "Ford", "Mazda"};
            var letterSelection = from x in carNames
                                  where x.Contains ("o")
                                  orderby x descending
                                  select x;

                                  
            foreach (var i in letterSelection)
            {
                return ;

            }

        }
    }
}
