```java
import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

public class BackupTextFileGenerator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter the text you want to backup:");
        String text = scanner.nextLine();
        System.out.println("Enter the name of the backup file:");
        String fileName = scanner.nextLine();
        try {
            BufferedWriter writer = new BufferedWriter(new FileWriter(fileName));
            writer.write(text);
            writer.close();
            System.out.println("Backup created successfully.");
        } catch (IOException e) {
            System.out.println("An error occurred.");
            e.printStackTrace();
        }
    }
}
```