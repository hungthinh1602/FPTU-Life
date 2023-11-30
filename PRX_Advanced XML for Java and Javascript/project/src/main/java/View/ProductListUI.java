package View;

import com.mycompany.project.BasicCRUD;
import com.mycompany.project.XMLtoPDF;
import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.event.ActionEvent;
import java.util.List;
import javax.swing.BoxLayout;
import javax.swing.JButton;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.xml.transform.stream.StreamSource;
import model.Product;
import com.mycompany.project.XQuerySearch;
import com.mycompany.project.XPathSearch;
import java.awt.Font;
import java.awt.event.ActionListener;
import javax.swing.InputVerifier;
import javax.swing.JComponent;
import javax.swing.JScrollPane;
import javax.swing.JTextField;

public class ProductListUI {

    public static void displayProductList(List<Product> productList, StreamSource xmlSource, String xmlFile, BasicCRUD basicCRUD) {
        // Create a new JFrame to hold the UI
        JFrame frame = new JFrame("Product List");

        // Create a new JPanel to hold the product labels
        JPanel productPanel = new JPanel();
        productPanel.setLayout(new BoxLayout(productPanel, BoxLayout.Y_AXIS));

        // Create a new JPanel to hold search part
        JPanel searchPanel = new JPanel();
        searchPanel.setLayout(new BoxLayout(searchPanel, BoxLayout.X_AXIS));

        // Create a new JPanel to hold button part
        JPanel buttonPanel = new JPanel();
        buttonPanel.setLayout(new BoxLayout(buttonPanel, BoxLayout.X_AXIS));

        // Create a JLabel
        JLabel label = new JLabel("Search Price:   ");
        // Add the JLabel to the JPanel
        searchPanel.add(label);

        // Create a JTextField
        JTextField textField = new JTextField(10); // Set preferred width of the input text field

        // Add the JTextField to the JPanel
        searchPanel.add(textField);

        // Create a JButton
        JButton button = new JButton("Xquery Search!");
// Add an ActionListener to the JButton
        button.addActionListener((ActionEvent e) -> {
            // Handle button click event

            String text = textField.getText();
            if (text.isEmpty()) {
                JOptionPane.showMessageDialog(null, "Please enter a search price!", "Error", JOptionPane.ERROR_MESSAGE);
                return;
            }

            try {
                double price = Double.parseDouble(text);
                if (price < 0) {
                    throw new NumberFormatException("Price must be a positive number");
                }

                String xqueryExpression = "for $product in //Product[Price = " + price + "] return $product";
                String searchResult = XQuerySearch.searchXML(xmlSource, xqueryExpression);
                JOptionPane.showMessageDialog(null, searchResult);
            } catch (NumberFormatException ex) {
                JOptionPane.showMessageDialog(null, "Invalid input: Price must be a valid positive number!", "Error", JOptionPane.ERROR_MESSAGE);
            }
        });
        searchPanel.add(button);

        // Create a JButton
        JButton xpathButton = new JButton("XPath Search!");
// Add an ActionListener to the JButton
        xpathButton.addActionListener((ActionEvent e) -> {
            // Handle button click event

            String text = textField.getText();
            if (text.isEmpty()) {
                JOptionPane.showMessageDialog(null, "Please enter a search price!", "Error", JOptionPane.ERROR_MESSAGE);
                return;
            }

            try {
                double price = Double.parseDouble(text);
                if (price < 0) {
                    throw new NumberFormatException("Price must be a positive number");
                }

                String xpathExpression = "//Product[Price = " + price + "]";
                String searchResult = XPathSearch.searchXML(xmlFile, xpathExpression);
                JOptionPane.showMessageDialog(null, searchResult);
            } catch (NumberFormatException ex) {
                JOptionPane.showMessageDialog(null, "Invalid input: Price must be a valid positive number!", "Error", JOptionPane.ERROR_MESSAGE);
            }
        });
// Add the JButton to the JFrame
        searchPanel.add(xpathButton);

        // Add a label for each product in the list
        for (Product product : productList) {
            JLabel productLabel = new JLabel(product.toString());
            productLabel.setFont(new Font(productLabel.getFont().getName(), Font.BOLD, 20));
            productPanel.add(productLabel);
        }
        // button table
        // Create a JButton
        JButton ShowButton = new JButton("Show");
        // Add an ActionListener to the JButton
        ShowButton.addActionListener((ActionEvent e) -> {
            // Handle button click event
            ProductTable productTable = new ProductTable(productList);
        });// Add the JButton to the JFrame
        buttonPanel.add(ShowButton);

        // Create a JButton
        JButton AddButton = new JButton("Add");
        // Add an ActionListener to the JButton
        AddButton.addActionListener((ActionEvent e) -> {
            // Handle button click event
            showAddProductScreen(basicCRUD);
        });// Add the JButton to the JFrame
        buttonPanel.add(AddButton);

        // Create a JButton
        JButton RemoveButton = new JButton("Remove");
        // Add an ActionListener to the JButton
        RemoveButton.addActionListener((ActionEvent e) -> {
            // Handle button click event
            showDeleteProductScreen(basicCRUD);
        });// Add the JButton to the JFrame
        buttonPanel.add(RemoveButton);

        // Create a JButton
        JButton UpdateButton = new JButton("Update");
        // Add an ActionListener to the JButton
        UpdateButton.addActionListener((ActionEvent e) -> {
            // Handle button click event
            showUpdateProductScreen(basicCRUD);
        });// Add the JButton to the JFrame
        buttonPanel.add(UpdateButton);

        JButton ExportButton = new JButton("Export");
        // Add an ActionListener to the JButton
        ExportButton.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                String xmlFilePath = "C:/Users/Quang Thanh/Documents/NetBeansProjects/project/src/main/java/Resource/Products.xml";
                try {
                    XMLtoPDF.generatePDF(xmlFilePath);
                } catch (Exception ex) {
                    ex.printStackTrace();
                    JOptionPane.showMessageDialog(null, "Error generating PDF file!");
                }
            }
        });
        buttonPanel.add(ExportButton);

        // Add the product panel to the center of the JFrame
        frame.add(searchPanel, BorderLayout.PAGE_START);
        frame.add(productPanel, BorderLayout.CENTER);
        frame.add(buttonPanel, BorderLayout.PAGE_END);

        // Set the size of the JFrame and display it
        JScrollPane scrollPane = new JScrollPane(productPanel);

        // Add the JScrollPane to the center of the JFrame
        frame.add(scrollPane, BorderLayout.CENTER);

        // Set the size of the JFrame and display it
        //    frame.setPreferredSize(new Dimension(800, 800));
        frame.setSize(800, 800);
        frame.setLocationRelativeTo(null);
        //   frame.pack();        
        productPanel.setLocation(300, 200);
        frame.setVisible(true);
    }

    public static void showAddProductScreen(BasicCRUD basicCRUD) {
        // Call the AddProduct dialog here
        AddProduct addProductDialog = new AddProduct(basicCRUD);
    }

    public static void showDeleteProductScreen(BasicCRUD basicCRUD) {
        // Call the AddProduct dialog here
        DeleteProduct deleteProductDialog = new DeleteProduct(basicCRUD);
    }

    public static void showUpdateProductScreen(BasicCRUD basicCRUD) {
        // Call the AddProduct dialog here
        UpdateProduct updateProductDialog = new UpdateProduct(basicCRUD);
    }

}
