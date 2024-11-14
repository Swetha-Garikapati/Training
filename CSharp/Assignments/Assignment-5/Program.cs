using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{ 
        public class Books
        {
            public string BookName { get; set; }
            public string AuthorName { get; set; }

            public Books(string bookName, string authorName)
            {
                BookName = bookName;
                AuthorName = authorName;
            }

            public void Display()
            {
                Console.WriteLine($"Book: {BookName}, Author: {AuthorName}");
            }
        }
        public class BookShelf
        {
            private List<Books> books; 

           
            public BookShelf()
            {
                books = new List<Books>();
            }

           
            public void AddBook(Books book)
            {
                if (books.Count < 5)
                {
                    books.Add(book);
                }
                else
                {
                    Console.WriteLine("BookShelf is full. Cannot add more books.");
                }
            }

           
            public void DisplayBooks()
            {
                Console.WriteLine("\nBooks in the Shelf:");
                foreach (var book in books)
                {
                    book.Display();
                }
            }
        }

        
        class Program
        {
            static void Main(string[] args)
            {
                
                List<Books> bookList = new List<Books>();

                
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Enter details for Book {i + 1}:");

                    Console.Write("Enter Book Name: ");
                    string bookName = Console.ReadLine();

                    Console.Write("Enter Author Name: ");
                    string authorName = Console.ReadLine();

                    bookList.Add(new Books(bookName, authorName));
                }

                
                BookShelf shelf = new BookShelf();

                
                foreach (var book in bookList)
                {
                    shelf.AddBook(book);
                }

   
                shelf.DisplayBooks();
            Console.Read();
            }
        }
}

