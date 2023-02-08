/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package wordshop45;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Container;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.Panel;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.PrintWriter;
import java.util.Enumeration;
import java.util.StringTokenizer;
import javax.swing.BorderFactory;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.JTree;
import javax.swing.text.JTextComponent;
import javax.swing.tree.DefaultMutableTreeNode;
import javax.swing.tree.DefaultTreeModel;
import javax.swing.tree.TreePath;

/**
 *
 * @author USER
 */
public class workshop45 extends JFrame {

    JPanel FullJFrame;

    JPanel PRIGHT;
    JPanel PLEFT;

    JTree Tree;
    JButton btnSaveFile;

    JPanel DepPanel;
    JPanel DepCP;
    JPanel DepNP;
    JPanel DepBtnP;
    JPanel EmpCP;
    JPanel EmpNP;
    JPanel EmpSP;
    JPanel EmpBtnP;

    JLabel CodeD;
    JLabel NameD;
    JButton btnNewD;
    JButton btnSaveD;
    JButton btnRemoveD;
    JTextField txtCodeD;
    JTextField txtNameD;

    JPanel EmpPanel;
    JPanel EmpN;
    JPanel EmpS;
    JLabel CodeE;
    JLabel NameE;
    JLabel Salary;
    JButton btnNewE;
    JButton btnSaveE;
    JButton btnRemoveE;
    JTextField txtCodeE;
    JTextField txtNameE;
    JTextField txtSalaryE;

    String fileName = "departments.txt";
    DefaultMutableTreeNode root;
    DefaultMutableTreeNode deptNode;
    DefaultMutableTreeNode empNode;
    boolean addNewDep = false;
    boolean addNewEmp = false;

    public workshop45() {
        initComponents();
        root = (DefaultMutableTreeNode) Tree.getModel().getRoot();
        loadData();
        TreePath path = new TreePath(root);
        Tree.expandPath(path);
    }

