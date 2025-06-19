using System;
public class DocumentFactory
{
    public class WordDocument : Document
    {
        public void PerformOperation()
        {
            Console.WriteLine("Performing Operations in Word Document");
        }
    }
    public class PdfDocument : Document
    {
        public void PerformOperation()
        {
            Console.WriteLine("Performing Operations in PDF Document");
        }
    }
    public class ExcelDocument : Document
    {
        public void PerformOperation()
        {
            Console.WriteLine("Performing Operations in Excel Document");
        }
    }
    public Document CreateDocument(string type)
    {
        switch (type.ToLower())
        {
            case "word":
                return new WordDocument();
            case "pdf":
                return new PdfDocument();
            case "excel":
                return new ExcelDocument();
            default:
                throw new ArgumentException($"Invalid document type: {type}");
        }
    }
}
