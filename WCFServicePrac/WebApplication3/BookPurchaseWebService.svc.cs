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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookPurchaseWebService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BookPurchaseWebService.svc or BookPurchaseWebService.svc.cs at the Solution Explorer and start debugging.
    public class BookPurchaseWebService : IBookPurchaseWebService
    {
        public BookPurchaseResponse PurchaseBooks(BookPurchaseInfo info)
        {
            BookPurchaseResponse response = new BookPurchaseResponse();

            bool inStock = true;

            float price = 0.0f;

            List<Book> bookList = getAllBook();

            float budget = info.budget;
            Dictionary<int, int> items = info.items;
            foreach (KeyValuePair<int, int> entry in items)
            {
                Book b = bookList[entry.Key - 1];
                int qty = entry.Value;
                if (qty > b.Stock) { inStock = false; }
                price += qty * b.Price;
            }

            if (!inStock)
            {
                response.result = false;
                response.response += " No enough stocks !";
            }

            if (price > budget)
            {
                response.result = false;
                response.response += " “No enough money !";
            }

            if (inStock && price <= budget)
            {
                response.result = true;
                response.response = (budget - price).ToString();
            }

            return response;
        }

        public List<Book> getAllBook()
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
    }
}
