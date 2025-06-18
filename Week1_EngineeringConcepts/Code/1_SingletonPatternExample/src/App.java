public class App {
    public static void main(String[] args) throws Exception {
        Logger l1= Logger.getLogger();
        Logger l2= Logger.getLogger();
        System.out.println(l1.hashCode());
        System.out.println(l2.hashCode());
        l1.msg("Message from l1");
        l2.msg("Message from l2");
    }
}
