
using Aspose.Words;


namespace Real_time_project
{
    internal class Program
    {
        static void Main()
        {
            Document doc = new Document("D:\\realtime.docx");
            DocumentBuilder d = new DocumentBuilder(doc);
            //We call this method to start building the table.
           d.StartTable();
            d.InsertCell();
            d.Write("chandu");
            
            //  builder the second cell
           d.InsertCell();
            d.Write("sravan");
         
            d.EndRow();
            d.EndTable(); 
            doc.Save("D:\\realtime.docx");

        }
    }
}