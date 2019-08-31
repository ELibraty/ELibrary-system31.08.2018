using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.My.Data.Models
{
    public class GetBook
    {
        public GetBook()
        {

        }

        public virtual string Id { get; set; }

        public virtual string UserId { get; set; }
        public virtual ICollection<User> Users { get; set; }

        public virtual string BookId { get; set; }
        public virtual ICollection<Book> Books { get; set; }

        public virtual DateTime CreatedOn { get; set; }
        public virtual DateTime ReturnedOn { get; set; }


        public virtual DateTime? DeletedOn { get; set; }


    }
}
