﻿
namespace ChapooDatabaseUI
{
    partial class PaymentForm
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
            this.TableHolderFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.priceLabelPayment = new System.Windows.Forms.Label();
            this.SubmitReceedBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            initNavBar();
            
            // 
            // TableHolderFlowLayout
            // 
            this.TableHolderFlowLayout.Location = new System.Drawing.Point(14, 251);
            this.TableHolderFlowLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TableHolderFlowLayout.Name = "TableHolderFlowLayout";
            this.TableHolderFlowLayout.Size = new System.Drawing.Size(821, 613);
            this.TableHolderFlowLayout.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(841, 251);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(560, 613);
            this.dataGridView1.TabIndex = 0;
            // 
            // priceLabelPayment
            // 
            this.priceLabelPayment.AutoSize = true;
            this.priceLabelPayment.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceLabelPayment.Location = new System.Drawing.Point(841, 952);
            this.priceLabelPayment.Name = "priceLabelPayment";
            this.priceLabelPayment.Size = new System.Drawing.Size(134, 35);
            this.priceLabelPayment.TabIndex = 1;
            this.priceLabelPayment.Text = "Total Price:";
            // 
            // SubmitReceedBTN
            // 
            this.SubmitReceedBTN.Location = new System.Drawing.Point(1215, 997);
            this.SubmitReceedBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubmitReceedBTN.Name = "SubmitReceedBTN";
            this.SubmitReceedBTN.Size = new System.Drawing.Size(185, 28);
            this.SubmitReceedBTN.TabIndex = 2;
            this.SubmitReceedBTN.Text = "Submit receed";
            this.SubmitReceedBTN.UseVisualStyleBackColor = true;
            this.SubmitReceedBTN.Click += new System.EventHandler(this.SubmitReceedBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(841, 868);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tip:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1215, 958);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(897, 875);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(503, 27);
            this.textBox1.TabIndex = 5;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 1055);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitReceedBTN);
            this.Controls.Add(this.priceLabelPayment);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TableHolderFlowLayout);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PaymentForm";
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
            this.NavBarContainer.Size = new System.Drawing.Size(801, 51);
            this.NavBarContainer.TabIndex = 2;
            // 
            // BarMederwerkesButton
            // 
            this.AdministratorButton.Location = new System.Drawing.Point(82, 0);
            this.AdministratorButton.Name = "AdministratorButton";
            this.AdministratorButton.Size = new System.Drawing.Size(139, 51);
            this.AdministratorButton.TabIndex = 10;
            this.AdministratorButton.Text = "Administrator";
            this.AdministratorButton.UseVisualStyleBackColor = true;
            this.AdministratorButton.Click += (sender, e) => AdministratorButton(this);
            // 
            // BedieningButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(227, 0);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(139, 51);
            this.OrderButton.TabIndex = 9;
            this.OrderButton.Text = "Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += (sender, e) => OrderButton(this);
            // 
            // ChefKokButton
            // 
            this.KitchenButton.Location = new System.Drawing.Point(372, 0);
            this.KitchenButton.Name = "KitchenButton";
            this.KitchenButton.Size = new System.Drawing.Size(139, 51);
            this.KitchenButton.TabIndex = 8;
            this.KitchenButton.Text = "Kitchen";
            this.KitchenButton.UseVisualStyleBackColor = true;
            this.KitchenButton.Click += (sender, e) => KitchenButton(this);
            // 
            // ManagementButton
            // 
            this.PaymentButton.Location = new System.Drawing.Point(517, 0);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(139, 51);
            this.PaymentButton.TabIndex = 7;
            this.PaymentButton.Text = "Payment";
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += (sender, e) => PaymentButton(this);
            // 
            // KassaButton
            // 


            this.Controls.Add(this.NavBarContainer);
        }

        public void generateGridLayout(System.Windows.Forms.DataGridView view, string[] columnArr)
        {
            view.ColumnCount = columnArr.Length;

            view.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Navy;
            view.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

            view.GridColor = System.Drawing.Color.Black;
            view.RowHeadersVisible = false;
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


        private System.Windows.Forms.Panel NavBarContainer;
        private new System.Windows.Forms.Button AdministratorButton;
        private new System.Windows.Forms.Button OrderButton;
        private new System.Windows.Forms.Button KitchenButton;
        private new System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.FlowLayoutPanel TableHolderFlowLayout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label priceLabelPayment;
        private System.Windows.Forms.Button SubmitReceedBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}