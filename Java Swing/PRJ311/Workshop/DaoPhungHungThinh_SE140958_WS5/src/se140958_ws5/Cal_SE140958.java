/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package se140958_ws5;

/**
 *
 * @author knc
 */
public class Cal_SE140958 extends javax.swing.JFrame {

    String phep = null;
    int Total = 0;
    int Component = 0;
    

    /**
     * Creates new form Cal_SE140958
     */
    public Cal_SE140958() {
        initComponents();
        txtCal.setEnabled(false);
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel2 = new javax.swing.JPanel();
        txtCal = new javax.swing.JTextField();
        jPanel1 = new javax.swing.JPanel();
        btn1 = new javax.swing.JButton();
        btn2 = new javax.swing.JButton();
        btn3 = new javax.swing.JButton();
        btnCong = new javax.swing.JButton();
        btn4 = new javax.swing.JButton();
        btn5 = new javax.swing.JButton();
        btn6 = new javax.swing.JButton();
        btnTru = new javax.swing.JButton();
        btn7 = new javax.swing.JButton();
        btn8 = new javax.swing.JButton();
        btn9 = new javax.swing.JButton();
        btnNhan = new javax.swing.JButton();
        btnAC = new javax.swing.JButton();
        btn0 = new javax.swing.JButton();
        btnChia = new javax.swing.JButton();
        btnBang = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        txtCal.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtCalActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(txtCal)
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(txtCal, javax.swing.GroupLayout.DEFAULT_SIZE, 54, Short.MAX_VALUE)
        );

        jPanel1.setLayout(new java.awt.GridLayout(4, 4, 1, 0));

