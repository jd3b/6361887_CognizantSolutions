using System;
public class Program
{
    public static void Main(string[] args)
    {
        DocumentFactory factory = new DocumentFactory();

        Document wordDocument = factory.CreateDocument("word");
        wordDocument.PerformOperation();

        Console.WriteLine();

        Document pdfDocument = factory.CreateDocument("pdf");
        pdfDocument.PerformOperation();

        Console.WriteLine();

        Document excelDocument = factory.CreateDocument("excel");
        excelDocument.PerformOperation();
    }
}
