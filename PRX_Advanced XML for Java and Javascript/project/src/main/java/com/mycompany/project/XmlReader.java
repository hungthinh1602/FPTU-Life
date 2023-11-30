/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.project;


import model.Products;
import java.io.File;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;

public class XmlReader {
    public Products parse(String xmlFile) throws JAXBException {
        File file = new File(xmlFile);
        JAXBContext jaxbContext = JAXBContext.newInstance(Products.class);
        Unmarshaller jaxbUnmarshaller = jaxbContext.createUnmarshaller();
        Products products = (Products) jaxbUnmarshaller.unmarshal(file);
        return products;
    }
}
