using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentCreator
{
    class HTMLDocument
    {
        // the title of the document
        private string title = "";

        // the elements making up the body of the document

        private IList<IHTMLElement> body = new List<IHTMLElement>();


        // constructor
        public HTMLDocument()
        {

        }


        // append an element to the body of the document
        public void AppendToBody(IHTMLElement elementIn)
        {
            body.Add(elementIn);
        }

        // get a string representing the document
        public string GetString()
        {
            StringBuilder sbuilder = new StringBuilder();

            // start with the <html> element
            sbuilder.Append("<html>\n\n");

            // add the <head> with the <title>
            sbuilder.Append("<head>\n");
            sbuilder.Append("    <title>" + title + "</title>\n");
            sbuilder.Append("</head>\n\n");

            // start the body
            sbuilder.Append("<body>\n\n");

            // append all of the body elements
            foreach (IHTMLElement elem in body)
                sbuilder.Append(elem.GetString());

            // finish the body
            sbuilder.Append("</body>\n\n");

            // close the <html> element
            sbuilder.Append("</html>");

            return sbuilder.ToString();
        }


        // Write code here: set the title of the document
        public void SetTitle(String title)
        {
            this.title = title;
        }


    }
}
