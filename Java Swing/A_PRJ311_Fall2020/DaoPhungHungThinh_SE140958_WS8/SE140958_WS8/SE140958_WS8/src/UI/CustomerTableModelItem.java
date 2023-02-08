/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package UI;

import DAO.tblSupliers;
import DTO.Items;
import DTO.Suppliers;
import java.util.Vector;
import javax.swing.table.AbstractTableModel;

/**
 *
 * @author knc
 */
public class CustomerTableModelItem extends AbstractTableModel{
     private String[] headeres;
    private int[] indexes;
    private Vector<Items> data;
    tblSupliers dao = new tblSupliers();
    
    public void loadSuppliersComboBox(){
        try {
            dao.loadSuppliersComboBox();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
    
    public String getSuppliers(String supCode){
        for(String sup : dao.getListSuppliersComboBox()){
            if(sup.contains(supCode)){
                return sup;
            }
        }
        return "";
    }
    
    public Vector<Items> getList(){
        return data;
    }
    
    public CustomerTableModelItem(String[] headeres, int[] indexes){
        this.headeres = new String[headeres.length];
       for(int i=0; i<headeres.length ;i++){
            this.headeres[i] = headeres[i];
       }
       this.indexes = new int[indexes.length];
       for(int i=0; i<indexes.length ;i++){
            this.indexes[i] = indexes[i];       
    }
       data = new Vector<>();

    }

    @Override
    public String getColumnName(int column){
        if(column >=0 || column<headeres.length){
            return headeres[column];
        }else return "";
    }
    
    @Override
    public int getRowCount() {
        return data.size();
    }

    @Override
    public int getColumnCount() {
        return headeres.length;
    }

    @Override
    public Object getValueAt(int rowIndex, int columnIndex) {
        if(rowIndex < 0 || rowIndex >= data.size() || columnIndex <0 || columnIndex >= headeres.length){
            return null;
        }
        Items item = data.get(rowIndex);
        switch(indexes[columnIndex]){
            case 0: return item.getIteamCode();
            case 1: return item.getIteamName();
            case 2: return item.getUnit();
            case 3: return item.getPrice();
            case 4: return item.isSupplying();
            case 5: return getSuppliers(item.getSupCode());
            
        }
        return null;
    }

}
