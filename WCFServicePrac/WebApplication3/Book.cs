using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace WebApplication3
{
    [DataContract]
    public class Book
    {
        private string id;

        [DataMember]
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string author;

        [DataMember]
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private int year;

        [DataMember]
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private float price;

        [DataMember]
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private int stock;

        [DataMember]
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
    }
}