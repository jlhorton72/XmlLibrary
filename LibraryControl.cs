using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;  // for XmlNodeType enumeration
using System.Xml.Linq; // for Xnode and others
using System.Xml.XPath; // for XpathSelectedElements
using System.Windows.Forms;
using System.IO;

namespace _7LibraryXML
{
    // Name:        James Horton
    // Date:        10/09/2018
    // Assignement: Library XML Project
    // File:        7LibraryXML

    public partial class LibraryControl : Form
    {
        XmlDocument doc = new XmlDocument();
         

        public LibraryControl()
        {
            InitializeComponent();
        }

        #region --- Form Load ---
        /// <summary>
        /// this just loads the basic form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LibraryControl_Load(object sender, EventArgs e)
        {
            // this section loads the contents of the library
            #region --- loads the xml document ---
            //Book[] bkInLib = new Book[4];
            //bkInLib[0] = new Book("Ready Player One", "Ernest Cline", "Historical Fiction", "030788743X", "August 16, 2011", 4, 0);
            //bkInLib[1] = new Book("Dancing Barefoot", "Wil Wheaton", "Autobiography", "0596006748", "January 1, 2004", 9, 0);
            //bkInLib[2] = new Book("IQ84", "Haruki Murakami", "Historical Fiction", "0307593312", "October 25, 2011", 1, 0);
            //bkInLib[3] = new Book("Anansi Boys", "Neil Gailman", "Fiction", "0060515198", "September 26, 2006", 2, 0);

            //using (XmlWriter writer = XmlWriter.Create("bkInLib.xml"))
            //{
            //    writer.WriteStartDocument();
            //    writer.WriteStartElement("Books");

            //    foreach (Book bk in bkInLib)
            //    {
            //        writer.WriteStartElement("Book");

            //        writer.WriteElementString("Title", bk.Title.ToString());
            //        writer.WriteElementString("Author", bk.Author.ToString());
            //        writer.WriteElementString("SubjectArea", bk.SubjectArea.ToString());
            //        writer.WriteElementString("IsbnNumber", bk.IsbnNumber.ToString());
            //        writer.WriteElementString("DateAdded", bk.DateAdded.ToString());
            //        writer.WriteElementString("NumberOfCopiesInSystem1", bk.NumberOfCopiesInSystem1.ToString());
            //        writer.WriteElementString("NumberofCopiesCheckedOut1", bk.NumberOfCopiesCheckedOut1.ToString());

            //        writer.WriteEndElement();

            //    } // end of foreach

            //    writer.WriteEndElement();
            //    writer.WriteEndDocument();
            //} // end of using
            #endregion -- end of xml load---

            #region --- failed unused attempts at ---
            //var document = XDocument.Parse("bkInLib.xml");
            //var titles = document.XPathSelectElements("//books[./Title]");
            //lstBxInventory.Items.Add(titles);

            //var xmlStr = File.ReadAllText("bkInLib.xml");
            //var str = XElement.Parse(xmlStr);
            //var result = str.Elements("Title");
            //if (result != null)
            //{
            //    lstBxInventory.Items.Add(result);
            //} // end of if
            //.
            //    Where(x => x.Element("Title").Value.Equals(Not null)


            // **** this looks like it is trying to load the file again
            //document = XDocument.Load("bkInLib.xml");
            //XElement book = document.Element("Books");
            //Book[] bookTitles = null;
            //if (book != null)
            //{
            //    IEnumerable<XElement> titles = book.Elements("Title");
            //    bookTitles = (from itm in titles
            //                where itm.Element("Title") != null
            //                && itm.Element("SubjectArea") != null
            //                && itm.Element("Author") != null
            //                && itm.Element("IsbnNumber") != null
            //                && itm.Element("DateAdded") != null
            //                && itm.Element("NumberOfCopiesInSystem1") != null
            //                && itm.Element("NumberOfCopiesCheckedOut1") != null
            //                select new Book()
            //                {
            //                    Title = itm.Element("Title").Value,
            //                    Author = itm.Element("Author").Value,
            //                    IsbnNumber = itm.Element("IsbnNumber").Value,
            //                }).ToArray<Book>();
            //} // end of if
            #endregion -- trying to find the documents attributes and elements --

            // this section hides inactive stuff for now
            #region --- hide buttons and labels ---
            btnAccept.Enabled = false;
            btnAccept.Visible = false;
            lblBook.Visible = false;
            lstBxBook.Visible = false;
            lstBxInventory.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            btnCheckOut.Visible = false;
            btnReturn.Visible = false;
            #endregion -- hide --

        } // end of LibraryControl_Load
        #endregion -- form load --

