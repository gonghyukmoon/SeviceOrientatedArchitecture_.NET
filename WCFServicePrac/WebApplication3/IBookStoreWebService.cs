using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebApplication3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBookStoreWebService" in both code and config file together.
    [ServiceContract]
    public interface IBookStoreWebService
    {
        [OperationContract]
        List<Book> GetAllBooks();

        [OperationContract]
        bool AddBook(Book book);

        [OperationContract]
        bool DeleteBook(string field, string value);

        [OperationContract]
        List<Book> SearchBook(string field, string value);
    }
}
