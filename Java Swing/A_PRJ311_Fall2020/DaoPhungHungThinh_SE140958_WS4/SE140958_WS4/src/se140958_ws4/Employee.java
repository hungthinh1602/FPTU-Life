/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package se140958_ws4;

/**
 *
 * @author knc
 */
public class Employee {
    String code;
    String name;
    String salary;

    public Employee(String code, String name, String salary) {
        this.code = code;
        this.name = name;
        this.salary = salary;
    }

    public String getCode() {
        return code;
    }

    public void setCode(String code) {
        this.code = code;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getSalary() {
        return salary;
    }

    public void setSalary(String salary) {
        this.salary = salary;
    }

    
    @Override
    public String toString() {
        return code + "-" + name;
    }

}
