/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.project;


import net.sf.saxon.s9api.Processor;
import net.sf.saxon.s9api.XQueryCompiler;
import net.sf.saxon.s9api.XQueryEvaluator;
import net.sf.saxon.s9api.XQueryExecutable;
import net.sf.saxon.s9api.XdmValue;

import javax.xml.transform.stream.StreamSource;

public class XQuerySearch {
    public static String searchXML(StreamSource xmlStreamSource, String xqueryExpression) {
        try {
            // Create a Saxon Processor
            Processor processor = new Processor(false);

            // Create a XQueryCompiler
            XQueryCompiler xqueryCompiler = processor.newXQueryCompiler();

            // Compile the XQuery expression
            XQueryExecutable xqueryExecutable = xqueryCompiler.compile(xqueryExpression);

            // Create a XQueryEvaluator
            XQueryEvaluator xqueryEvaluator = xqueryExecutable.load();

            // Set the context item to the XML stream source
            xqueryEvaluator.setContextItem(processor.newDocumentBuilder().build(xmlStreamSource));

            // Evaluate the XQuery expression and get the results
            XdmValue result = xqueryEvaluator.evaluate();

            // Print the results
            return ("Results of XQuery search :\n" + result.toString());

        } catch (Exception e) {
            e.printStackTrace();
        }
        return "NUll";
    }
}