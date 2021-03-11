using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldLesPractice
{
    public partial class Author
    {
        public Author()
        {
            Articles = new HashSet<Article>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
