/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.project;


import java.time.LocalDateTime;
import java.util.List;
import model.Product;
import net.sf.saxon.expr.instruct.ForEach;

public class BasicCRUD {
    // XML file path
    private final List<Product> productList;

    public BasicCRUD(List<Product> list) {
        this.productList = list;
    }

    public void addProductToXML(int id, String name, Double price, LocalDateTime createdDate) {
        Product p = new Product();
        p.setId(id);
        p.setName(name);
        p.setPrice(price);
        p.setCreatedDate(createdDate);
        productList.add(p);
        System.out.println("Add product");
    }
    
    public boolean removeProduct(int id){
        for(Product p : productList){
            if(p.getId() == id){
                productList.remove(p);
                return true;
            }
        }
        return false;
    }
    
    public boolean updateProduct(int id, String name, Double price, LocalDateTime createdDate){
        for(Product p : productList){
            if(p.getId() == id){
                p.setId(id);
                p.setName(name);
                p.setPrice(price);
                p.setCreatedDate(createdDate);
                return true;
            }
        }
        return false;
    }
}