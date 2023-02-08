
package EX2;

public class Customer_SE140958 {
    private int balance = 1000;

    public Customer_SE140958() {
        System.out.println("The balance in your account is: "+balance);
    }
    
    public synchronized void withdraw(int amount){
        System.out.println("Withdrawal transactions in progress: "+ amount);
        if(balance < amount){
            System.out.println("Cannot withdraw!");
            try {
                wait();
            } catch (InterruptedException ie) {
                System.out.println(ie.toString());
            }
            balance -=amount;
            System.out.println("With successful withdrawal, your balance is: " +balance);
        }        
    }
    
    public synchronized void deposit(int amount){
        System.out.println("Make a deposit to your account : "+ amount + "...");
        balance +=amount;
        System.out.println("Deposit is successful, your balance is: "+ balance);
        notify();
    }
}
