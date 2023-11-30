/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package model;

import java.io.ByteArrayInputStream;
import java.io.InputStream;
import java.nio.charset.StandardCharsets;
import java.util.ArrayList;
import java.util.List;


public class Data {
    private List<Product> productList;

    public Data() {
        productList = new ArrayList<>();
    }
    
    public Data(ArrayList list){
        productList = list; 
    }

    public List<Product> getProductList() {
        return productList;
    }

    public void setProductList(List<Product> productList) {
        this.productList = productList;
    }

    public void addProduct(Product product) {
        productList.add(product);
    }
    
    public InputStream toInputStream() {
        String xmlString = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<Products>\n";
        for (Product product : productList) {
            xmlString += "  <Product Id=\"" + product.getId() + "\">\n";
            xmlString += "    <Name>" + product.getName() + "</Name>\n";
            xmlString += "    <Price>" + product.getPrice() + "</Price>\n";
            xmlString += "    <CreatedDate>" + product.getCreatedDate() + "</CreatedDate>\n";
            xmlString += "  </Product>\n";
        }
        xmlString += "</Products>\n";
        return new ByteArrayInputStream(xmlString.getBytes(StandardCharsets.UTF_8));
    }
}
