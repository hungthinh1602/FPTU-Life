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
    public class ThreadSimple_SE140958 extends  Thread{
        public void run(){
        System.out.println("Age : " + "21");
        System.out.println("Full Name : " + "DAO PHUNG HUNG THINH");
        System.out.println("Address : " + "Truong Thanh, quan 9, tp Ho Chi Minh");
    }
    public static void main(String[] args) {
        ThreadSimple_SE140958 t1 = new ThreadSimple_SE140958();
        t1.start();
    }        
}
