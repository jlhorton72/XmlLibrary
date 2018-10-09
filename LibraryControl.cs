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

        /// <summary>
        /// here begins the form for library controls
        /// </summary>
    public partial class LibraryControl : Form
    {
        XmlDocument doc = new XmlDocument();
        static int selected; 
        static int numCop;
        static int numOut;

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
            label8.Visible = false;
            btnCheckOut.Visible = false;
            btnReturn.Visible = false;
            lblFalse.Visible = false;
            txtBxInfo.Visible = false;
            btnAcceptRtrn.Visible = false;
            btnAcceptRtrn.Enabled = false;       
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
            btnAcceptRtrn.Visible = false;
            btnAcceptRtrn.Enabled = false;
            label8.Visible = true;
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

            doc.Save("books.xml");
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
            btnAcceptRtrn.Visible = false;
            btnAcceptRtrn.Enabled = false;
            lblFalse.Visible = false;
            txtBxInfo.Visible = false;
            lstBxBook.Items.Clear();    // clears the lstbxbook        
            lstBxBook.Visible = true;   // makes lstbxbook visible
            label8.Visible = true;
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
                selected = 1;
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
                selected = 2;
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
                selected = 3;
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
                XmlNode numcop = doc.SelectSingleNode("books/book[4]/numcopies");
                lstBxBook.Items.Add(numcop.InnerText);
                XmlNode numout = doc.SelectSingleNode("books/book[4]/copiesout");
                lstBxBook.Items.Add(numout.InnerText);
                selected = 4;
            } // end of if
            #endregion -- populated --

            doc.Save("books.xml");      // saves the file

        } // end of lstBxInventory SelectedIndexChanged
        #endregion -- controls --

        /// <summary>
        /// this will call the IsCopyAvail method to 
        /// verify there are copies to check out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            doc.Load("books.xml");      // loads the file
            XmlNode numcop = doc.SelectSingleNode("books/book[" + selected + "]/numcopies");
            numCop = Int32.Parse(numcop.InnerText);
            XmlNode numout = doc.SelectSingleNode("books/book[" + selected + "]/copiesout");
            numOut = Int32.Parse(numout.InnerText);
            // need to find the values for numcopies and copies out thru the reader
            bool chkOut = Book.IsCopyAvailable(numCop, numOut);
            // must use boolean for iscopyavailable
            // if book copiesout < numcopies then allow a check out process
            // and enable the btnaccept
            if (chkOut == true)
            {
                btnAccept.Visible = true;
                btnAccept.Enabled = true;
                lblFalse.Visible = false;
                txtBxInfo.Visible = true;
                // test code
                //lstBxInventory.Items.Clear();
                //lstBxInventory.Text = "it worked";

                // add code for messagebox saying you can check book out
                txtBxInfo.Text = "Book available for check out";

            } // end of if true

            if (chkOut == false)
            {
                lblFalse.Visible = true;
                txtBxInfo.Visible = true;
                // add code for messagebox saying check out not possible
                txtBxInfo.Text = "Book is NOT available for check out";
            } // end of false

            // if chkout possible now we go to the btnAccept

            doc.Save("books.xml");          // saves the file
        } // end of btnCheckOut

        /// <summary>
        /// this checks to see if book needs to be 
        /// returned by calling the rNeedReturn method from 
        /// book class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            doc.Load("books.xml");          // loads the file
            XmlNode numcop = doc.SelectSingleNode("books/book[" + selected + "]/numcopies");
            numCop = Int32.Parse(numcop.InnerText);
            XmlNode numout = doc.SelectSingleNode("books/book[" + selected + "]/copiesout");
            numOut = Int32.Parse(numout.InnerText);
            bool chkIn = Book.NeedReturn(numCop, numOut);
            if (chkIn == true)
            {
                btnAcceptRtrn.Visible = true;
                btnAcceptRtrn.Enabled = true;
                txtBxInfo.Visible = true;
                txtBxInfo.Text = "Book Eligible for Return";
            } // EndInvoke of if for chkIn true

            if (chkIn == false)
            {
                btnAccept.Visible = false;
                btnAccept.Enabled = false;                
                btnAcceptRtrn.Visible = false;
                btnAcceptRtrn.Enabled = false;
                txtBxInfo.Visible = true;
                txtBxInfo.Text = " Book NOT Eligible for Return";
            } // end of if chkIn false
              // if this is the bookj being returned
              // must be a copy that needs to be returned
              // must use reader to update the copiesout

            doc.Save("books.xml");          // // saves the file
        } // end of btnReturn

        /// <summary>
        ///  this should call the check out method
        ///  and display message when done with due date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            txtBxInfo.Visible = false;
            btnAcceptRtrn.Visible = false;
            // need to call the check out method
            // check out
            Book.CheckOutBook(numCop, numOut, selected);
            txtBxInfo.Visible = true;
            txtBxInfo.Text = "Book successfully checked out\n" + "Due date is " + 
                DateTime.Now.AddDays(14).ToString("dd.MM.yy");
            btnAccept.Visible = false;
            btnAccept.Enabled = false;
            lblFalse.Visible = false;
            btnAccept.Visible = false;
            btnAccept.Enabled = false;

        } // end of btnAccept

        /// <summary>
        /// this should call the return method
        /// and display message when its done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAcceptRtrn_Click(object sender, EventArgs e)
        {
            txtBxInfo.Visible = false;
            btnAccept.Visible = false;
            btnAccept.Enabled = false;
            Book.ReturnBook(numCop, numOut, selected);
            txtBxInfo.Visible = true;
            txtBxInfo.Text = "Book succesfully returned\nThank You";
            btnAcceptRtrn.Visible = false;
            btnAcceptRtrn.Enabled = false;
        } // end of btnAcceptReturn
    } // end of partial class
} // end of namespace
