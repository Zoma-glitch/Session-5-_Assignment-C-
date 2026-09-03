using System.Drawing;

namespace Session_5__Assignment_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int genreNumber = 1;

            Genre genre = (Genre)genreNumber;

            Console.WriteLine(genre);

            //Book book = new Book();

            //book.Title = "Clean Code";

            //Console.WriteLine(book.Password);

            //Console.WriteLine(book.copiesInStock);

            //Console.WriteLine(book.Title);

            //book.Genre = Genre.Science;

            //Console.WriteLine(book.Genre);


            //Console.WriteLine((int)Genre.Fiction);

            //Console.WriteLine((int)Genre.NonFiction);

            //Console.WriteLine((int)Genre.Science);
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

        //class Book
        //{
        //    private string Password = "Secret";

        //    internal int copiesInStock = 5;
        //}


        #endregion

        #region Question03
        //3-Add a public string Title; field to Book.Set it and print it from Main.
        //class Book
        //{
        //    private string Password = "Secret";

        //    internal int copiesInStock = 5;

        //    public string Title;
        //}



        #endregion


        #region Question04
        //4-Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book, assign it Genre.Science, and print it.

        //enum Genre
        //{
        //    Fiction,
        //    NonFiction,
        //    Science
        //}
        //class Book
        //{
        //    private string Password = "Secret";

        //    internal int copiesInStock = 5;

        //    public string Title;

        //    public Genre Genre;

        //public Genre Genre { get; set; }

        //}
        #endregion


        #region Question05
        //5-Using the Genre enum above, print the underlying int value of Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int. 
        //enum Genre
        //{
        //    Fiction,
        //    NonFiction,
        //    Science
        //}
        //class Book
        //{
        //    private string Password = "Secret";

        //    internal int copiesInStock = 5;

        //    public string Title;

        //    //public Genre Genre;

        //    public Genre Genre { get; set; }

        //}


        #endregion


        #region Question06
        //6-Given int genreNumber = 1;, cast it into a Genre value and print the result.

        //int genreNumber = 1;

        enum Genre
        {
            Fiction,
            NonFiction,
            Science

        }


        #endregion
    }
}