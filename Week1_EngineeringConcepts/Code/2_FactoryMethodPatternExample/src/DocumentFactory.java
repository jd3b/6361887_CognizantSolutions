

public class DocumentFactory {

    public static class WordDocument implements Document {

        @Override
        public void performOperation() {
            System.out.println("Performing Operations in Word Document");
        }
    }

    public static class PdfDocument implements Document {

        @Override
        public void performOperation() {
            System.out.println("Performing Operations in PDF Document");
        }
    }

    public static class ExcelDocument implements Document {

        @Override
        public void performOperation() {
            System.out.println("Performing Operations in Excel Document");
        }
    }

    public Document createDocument(String type) {
        return switch (type.toLowerCase()) {
            case "word" ->
                new WordDocument();
            case "pdf" ->
                new PdfDocument();
            case "excel" ->
                new ExcelDocument();
            default ->
                throw new IllegalArgumentException(type);
        };
    }
}
