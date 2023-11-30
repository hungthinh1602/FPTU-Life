/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */
package com.mycompany.project;


import View.ProductListUI;
import java.io.File;
import java.util.List;
import javax.xml.transform.stream.StreamSource;
import model.Data;
import model.Product;
import model.Products;
import View.ProductListUI;
import org.xml.sax.SAXException;

public class Project {

    public static void main(String[] args) throws Exception {
        String xmlFile = "src/main/java/Resource/Products.xml";
        String xsdFile = "src/main/java/Resource/Products.xsd";

        // Validate the XML file
        Validator validator = new Validator(xsdFile);
        StreamSource xmlSource = new StreamSource(new File(xmlFile));
        try {
            if (validator.validate(xmlSource)) {
                System.out.println("Validation successful");

                // Parse the XML file
                Products data = validator.parse(xmlSource);
                List<Product> productList = data.getProducts();
                BasicCRUD basicCRUD = new BasicCRUD(productList);
                ProductListUI.displayProductList(productList,xmlSource,xmlFile,basicCRUD);
            } else {
                System.out.println("Validation failed");
            }
        } catch (SAXException e) {
            System.out.println("Validation error: " + e.getMessage());
        }
    }
}
