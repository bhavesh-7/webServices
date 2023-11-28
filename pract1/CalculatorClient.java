import java.rmi.Naming;

public class CalculatorClient {
    public static void main(String[] args) {
        try {
            String url = "rmi://localhost/CalculatorService";
            CalculatorInterface calculator = (CalculatorInterface) Naming.lookup(url);

            int resultAdd = calculator.add(10, 5);
            System.out.println("10 + 5 = " + resultAdd);

            int resultSubtract = calculator.subtract(10, 5);
            System.out.println("10 - 5 = " + resultSubtract);

            int resultMultiply = calculator.multiply(10, 5);
            System.out.println("10 * 5 = " + resultMultiply);

            double resultDivide = calculator.divide(10.0, 5.0);
            System.out.println("10 / 5 = " + resultDivide);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
