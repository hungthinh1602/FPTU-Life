/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package WS7;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.Vector;

/**
 *
 * @author knc
 */
public interface EmployeeMngInterface extends  Remote{
    Vector getInitiaData() throws RemoteException;
    boolean saveList (Vector data) throws RemoteException;
}