        #region --- lstBxSearch Controls ---
        /// <summary>
        /// uses the slelected index to populate the inventory listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstBxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAccept.Visible = false;
            btnAccept.Enabled = false;

            lstBxInventory.Items.Clear();
            doc.Load("books.xml");
            lstBxInventory.Visible = true;
            string curItem = lstBxSearch.SelectedItem.ToString();

            if (curItem == "Title")         // sets the titles into the inventory list box
            {
                XmlNodeList titles = doc.SelectNodes("/books/book/title");
                foreach (XmlNode title in titles)
                {
                    lstBxInventory.Items.Add(title.InnerText);
                } // end of foreach
            } // end of if loop for title

            if (curItem == "Author")        // sets the authors into the inventory list box
            {
                XmlNodeList authors = doc.SelectNodes("/books/book/author");
                foreach (XmlNode author in authors)
                {
                    lstBxInventory.Items.Add(author.InnerText);
                } // end of foreach
            } // end of if loop for title

            if (curItem == "ISBN")          // sets the isbn numbers into the list box
            {
                XmlNodeList isbns = doc.SelectNodes("/books/book/isbn");
                foreach (XmlNode isbn in isbns)
                {
                    lstBxInventory.Items.Add(isbn.InnerText);
                } // end of foreach
            } // end of if loop for title

            if (curItem == "Subject")       // sets the subject into the list box
            {
                XmlNodeList subjects = doc.SelectNodes("/books/book/subject");
                foreach (XmlNode subject in subjects)
                {
                    lstBxInventory.Items.Add(subject.InnerText);
                } // end of foreach
            } // end of if loop for title


            #region --- unused failed code for populating the lstbxinventory --
            //XmlTextReader reader = new XmlTextReader("bkInLib.xml");
            //while (reader.Read())
            //{

            //    if (curItem == "Title")
            //    {
            //        var document = XDocument.Parse("bkInLib.xml");
            //        var titles = document.XPathSelectElements("//books[./Title]");
            //        lstBxInventory.Items.Add(reader);
            //    } // end of if statement

            //} // end of while
            #endregion -- unused failed --

        } // end of lstBxSearch_SelectedIndexChanged
        #endregion -- end of lstBxSearch --

        #region --- lstBxInvetory Controls ---
        /// <summary>
        /// this will add the bokk info into the book list box
        /// for the selected book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstBxInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAccept.Visible = false;
            btnAccept.Enabled = false;
            lstBxBook.Items.Clear();    // clears the lstbxbook        
            lstBxBook.Visible = true;   // makes lstbxbook visible
            doc.Load("books.xml");      // loads the xml file

            // shows the labels for context of lstBxBook
            #region --- reveals ---
            lblBook.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            btnReturn.Visible = true;
            btnCheckOut.Visible = true;
            #endregion -- reveals --

            // uses the index to populate which book info appears in the book info lstbx
            #region --- Populate lstBxBook ---
            if (lstBxInventory.SelectedIndex == 0 )
            {
                XmlNode title = doc.SelectSingleNode("/books/book[1]/title");
                lstBxBook.Items.Add(title.InnerText);
                XmlNode author = doc.SelectSingleNode("/books/book[1]/author");
                lstBxBook.Items.Add(author.InnerText);
                XmlNode subject = doc.SelectSingleNode("/books/book[1]/subject");
                lstBxBook.Items.Add(subject.InnerText);
                XmlNode isbn = doc.SelectSingleNode("/books/book[1]/isbn");
                lstBxBook.Items.Add(isbn.InnerText);
                XmlNode date = doc.SelectSingleNode("books/book[1]/date");
                lstBxBook.Items.Add(date.InnerText);
                XmlNode numcop = doc.SelectSingleNode("books/book[1]/numcopies");
                lstBxBook.Items.Add(numcop.InnerText);
                XmlNode numout = doc.SelectSingleNode("books/book[1]/copiesout");
                lstBxBook.Items.Add(numout.InnerText);

            } // end of if

