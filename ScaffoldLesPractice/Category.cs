using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldLesPractice
{
    public partial class Category
    {
        public Guid Id { get; set; }
        public string Section { get; set; }
        public Guid? ArticleId { get; set; }

        public virtual Article Article { get; set; }
    }
}
