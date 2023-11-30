/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package View;


import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import com.mycompany.project.BasicCRUD;

public class DeleteProduct {

    private JFrame frame;
    private JTextField idField;

    public DeleteProduct(BasicCRUD basicCRUD) {
        frame = new JFrame("Add Product");
        frame.setLayout(new FlowLayout());

        idField = new JTextField(10);

        JButton addButton = new JButton("Remove Product");
        addButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String idString = idField.getText();
                int id = 0;
                try {
                    id = Integer.parseInt(idString);
                } catch (NumberFormatException er) {
                    // Handle invalid input for ID (e.g., non-numeric characters)
                    System.out.println("Invalid input for ID: " + idString);
                }

                if (basicCRUD.removeProduct(id)) {
                    JOptionPane.showMessageDialog(frame, "Product remove successfully!");
                }else{
                    JOptionPane.showMessageDialog(frame, "Product remove fall!");
                }
            }
        });

        frame.add(new JLabel("ID:"));
        frame.add(idField);
        frame.add(addButton);
        frame.setLocationRelativeTo(null);
        frame.pack();
        frame.setVisible(true);
    }

}