            if (lstBxInventory.SelectedIndex == 1)
            {
                XmlNode title = doc.SelectSingleNode("/books/book[2]/title");
                lstBxBook.Items.Add(title.InnerText);
                XmlNode author = doc.SelectSingleNode("/books/book[2]/author");
                lstBxBook.Items.Add(author.InnerText);
                XmlNode subject = doc.SelectSingleNode("/books/book[2]/subject");
                lstBxBook.Items.Add(subject.InnerText);
                XmlNode isbn = doc.SelectSingleNode("/books/book[2]/isbn");
                lstBxBook.Items.Add(isbn.InnerText);
                XmlNode date = doc.SelectSingleNode("books/book[2]/date");
                lstBxBook.Items.Add(date.InnerText);
                XmlNode numcop = doc.SelectSingleNode("books/book[2]/numcopies");
                lstBxBook.Items.Add(numcop.InnerText);
                XmlNode numout = doc.SelectSingleNode("books/book[2]/copiesout");
                lstBxBook.Items.Add(numout.InnerText);

            } // end of if

            if (lstBxInventory.SelectedIndex == 2)
            {
                XmlNode title = doc.SelectSingleNode("/books/book[3]/title");
                lstBxBook.Items.Add(title.InnerText);
                XmlNode author = doc.SelectSingleNode("/books/book[3]/author");
                lstBxBook.Items.Add(author.InnerText);
                XmlNode subject = doc.SelectSingleNode("/books/book[3]/subject");
                lstBxBook.Items.Add(subject.InnerText);
                XmlNode isbn = doc.SelectSingleNode("/books/book[3]/isbn");
                lstBxBook.Items.Add(isbn.InnerText);
                XmlNode date = doc.SelectSingleNode("books/book[3]/date");
                lstBxBook.Items.Add(date.InnerText);
                XmlNode numcop = doc.SelectSingleNode("books/book[3]/numcopies");
                lstBxBook.Items.Add(numcop.InnerText);
                XmlNode numout = doc.SelectSingleNode("books/book[3]/copiesout");
                lstBxBook.Items.Add(numout.InnerText);

            } // end of if



            if (lstBxInventory.SelectedIndex == 3)
            {
                XmlNode title = doc.SelectSingleNode("/books/book[4]/title");
                lstBxBook.Items.Add(title.InnerText);
                XmlNode author = doc.SelectSingleNode("/books/book[4]/author");
                lstBxBook.Items.Add(author.InnerText);
                XmlNode subject = doc.SelectSingleNode("/books/book[4]/subject");
                lstBxBook.Items.Add(subject.InnerText);
                XmlNode isbn = doc.SelectSingleNode("/books/book[4]/isbn");
                lstBxBook.Items.Add(isbn.InnerText);
                XmlNode date = doc.SelectSingleNode("books/book[4]/date");
                lstBxBook.Items.Add(date.InnerText);
                XmlNode numcop = doc.SelectSingleNode("books/book/numcopies");
                lstBxBook.Items.Add(numcop.InnerText);
                XmlNode numout = doc.SelectSingleNode("books/book[4]/copiesout");
                lstBxBook.Items.Add(numout.InnerText);

            } // end of if
            #endregion -- populated --


        } // end of lstBxInventory SelectedIndexChanged
        #endregion -- controls --


        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            btnAccept.Visible = true;
            btnAccept.Enabled = true;
            // if book copiesout < numcopies then allow a check out process
            // and enable the btnaccept

            // will need to read the xml and make an update to the xml file updating the 
            // copiesout

            // then need to close the xmlfile


        } // end of btnCheckOut

        private void btnReturn_Click(object sender, EventArgs e)
        {
            btnAccept.Visible = true;
            btnAccept.Enabled = true;
            // if this is the bookj being returned
            // must use reader to update the copiesout
            
        } // end of btnReturn


    } // end of partial class
} // end of namespace
