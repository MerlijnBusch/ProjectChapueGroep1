﻿
namespace ChapooDatabaseUI
{
    partial class DashboardForm
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
            this.NavBarContainer = new System.Windows.Forms.Panel();
            this.AdministratorButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.KitchenButton = new System.Windows.Forms.Button();
            this.PaymentButton = new System.Windows.Forms.Button();
            //this.KassaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

            initNavBar();

        }

        public void initNavBar()
        {
            // 
            // panel1
            // 
            this.NavBarContainer.Controls.Add(this.AdministratorButton);
            this.NavBarContainer.Controls.Add(this.OrderButton);
            this.NavBarContainer.Controls.Add(this.KitchenButton);
            this.NavBarContainer.Controls.Add(this.PaymentButton);
            //this.NavBarContainer.Controls.Add(this.KassaButton);
            this.NavBarContainer.Location = new System.Drawing.Point(0, 0);
            this.NavBarContainer.Name = "NavBarContainer";
            this.NavBarContainer.Size = new System.Drawing.Size(1801, 100);
            this.NavBarContainer.TabIndex = 2;
            // 
            // AdministratorButton
            // 
            this.AdministratorButton.Location = new System.Drawing.Point(10, 0);
            this.AdministratorButton.Name = "AdministratorButton";
            this.AdministratorButton.Size = new System.Drawing.Size(250, 91);
            this.AdministratorButton.TabIndex = 10;
            this.AdministratorButton.Text = "Administrator";
            this.AdministratorButton.UseVisualStyleBackColor = true;
            this.AdministratorButton.Click += (sender, e) => AdministratorButton(this);
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(260, 0);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(250, 91);
            this.OrderButton.TabIndex = 9;
            this.OrderButton.Text = "Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += (sender, e) => OrderButton(this);
            // 
            // PaymentButton
            // 
            this.KitchenButton.Location = new System.Drawing.Point(510, 0);
            this.KitchenButton.Name = "KitchenButton";
            this.KitchenButton.Size = new System.Drawing.Size(250, 91);
            this.KitchenButton.TabIndex = 8;
            this.KitchenButton.Text = "Kitchen and Bar";
            this.KitchenButton.UseVisualStyleBackColor = true;
            this.KitchenButton.Click += (sender, e) => KitchenButton(this);
            // KitchenButton            // ManagementButton
            // 
            this.PaymentButton.Location = new System.Drawing.Point(760, 0);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(250, 91);
            this.PaymentButton.TabIndex = 7;
            this.PaymentButton.Text = "Register";
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += (sender, e) => PaymentButton(this);
            // 
            // KassaButton
            // 
            //this.KassaButton.Location = new System.Drawing.Point(662, 0);
            //this.KassaButton.Name = "KassaButton";
            //this.KassaButton.Size = new System.Drawing.Size(139, 51);
            //this.KassaButton.TabIndex = 6;
            //this.KassaButton.Text = "Kassa";
            //this.KassaButton.UseVisualStyleBackColor = true;
            //this.KassaButton.Click += (sender, e) => KassaButton(this);

            this.Controls.Add(this.NavBarContainer);
        }

        #endregion

        private System.Windows.Forms.Panel NavBarContainer;
        private new System.Windows.Forms.Button AdministratorButton;
        private new System.Windows.Forms.Button OrderButton;
        private new System.Windows.Forms.Button KitchenButton;
        private new System.Windows.Forms.Button PaymentButton;
    }
}