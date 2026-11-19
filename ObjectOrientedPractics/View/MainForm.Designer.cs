namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabPage1 = new TabPage();
            customersTab1 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            tabPage2 = new TabPage();
            itemsListBox1 = new ObjectOrientedPractics.View.Tabs.ItemsListBox();
            CartsTab = new TabControl();
            tabPage3 = new TabPage();
            cartsTab1 = new ObjectOrientedPractics.View.Tabs.CartsTab();
            tabPage4 = new TabPage();
            ordersTab1 = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            CartsTab.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(customersTab1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(192, 67);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Customers";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.BackColor = Color.White;
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(186, 61);
            customersTab1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(itemsListBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(868, 569);
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
            itemsListBox1.Size = new Size(862, 563);
            itemsListBox1.TabIndex = 0;
            itemsListBox1.Load += itemsListBox1_Load;
            // 
            // CartsTab
            // 
            CartsTab.Controls.Add(tabPage2);
            CartsTab.Controls.Add(tabPage1);
            CartsTab.Controls.Add(tabPage3);
            CartsTab.Controls.Add(tabPage4);
            CartsTab.Dock = DockStyle.Fill;
            CartsTab.Location = new Point(0, 0);
            CartsTab.Name = "CartsTab";
            CartsTab.SelectedIndex = 0;
            CartsTab.Size = new Size(876, 602);
            CartsTab.TabIndex = 0;
            CartsTab.SelectedIndexChanged += cartsTabPage_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(cartsTab1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(192, 67);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Carts";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.BackColor = Color.White;
            cartsTab1.Dock = DockStyle.Fill;
            cartsTab1.Location = new Point(3, 3);
            cartsTab1.Margin = new Padding(0);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(186, 61);
            cartsTab1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(ordersTab1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(868, 569);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "Orders";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            ordersTab1.AutoScroll = true;
            ordersTab1.Dock = DockStyle.Fill;
            ordersTab1.Location = new Point(3, 3);
            ordersTab1.Name = "ordersTab1";
            ordersTab1.Size = new Size(862, 563);
            ordersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 602);
            Controls.Add(CartsTab);
            MinimumSize = new Size(720, 490);
            Name = "MainForm";
            Text = "Object Oriented Practices";
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            CartsTab.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPage1;
        private View.Tabs.CustomersTab customersTab1;
        private TabPage tabPage2;
        private View.Tabs.ItemsListBox itemsListBox1;
        private TabControl CartsTab;
        private TabPage tabPage3;
        private View.Tabs.CartsTab cartsTab1;
        private TabPage tabPage4;
        private View.Tabs.OrdersTab ordersTab1;
    }
}
