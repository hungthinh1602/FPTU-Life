/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lab2_450loc;

import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author knc
 */
public class Lab2 {

    public static void main(String[] args) {
        String getUserChoice;
        UserManager userM = new UserManager();
        boolean check = true;
        String fileName = "user.txt";
        userM.loadFromFile(fileName);
        do {
            System.out.println("--------------Menu----------------");
            System.out.println("1-Create user account");
            System.out.println("2-Check exit user");
            System.out.println("3-Search user by Name");
            System.out.println("4-Update user");
            System.out.println("5-Save account to file");
            System.out.println("6-Print");
            System.out.println("Other-Exit");
            System.out.println("User choice: ");
            Scanner sc = new Scanner(System.in);
            try {
                getUserChoice = sc.next();
                switch (getUserChoice) {
                    case "1":
                        userM.AddUser();
                        break;
                    case "2":
                        userM.findUser();
                        break;
                    case "4":
                        userM.subMenu();
                        break;
                    case "3":
                        userM.seachByName();
                        break;
                    case "5":
                        userM.SaveToFile(fileName);
                        break;
                    case "6":
                        userM.showlist();
                        break;
                   
                    default: check =false;
                }
            } catch (Exception e) {
                check=false;
            }

        } while (check == true);
    }
}
