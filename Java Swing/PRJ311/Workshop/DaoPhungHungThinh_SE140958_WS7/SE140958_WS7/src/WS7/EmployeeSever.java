/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package WS7;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.PrintWriter;
import java.rmi.Remote;
import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.util.StringTokenizer;
import java.util.Vector;

/**
 *
 * @author knc
 */

public class EmployeeSever extends UnicastRemoteObject implements EmployeeMngInterface{
    String fileName;
    public  EmployeeSever(String fileName) throws RemoteException{
        super();
        this.fileName = fileName;
    }

    @Override
    public Vector getInitiaData() throws RemoteException {
        Vector data = new Vector(0);
         try {
            FileReader fr = new FileReader(fileName);
            BufferedReader bf = new BufferedReader(fr);
            String line;
            StringTokenizer stk;
            String code,name,salary;
            while((line = bf.readLine()) != null){
                stk = new StringTokenizer(line, ",");
                Vector v = new Vector();
                v.add(stk.nextToken());
                v.add(stk.nextToken());
                v.add(Integer.parseInt(stk.nextToken()));
                data.add(v);
            }
            bf.close();
            fr.close();
        } catch (Exception e) {}
         return  data;
    }

    @Override
    public boolean saveList(Vector data) throws RemoteException {
        try {
            FileWriter fw = new FileWriter(fileName);
            PrintWriter pw = new PrintWriter(fw);
            for(int i=0;i<data.size();i++){
                Vector v = ((Vector)(data.get(i)));
                String S="";
                S+=v.get(0)+","+ v.get(1)+","+v.get(2);
                pw.println(S);
            }
            pw.close();
            fw.close();
            return true;
        } catch (Exception e) {
        }
        return false;
    }
    
}
