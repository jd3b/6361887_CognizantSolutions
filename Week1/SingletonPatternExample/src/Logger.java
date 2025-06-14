public class Logger {
    private static Logger instance;
    private Logger(){
        System.out.println("Initialized Logger");
    }
    public static Logger getLogger(){
        if (instance == null) {
            instance = new Logger();
        }
        return instance;
    }
    public void msg(String msg) {
        System.out.println("Log: " + msg);
    }
}