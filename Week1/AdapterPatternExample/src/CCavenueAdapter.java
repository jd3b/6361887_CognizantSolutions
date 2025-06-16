public class CCavenueAdapter implements PaymentProcessor {
    private final CCavenueGateway ccAvenueGateway;

    public CCavenueAdapter(CCavenueGateway ccAvenueGateway) {
        this.ccAvenueGateway = ccAvenueGateway;
    }

    @Override
    public void processPayment(double amount) {
        ccAvenueGateway.processPayment(amount);
    }
}
