using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book() { Name = "Empty" };

            book.NameChanged += new NameChangedDelegate(OnNameChanged);

            book.Name = "New Name";
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Book changing name from {args.ExistingName} to {args.NewName}");            
        }
    }
}
