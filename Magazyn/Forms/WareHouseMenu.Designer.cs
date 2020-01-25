namespace Magazyn.Forms
{
    partial class WareHouseMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WareHouseMenu));
            this.label_username = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.showStatus = new System.Windows.Forms.Button();
            this.takeGoods = new System.Windows.Forms.Button();
            this.releaseGoods = new System.Windows.Forms.Button();
            this.addNewProduct = new System.Windows.Forms.Button();
            this.exit_click = new System.Windows.Forms.Button();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeList = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_username.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_username.Location = new System.Drawing.Point(20, 118);
            this.label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(212, 25);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Zalogowany:  username";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(268, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wyloguj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Logout_Click);
            // 
            // showStatus
            // 
            this.showStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.showStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.showStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showStatus.Location = new System.Drawing.Point(24, 397);
            this.showStatus.Margin = new System.Windows.Forms.Padding(4);
            this.showStatus.Name = "showStatus";
            this.showStatus.Size = new System.Drawing.Size(339, 45);
            this.showStatus.TabIndex = 2;
            this.showStatus.Text = "Wyświetl stan magazynu";
            this.showStatus.UseVisualStyleBackColor = false;
            this.showStatus.Click += new System.EventHandler(this.ShowStatus_Click);
            // 
            // takeGoods
            // 
            this.takeGoods.BackColor = System.Drawing.SystemColors.Menu;
            this.takeGoods.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.takeGoods.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.takeGoods.Location = new System.Drawing.Point(24, 450);
            this.takeGoods.Margin = new System.Windows.Forms.Padding(4);
            this.takeGoods.Name = "takeGoods";
            this.takeGoods.Size = new System.Drawing.Size(339, 45);
            this.takeGoods.TabIndex = 3;
            this.takeGoods.Text = "Przyjmij towar";
            this.takeGoods.UseVisualStyleBackColor = false;
            this.takeGoods.Click += new System.EventHandler(this.TakeGoods_Click);
            // 
            // releaseGoods
            // 
            this.releaseGoods.BackColor = System.Drawing.SystemColors.Menu;
            this.releaseGoods.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.releaseGoods.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.releaseGoods.Location = new System.Drawing.Point(24, 503);
            this.releaseGoods.Margin = new System.Windows.Forms.Padding(4);
            this.releaseGoods.Name = "releaseGoods";
            this.releaseGoods.Size = new System.Drawing.Size(339, 45);
            this.releaseGoods.TabIndex = 4;
            this.releaseGoods.Text = "Wydaj towar";
            this.releaseGoods.UseVisualStyleBackColor = false;
            this.releaseGoods.Click += new System.EventHandler(this.ReleaseGoods_Click);
            // 
            // addNewProduct
            // 
            this.addNewProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addNewProduct.BackColor = System.Drawing.SystemColors.Menu;
            this.addNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addNewProduct.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewProduct.Location = new System.Drawing.Point(24, 238);
            this.addNewProduct.Margin = new System.Windows.Forms.Padding(4);
            this.addNewProduct.Name = "addNewProduct";
            this.addNewProduct.Size = new System.Drawing.Size(339, 45);
            this.addNewProduct.TabIndex = 5;
            this.addNewProduct.Text = "Dodaj nowy produkt";
            this.addNewProduct.UseVisualStyleBackColor = false;
            this.addNewProduct.Click += new System.EventHandler(this.AddNewProduct_Click);
            // 
            // exit_click
            // 
            this.exit_click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exit_click.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exit_click.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit_click.Location = new System.Drawing.Point(24, 556);
            this.exit_click.Margin = new System.Windows.Forms.Padding(4);
            this.exit_click.Name = "exit_click";
            this.exit_click.Size = new System.Drawing.Size(339, 45);
            this.exit_click.TabIndex = 6;
            this.exit_click.Text = "Zamknij program";
            this.exit_click.UseVisualStyleBackColor = false;
            this.exit_click.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddEmployee
            // 
            this.AddEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddEmployee.BackColor = System.Drawing.SystemColors.Menu;
            this.AddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddEmployee.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddEmployee.Location = new System.Drawing.Point(24, 291);
            this.AddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(339, 45);
            this.AddEmployee.TabIndex = 7;
            this.AddEmployee.Text = "Dodaj nowego pracownika";
            this.AddEmployee.UseVisualStyleBackColor = false;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 95);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(35, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // EmployeeList
            // 
            this.EmployeeList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EmployeeList.BackColor = System.Drawing.SystemColors.Menu;
            this.EmployeeList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EmployeeList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmployeeList.Location = new System.Drawing.Point(23, 344);
            this.EmployeeList.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.Size = new System.Drawing.Size(339, 45);
            this.EmployeeList.TabIndex = 9;
            this.EmployeeList.Text = "Wyswietl liste pracowników";
            this.EmployeeList.UseVisualStyleBackColor = false;
            this.EmployeeList.Click += new System.EventHandler(this.WorkersTab_Click);
            // 
            // WareHouseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 623);
            this.ControlBox = false;
            this.Controls.Add(this.EmployeeList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.exit_click);
            this.Controls.Add(this.addNewProduct);
            this.Controls.Add(this.releaseGoods);
            this.Controls.Add(this.takeGoods);
            this.Controls.Add(this.showStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_username);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "WareHouseMenu";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button showStatus;
        private System.Windows.Forms.Button takeGoods;
        private System.Windows.Forms.Button releaseGoods;
        private System.Windows.Forms.Button addNewProduct;
        private System.Windows.Forms.Button exit_click;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EmployeeList;
    }
}