    public void loadData() {
        try {
            File f = new File(fileName);
            if (!f.exists()) {
                return;
            }
            FileReader fr = new FileReader(f);
            BufferedReader br = new BufferedReader(fr);
            String line = "";
            while ((line = br.readLine()) != null) {
                boolean isDept = line.charAt(line.length() - 1) == ':';
                StringTokenizer stk = new StringTokenizer(line, ":,-");
                String code = stk.nextToken().trim();
                String name = stk.nextToken().trim();
                if (isDept) {
                    // create new department node
                    Department newDept = new Department(code, name);
                    deptNode = new DefaultMutableTreeNode(newDept);
                    root.add(deptNode);
                } else {
                    // create new employee node
                    String salary = stk.nextToken().trim();
                    Employee newEmp = new Employee(code, name, salary);
                    empNode = new DefaultMutableTreeNode(newEmp);
                    deptNode.add(empNode);
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private void viewDeptAndEmp() {
        Department curDep = null;
        Employee curEmp = null;
        if (deptNode != null) {
            curDep = (Department) (deptNode.getUserObject());
        }
        if (empNode != null) {
            curEmp = (Employee) (empNode.getUserObject());
        }
        this.txtCodeD.setText(curDep != null ? curDep.getCode() : "");
        this.txtNameD.setText(curDep != null ? curDep.getName() : "");
        this.txtCodeE.setText(curEmp != null ? curEmp.getCode() : "");
        this.txtNameE.setText(curEmp != null ? curEmp.getName() : "");
        this.txtSalaryE.setText("" + (curEmp != null ? curEmp.getSalary() : ""));
        this.txtCodeD.setEditable(false);
        this.txtCodeE.setEditable(false);
    }

    private void TreeMouseClicked(java.awt.event.MouseEvent evt) {
        // turn of the on-tree editting mode
        Tree.cancelEditing();

        // Get the clicked node at the last component of the path
        TreePath path = Tree.getSelectionPath();
        if (path == null) {
            return;
        }
        DefaultMutableTreeNode selectedNode = null;
        selectedNode = (DefaultMutableTreeNode) (path.getLastPathComponent());
        // Get the selected object in the model
        Object selectedObj = selectedNode.getUserObject();
        // Checking what is the selected object
        if (selectedNode == root) {
            this.deptNode = this.empNode = null;
        } else {
            if (selectedObj instanceof Department) {
                this.deptNode = selectedNode;
                this.empNode = null;
            } else if (selectedObj instanceof Employee) {
                empNode = selectedNode;
                deptNode = (DefaultMutableTreeNode) (selectedNode.getParent());
            }
        }

        viewDeptAndEmp();
    }

    private void btnDepNewActionPerformed(java.awt.event.ActionEvent evt) {
        // Make the GUI ready for a new department detals entered
        this.addNewDep = true;
        this.txtCodeD.setText("");
        this.txtNameD.setText("");
        this.txtCodeE.setText("");
        this.txtNameE.setText("");
        this.txtSalaryE.setText("");
        this.txtCodeD.setEditable(true);
        this.txtCodeD.requestFocus();

    }

    private void btnDepRemoveActionPerformed(java.awt.event.ActionEvent evt) {
        //Removing a department
        if (this.deptNode.getChildCount() > 0) {
            String msg = " Remove all employees before deleting a department.";
            JOptionPane.showMessageDialog(this, msg);
        } else {
            int response = JOptionPane.showConfirmDialog(this, "Delete this department - OK ?");
            if (response == JOptionPane.OK_OPTION) {
                root.remove(this.deptNode);
                Tree.updateUI();
            }
        }
    }

    private void btnEmpNewActionPerformed(java.awt.event.ActionEvent evt) {
        // Make the GUI ready for a new employee details entered
        this.addNewEmp = true;
        this.txtCodeE.setText("");
        this.txtNameE.setText("");
        this.txtSalaryE.setText("");
        this.txtCodeE.setEditable(true);
        this.txtCodeE.requestFocus();
    }

    private void btnEmpRemoveActionPerformed(java.awt.event.ActionEvent evt) {
        //Removing an employee
        if (this.empNode != null) {
            int response = JOptionPane.showConfirmDialog(this, " Delete this employee- OK?");
            if (response == JOptionPane.OK_OPTION) {
                deptNode.remove(this.empNode);
                Tree.updateUI();
            }
        }
    }

    private boolean validEmpDetails() {
        String s = "";
        if (addNewEmp == true) {
            s = txtCodeE.getText().trim().toUpperCase();
            txtCodeE.setText(s);
            if (!s.matches("(E)\\d{3}")) // checking code format
            {
                JOptionPane.showMessageDialog(this, "Code format: E000");
                return false;
            }

        }
        // checking the name
        s = txtNameE.getText().trim();
        if (s.length() == 0) {
            JOptionPane.showMessageDialog(this, "Name is required");
            return false;
        }
        // checking the salary
        s = txtSalaryE.getText().trim();
        if (!s.matches("^\\d+$")) {
            JOptionPane.showMessageDialog(this, "Salary is an integer.");
            return false;
        }
        return true;

    }

    private void btnEmpSaveActionPerformed(java.awt.event.ActionEvent evt) {
        // Save/update new employee/ employee details
        String code = this.txtCodeE.getText().trim().toUpperCase();
        txtCodeE.setText(code);
        String name = this.txtNameE.getText().trim();
        txtNameE.setText(name);
        String salary = this.txtSalaryE.getText().trim();
        txtSalaryE.setText(salary);

        if (!validEmpDetails()) {
            return;
        }
        if (addNewEmp == true) {
            Employee newEmp = new Employee(code, name, salary);
            deptNode.add(new DefaultMutableTreeNode(newEmp));
        } else {
            Employee emp = (Employee) (empNode.getUserObject());
            emp.setName(name);
            emp.setSalary(salary);
        }
        this.Tree.updateUI();
        this.addNewEmp = false;
    }

    private void btnSaveFileActionPerformed(java.awt.event.ActionEvent evt) {
//Saving details to the file
        if (root.getChildCount() == 0) {
            return;
        }
        String S;
        try {
            FileWriter f = new FileWriter(fileName);
            PrintWriter pf = new PrintWriter(f);
            Enumeration depts = root.children(); // get departments
            while (depts.hasMoreElements()) {
                DefaultMutableTreeNode depNode = (DefaultMutableTreeNode) depts.nextElement();
                Department dept = (Department) (depNode.getUserObject());
                S = dept.getCode() + "-" + dept.getName() + ":";
                pf.println(S);
                Enumeration emps = depNode.children();
                // get employees;
                while (emps.hasMoreElements()) {
                    DefaultMutableTreeNode empNode = (DefaultMutableTreeNode) emps.nextElement();
                    Employee emp = (Employee) (empNode.getUserObject());
                    S = emp.getCode() + "," + emp.getName() + "," + emp.getSalary();
                    pf.println(S);
                }
            }
            pf.close();
            f.close();
            JOptionPane.showMessageDialog(this, "Data are saved to the file" + fileName);
        } catch (Exception e) {
            JOptionPane.showMessageDialog(this, e);
        }
    }

    private boolean validDepDetails() {
        String s = "";
        if (addNewDep == true) {
            s = txtCodeD.getText().trim().toUpperCase();
            txtCodeD.setText(s);
            if (!s.matches("\\w{2,3}")) // checking code format
            {
                JOptionPane.showMessageDialog(this, "Code format just have 2 or 3 character");
                return false;
            }

        }
        // checking the name
        s = txtNameD.getText().trim();
        if (s.length() == 0) {
            JOptionPane.showMessageDialog(this, "Name is required");
            return false;
        }

        return true;

    }

    private void btnDepSaveActionPerformed(java.awt.event.ActionEvent evt) {
        // Save department details
        String code = this.txtCodeD.getText().trim().toUpperCase();
        txtCodeD.setText(code);
        String name = this.txtNameD.getText().trim();
        txtNameD.setText(name);
        if (!validDepDetails()) {
            return;
        }
        if (addNewDep == true) {
            Department newDep = new Department(code, name);
            root.add(new DefaultMutableTreeNode(newDep));
        } else {
            ((Department) deptNode.getUserObject()).setName(name);
        }
        this.Tree.updateUI();
        this.addNewDep = false;
    }

    public void initComponents() {
        DepPanel = new JPanel(new FlowLayout(FlowLayout.CENTER, 0, 0));
        DepCP = new JPanel(new FlowLayout(FlowLayout.CENTER, 10, 10));
        DepCP.add(CodeD = new JLabel("Code"));
        DepCP.add(txtCodeD = new JTextField(20) {
        });
        DepCP.setPreferredSize(new Dimension(290, 50));

        DepNP = new JPanel(new FlowLayout(FlowLayout.CENTER, 10, 10));
        DepNP.add(NameD = new JLabel("Name"));
        DepNP.add(txtNameD = new JTextField(20) {
        });
        DepNP.setPreferredSize(new Dimension(290, 50));

        DepBtnP = new JPanel(new FlowLayout(FlowLayout.CENTER, 10, 10));
        DepBtnP.add(btnNewD = new JButton("New"));
        DepBtnP.add(btnSaveD = new JButton("Save"));
        DepBtnP.add(btnRemoveD = new JButton("Remove"));
        DepBtnP.setPreferredSize(new Dimension(290, 50));

        DepPanel.add(DepCP);
        DepPanel.add(DepNP);
        DepPanel.add(DepBtnP);
        DepPanel.setPreferredSize(new Dimension(350, 250));
        DepPanel.setOpaque(true);
        DepPanel.setBorder(BorderFactory.createLineBorder(Color.black));
        DepPanel.setBorder(BorderFactory.createTitledBorder("Department"));

        EmpPanel = new JPanel(new FlowLayout(FlowLayout.CENTER, 0, 0));
        EmpCP = new JPanel(new FlowLayout(FlowLayout.CENTER, 10, 10));
        EmpNP = new JPanel(new FlowLayout(FlowLayout.CENTER, 10, 10));
        EmpSP = new JPanel(new FlowLayout(FlowLayout.CENTER, 10, 10));
        EmpBtnP = new JPanel(new FlowLayout(FlowLayout.CENTER, 10, 10));
        EmpCP.add(CodeE = new JLabel("Code"));
        EmpCP.add(txtCodeE = new JTextField(20) {
        });
        EmpCP.setPreferredSize(new Dimension(290, 50));
        EmpNP.add(NameE = new JLabel("Name"));
        EmpNP.add(txtNameE = new JTextField(20) {
        });
        EmpNP.setPreferredSize(new Dimension(290, 50));
        EmpSP.add(Salary = new JLabel("Salary"));
        EmpSP.add(txtSalaryE = new JTextField(20) {
        });
        EmpSP.setPreferredSize(new Dimension(290, 50));
        EmpBtnP.add(btnNewE = new JButton("New"));
        EmpBtnP.add(btnSaveE = new JButton("Save"));
        EmpBtnP.add(btnRemoveE = new JButton("Remove"));
        EmpBtnP.setPreferredSize(new Dimension(290, 50));
        EmpPanel.add(EmpCP);
        EmpPanel.add(EmpNP);
        EmpPanel.add(EmpSP);
        EmpPanel.add(EmpBtnP);
        EmpPanel.setOpaque(true);
        EmpPanel.setPreferredSize(new Dimension(290, 250));
        EmpPanel.setBorder(BorderFactory.createLineBorder(Color.black));
        EmpPanel.setBorder(BorderFactory.createTitledBorder("Employee"));

        PRIGHT = new JPanel(new BorderLayout());
        PRIGHT.setBackground(Color.white);
        PRIGHT.add(DepPanel, "North");
        PRIGHT.add(EmpPanel, "South");
        PRIGHT.setPreferredSize(new Dimension(350, 510));

        PLEFT = new JPanel(new BorderLayout());
        Tree = new JTree();
        Tree.setPreferredSize(new Dimension(150, 450));
        DefaultMutableTreeNode treeNode1 = new DefaultMutableTreeNode("Departments");
        Tree.setModel(new DefaultTreeModel(treeNode1));
        PLEFT.add(Tree, "North");
        btnSaveFile = new JButton("Save File");
        PLEFT.add(btnSaveFile, "South");
        PLEFT.setPreferredSize(new Dimension(150, 500));

        FullJFrame = new JPanel(new FlowLayout(FlowLayout.CENTER, 0, 0));
        FullJFrame.add(PLEFT, "LEFT");
        FullJFrame.add(PRIGHT, "RIGHT");

        Container container = getContentPane();
        container.setLayout(new FlowLayout(FlowLayout.CENTER, 10, 10));
        container.add(FullJFrame);

        Tree.addMouseListener(new java.awt.event.MouseAdapter() {
            @Override
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                TreeMouseClicked(evt);
            }
        });
        btnNewD.addActionListener(new java.awt.event.ActionListener() {
            @Override
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnDepNewActionPerformed(evt);
            }
        });
        btnRemoveD.addActionListener(new java.awt.event.ActionListener() {
            @Override
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnDepRemoveActionPerformed(evt);
            }
        });
        btnSaveD.addActionListener(new java.awt.event.ActionListener() {
            @Override
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnDepSaveActionPerformed(evt);
            }
        });
        btnNewE.addActionListener(new java.awt.event.ActionListener() {
            @Override
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEmpNewActionPerformed(evt);
            }
        });
        btnRemoveE.addActionListener(new java.awt.event.ActionListener() {
            @Override
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEmpRemoveActionPerformed(evt);
            }
        });
        btnSaveE.addActionListener(new java.awt.event.ActionListener() {
            @Override
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEmpSaveActionPerformed(evt);
            }
        });
        btnSaveFile.addActionListener(new java.awt.event.ActionListener() {
            @Override
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnSaveFileActionPerformed(evt);
            }
        });
    }

    public static void main(String[] args) {
        workshop45 c = new workshop45();
        c.setDefaultCloseOperation(EXIT_ON_CLOSE);
        c.setSize(600, 580);
        c.setBackground(Color.white);
        c.setResizable(true);
        c.setLocationRelativeTo(null);
        c.setVisible(true);
    }
}