        btn1.setFont(new java.awt.Font("Tahoma", 0, 24)); // NOI18N
        btn1.setText("1");
        btn1.setPreferredSize(new java.awt.Dimension(50, 40));
        btn1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn1ActionPerformed(evt);
            }
        });
        jPanel1.add(btn1);

        btn2.setFont(new java.awt.Font("Tahoma", 0, 24)); // NOI18N
        btn2.setText("2");
        btn2.setPreferredSize(new java.awt.Dimension(50, 40));
        btn2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn2ActionPerformed(evt);
            }
        });
        jPanel1.add(btn2);

        btn3.setFont(new java.awt.Font("Tahoma", 0, 24)); // NOI18N
        btn3.setText("3");
        btn3.setPreferredSize(new java.awt.Dimension(50, 40));
        btn3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn3ActionPerformed(evt);
            }
        });
        jPanel1.add(btn3);

        btnCong.setFont(new java.awt.Font("Tahoma", 0, 24)); // NOI18N
        btnCong.setText("+");
        btnCong.setPreferredSize(new java.awt.Dimension(50, 40));
        btnCong.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCongActionPerformed(evt);
            }
        });
        jPanel1.add(btnCong);

        btn4.setFont(new java.awt.Font("Tahoma", 0, 24)); // NOI18N
        btn4.setText("4");
        btn4.setPreferredSize(new java.awt.Dimension(50, 40));
        btn4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn4ActionPerformed(evt);
            }
        });
        jPanel1.add(btn4);

        btn5.setFont(new java.awt.Font("Tahoma", 0, 24)); // NOI18N
        btn5.setText("5");
        btn5.setPreferredSize(new java.awt.Dimension(50, 40));
        btn5.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn5ActionPerformed(evt);
            }
        });
        jPanel1.add(btn5);

        btn6.setFont(new java.awt.Font("Tahoma", 0, 24)); // NOI18N
        btn6.setText("6");
        btn6.setPreferredSize(new java.awt.Dimension(50, 40));
        btn6.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn6ActionPerformed(evt);
            }
        });
        jPanel1.add(btn6);

        btnTru.setFont(new java.awt.Font("Tahoma", 0, 24)); // NOI18N
        btnTru.setText("-");
        btnTru.setPreferredSize(new java.awt.Dimension(50, 40));
        btnTru.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnTruActionPerformed(evt);
            }
        });
        jPanel1.add(btnTru);

        btn7.setFont(new java.awt.Font("Tahoma", 0, 24)); // NOI18N
        btn7.setText("7");
        btn7.setPreferredSize(new java.awt.Dimension(50, 40));
        btn7.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn7ActionPerformed(evt);
            }
        });
        jPanel1.add(btn7);

        btn8.setFont(new java.awt.Font("Tahoma", 0, 24)); // NOI18N
        btn8.setText("8");
        btn8.setPreferredSize(new java.awt.Dimension(50, 40));
        btn8.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn8ActionPerformed(evt);
            }
        });
        jPanel1.add(btn8);

        btn9.setFont(new java.awt.Font("Tahoma", 0, 24)); // NOI18N
        btn9.setText("9");
        btn9.setPreferredSize(new java.awt.Dimension(50, 40));
        btn9.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn9ActionPerformed(evt);
            }
        });
        jPanel1.add(btn9);

        btnNhan.setFont(new java.awt.Font("Tahoma", 0, 24)); // NOI18N
        btnNhan.setText("*");
        btnNhan.setPreferredSize(new java.awt.Dimension(50, 40));
        btnNhan.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnNhanActionPerformed(evt);
            }
        });
        jPanel1.add(btnNhan);

        btnAC.setFont(new java.awt.Font("Tahoma", 0, 24)); // NOI18N
        btnAC.setText("AC");
        btnAC.setPreferredSize(new java.awt.Dimension(50, 40));
        btnAC.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnACActionPerformed(evt);
            }
        });
        jPanel1.add(btnAC);

        btn0.setFont(new java.awt.Font("Tahoma", 0, 24)); // NOI18N
        btn0.setText("0");
        btn0.setPreferredSize(new java.awt.Dimension(50, 40));
        btn0.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn0ActionPerformed(evt);
            }
        });
        jPanel1.add(btn0);

        btnChia.setFont(new java.awt.Font("Tahoma", 0, 24)); // NOI18N
        btnChia.setText("/");
        btnChia.setPreferredSize(new java.awt.Dimension(50, 40));
        btnChia.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnChiaActionPerformed(evt);
            }
        });
        jPanel1.add(btnChia);

        btnBang.setFont(new java.awt.Font("Tahoma", 0, 24)); // NOI18N
        btnBang.setText("=");
        btnBang.setPreferredSize(new java.awt.Dimension(50, 40));
        btnBang.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnBangActionPerformed(evt);
            }
        });
        jPanel1.add(btnBang);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, 436, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, 263, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void txtCalActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtCalActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtCalActionPerformed

    private void btn1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn1ActionPerformed
        String Number = (txtCal.getText().trim());
        if (Number.isEmpty()) {
            txtCal.setText(Number + 1 + "");
        } else if (!(Number.equals("+") || Number.equals("-") || Number.equals("/") || Number.equals("*"))) {
            txtCal.setText(Number + 1 + "");
        }
        Component = Integer.parseInt(txtCal.getText().trim());
    }//GEN-LAST:event_btn1ActionPerformed

    private void btn2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn2ActionPerformed
        String Number = (txtCal.getText().trim());
        if (Number.isEmpty()) {
            txtCal.setText(Number + 2 + "");
        } else if (!(Number.equals("+") || Number.equals("-") || Number.equals("/") || Number.equals("*"))) {
            txtCal.setText(Number + 2 + "");
        }
        Component = Integer.parseInt(txtCal.getText().trim());        // TODO add your handling code here:
    }//GEN-LAST:event_btn2ActionPerformed

    private void btn3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn3ActionPerformed
        String Number = (txtCal.getText().trim());
        if (Number.isEmpty()) {
            txtCal.setText(Number + 3 + "");
        } else if (!(Number.equals("+") || Number.equals("-") || Number.equals("/") || Number.equals("*"))) {
            txtCal.setText(Number + 3 + "");
        }
        Component = Integer.parseInt(txtCal.getText().trim());        // TODO add your handling code here:
    }//GEN-LAST:event_btn3ActionPerformed

    private void btn4ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn4ActionPerformed
        String Number = (txtCal.getText().trim());
        if (Number.isEmpty()) {
            txtCal.setText(Number + 4 + "");
        } else if (!(Number.equals("+") || Number.equals("-") || Number.equals("/") || Number.equals("*"))) {
            txtCal.setText(Number + 4 + "");
        }
        Component = Integer.parseInt(txtCal.getText().trim());        // TODO add your handling code here:
    }//GEN-LAST:event_btn4ActionPerformed

    private void btn5ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn5ActionPerformed
        String Number = (txtCal.getText().trim());
        if (Number.isEmpty()) {
            txtCal.setText(Number + 5 + "");
        } else if (!(Number.equals("+") || Number.equals("-") || Number.equals("/") || Number.equals("*"))) {
            txtCal.setText(Number + 5 + "");
        }
        Component = Integer.parseInt(txtCal.getText().trim());        // TODO add your handling code here:
    }//GEN-LAST:event_btn5ActionPerformed

    private void btn6ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn6ActionPerformed
        String Number = (txtCal.getText().trim());
        if (Number.isEmpty()) {
            txtCal.setText(Number + 6 + "");
        } else if (!(Number.equals("+") || Number.equals("-") || Number.equals("/") || Number.equals("*"))) {
            txtCal.setText(Number + 6 + "");
        }
        Component = Integer.parseInt(txtCal.getText().trim());        // TODO add your handling code here:
    }//GEN-LAST:event_btn6ActionPerformed

    private void btn7ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn7ActionPerformed
        String Number = (txtCal.getText().trim());
        if (Number.isEmpty()) {
            txtCal.setText(Number + 7 + "");
        } else if (!(Number.equals("+") || Number.equals("-") || Number.equals("/") || Number.equals("*"))) {
            txtCal.setText(Number + 7 + "");
        }
        Component = Integer.parseInt(txtCal.getText().trim());        // TODO add your handling code here:
    }//GEN-LAST:event_btn7ActionPerformed

    private void btn8ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn8ActionPerformed
        String Number = (txtCal.getText().trim());
        if (Number.isEmpty()) {
            txtCal.setText(Number + 8 + "");
        } else if (!(Number.equals("+") || Number.equals("-") || Number.equals("/") || Number.equals("*"))) {
            txtCal.setText(Number + 8 + "");
        }
        Component = Integer.parseInt(txtCal.getText().trim());// TODO add your handling code here:
    }//GEN-LAST:event_btn8ActionPerformed

    private void btn9ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn9ActionPerformed
        String Number = (txtCal.getText().trim());
        if (Number.isEmpty()) {
            txtCal.setText(Number + 9 + "");
        } else if (!(Number.equals("+") || Number.equals("-") || Number.equals("/") || Number.equals("*"))) {
            txtCal.setText(Number + 9 + "");
        }
        Component = Integer.parseInt(txtCal.getText().trim());// TODO add your handling code here:
    }//GEN-LAST:event_btn9ActionPerformed

    private void btn0ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn0ActionPerformed
        String Number = (txtCal.getText().trim());
        if (Number.isEmpty()) {
            txtCal.setText(Number + 0 + "");
        } else if (!(Number.equals("+") || Number.equals("-") || Number.equals("/") || Number.equals("*"))) {
            txtCal.setText(Number + 0 + "");
        }
        Component = Integer.parseInt(txtCal.getText().trim());// TODO add your handling code here:
    }//GEN-LAST:event_btn0ActionPerformed

    private void btnCongActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCongActionPerformed
        phep = "+";
        Total=Integer.parseInt(txtCal.getText());
        txtCal.setText("");
        
    }//GEN-LAST:event_btnCongActionPerformed

    private void btnTruActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnTruActionPerformed
        phep = "-";
        Total=Integer.parseInt(txtCal.getText());
        txtCal.setText("");
    }//GEN-LAST:event_btnTruActionPerformed

    private void btnNhanActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnNhanActionPerformed
        phep = "*";
        Total=Integer.parseInt(txtCal.getText());
        txtCal.setText("");        // TODO add your handling code here:
    }//GEN-LAST:event_btnNhanActionPerformed

    private void btnChiaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnChiaActionPerformed
        phep = "/";
        Total=Integer.parseInt(txtCal.getText());
        txtCal.setText("");        // TODO add your handling code here:
    }//GEN-LAST:event_btnChiaActionPerformed

    private void btnBangActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnBangActionPerformed
        if (phep.equals("+")){
            Total+=Component;
        }
        if (phep.equals("-")){
            Total-=Component;
        }
        if (phep.equals("/")){
            Total/=Component;
        }
        if (phep.equals("*")){
            Total*=Component;
        }
        txtCal.setText(Total+"");
        Component=0;
    }//GEN-LAST:event_btnBangActionPerformed

    private void btnACActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnACActionPerformed
        txtCal.setText("");
        // TODO add your handling code here:
    }//GEN-LAST:event_btnACActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(Cal_SE140958.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Cal_SE140958.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Cal_SE140958.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Cal_SE140958.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Cal_SE140958().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btn0;
    private javax.swing.JButton btn1;
    private javax.swing.JButton btn2;
    private javax.swing.JButton btn3;
    private javax.swing.JButton btn4;
    private javax.swing.JButton btn5;
    private javax.swing.JButton btn6;
    private javax.swing.JButton btn7;
    private javax.swing.JButton btn8;
    private javax.swing.JButton btn9;
    private javax.swing.JButton btnAC;
    private javax.swing.JButton btnBang;
    private javax.swing.JButton btnChia;
    private javax.swing.JButton btnCong;
    private javax.swing.JButton btnNhan;
    private javax.swing.JButton btnTru;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JTextField txtCal;
    // End of variables declaration//GEN-END:variables
}
