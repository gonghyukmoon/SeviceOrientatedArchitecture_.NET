using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class BookStore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IBookStoreWebService searchSevice = new BookStoreWebService();
            List<Book> returnBooks = searchSevice.GetAllBooks();

            displayBooks(returnBooks);

        }

        protected void recreateControl(int count)
        {
            for (int i = 2; i <= count; i++)
            {
                TableRow row = new TableRow();
                TableCell lblnumber = new TableCell();
                lblnumber.Text = "Book Number";
                TableCell txtnumber = new TableCell();
                TextBox number = new TextBox();
                number.ID = "numbertxt" + i;
                number.Text = (string)ViewState[number.ID];
                txtnumber.Controls.Add(number);
                TableCell lblamount = new TableCell();
                lblamount.Text = "Amount";
                TableCell txtamount = new TableCell();
                TextBox amount = new TextBox();
                amount.ID = "amounttxt" + i;
                amount.Text = (string)ViewState[amount.ID];
                txtamount.Controls.Add(amount);

                row.Cells.Add(lblnumber);
                row.Cells.Add(txtnumber);
                row.Cells.Add(lblamount);
                row.Cells.Add(txtamount);

                Table1.Rows.Add(row);
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string field = searchddl.SelectedValue;
            string value = searchtxt.Text;
            IBookStoreWebService searchSevice = new BookStoreWebService();
            List<Book> returnBooks = searchSevice.SearchBook(field,value);

            displayBooks(returnBooks);
        }

        public void displayBooks(List<Book> returnBooks)
        {
            bookTable.Rows.Clear();

            TableHeaderRow hRow = new TableHeaderRow();
            bookTable.Rows.Add(hRow);
            TableHeaderCell numH = new TableHeaderCell();
            numH.Text = "Num";

            TableHeaderCell idH = new TableHeaderCell();
            idH.Text = "ID";

            TableHeaderCell nameH = new TableHeaderCell();
            nameH.Text = "Name";

            TableHeaderCell authorH = new TableHeaderCell();
            authorH.Text = "Author";

            TableHeaderCell yearH = new TableHeaderCell();
            yearH.Text = "Year";

            TableHeaderCell priceH = new TableHeaderCell();
            priceH.Text = "Price";

            TableHeaderCell stockH = new TableHeaderCell();
            stockH.Text = "Stock";

            hRow.Cells.Add(numH);
            hRow.Cells.Add(idH);
            hRow.Cells.Add(nameH);
            hRow.Cells.Add(authorH);
            hRow.Cells.Add(yearH);
            hRow.Cells.Add(priceH);
            hRow.Cells.Add(stockH);

            for (int i = 1; i <= returnBooks.Count; i++)
            {
                Book book = returnBooks[i - 1];
                TableRow tRow = new TableRow();
                bookTable.Rows.Add(tRow);
                TableCell num = new TableCell();
                num.Text = i.ToString();

                TableCell id = new TableCell();
                id.Text = book.ID;

                TableCell name = new TableCell();
                name.Text = book.Name;

                TableCell author = new TableCell();
                author.Text = book.Author;

                TableCell year = new TableCell();
                year.Text = book.Year.ToString();

                TableCell price = new TableCell();
                price.Text = book.Price.ToString();

                TableCell stock = new TableCell();
                stock.Text = book.Stock.ToString();

                tRow.Cells.Add(num);
                tRow.Cells.Add(id);
                tRow.Cells.Add(name);
                tRow.Cells.Add(author);
                tRow.Cells.Add(year);
                tRow.Cells.Add(price);
                tRow.Cells.Add(stock);
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.ID = idtxt.Text;
            book.Name = nametxt.Text;
            book.Author = authortxt.Text;
            book.Year = Convert.ToInt32(yeartxt.Text);
            book.Price = float.Parse(pricetxt.Text);
            book.Stock = Convert.ToInt32(stocktxt.Text);

            IBookStoreWebService bookService = new BookStoreWebService();
            if (bookService.AddBook(book))
            {
                displayBooks(bookService.GetAllBooks());
            }
            else
            {
                errorlbl.Text = "Add failed!";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string field = deleteddl.SelectedValue;
            string value = deletetxt.Text;

            IBookStoreWebService bookService = new BookStoreWebService();
            if (bookService.DeleteBook(field, value))
            {
                displayBooks(bookService.GetAllBooks());
            }
            else
            {
                errorlbl.Text = "Delete failed!";
            }

        }

        protected void btnPurchase_Click(object sender, EventArgs e)
        {
            int budget = Convert.ToInt32(budgettxt.Text);
            int numberOfRows = Table1.Rows.Count;


            IBookPurchaseWebService bookPurchase = new BookPurchaseWebService();
            BookPurchaseInfo info = new BookPurchaseInfo();
            info.budget = budget;
            Dictionary<int, int> items = new Dictionary<int, int>();

            for (int i = 1; i <= Table1.Rows.Count; i++)
            {
                TextBox numbertxt = (TextBox)FindControl("numbertxt"+i);
                TextBox amounttxt = (TextBox)FindControl("amounttxt"+i);
                items.Add(Convert.ToInt32(numbertxt.Text), Convert.ToInt32(amounttxt.Text));
            }
                
            info.items = items;
            BookPurchaseResponse response = bookPurchase.PurchaseBooks(info);

            responsetxt.Text = response.response;
        }

        
    }
}