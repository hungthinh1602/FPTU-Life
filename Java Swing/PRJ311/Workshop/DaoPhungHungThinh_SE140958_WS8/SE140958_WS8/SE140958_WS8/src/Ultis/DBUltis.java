/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Ultis;

import java.io.Serializable;
import java.sql.Connection;
import java.sql.DriverManager;

/**
 *
 * @author knc
 */
public class DBUltis implements Serializable{
    public static Connection openConnection(){
        try {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            String url = "jdbc:sqlserver://localhost:1433; databaseName= SE140958_WS8;";
            Connection con = DriverManager.getConnection(url,"sa","12345");
            return con;
        } catch (Exception e) {
            e.printStackTrace();
        }
    
    return null;
}
}
