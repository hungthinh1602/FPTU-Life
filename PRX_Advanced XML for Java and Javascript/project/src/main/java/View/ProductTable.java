/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package View;


import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.awt.*;
import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;
import model.Product;

public class ProductTable extends JFrame {
    private final JTable table;
    private final DefaultTableModel model;
    private List<Product> productList;

    public ProductTable(List<Product> list) {
        productList =list;

        // Create table model
        model = new DefaultTableModel(new Object[][]{}, new String[]{"ID", "Name", "Price", "Created Date"});

        // Create table
        table = new JTable(model);
        JScrollPane scrollPane = new JScrollPane(table);
        getContentPane().add(scrollPane, BorderLayout.CENTER);

        // Add products to the table
        for (Product product : productList) {
            addProductToTable(product);
        }

       
        setSize(800, 800);
        setVisible(true);
        setLocationRelativeTo(null);
    }

    // Method to add a product to the table
    private void addProductToTable(Product product) {
        model.addRow(new Object[]{product.getId(), product.getName(), product.getPrice(), product.getCreatedDate()});
    }

    // Method to update the table when the productList changes
    private void updateTable() {
        model.setRowCount(0); // Clear the table

        // Add products from the updated productList
        for (Product product : productList) {
            addProductToTable(product);
        }
    }

    // Method to update the productList
    public void updateProductList(List<Product> updatedProductList) {
        productList = updatedProductList;
        updateTable(); // Update the table
    }
}
