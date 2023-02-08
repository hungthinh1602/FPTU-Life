/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package lab2_450loc;

/**
 *
 * @author knc
 */
public class User {
    String userName;
    String password;
    String phone;
    String email;

    public User(String userName, String password, String phone, String email) {
        this.userName = userName;
        this.password = password;
        this.phone = phone;
        this.email = email;
    }

    public String getUserName() {
        return userName;
    }

    public void setUserName(String userName) {
        this.userName = userName;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getPhone() {
        return phone;
    }

    public void setPhone(String phone) {
        this.phone = phone;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    @Override
    public String toString() {
        return "User{" + "userName=" + userName  + ", phone=" + phone + ", email=" + email + '}';
    }
    
    
    
}
