namespace ObjectOrientedPractics.View
{
    partial class AddressTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
           
            addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            LoadAddressButton = new Button();
            CheckAddressButton = new Button();
            SuspendLayout();
            // 
            // addressControl1
            // 
            
            addressControl1.Location = new Point(-2, -2);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(725, 300);
            addressControl1.TabIndex = 0;
            // 
            // LoadAddressButton
            // 
            LoadAddressButton.Location = new Point(12, 235);
            LoadAddressButton.Name = "LoadAddressButton";
            LoadAddressButton.Size = new Size(94, 29);
            LoadAddressButton.TabIndex = 1;
            LoadAddressButton.Text = "Load Address";
            LoadAddressButton.UseVisualStyleBackColor = true;
            // 
            // CheckAddressButton
            // 
            CheckAddressButton.Location = new Point(124, 235);
            CheckAddressButton.Name = "CheckAddressButton";
            CheckAddressButton.Size = new Size(94, 29);
            CheckAddressButton.TabIndex = 2;
            CheckAddressButton.Text = "Check Address";
            CheckAddressButton.UseVisualStyleBackColor = true;
            // 
            // AddressTestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CheckAddressButton);
            Controls.Add(LoadAddressButton);
            Controls.Add(addressControl1);
            Name = "AddressTestForm";
            Text = "AddressTestForm";
            ResumeLayout(false);
        }

        #endregion

        private Controls.AddressControl addressControl1;
        private Button LoadAddressButton;
        private Button CheckAddressButton;
    }
}