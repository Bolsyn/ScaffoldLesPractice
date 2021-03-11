using System;

namespace ScaffoldLesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new JournalContext())
            {
                context.Add(new Author
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Age = 32
                });
                context.SaveChanges();
            };
        }
    }
}
