using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentCreator
{
    class HTMLHeading : IHTMLElement
    {
        private int level;
        private string text;

        // constructor
        public HTMLHeading(int levelIn, string textIn)
        {
            level = levelIn;
            text = textIn;

            // HTML supports heading levels of 1 through 6, so make sure the level is one of these
            if (level < 1)
                level = 1;
            else if (level > 6)
                level = 6;
        }


        // headings in HTML are denoted by "<hN>...</hN>" where N is the level of the header
        public string GetString()
        {
            //Write code here: Look at the GetString() method of HTMLParagraph
            return "<h1>\n" + text + "\n</h1>\n\n";
        }

        // get the level of the header
        public int GetLevel()
        {
            return level;
        }
    }
}
