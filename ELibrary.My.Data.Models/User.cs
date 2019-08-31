using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ELibrary.My.Data.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            this.CreatedOn = DateTime.UtcNow;
            this.AddedBooks = new List<Book>();
            this.GettedBooks = new List<Book>();
        }

        public virtual string Avatar { get; set; }

        public virtual string Type { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual string LibararyName { get; set; }

        public virtual string LibraryLocation { get; set; }

        public virtual DateTime CreatedOn { get; set; }

        public virtual DateTime? DeletedOn { get; set; }

        public virtual ICollection<Book> AddedBooks { get; set; }

        public virtual ICollection<Book> GettedBooks { get; set; }




    }
}
