public class App {
    public static void main(String[] args) {
        Computer PC1 = new Computer.Builder()
                .setCPU("Intel i7")
                .setRAM("32GB")
                .setStorage("1TB SSD")
                .build();

        Computer PC2 = new Computer.Builder()
                .setCPU("Intel i5")
                .setRAM("16GB")
                .setStorage("512GB SSD")
                .build();

        System.out.println("PC1 Configuration: " + PC1);
        System.out.println("PC2 Configuration: " + PC2);
    }
}
