/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DTO;

/**
 *
 * @author knc
 */
public class Items {
    private String iteamCode;
    private String iteamName;
    private String unit;
    private float  price;
    private boolean supplying;
    private String supCode;

    public Items() {
    }

    public Items(String iteamCode, String iteamName, String unit, float price, boolean supplying, String supCode) {
        this.iteamCode = iteamCode;
        this.iteamName = iteamName;
        this.unit = unit;
        this.price = price;
        this.supplying = supplying;
        this.supCode = supCode;
    }

    public String getIteamCode() {
        return iteamCode;
    }

    public void setIteamCode(String iteamCode) {
        this.iteamCode = iteamCode;
    }

    public String getIteamName() {
        return iteamName;
    }

    public void setIteamName(String iteamName) {
        this.iteamName = iteamName;
    }

    public String getUnit() {
        return unit;
    }

    public void setUnit(String unit) {
        this.unit = unit;
    }

    public float getPrice() {
        return price;
    }

    public void setPrice(float price) {
        this.price = price;
    }

    public boolean isSupplying() {
        return supplying;
    }

    public void setSupplying(boolean supplying) {
        this.supplying = supplying;
    }

    public String getSupCode() {
        return supCode;
    }

    public void setSupCode(String supCode) {
        this.supCode = supCode;
    }
    
    
    
}
