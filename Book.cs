using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace _7LibraryXML
{
    // Name:        James Horton
    // Date:        10/09/2018
    // Assignement: Library XML Project
    // File:        7LibraryXML

    class Book
    {
        #region --- Private Data Fields ---
        string title;
        string author;
        string subjectArea;
        string isbnNumber;
        string dateAdded;
        int NumberOfCopiesInSystem;
        int NumberOfCopiesCheckedOut;
        #endregion -- Private --

        #region --- Public Properties ---
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string SubjectArea { get => subjectArea; set => subjectArea = value; }
        public string IsbnNumber { get => isbnNumber; set => isbnNumber = value; }
        public string DateAdded { get => dateAdded; set => dateAdded = value; }
        public int NumberOfCopiesInSystem1 { get => NumberOfCopiesInSystem; set => NumberOfCopiesInSystem = value; }
        public int NumberOfCopiesCheckedOut1 { get => NumberOfCopiesCheckedOut; set => NumberOfCopiesCheckedOut = value; }
        #endregion -- Public --

        #region --- Constructor ---
        public Book(string ttl, string athr, string subj, string isbn,
                string dtInsys, int numCopIn, int numCopOut)
        {
            this.title = ttl;
            this.author = athr;
            this.subjectArea = subj;
            this.isbnNumber = isbn;
            this.dateAdded = dtInsys;
            this.NumberOfCopiesInSystem = numCopIn;
            this.NumberOfCopiesCheckedOut = numCopOut;
        } // end of Book
        #endregion -- constructor --


        #region --- Methods ---
        public void IsCopyAvailable()
        {
            // if num copies checked out is less than num copies in system
            // the make true

        } // end of IsAvailable

        public void CheckOutBook()
        {
            // this should update num copies checked out 
        } // end of CheckOutBook

        #endregion -- methods --

    } // end of class
} // end of namespace
