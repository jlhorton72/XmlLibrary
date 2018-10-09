using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
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
        /// <summary>
        /// generates the public properties to be used for a book
        /// </summary>
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string SubjectArea { get => subjectArea; set => subjectArea = value; }
        public string IsbnNumber { get => isbnNumber; set => isbnNumber = value; }
        public string DateAdded { get => dateAdded; set => dateAdded = value; }
        public int NumberOfCopiesInSystem1 { get => NumberOfCopiesInSystem; set => NumberOfCopiesInSystem = value; }
        public int NumberOfCopiesCheckedOut1 { get => NumberOfCopiesCheckedOut; set => NumberOfCopiesCheckedOut = value; }
        #endregion -- Public --

        #region --- Constructor ---
        /// <summary>
        /// this makes a book
        /// </summary>
        /// <param name="ttl"></param>
        /// <param name="athr"></param>
        /// <param name="subj"></param>
        /// <param name="isbn"></param>
        /// <param name="dtInsys"></param>
        /// <param name="numCopIn"></param>
        /// <param name="numCopOut"></param>
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

        /// <summary>
        /// this methods determines book availability
        /// </summary>
        /// <param name="numcop"></param>
        /// <param name="numout"></param>
        /// <returns></returns>
        public static bool IsCopyAvailable(int numcop, int numout)
        {
            if (numcop > numout)
                return true;            
            // if num copies checked out is less than num copies in system
            // the make true
            return false;
        } // end of IsAvailable

        /// <summary>
        /// this method determines if book needs to be returned
        /// </summary>
        /// <param name="numcop"></param>
        /// <param name="numout"></param>
        /// <returns></returns>
        public static bool NeedReturn(int numcop, int numout)
        {
            if (numout > 0 && numout <= numcop)
                return true;

            return false;
        } // end of NeedReturn

        /// <summary>
        /// this methods checks out book 
        /// and updates the number of copies checked out
        /// </summary>
        /// <param name="numCop"></param>
        /// <param name="numOut"></param>
        /// <param name="selected"></param>
        public static void CheckOutBook(int numCop, int numOut, int selected)
        {
            XmlDocument doc = new XmlDocument();
            // this should update num copies checked out 
            doc.Load("books.xml");
            //string newNumCop = (numCop - 1).ToString();
            string newNumOut = (numOut + 1).ToString();
            //selected = selected + 1;
            //XmlNode node = doc.SelectSingleNode("books/book[" + selected + "]/numcopies");
            //node.InnerText = newNumCop;
            //numOut
            XmlNode node1 = doc.SelectSingleNode("books/book[" + selected + "]/copiesout");
            node1.InnerText = newNumOut;

            // will need to read the xml and make an update to the xml file updating the 
            // copiesout
            doc.Save("books.xml");
        } // end of CheckOutBook

        /// <summary>
        /// this method returns the book and 
        /// updates the number of copies checked out
        /// </summary>
        /// <param name="numCop"></param>
        /// <param name="numOut"></param>
        /// <param name="selected"></param>
        public static void ReturnBook (int numCop, int numOut, int selected)
        {
            XmlDocument doc = new XmlDocument();
            // this should update num copies checked out 
            doc.Load("books.xml");
            //string newNumCop = (numCop + 1).ToString();
            string newNumOut = (numOut - 1).ToString();
            //selected = selected + 1;
            //XmlNode node = doc.SelectSingleNode("books/book[" + selected + "]/numcopies");
            //node.InnerText = newNumCop;
            //numOut
            XmlNode node1 = doc.SelectSingleNode("books/book[" + selected + "]/copiesout");
            node1.InnerText = newNumOut;

            // will need to read the xml and make an update to the xml file updating the 
            // copiesout
            doc.Save("books.xml");
        } // end of returnbook

        #endregion -- methods --

    } // end of class
} // end of namespace
