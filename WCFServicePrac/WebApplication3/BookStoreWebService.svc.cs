using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web;

namespace WebApplication3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookStoreWebService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BookStoreWebService.svc or BookStoreWebService.svc.cs at the Solution Explorer and start debugging.
    public class BookStoreWebService : IBookStoreWebService
    {
        public List<Book> GetAllBooks()
        {
            List<Book> bookList = new List<Book>();

            string path = HttpRuntime.AppDomainAppPath + "books.txt";
            using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read)))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] row = line.Split(',');
                    Book book = new Book();
                    book.ID = row[0];
                    book.Name = row[1];
                    book.Author = row[2];
                    book.Year = Convert.ToInt32(row[3]);
                    book.Price = float.Parse(row[4].Substring(1));
                    book.Stock = Convert.ToInt32(row[5]);
                    bookList.Add(book);
                }
            }
            return bookList;
        }


        public bool AddBook(Book book)
        {
            string path = HttpRuntime.AppDomainAppPath + "books.txt";
            bool isExist = false;
            List<Book> bookList = GetAllBooks();
            foreach(Book searchedBook in bookList){
                if (book.ID == searchedBook.ID && 
                    book.Name == searchedBook.Name && 
                    searchedBook.Author == searchedBook.Author && 
                    book.Year == searchedBook.Year && 
                    book.Price == searchedBook.Price)
                {
                    searchedBook.Stock+=book.Stock;
                    isExist = true;
                }
            }

            try
            {
                if (isExist)
                {
                    using (StreamWriter writer = new StreamWriter(path, false))
                    {
                        foreach (Book b in bookList)
                        {
                            writer.WriteLine(b.ID + "," + b.Name + "," + b.Author + "," + b.Year + ",$" + b.Price + "," + b.Stock);
                        }
                    }
                }
                else
                {
                    using (StreamWriter writer = File.AppendText(path))
                    {
                        writer.WriteLine(book.ID + "," + book.Name + "," + book.Author + "," + book.Year + ",$" + book.Price + "," + book.Stock);
                    }
                }


                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool DeleteBook(string field, string value)
        {
            string path = HttpRuntime.AppDomainAppPath + "books.txt";
            int count = 0;
            List<Book> bookList = GetAllBooks();
            for (int i = bookList.Count - 1; i >= 0;i-- )
            {
                Book searchedBook = bookList[i];
                string fieldValue = searchedBook.GetType().GetProperty(field).GetValue(searchedBook, null).ToString();
                if (fieldValue == value)
                {
                    count++;
                    bookList.RemoveAt(i);
                }
            }

            if (count == 0) { return false; }
            else
            {
                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    foreach (Book book in bookList)
                    {
                        writer.WriteLine(book.ID + "," + book.Name + "," + book.Author + "," + book.Year + ",$" + book.Price + "," + book.Stock);
                    }
                }
                return true;
            }
        }

        public List<Book> SearchBook(string field, string value)
        {
            List<Book> returnedBooks = new List<Book>();
            string path = HttpRuntime.AppDomainAppPath + "books.txt";
            List<Book> bookList = GetAllBooks();
            foreach (Book searchedBook in bookList)
            {
                string fieldValue = searchedBook.GetType().GetProperty(field).GetValue(searchedBook, null).ToString();
                if (fieldValue == value)
                {
                    returnedBooks.Add(searchedBook);
                }
            }
            return returnedBooks;
        }
    }
}
