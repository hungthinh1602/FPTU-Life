/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Lab2;

/**
 *
 * @author knc
 */
public class User {
    String nameUser,password,firstName,lastName,confirm,phone,email;

    public User(String nameUser, String password, String firstName, String lastName, String confirm, String phone, String email) {
        this.nameUser = nameUser;
        this.password = password;
        this.firstName = firstName;
        this.lastName = lastName;
        this.confirm = confirm;
        this.phone = phone;
        this.email = email;
    }

    public String getNameUser() {
        return nameUser;
    }

    public void setNameUser(String nameUser) {
        this.nameUser = nameUser;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public String getConfirm() {
        return confirm;
    }

    public void setConfirm(String confirm) {
        this.confirm = confirm;
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
        return "nameUser=" + nameUser + ", password=" + password + ", firstName=" + firstName + ", lastName=" + lastName + ", confirm=" + confirm + ", phone=" + phone + ", email=" + email ;
    }
    
    
}
