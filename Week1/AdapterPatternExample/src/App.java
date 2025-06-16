public class App {
    public static void main(String[] args) {

        PaymentProcessor razorPayProcessor = new RazorPayAdapter(new RazorPayGateway());
        PaymentProcessor ccAvenueProcessor = new CCavenueAdapter(new CCavenueGateway());

        System.out.println("Using RazorPay Adapter:");
        razorPayProcessor.processPayment(1500.00);

        System.out.println("Using CCAvenue Adapter:");
        ccAvenueProcessor.processPayment(2500.50);
    }
}
