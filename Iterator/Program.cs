using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            BookShelf bookShelf = new BookShelf(4);
            bookShelf.AppendBook(new Book("Harry Poter & Wise Stone"));
            bookShelf.AppendBook(new Book("Life 100 cat"));
            bookShelf.AppendBook(new Book("Conffesion"));
            bookShelf.AppendBook(new Book("OnePiece"));

            Iterator it = bookShelf.iterator();
            while (it.HasNext()) {
                Book book = (Book)it.Next();
                Console.WriteLine(book.GetName());
            }
        }
    }
}
