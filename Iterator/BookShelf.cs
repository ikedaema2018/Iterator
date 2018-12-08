using System;
using System.Collections.Generic;

namespace Iterator
{
    public class BookShelf: Aggregate
    {
        private List<Book> books = new List<Book>();
        private int last = 0;

        public Book GetBookAt(int index) {
            return books[index];
        }
        public void AppendBook(Book book) {
            this.books.Add(book);
            last++;
        }
        public int GetLength() {
            return last;
        }
        public Iterator iterator() {
            return new BookShelfIterator(this);
        }
    }
}
