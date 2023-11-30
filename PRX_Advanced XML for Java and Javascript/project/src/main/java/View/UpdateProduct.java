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

public class UpdateProduct {

    private JFrame frame;
    private JTextField idField;
    private JTextField nameField;
    private JTextField priceField;
    private JTextField createdDateField;

    public UpdateProduct(BasicCRUD basicCRUD) {
        frame = new JFrame("Add Product");
        frame.setLayout(new FlowLayout());

        idField = new JTextField(10);
        nameField = new JTextField(10);
        priceField = new JTextField(10);
        createdDateField = new JTextField(10);

        JButton addButton = new JButton("Update Product");
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
                    System.out.println("Invalid update for ID: " + idString);
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
                    System.out.println("Invalid update for createdDate: " + createdDateString);
                }

                if (basicCRUD.updateProduct(id , name , price , createdDate)) {
                    JOptionPane.showMessageDialog(frame, "Product update successfully!");
                }else{
                    JOptionPane.showMessageDialog(frame, "Product update fall!");
                }
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
