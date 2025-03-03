﻿namespace AuthorsEF
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        public override string ToString()
        {
            return Title + " (Author: " + (Author?.Name ?? "-") + ")";
        }
    }
}