using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicBookGallery.Models;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        //Static ensures that we only have one copy of the data in memory, at any given time
        private static ComicBook[] _comicBooks = new ComicBook[] 
        {
            new ComicBook()
            {
                SeriesTitle = "The amazing Spider Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                    {
                        new Artist() { Name = "dan slott", Role = "script" },
                        new Artist() { Name = "humberto ramos", Role = "pencils" },
                        new Artist() { Name = "victor olazaba", Role = "inks" },
                        new Artist() { Name = "edgar delgado", Role = "colors" },
                        new Artist() { Name = "chris eliopoulos", Role = "letters" }
                    }

            },

           new ComicBook()
           {
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Jeff Smith", Role = "Script" },
                    new Artist() { Name = "Jeff Smith", Role = "Pencils" },
                    new Artist() { Name = "Jeff Smith", Role = "Inks" },
                    new Artist() { Name = "Jeff Smith", Role = "Letters" }
                },
                Favorite = false
           }   
        };

        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;

            foreach (var comicBook in _comicBooks)
            {
                if(comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;

                    break;
                }
            }
            return comicBookToReturn;
        }
    }
}