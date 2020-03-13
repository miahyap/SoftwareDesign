using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentCreator
{
    class HTMLDocumentBuilder
    {
        private HTMLDocument doc;
        private string title;
        private string author;

        // constructor
        public HTMLDocumentBuilder()
        {
            doc = new HTMLDocument();

            // set a default title and author
            title = "";
            author = "";
        }

        // build the <head> element
        private void BuildHeadElement(string titleIn, string authorIn)
        {
            // save the title and author for later
            title = titleIn;
            author = authorIn;

            // Write code here: set the title of the document
            doc.SetTitle(title);

        }

        // build the <body> element
        private void BuildBody(string textIn)
        {
            // add a top-level heading containing the title
            doc.AppendToBody(new HTMLHeading(1, title));

            // Write code here: add a second-level heading containing the author
            doc.AppendToBody(new HTMLHeading(2, author));

            // Write code here: add a paragraph containing the text
            doc.AppendToBody(new HTMLParagraph(textIn));

        }

        public void BuildDocument(String titleIn, String authorIn, String textIn)
        {
            BuildHeadElement(titleIn, authorIn);
            //Write code here: call the method to build the body
            BuildBody(textIn);

        }
        // return the document that has built
        public HTMLDocument GetDocument()
        {
            return doc;
        }
    }
}
