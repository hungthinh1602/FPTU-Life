/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package WS6;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.Socket;
import javax.swing.JOptionPane;
import javax.swing.JTextArea;

/**
 *
 * @author USER
 */

public class OutputThread extends Thread {
    Socket socket; // socket is joining to the communication
    JTextArea txt; //text-area contains communicated message
    BufferedReader bf; // in put buufer of the socket
    String sender; // sender, a site of the commumication
    String receiver; /// receiver, other site of the communication

    public OutputThread(Socket socket, JTextArea txt, String sender, String receiver) {
        super();
        this.socket = socket;
        this.txt = txt;
        this.sender = sender;
        this.receiver = receiver;
        try {
            bf = new BufferedReader(new InputStreamReader(socket.getInputStream()));
        }
        catch (Exception e){
            JOptionPane.showMessageDialog(null, "Network Error!");
            System.exit(0);
        }
    }
    // get data from the input stream periodically (1 time/sec)
    // The time when data comes can'nt be known in advance
    public void run(){
        while (true)
             try {
               if (socket !=null){
                   String msg=""; // get data from the input stream
                   if ((msg=bf.readLine())!=null && msg.length()>0) txt.append("\n"+receiver+": "+msg);
               }     
                 Thread.sleep(1000);
             }
        catch (Exception e){
            
        }
    }
    
}
