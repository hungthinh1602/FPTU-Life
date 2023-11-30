/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.project;


import java.io.File;
import java.io.IOException;
import javax.xml.XMLConstants;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBElement;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;
import javax.xml.transform.stream.StreamSource;
import javax.xml.validation.Schema;
import javax.xml.validation.SchemaFactory;
import model.Data;
import model.Products;
import org.xml.sax.SAXException;

public class Validator {

    private final String xsdFile;

    public Validator(String xsdFile) {
        this.xsdFile = xsdFile;
    }

    public boolean validate(StreamSource xmlSource) throws SAXException {
        try {
            String schemaLanguage = XMLConstants.W3C_XML_SCHEMA_NS_URI;
            SchemaFactory schemaFactory = SchemaFactory.newInstance(schemaLanguage);
            File fileXsd = new File(xsdFile);
            Schema schema = schemaFactory.newSchema(fileXsd);
            javax.xml.validation.Validator validator = schema.newValidator();
            validator.validate(xmlSource);
            return true;
        } catch (IOException | SAXException e ) {
            System.err.println("Error data occus: " + e);
            return false;
        }
    }

    public Products parse(StreamSource xmlSource) throws JAXBException {
        Class classFormat = Products.class;
        JAXBContext jaxbContext = JAXBContext.newInstance(classFormat);
        Unmarshaller jaxbUnmarshaller = jaxbContext.createUnmarshaller();
        JAXBElement<Products> root = jaxbUnmarshaller.unmarshal(xmlSource, classFormat);
        Products productList = root.getValue();
        return productList;
    }
}
