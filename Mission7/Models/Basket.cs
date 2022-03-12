using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Mission7.Models
{
    public class Basket
    {
        public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();

        public virtual void AddItem (Books book, int qty)
        {
            BasketLineItem line = Items.Where(b => b.Book.BookId == book.BookId).FirstOrDefault();

            if (line == null)
            {
                Items.Add(new BasketLineItem
                {
                    Book = book,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public virtual void RemoveItem (Books bk)
        {
            Items.RemoveAll(x => x.Book.BookId == bk.BookId);
        }

        public virtual void ClearBasket()
        {
            Items.Clear();
        }

        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Book.Price);

            return sum;
        }
    }

    public class BasketLineItem
    {
        [Key]
        public int LineID { get; set; }
        public Books Book { get; set; }
        public int Quantity { get; set; }
    }
}
