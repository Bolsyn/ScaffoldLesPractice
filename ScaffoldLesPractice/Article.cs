using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldLesPractice
{
    public partial class Article
    {
        public Article()
        {
            Categories = new HashSet<Category>();
        }

        public Guid Id { get; set; }
        public string Head { get; set; }
        public string Body { get; set; }
        public Guid? AuthorId { get; set; }

        public virtual Author Author { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}
