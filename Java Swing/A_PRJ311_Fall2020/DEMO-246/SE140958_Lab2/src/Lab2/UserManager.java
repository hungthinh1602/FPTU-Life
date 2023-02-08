/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Lab2;

import java.io.*;
import java.util.*;

/**
 *
 * @author knc
 */
public class UserManager {
    Scanner sc = new Scanner(System.in);
    ArrayList<User> userList = new ArrayList<>();

public void CreateNewAccount(){
    String nameUser,password,firstName,lastName,confirm,phone,email;
    boolean check=true;
    
    do{
    System.out.println("Input User name: ");
    String validUserName = "^\\s\\D";    
    nameUser = sc.nextLine().trim().toUpperCase();
    if(nameUser.equals(" ")){
            System.out.println("Username can not NULL");
            check =false;
    }else if(!nameUser.equals(validUserName)){
                System.out.println("Username can not have SPACE charater");
                check=false;
            }else
                check =true;
    }while(check == true);
    
    
}  




}
