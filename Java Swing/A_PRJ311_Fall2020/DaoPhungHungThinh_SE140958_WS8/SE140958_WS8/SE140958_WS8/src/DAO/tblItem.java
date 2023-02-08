/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAO;

import DTO.Items;
import DTO.Suppliers;
import UI.CustomerTableModelItem;
import UI.CustomerTableModelSuppliers;
import Ultis.DBUltis;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.StringTokenizer;
import java.util.Vector;
import javax.swing.JOptionPane;

/**
 *
 * @author knc
 */
public class tblItem {
    private String[] headeres = {"itemCode","itemName","Suppliers","Unit","Price","Suppying"};
    private int[] indexes ={0,1,2,3,4,5};
    private CustomerTableModelItem modelItem = new CustomerTableModelItem(headeres,indexes);

    public CustomerTableModelItem getModelItem(){
        return modelItem;
    }
    
    public tblItem(){
        try {
            loadData();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private void loadData() throws SQLException {
        modelItem.getList().clear();
        Connection con=null;
        PreparedStatement ps = null;
        ResultSet rs = null;
        try {
            con = Ultis.DBUltis.openConnection();
            if(con != null){
                String sql = "SELECT * FROM Items";
                ps = con.prepareStatement(sql);
                rs = ps.executeQuery();
                while(rs.next()){
                    Items it = new Items(rs.getString("ItemCode"), rs.getString("ItemName")
                            , rs.getString("Unit"), rs.getFloat("Price"), rs.getBoolean("Supplying"),rs.getString("SupCode"));
                    
                    modelItem.getList().add(it);
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
    
    public String loadSupCodeIntoItems(String Suppliers){
        StringTokenizer stk = new StringTokenizer(Suppliers, "-");
        return stk.nextToken();
    }
    
    public int Insert(Items it) throws Exception{
        Connection con = null;
        PreparedStatement ps = null;
        try {
            con = DBUltis.openConnection();
            if(con != null){
                String sql = "Insert Items values(?,?,?,?,?,?)";
                StringTokenizer stk = new StringTokenizer(it.getSupCode(),"-");
                
                ps = con.prepareStatement(sql);
                ps.setString(1, it.getIteamCode());
                ps.setString(2, it.getIteamName());
                ps.setString(3, it.getUnit());
                ps.setFloat(4, it.getPrice());
                ps.setBoolean(5, it.isSupplying());
                ps.setString(6, stk.nextToken());
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
    
    public int Save(Items it) throws Exception{
        Connection con = null;
        PreparedStatement ps = null;
        try {
            con = DBUltis.openConnection();
            if(con != null){
                String sql = "UPDATE Items SET ItemName=? , Unit=?, Price=?,"
                        + "Supplying =?,SupCode=? WHERE ItemCode =?";
                ps = con.prepareStatement(sql);
                ps.setString(1, it.getIteamName());
                ps.setString(2, it.getUnit());
                ps.setFloat(3, it.getPrice());
                ps.setBoolean(4, it.isSupplying());
                ps.setString(5, it.getSupCode());
                ps.setString(6, it.getIteamCode());
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

      public int Delete(Items it) throws Exception{
        Connection con = null;
        PreparedStatement ps = null;
        try {
            con = DBUltis.openConnection();
            if(con != null){
                String sql = "DELETE FROM Items WHERE ItemCode =?";
                ps = con.prepareStatement(sql);
                ps.setString(1, it.getIteamCode());
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
      
    public boolean validDateCodeItem(String itemCode){
        try {
            for(int i=0;i<modelItem.getList().size();i++){
                if(modelItem.getList().get(i).getSupCode().compareToIgnoreCase(itemCode)==0){
                    return false;
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
        return true;
    }
    
    public boolean validDate(String itemCode, String itemName,String unit,String price, Object supCode){
        if(!itemCode.toUpperCase().matches("E\\d{4}")){
            JOptionPane.showMessageDialog(null, "Invaid Items Code");
            return false;
        }
        if(itemName.isEmpty() || itemName.length()>50){
            JOptionPane.showMessageDialog(null, "Invaid Items Name");
            return false;
        }
        if(unit.isEmpty() || unit.length()>10){
            JOptionPane.showMessageDialog(null, "Invaid Items Unit");
            return false;
        }
        if(!price.matches("\\d+.?\\d*")){
            JOptionPane.showMessageDialog(null, "Invalid Items Price");
            return false;
        }
        if(supCode== null){
            JOptionPane.showMessageDialog(null, "Choose the SupCode");
            return false;
        }
        return true;
    }
    
    public boolean checkconstraintSupCode(String supCode){
        for(int i=0;i<modelItem.getList().size();i++){
            if(supCode.compareToIgnoreCase(modelItem.getList().get(i).getSupCode())==0){
                return false;
            }
    }
        return true;
    }
}
