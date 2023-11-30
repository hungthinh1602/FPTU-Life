/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lab2_450loc;

import com.sun.org.apache.bcel.internal.generic.AALOAD;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.PrintWriter;
import java.nio.charset.StandardCharsets;
import java.security.MessageDigest;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.StringTokenizer;
import java.util.Vector;
import javax.xml.bind.DatatypeConverter;

/**
 *
 * @author knc
 */
public class UserManager {

    public UserManager() {
        super();
    }

    ArrayList<User> userL = new ArrayList<>();
    Scanner sc = new Scanner(System.in);

    public void AddUser() {
        String userName;
        String password;
        String rePassword;
        String phone;
        String email;
        boolean check = true;
        boolean ValidUser;
        
        do {
            System.out.println("Input user name: ");
            userName = sc.nextLine();
            String valid = "\\S{5,20}+";
            ValidUser = userName.matches(valid);
            if (ValidUser == false) {
                System.out.println("False");
                check = false;
            } else {
                check = true;
            }
        } while (check == false);

        do {
            System.out.println("Input password: ");
            password = sc.nextLine();
            String validPassword = "\\S+";
            if (!password.matches(validPassword)) {
                System.out.println("False");
                check = false;
            } else {
                check = true;
            }
        } while (check == false);

        do {
            System.out.println("ReInput Password: ");
            rePassword = sc.nextLine();
            if (!rePassword.matches(password)) {
                System.out.println("The password not same");
                check = false;
            } else {
                check = true;
            }
        } while (check == false);

        String SHApassword = password;
        String passwordChange = null;
        try {
            MessageDigest digets = MessageDigest.getInstance("SHA-256");
            byte[] change = digets.digest(SHApassword.getBytes(StandardCharsets.UTF_8));
            passwordChange = DatatypeConverter.printHexBinary(change);
        } catch (Exception e) {
        }

        do {
            Scanner scc = new Scanner(System.in);
            check = true;
            System.out.println("Email : ");
            String validEmail = "\\w+@\\w+[.]\\w+";      //Email
            email = scc.nextLine();
            if (!email.equals("")) {
                System.out.println("can not NULL");
            }
            if (!email.matches(validEmail)) {
                check = false;
                System.out.println("Invalid Email");
            } else {
                check = true;
            }
        } while (check == false);

        do {
            Scanner scc = new Scanner(System.in);
            check = true;
            String validPhone = "\\d{10,11}";
            System.out.println("Phone numbers : ");
            phone = scc.nextLine();
            if (phone.equals("")) {
                check = false;
                System.out.println("Can not NULL");
            } else if (!phone.matches(validPhone)) {
                System.out.println("Phone number must be 10-12 degits!!!");
                check = false;
            } else {
                check = true;
            }
        } while (check == false);

        userL.add(new User(userName, passwordChange, phone, email));

//        for (int i = 0; i < userL.size(); i++) {
//            System.out.println(userL);
//        }
    }

    public void SaveToFile(String fname) {

        if (userL.size() == 0) {
            System.out.println("Empty List");
            return;
        }
        try {
            File f = new File(fname);
            FileWriter fw = new FileWriter(f);
            PrintWriter pw = new PrintWriter(fw);
            for (User x : userL) {
                pw.println(x.getUserName() + "," + x.getPassword() + "," + x.getPhone() + "," + x.getEmail());
            }
            pw.close();
            fw.close();
        } catch (Exception e) {
            System.out.println(e);
        }
        System.out.println("Saved!!!");
    }

    public int find(String aUserName) {
        for (int i = 0; i < userL.size(); i++) {
            if (userL.get(i).getUserName().equals(aUserName)) {
                return i;
            }
        }
        return -1;
    }

    public void findUser() {
        String UserName;
        int pos;
        System.out.print("Input User want to find: ");
        UserName = sc.nextLine();
        pos = find(UserName);
        if (pos < 0) {
            System.out.println(UserName + " does not exit!");
        } else {
            System.out.println(UserName + " is exit!");
        }
    }

    public void loadFromFile(String fname) {
        try {
            File f = new File(fname);
            FileReader fr = new FileReader(f);
            BufferedReader br = new BufferedReader(fr);
            String data;
            while ((data = br.readLine()) != null) {
                StringTokenizer sz = new StringTokenizer(data, ",");
                String userName = sz.nextToken();
                String pass = sz.nextToken();
                String phone = sz.nextToken();
                String email = sz.nextToken();
                User user = new User(userName, pass, phone, email);
                userL.add(user);

            }

        } catch (Exception e) {
            System.out.println(e);
        }

    }

