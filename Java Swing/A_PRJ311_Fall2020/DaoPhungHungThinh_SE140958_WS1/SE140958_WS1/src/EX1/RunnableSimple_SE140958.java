/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package EX1;

/**
 *
 * @author knc
 */
public class RunnableSimple_SE140958 implements Runnable{
    public void run(){
        System.out.println("Code : " + "SE140958");
        System.out.println("Full Name : " + "DAO PHUNG HUNG THINH");
        System.out.println("Class: " + "SE01D");
    }
    
    public static void main(String[] args) {
        RunnableSimple_SE140958 runable = new RunnableSimple_SE140958();
        Thread t1 = new Thread(runable);
        t1.start();
    }
}
