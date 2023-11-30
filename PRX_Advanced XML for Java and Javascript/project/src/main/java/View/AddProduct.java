/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package View;


import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import net.sf.saxon.s9api.*;

import com.mycompany.project.BasicCRUD;
import java.time.LocalDateTime;
import java.time.format.DateTimeParseException;

public class AddProduct {

    private JFrame frame;
    private JTextField idField;
    private JTextField nameField;
    private JTextField priceField;
    private JTextField createdDateField;

    public AddProduct(BasicCRUD basicCRUD) {
        frame = new JFrame("Add Product");
        frame.setLayout(new FlowLayout());

        idField = new JTextField(10);
        nameField = new JTextField(10);
        priceField = new JTextField(10);
        createdDateField = new JTextField(10);

        JButton addButton = new JButton("Add Product");
        addButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String idString = idField.getText();
                String name = nameField.getText();
                String priceString = priceField.getText();
                String createdDateString = createdDateField.getText();
                int id = 0;
                try {
                    id = Integer.parseInt(idString);
                } catch (NumberFormatException er) {
                    // Handle invalid input for ID (e.g., non-numeric characters)
                    System.out.println("Invalid input for ID: " + idString);
                }

                double price = 0.0;
                try {
                    price = Double.parseDouble(priceString);
                } catch (NumberFormatException er) {
                    // Handle invalid input for price (e.g., non-numeric characters)
                    System.out.println("Invalid input for price: " + priceString);
                }

                LocalDateTime createdDate = null;
                try {
                    createdDate = LocalDateTime.parse(createdDateString);
                } catch (DateTimeParseException er) {
                    // Handle invalid input for createdDate (e.g., incorrect date format)
                    System.out.println("Invalid input for createdDate: " + createdDateString);
                }

                // Call the function to add product to XML
                basicCRUD.addProductToXML(id, name, price, createdDate);

                // Display a success message
                JOptionPane.showMessageDialog(frame, "Product added successfully!");
            }
        });

        frame.add(new JLabel("ID:"));
        frame.add(idField);
        frame.add(new JLabel("Name:"));
        frame.add(nameField);
        frame.add(new JLabel("Price:"));
        frame.add(priceField);
        frame.add(new JLabel("Created Date:"));
        frame.add(createdDateField);
        frame.add(addButton);
        frame.setLocationRelativeTo(null);
        frame.pack();
        frame.setVisible(true);
    }

}
