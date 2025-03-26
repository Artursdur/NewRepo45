namespace ConsoleApp9
{
    internal class Program
    {
        public static void Main()
        {
            var bookLibrary = new Library<Book>();

                bookLibrary.Add(new Book("1984", "George Orwell", 1949, 328, "Dystopian"));
                bookLibrary.Add(new Book("To Kill a Mockingbird", "Harper Lee", 1960, 281, "Fiction"));

            var movieLibrary = new Library<Movie>();

            movieLibrary.Add(new Movie("1984", "George Orwell", 1949, 125, "Alfredich"));
            movieLibrary.Add(new Movie("To Kill a Mockingbird", "Harper Lee", 1960, 281, "Alfredich"));


        }
    }
}
