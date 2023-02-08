/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package WS6;

import java.io.BufferedReader;
import java.io.DataOutputStream;
import java.io.InputStreamReader;
import java.net.Socket;
import javax.swing.JOptionPane;
import java.net.ServerSocket;

/**
 *
 * @author USER
 */
public class ClientChatter extends javax.swing.JFrame implements Runnable{ // extends ManagerChatter

    /**
     * Creates new form ClientChatter
     */
    Socket mngSocket =null;
    String mngIP="";
    int mngPort=0;
    String staffName="";
    BufferedReader bf = null;
    DataOutputStream os = null;
    
    int serverPort ;
    ServerSocket srvSocket = null;
    BufferedReader br =null;
    Thread th; 
    // Thread allows presenting received data automatically
    OutputThread t= null;
    public ClientChatter() {
        initComponents();
        Control.setSize(750,110);
        Contain.setSize(750,890);
        this.setSize(750,500);
        
        th = new Thread(this);
        th.start();
        
    }
    public void run(){
        try {
            srvSocket = new ServerSocket(serverPort);
            txtClientPort.setText(srvSocket.getLocalPort()+"");
            txtClientPort.setEditable(false);
        } catch (Exception e) {
            e.printStackTrace();
        }
        while (true){
            try {// wait for a client            
                Socket aStaffSocket = srvSocket.accept();
                if (aStaffSocket!=null){
                    // If there is a connection
                    //get staffname
                    // When a staff inits a connection, he/she sends his/ her name first
                    br = new BufferedReader(new InputStreamReader(aStaffSocket.getInputStream()));
                    String S = br.readLine();
                    int pos = S.indexOf(":"); // Format: Staff: Hoa
                    String staffName = S.substring(pos+1);// get name
                    //create a tab for this connection
                    ChatPanel p = new ChatPanel(aStaffSocket, "Manager", staffName);
                    Contain.add(staffName,p);
                    p.updateUI();
                }
                else JOptionPane.showMessageDialog(this, "Error!!");
                Thread.sleep(1000);
            }
            catch (Exception e){
                
            }
        }
    }
    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        Control = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        txtStaff = new javax.swing.JTextField();
        jLabel2 = new javax.swing.JLabel();
        txtServerIP = new javax.swing.JTextField();
        jLabel3 = new javax.swing.JLabel();
        txtServerPort = new javax.swing.JTextField();
        btnConnect = new javax.swing.JButton();
        jLabel4 = new javax.swing.JLabel();
        txtClientPort = new javax.swing.JTextField();
        Contain = new javax.swing.JTabbedPane();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        Control.setBorder(javax.swing.BorderFactory.createTitledBorder("Staff and Sever Info."));

        jLabel1.setText("Staff:");

        txtStaff.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtStaffActionPerformed(evt);
            }
        });

        jLabel2.setText("Mng IP:");

        jLabel3.setText("Port:");

        btnConnect.setText("Connect");
        btnConnect.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnConnectActionPerformed(evt);
            }
        });

        jLabel4.setText("ClientPort:");

        javax.swing.GroupLayout ControlLayout = new javax.swing.GroupLayout(Control);
        Control.setLayout(ControlLayout);
        ControlLayout.setHorizontalGroup(
            ControlLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(ControlLayout.createSequentialGroup()
                .addGap(2, 2, 2)
                .addComponent(jLabel1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(txtStaff, javax.swing.GroupLayout.PREFERRED_SIZE, 88, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(jLabel2, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(txtServerIP, javax.swing.GroupLayout.PREFERRED_SIZE, 88, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jLabel3, javax.swing.GroupLayout.PREFERRED_SIZE, 34, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(txtServerPort, javax.swing.GroupLayout.PREFERRED_SIZE, 88, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jLabel4)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(txtClientPort, javax.swing.GroupLayout.PREFERRED_SIZE, 79, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(btnConnect, javax.swing.GroupLayout.DEFAULT_SIZE, 75, Short.MAX_VALUE)
                .addContainerGap())
        );
        ControlLayout.setVerticalGroup(
            ControlLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(ControlLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 23, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addComponent(txtStaff, javax.swing.GroupLayout.PREFERRED_SIZE, 23, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addComponent(jLabel2, javax.swing.GroupLayout.PREFERRED_SIZE, 23, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addComponent(txtServerIP, javax.swing.GroupLayout.PREFERRED_SIZE, 23, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addComponent(jLabel3, javax.swing.GroupLayout.PREFERRED_SIZE, 23, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addComponent(txtServerPort, javax.swing.GroupLayout.PREFERRED_SIZE, 23, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addComponent(jLabel4)
                .addComponent(txtClientPort, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addComponent(btnConnect)
        );

        getContentPane().add(Control, java.awt.BorderLayout.PAGE_START);

        Contain.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(0, 0, 0)));
        getContentPane().add(Contain, java.awt.BorderLayout.CENTER);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnConnectActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnConnectActionPerformed
        // TODO add your handling code here:
        // kết nối với server
        mngIP = this.txtServerIP.getText();
        mngPort=Integer.parseInt("0"+this.txtServerPort.getText());
        staffName=this.txtStaff.getText();
        try {
            mngSocket =  new Socket(mngIP, mngPort);  // connect to server
           
           // System.out.println(mngSocket.getLocalPort());
            if (mngSocket!=null){ //If the connect is successfull
                ChatPanel p = new ChatPanel(mngSocket, staffName, "Manager");
                
                //this.getContentPane().add(p);
                p.setSize(550,500);
                Contain.add(staffName,p);
                p.getTxtMessages().append("Manager is running\n");
                p.updateUI();
                // get the socket input stream and output stream
                bf = new BufferedReader(new InputStreamReader(mngSocket.getInputStream()));
                os = new DataOutputStream(mngSocket.getOutputStream());
                // Annouce to manager
                os.writeBytes("Staff:"+staffName);
                os.write(13);
                os.write(10);
                os.flush();
            }
        }
        catch (Exception e){
            JOptionPane.showMessageDialog(this, "Manager is not running");
            System.exit(0);
        }
    }//GEN-LAST:event_btnConnectActionPerformed

    private void txtStaffActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtStaffActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtStaffActionPerformed

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
                if ("Window".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(ClientChatter.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(ClientChatter.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(ClientChatter.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(ClientChatter.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new ClientChatter().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JTabbedPane Contain;
    private javax.swing.JPanel Control;
    private javax.swing.JButton btnConnect;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JTextField txtClientPort;
    private javax.swing.JTextField txtServerIP;
    private javax.swing.JTextField txtServerPort;
    private javax.swing.JTextField txtStaff;
    // End of variables declaration//GEN-END:variables
}
