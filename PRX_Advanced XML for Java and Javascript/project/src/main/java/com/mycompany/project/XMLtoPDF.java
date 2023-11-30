/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.project;

/**
 *
 * @author Quang Thanh
 */
import java.io.FileOutputStream;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import com.itextpdf.text.Document;
import com.itextpdf.text.DocumentException;
import com.itextpdf.text.Paragraph;
import com.itextpdf.text.pdf.PdfWriter;
import java.awt.Desktop;
import java.io.File;
import java.io.FileNotFoundException;
import javax.swing.JOptionPane;
import org.w3c.dom.NodeList;
import org.w3c.dom.Node;

import com.itextpdf.text.Document;
import com.itextpdf.text.DocumentException;
import com.itextpdf.text.Element;
import com.itextpdf.text.PageSize;
import com.itextpdf.text.Phrase;
import com.itextpdf.text.pdf.PdfPCell;
import com.itextpdf.text.pdf.PdfPTable;
import com.itextpdf.text.pdf.PdfWriter;

import java.io.File;
import java.io.FileOutputStream;
import javax.swing.JOptionPane;

public class XMLtoPDF {
    public static void generatePDF(String xmlFilePath) throws FileNotFoundException, DocumentException {
        try {
            // Đọc tệp XML
            DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
            DocumentBuilder builder = factory.newDocumentBuilder();
            org.w3c.dom.Document documentXml = builder.parse("C:/Users/Quang Thanh/Documents/NetBeansProjects/project/src/main/java/Resource/Products.xml");
            NodeList nodeList = documentXml.getElementsByTagName("Product");

            // Tạo đối tượng Document và thiết lập kích thước trang A4
            Document documentPdf = new Document(PageSize.A4);

            // Tạo tệp PDF mới với PdfWriter
            PdfWriter.getInstance(documentPdf, new FileOutputStream("C:/Users/Quang Thanh/Documents/NetBeansProjects/project/FilePDF.pdf"));

            // Mở tài liệu
            documentPdf.open();

            // Tạo bảng và thiết lập các thông số cho bảng
            PdfPTable table = new PdfPTable(3);
            table.setWidthPercentage(100);
            table.setSpacingBefore(10f);
            table.setSpacingAfter(10f);

            // Thêm tiêu đề cho bảng
            PdfPCell cell1 = new PdfPCell(new Phrase("Product ID"));
            cell1.setHorizontalAlignment(Element.ALIGN_CENTER);
            table.addCell(cell1);

            PdfPCell cell2 = new PdfPCell(new Phrase("Product Name"));
            cell2.setHorizontalAlignment(Element.ALIGN_CENTER);
            table.addCell(cell2);

            PdfPCell cell3 = new PdfPCell(new Phrase("Price"));
            cell3.setHorizontalAlignment(Element.ALIGN_CENTER);
            table.addCell(cell3);

            // Thêm nội dung vào bảng từ nội dung của tệp XML
            for (int i = 0; i < nodeList.getLength(); i++) {
                Node node = nodeList.item(i);
                Element element = (Element) node;
                 String text = node.getTextContent();
                documentPdf.add(new Paragraph(text));
            }

            // Thêm bảng vào tài liệu PDF
            documentPdf.add(table);

            // Đóng tài liệu
            documentPdf.close();
            JOptionPane.showMessageDialog(null, "PDF file generated successfully!");
            Desktop.getDesktop().open(new File("C:/Users/Quang Thanh/Documents/NetBeansProjects/project/FilePDF.pdf").getParentFile());
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
