using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get => title;
            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                title = value;
            }
        }

        public string Author
        {
            get => author;
            protected set
            {
                if (AuthorValidation(value))
                {
                    throw new ArgumentException("Author not valid!");
                }
                author = value;
            }
        }

        public virtual decimal Price
        {
            get => price;
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value;
            }
        }

        private bool AuthorValidation(string author)
        {
            string[] names = author.Split();
            if (names.Length > 1)
            {
                if (names[1][0] >= '0' && names[1][0] <= '9')
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:f2}");

            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }

    }
}