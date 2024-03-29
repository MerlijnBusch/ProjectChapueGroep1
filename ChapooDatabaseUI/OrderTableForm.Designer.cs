﻿
using System.Windows.Forms;

namespace ChapooDatabaseUI
{
    partial class OrderTableForm : BaseForm
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
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.OrderItemsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.AddMenuItemToOrderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RemoveMenuItemToOrderButton = new System.Windows.Forms.Button();
            this.GoToTableDashboardButton = new System.Windows.Forms.Button();
            this.LunchButton = new System.Windows.Forms.Button();
            this.DinerButton = new System.Windows.Forms.Button();
            this.DrankAlcholButton = new System.Windows.Forms.Button();
            this.DrankButton = new System.Windows.Forms.Button();
            this.BTTNFinishOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Location = new System.Drawing.Point(781, 257);
            this.CreateOrderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(215, 112);
            this.CreateOrderButton.TabIndex = 0;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.Location = new System.Drawing.Point(934, 808);
            this.DeleteOrderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(136, 52);
            this.DeleteOrderButton.TabIndex = 1;
            this.DeleteOrderButton.Text = "Delete Order";
            this.DeleteOrderButton.UseVisualStyleBackColor = true;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // OrderItemsGridView
            // 
            this.OrderItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderItemsGridView.Location = new System.Drawing.Point(731, 83);
            this.OrderItemsGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderItemsGridView.Name = "OrderItemsGridView";
            this.OrderItemsGridView.RowHeadersWidth = 51;
            this.OrderItemsGridView.RowTemplate.Height = 25;
            this.OrderItemsGridView.Size = new System.Drawing.Size(731, 717);
            this.OrderItemsGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(731, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Ordered Items:";
            // 
            // MenuItemsDataGridView
            // 
            this.MenuItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuItemsDataGridView.Location = new System.Drawing.Point(190, 83);
            this.MenuItemsDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuItemsDataGridView.Name = "MenuItemsDataGridView";
            this.MenuItemsDataGridView.RowHeadersWidth = 51;
            this.MenuItemsDataGridView.RowTemplate.Height = 25;
            this.MenuItemsDataGridView.Size = new System.Drawing.Size(535, 256);
            this.MenuItemsDataGridView.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(190, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "All menu items";
            // 
            // AddMenuItemToOrderButton
            // 
            this.AddMenuItemToOrderButton.Location = new System.Drawing.Point(589, 373);
            this.AddMenuItemToOrderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddMenuItemToOrderButton.Name = "AddMenuItemToOrderButton";
            this.AddMenuItemToOrderButton.Size = new System.Drawing.Size(136, 52);
            this.AddMenuItemToOrderButton.TabIndex = 7;
            this.AddMenuItemToOrderButton.Text = "Add Item";
            this.AddMenuItemToOrderButton.UseVisualStyleBackColor = true;
            this.AddMenuItemToOrderButton.Click += new System.EventHandler(this.AddMenuItemToOrderButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(190, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "Add Item to order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(190, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 46);
            this.label4.TabIndex = 9;
            this.label4.Text = "Remove Item to order";
            // 
            // RemoveMenuItemToOrderButton
            // 
            this.RemoveMenuItemToOrderButton.Location = new System.Drawing.Point(589, 457);
            this.RemoveMenuItemToOrderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveMenuItemToOrderButton.Name = "RemoveMenuItemToOrderButton";
            this.RemoveMenuItemToOrderButton.Size = new System.Drawing.Size(136, 52);
            this.RemoveMenuItemToOrderButton.TabIndex = 13;
            this.RemoveMenuItemToOrderButton.Text = "Remove Item";
            this.RemoveMenuItemToOrderButton.UseVisualStyleBackColor = true;
            this.RemoveMenuItemToOrderButton.Click += new System.EventHandler(this.RemoveMenuItemToOrderButton_Click);
            // 
            // GoToTableDashboardButton
            // 
            this.GoToTableDashboardButton.Location = new System.Drawing.Point(559, 257);
            this.GoToTableDashboardButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GoToTableDashboardButton.Name = "GoToTableDashboardButton";
            this.GoToTableDashboardButton.Size = new System.Drawing.Size(216, 112);
            this.GoToTableDashboardButton.TabIndex = 14;
            this.GoToTableDashboardButton.Text = "Go Back";
            this.GoToTableDashboardButton.UseVisualStyleBackColor = true;
            this.GoToTableDashboardButton.Click += new System.EventHandler(this.GoToTableDashboardButton_Click);
            // 
            // LunchButton
            // 
            this.LunchButton.Location = new System.Drawing.Point(11, 83);
            this.LunchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LunchButton.Name = "LunchButton";
            this.LunchButton.Size = new System.Drawing.Size(136, 52);
            this.LunchButton.TabIndex = 15;
            this.LunchButton.Text = "Lunch";
            this.LunchButton.UseVisualStyleBackColor = true;
            this.LunchButton.Click += new System.EventHandler(this.LunchButton_Click);
            // 
            // DinerButton
            // 
            this.DinerButton.Location = new System.Drawing.Point(11, 160);
            this.DinerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DinerButton.Name = "DinerButton";
            this.DinerButton.Size = new System.Drawing.Size(136, 52);
            this.DinerButton.TabIndex = 16;
            this.DinerButton.Text = "Diner";
            this.DinerButton.UseVisualStyleBackColor = true;
            this.DinerButton.Click += new System.EventHandler(this.DinerButton_Click);
            // 
            // DrankAlcholButton
            // 
            this.DrankAlcholButton.Location = new System.Drawing.Point(11, 237);
            this.DrankAlcholButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DrankAlcholButton.Name = "DrankAlcholButton";
            this.DrankAlcholButton.Size = new System.Drawing.Size(136, 52);
            this.DrankAlcholButton.TabIndex = 17;
            this.DrankAlcholButton.Text = "Drank Alchol";
            this.DrankAlcholButton.UseVisualStyleBackColor = true;
            this.DrankAlcholButton.Click += new System.EventHandler(this.DrankAlcholButton_Click);
            // 
            // DrankButton
            // 
            this.DrankButton.Location = new System.Drawing.Point(11, 317);
            this.DrankButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DrankButton.Name = "DrankButton";
            this.DrankButton.Size = new System.Drawing.Size(136, 52);
            this.DrankButton.TabIndex = 18;
            this.DrankButton.Text = "Drank";
            this.DrankButton.UseVisualStyleBackColor = true;
            this.DrankButton.Click += new System.EventHandler(this.DrankButton_Click);
            // 
            // BTTNFinishOrder
            // 
            this.BTTNFinishOrder.Location = new System.Drawing.Point(731, 808);
            this.BTTNFinishOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTTNFinishOrder.Name = "BTTNFinishOrder";
            this.BTTNFinishOrder.Size = new System.Drawing.Size(136, 52);
            this.BTTNFinishOrder.TabIndex = 19;
            this.BTTNFinishOrder.Text = "Finish Order";
            this.BTTNFinishOrder.UseVisualStyleBackColor = true;
            this.BTTNFinishOrder.Click += new System.EventHandler(this.BTTNFinishOrder_Click);
            // 
            // OrderTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1614, 1017);
            this.Controls.Add(this.BTTNFinishOrder);
            this.Controls.Add(this.DrankButton);
            this.Controls.Add(this.DrankAlcholButton);
            this.Controls.Add(this.DinerButton);
            this.Controls.Add(this.LunchButton);
            this.Controls.Add(this.GoToTableDashboardButton);
            this.Controls.Add(this.RemoveMenuItemToOrderButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddMenuItemToOrderButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MenuItemsDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderItemsGridView);
            this.Controls.Add(this.DeleteOrderButton);
            this.Controls.Add(this.CreateOrderButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderTableForm";
            this.Text = "Order Table Form";
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void generateGridLayout(System.Windows.Forms.DataGridView view, string[] columnArr)
        {
            view.ColumnCount = columnArr.Length;

            view.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Navy;
            view.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

            view.GridColor = System.Drawing.Color.Black;
            view.RowHeadersVisible = false;
            view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;


            for (int i = 0; i < columnArr.Length; i++)
                view.Columns[i].Name = columnArr[i];

            view.MultiSelect = false;
        }

        public void FillDataInGridView(System.Windows.Forms.DataGridView view, string[] dataString)
        {
            view.Rows.Add(dataString);
        }

        public void ClearDataGridView(System.Windows.Forms.DataGridView view)
        {
            view.Columns.Clear();
        }

        #endregion

        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.Button DeleteOrderButton;
        private System.Windows.Forms.DataGridView OrderItemsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MenuItemsDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddMenuItemToOrderButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RemoveMenuItemToOrderButton;
        private System.Windows.Forms.Button GoToTableDashboardButton;
        private System.Windows.Forms.Button LunchButton;
        private System.Windows.Forms.Button DinerButton;
        private System.Windows.Forms.Button DrankAlcholButton;
        private System.Windows.Forms.Button DrankButton;
        private System.Windows.Forms.Button BTTNFinishOrder;
    }
}