using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryService.Models
{
    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }

        public string Category { get; set; }

        public string Language { get; set; }

        public int Pages { get; set; }

        public int Year { get; set; }
        public int AgeLimit { get; set; }
        public int PublicationDate { get; set; }
        public Author[] Authors { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}, Title = {Title}, Category = {Category}, Language = {Language}, Pages = {Pages}, Year = {Year}, AgeLimit = +{AgeLimit}, PublicationDate = {PublicationDate}" +
                $"Authors: {string.Join<Author>(", ", Authors)}";
        }
    }
}