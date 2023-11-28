import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;

public class CalculatorServer extends UnicastRemoteObject implements CalculatorInterface {

    public CalculatorServer() throws RemoteException {
        super();
    }

    @Override
    public int add(int a, int b) throws RemoteException {
        return a + b;
    }

    @Override
    public int subtract(int a, int b) throws RemoteException {
        return a - b;
    }

    @Override
    public int multiply(int a, int b) throws RemoteException {
        return a * b;
    }

    @Override
    public double divide(double a, double b) throws RemoteException {
        if (b == 0) {
            throw new RemoteException("Cannot divide by zero");
        }
        return a / b;
    }

    public static void main(String[] args) {
        try {
            CalculatorServer server = new CalculatorServer();
            java.rmi.Naming.rebind("CalculatorService", server);
            System.out.println("Calculator server is running...");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
