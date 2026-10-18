namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage2 = new TabPage();
            itemsListBox1 = new ObjectOrientedPractics.View.Tabs.ItemsListBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            customersTab1 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            tabPage2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(itemsListBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Items";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // itemsListBox1
            // 
            itemsListBox1.BackColor = Color.White;
            itemsListBox1.Dock = DockStyle.Fill;
            itemsListBox1.Location = new Point(3, 3);
            itemsListBox1.Name = "itemsListBox1";
            itemsListBox1.Size = new Size(786, 411);
            itemsListBox1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(customersTab1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Сustomers";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.BackColor = Color.White;
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(786, 411);
            customersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Object Oriented Practices";
            tabPage2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TabControl tabControl1;
        private View.Tabs.ItemsListBox itemsListBox1;
        private TabPage tabPage1;
        private View.Tabs.CustomersTab customersTab1;
    }
}
