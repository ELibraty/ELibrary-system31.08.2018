using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.My.Data.Models
{
    public class Book
    {
        public Book()
        {
            this.CreatedOn = DateTime.UtcNow;
        }

        public virtual int Id { get; set; }

        public virtual string BookName { get; set; }

        public virtual string Author { get; set; }

        public virtual int GenreId { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual DateTime CreatedOn { get; set; }

        public virtual DateTime? DeletedOn { get; set; }


    }
}
