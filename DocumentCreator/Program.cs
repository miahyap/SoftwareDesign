using System;

namespace DocumentCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Title");
            String titleText = Console.ReadLine();

            Console.WriteLine("Enter an Author Name");
            String authorText = Console.ReadLine();

            Console.WriteLine("Enter the body of the document");
            String bodyText = Console.ReadLine();

            //Write code here: to call the HTMLDocumentBuilder and do the necessary processing
            HTMLDocumentBuilder docBuilder = new HTMLDocumentBuilder();
            docBuilder.BuildDocument(titleText, authorText, bodyText);
            HTMLDocument resultDoc = docBuilder.GetDocument();

            //resultDoc is an HTMLDocument, the result of the document building process
            Console.WriteLine(resultDoc.GetString());
            Console.ReadLine();
         }
    }
}
