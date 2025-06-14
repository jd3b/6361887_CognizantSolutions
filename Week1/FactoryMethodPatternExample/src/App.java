
public class App {
    public static void main(String[] args) {
        DocumentFactory factory = new DocumentFactory();

        // Create and use WordDocument
        Document wordDocument = factory.createDocument("word");
        wordDocument.performOperation();

        System.out.println();

        // Create and use PdfDocument
        Document pdfDocument = factory.createDocument("pdf");
        pdfDocument.performOperation();

        System.out.println();

        // Create and use ExcelDocument
        Document excelDocument = factory.createDocument("excel");
        excelDocument.performOperation();
    }
}
