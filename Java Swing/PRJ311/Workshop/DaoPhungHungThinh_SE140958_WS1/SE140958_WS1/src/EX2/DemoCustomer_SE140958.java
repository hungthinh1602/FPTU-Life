/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package EX2;

/**
 *
 * @author knc
 */
public class DemoCustomer_SE140958 {
    public static void main(String[] args) {
        Customer_SE140958 c = new Customer_SE140958();
        
        Thread t1 = new Thread(){
            public void run(){
                c.withdraw(2000);
            }
        };
        t1.start();
        
        Thread t2 = new Thread(){
            public void run(){
                c.deposit(3000);
            }
        };
        t2.start();
        
    }
}
