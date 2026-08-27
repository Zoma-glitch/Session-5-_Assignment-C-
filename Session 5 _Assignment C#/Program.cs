using System.Drawing;

namespace Session_5__Assignment_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            //Console.WriteLine(book.Password);
            Console.WriteLine(book.copiesInStock);
        }

        #region Question01
        //Add a private string password = "secret"; field to a Book class. Try to print it from Main(outside the class). What happens, and why?
        //Error becuase private
        //class Book
        //{
        //    private string Password = "Secret";

        //}
        #endregion

        #region Question02
        //2-Add an internal int copiesInStock = 5; field to Book.Print it from Main.Does it compile? Why?

        class Book
        {
            private string Password = "Secret";

            internal int copiesInStock = 5;
        }


        #endregion
}
}
