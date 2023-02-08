/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAO;

import DTO.Suppliers;
import UI.CustomerTableModelSuppliers;
import Ultis.DBUltis;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Vector;
import javax.swing.JOptionPane;

/**
 *
 * @author knc
 */
public class tblSupliers {
    
    private String[] headeres ={"SupCode","SupName","Address"};
    private int[] indexes ={0,1,2};
    private CustomerTableModelSuppliers modelSup = new CustomerTableModelSuppliers(headeres, indexes);
    private Vector<String> listSuppliersComboBox = new Vector();
    
    public tblSupliers(){
        try {
            loadData();
            loadSuppliersComboBox();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private void loadData() throws Exception {
        modelSup.getList().clear();
        Connection con=null;
        PreparedStatement ps = null;
        ResultSet rs = null;
        try {
            con = Ultis.DBUltis.openConnection();
            if(con != null){
                String sql = "SELECT * FROM Suppliers";
                ps = con.prepareStatement(sql);
                rs = ps.executeQuery();
                while(rs.next()){
                    Suppliers sup = new Suppliers(rs.getString("supCode"),rs.getString("supName")
                            ,rs.getString("addres"),rs.getBoolean("Colloborating"));
                    modelSup.getList().add(sup);
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        } finally{
            if(rs != null){
                rs.close();
            }
            if(ps != null){
                ps.close();
            }
            if(con != null){
                con.close();
            }
            
        }
    }
    
    public CustomerTableModelSuppliers getModelSup(){
        return modelSup;
    }

    public Vector<String> loadSuppliersComboBox() throws Exception{
          listSuppliersComboBox.clear();
          Connection con = null;
          PreparedStatement ps =null;
          ResultSet rs = null;
          try {
            con = DBUltis.openConnection();
            if(con != null){
                String sql = "SELECT SupCode, SupName FROM Suppliers";
                ps = con.prepareStatement(sql);
                rs = ps.executeQuery();
                while(rs.next()){
                    listSuppliersComboBox.add(rs.getString("SupCode")+"-"+ rs.getString("SupName"));
                }
                return listSuppliersComboBox;
            }
        } catch (Exception e) {
            e.printStackTrace();
        } finally{
            if(rs != null){
                rs.close();
            }
            if(ps != null){
                ps.close();
            }
            if(con != null){
                con.close();
            }
            
        }
        return null;
    }    
    
    public Vector<String> getListSuppliersComboBox(){
        return listSuppliersComboBox;
    }
    
    public String getSupNameComboBox(String supCode){
        for(Suppliers sup : modelSup.getList()){
            if(sup.getSupCode().compareToIgnoreCase(supCode)==0){
                return sup.getSupName();
            }
        }
        return "";
    }
    
    public int Insert(Suppliers sup) throws Exception{
        Connection con = null;
        PreparedStatement ps = null;
        try {
            con = DBUltis.openConnection();
            if(con != null){
                String sql = "Insert Suppliers values(?,?,?,?)";
                ps = con.prepareStatement(sql);
                ps.setString(1, sup.getSupCode());
                ps.setString(2, sup.getSupName());
                ps.setString(3, sup.getAddress());
                ps.setBoolean(4, sup.isColloborating());
                return ps.executeUpdate();
            }
        } catch (Exception e) {
            e.printStackTrace();
        }finally{
            if(ps != null){
                ps.close();
            }
            if(con != null){
                con.close();
            }
            
        }
        return -1;
    }
    
    public int Save(Suppliers sup) throws Exception{
        Connection con = null;
        PreparedStatement ps = null;
        try {
            con = DBUltis.openConnection();
            if(con != null){
                String sql = "UPDATE Suppliers SET supName=? , addres=?, Colloborating=? WHERE supCode =?";
                ps = con.prepareStatement(sql);
                ps.setString(1, sup.getSupName());
                ps.setString(2, sup.getAddress());
                ps.setBoolean(3, sup.isColloborating());
                ps.setString(4, sup.getSupCode());
                return ps.executeUpdate();
            }
        } catch (Exception e) {
            e.printStackTrace();
        }finally{
            if(ps != null){
                ps.close();
            }
            if(con != null){
                con.close();
            }
            
        }
        return -1;
    }

      public int Delete(Suppliers sup) throws Exception{
        Connection con = null;
        PreparedStatement ps = null;
        try {
            con = DBUltis.openConnection();
            if(con != null){
                String sql = "DELETE FROM dbo.Suppliers WHERE SupCode =?";
                ps = con.prepareStatement(sql);
                ps.setString(1, sup.getSupCode());
                return ps.executeUpdate();
            }
        } catch (Exception e) {
            e.printStackTrace();
        }finally{
            if(ps != null){
                ps.close();
            }
            if(con != null){
                con.close();
            }
            
        }
        return -1;
    }
      
    public boolean validDateCodeSupplier(String supCode){
        try {
            for(int i=0;i<modelSup.getList().size();i++){
                if(modelSup.getList().get(i).getSupCode().compareToIgnoreCase(supCode)==0){
                    return false;
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
        return true;
    }
    
    public boolean validDate(String supCode, String supName,String address){
        if(supCode.isEmpty() || supCode.length()>20){
            JOptionPane.showMessageDialog(null, "Invaid Code Supplier");
            return false;
        }
        if(supName.isEmpty() || supName.length()>50){
            JOptionPane.showMessageDialog(null, "Invaid Name Supplier");
            return false;
        }
        if(address.isEmpty() || address.length()>30){
            JOptionPane.showMessageDialog(null, "Invaid Address");
            return false;
        }
        return true;
    }
        
}