    public void seachByName() {
        String userName = null;
        String email = null;
        String phone = null;
        int pos;

        System.out.print("Input UserName: ");
        userName = sc.nextLine();
        pos = find(userName);
        if (pos < 0) {
            System.out.println("This Username does not exit.");
        }
        for (int i = 0; i < userL.size(); i++) {
            if (userName.equals(userL.get(i).userName)) {
                System.out.println("Phone: " + userL.get(i).phone);

//                    email=userL.get(i).email;                    
                System.out.println("Email: " + userL.get(i).email);
            }
        }
    }

    public void subMenu() {
        boolean check = true, Input = true;
        Vector submnu = new Vector();

        do {
            check = true;
            submnu.add("A- Update User");
            submnu.add("\nB- Delete User");
            submnu.add("\nC- Exit");
            submnu.add("\nSubMenu Choice: ");
            System.out.println(submnu);
            String subChoices = "^A|B|C";
            do {
                Input = true;
                subChoices = sc.nextLine().trim().toUpperCase();
                if (!subChoices.equals("A") & !subChoices.equals("B") & !subChoices.equals("C")) {
                    Input = false;
                    System.out.println("\nYou must Choice A or B to use subMenu");
                }

                if (subChoices.equals("A")) {
                    UpdateUser();
                    Input = true;
                }
                if (subChoices.equals("B")) {
                    DeleteUser();
                    Input = true;
                }
                if (subChoices.equals("C")) {
                    check = true;
                }
            } while (Input == false);

        } while (check == false);
    }

    public void UpdateUser() {
        String user;
        String phone = null;
        String email = null;
        String password;
        String rePassword;
        int pos;
        boolean check = true;

        System.out.print("Input User: ");
        user = sc.nextLine();
        pos = find(user);
        if (pos < 0) {
            System.out.println("User does not exit.");
        }
        for (int i = 0; i < userL.size(); i++) {
            if (user.equals(userL.get(i).userName)) {
                do {
                    System.out.println("Input new password: ");
                    password = sc.nextLine();
                    String validPassword = "\\S+";
                    if (!password.matches(validPassword)) {
                        System.out.println("False");
                        check = false;
                    } else {
                        check = true;
                    }
                } while (check == false);

                do {
                    System.out.println("ReInput new Password: ");
                    rePassword = sc.nextLine();
                    if (!rePassword.matches(password)) {
                        System.out.println("The password not same");
                        check = false;
                    } else {
                        check = true;
                    }
                } while (check == false);

                do {
                    Scanner scc = new Scanner(System.in);
                    check = true;
                    System.out.println("Email : ");
                    String validEmail = "\\w+@\\w+[.]\\w+";      //Email
                    email = scc.nextLine();
                    if (!email.equals("")) {
                        System.out.println("can not NULL");
                    }
                    if (!email.matches(validEmail)) {
                        check = false;
                        System.out.println("Invalid Email");
                    } else {
                        check = true;
                    }
                } while (check == false);

                do {
                    Scanner scc = new Scanner(System.in);
                    check = true;
                    String validPhone = "\\d{10,11}";
                    System.out.println("Phone numbers : ");
                    phone = scc.nextLine();
                    if (phone.equals("")) {
                        check = false;
                        System.out.println("Can not NULL");
                    } else if (!phone.matches(phone)) {
                        System.out.println("Phone number must be 10-12 degits!!!");
                        check = false;
                    } else {
                        check = true;
                    }
                } while (check == false);

                userL.set(pos, new User(user, password, phone, email));
                System.out.println("User " + user + " has been update successfully!");
            }
        }
    }

    public void DeleteUser() {
        String user;
        int pos;

        System.out.print("Input the user you want to delete: ");
        user = sc.nextLine();
        pos = find(user);
        if (pos < 0) {
            System.out.println("This user does not exit.");
        } else {
            userL.remove(userL.get(pos));
        }
        System.out.println("User " + user + " has been delete!");
    }

    public void showlist() {
        for (User x : userL) {
            System.out.println(x.toString());
        }
    }

}
