using System.Drawing;

namespace Session_5__Assignment_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.WriteLine(book.Password);
        }

        #region Question01
        //Add a private string password = "secret"; field to a Book class. Try to print it from Main(outside the class). What happens, and why?
        //Error becuase private
        class Book
        {
            private string Password = "Secret";

        }
        #endregion
    }
}
