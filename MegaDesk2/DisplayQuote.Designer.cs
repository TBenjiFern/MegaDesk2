namespace MegaDesk2
{
    partial class DisplayQuote
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
            this.displayCustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.displayDeliveryComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.displayNumDrawersNumeric = new System.Windows.Forms.NumericUpDown();
            this.displayMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.deskDimensions = new System.Windows.Forms.GroupBox();
            this.deskDepth = new System.Windows.Forms.Label();
            this.deskWidth = new System.Windows.Forms.Label();
            this.displayWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.displayDepthNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.displayPriceTotal = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.displayDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayNumDrawersNumeric)).BeginInit();
            this.deskDimensions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayDepthNumeric)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayCustomerName
            // 
            this.displayCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayCustomerName.Location = new System.Drawing.Point(384, 65);
            this.displayCustomerName.Name = "displayCustomerName";
            this.displayCustomerName.Size = new System.Drawing.Size(243, 30);
            this.displayCustomerName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Customer Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.displayDeliveryComboBox);
            this.groupBox2.Location = new System.Drawing.Point(398, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 67);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shipping";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Delivery Type:";
            // 
            // displayDeliveryComboBox
            // 
            this.displayDeliveryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDeliveryComboBox.FormattingEnabled = true;
            this.displayDeliveryComboBox.Items.AddRange(new object[] {
            "Rush Order - 3 Days",
            "Rush Order - 5 Days",
            "Rush Order - 7 Days",
            "No Rush"});
            this.displayDeliveryComboBox.Location = new System.Drawing.Point(211, 22);
            this.displayDeliveryComboBox.Name = "displayDeliveryComboBox";
            this.displayDeliveryComboBox.Size = new System.Drawing.Size(134, 33);
            this.displayDeliveryComboBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.displayNumDrawersNumeric);
            this.groupBox1.Controls.Add(this.displayMaterialComboBox);
            this.groupBox1.Location = new System.Drawing.Point(398, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 103);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desk Customizations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Surface Material:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of Drawers:";
            // 
            // displayNumDrawersNumeric
            // 
            this.displayNumDrawersNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayNumDrawersNumeric.Location = new System.Drawing.Point(212, 20);
            this.displayNumDrawersNumeric.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.displayNumDrawersNumeric.Name = "displayNumDrawersNumeric";
            this.displayNumDrawersNumeric.Size = new System.Drawing.Size(133, 30);
            this.displayNumDrawersNumeric.TabIndex = 3;
            // 
            // displayMaterialComboBox
            // 
            this.displayMaterialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayMaterialComboBox.FormattingEnabled = true;
            this.displayMaterialComboBox.Location = new System.Drawing.Point(211, 62);
            this.displayMaterialComboBox.Name = "displayMaterialComboBox";
            this.displayMaterialComboBox.Size = new System.Drawing.Size(134, 33);
            this.displayMaterialComboBox.TabIndex = 4;
            // 
            // deskDimensions
            // 
            this.deskDimensions.Controls.Add(this.deskDepth);
            this.deskDimensions.Controls.Add(this.deskWidth);
            this.deskDimensions.Controls.Add(this.displayWidthNumeric);
            this.deskDimensions.Controls.Add(this.displayDepthNumeric);
            this.deskDimensions.Location = new System.Drawing.Point(44, 110);
            this.deskDimensions.Name = "deskDimensions";
            this.deskDimensions.Size = new System.Drawing.Size(300, 138);
            this.deskDimensions.TabIndex = 15;
            this.deskDimensions.TabStop = false;
            this.deskDimensions.Text = "Desk Dimensions";
            // 
            // deskDepth
            // 
            this.deskDepth.AutoSize = true;
            this.deskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDepth.Location = new System.Drawing.Point(19, 92);
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(83, 29);
            this.deskDepth.TabIndex = 9;
            this.deskDepth.Text = "Depth:";
            // 
            // deskWidth
            // 
            this.deskWidth.AutoSize = true;
            this.deskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidth.Location = new System.Drawing.Point(19, 30);
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(80, 29);
            this.deskWidth.TabIndex = 5;
            this.deskWidth.Text = "Width:";
            // 
            // displayWidthNumeric
            // 
            this.displayWidthNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayWidthNumeric.Location = new System.Drawing.Point(162, 29);
            this.displayWidthNumeric.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.displayWidthNumeric.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.displayWidthNumeric.Name = "displayWidthNumeric";
            this.displayWidthNumeric.Size = new System.Drawing.Size(120, 30);
            this.displayWidthNumeric.TabIndex = 1;
            this.displayWidthNumeric.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // displayDepthNumeric
            // 
            this.displayDepthNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDepthNumeric.Location = new System.Drawing.Point(162, 91);
            this.displayDepthNumeric.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.displayDepthNumeric.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.displayDepthNumeric.Name = "displayDepthNumeric";
            this.displayDepthNumeric.Size = new System.Drawing.Size(120, 30);
            this.displayDepthNumeric.TabIndex = 2;
            this.displayDepthNumeric.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "View Quote";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.displayDate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.displayPriceTotal);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(111, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(607, 71);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receipt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total:";
            // 
            // displayPriceTotal
            // 
            this.displayPriceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayPriceTotal.Location = new System.Drawing.Point(110, 26);
            this.displayPriceTotal.Name = "displayPriceTotal";
            this.displayPriceTotal.Size = new System.Drawing.Size(123, 30);
            this.displayPriceTotal.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(285, 390);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(230, 40);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // displayDate
            // 
            this.displayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDate.Location = new System.Drawing.Point(350, 26);
            this.displayDate.Name = "displayDate";
            this.displayDate.Size = new System.Drawing.Size(234, 30);
            this.displayDate.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Date:";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.displayCustomerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deskDimensions);
            this.Controls.Add(this.label1);
            this.Name = "DisplayQuote";
            this.Text = "Display Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayQuote_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayNumDrawersNumeric)).EndInit();
            this.deskDimensions.ResumeLayout(false);
            this.deskDimensions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayDepthNumeric)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayCustomerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox displayDeliveryComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown displayNumDrawersNumeric;
        private System.Windows.Forms.ComboBox displayMaterialComboBox;
        private System.Windows.Forms.GroupBox deskDimensions;
        private System.Windows.Forms.Label deskDepth;
        private System.Windows.Forms.Label deskWidth;
        private System.Windows.Forms.NumericUpDown displayWidthNumeric;
        private System.Windows.Forms.NumericUpDown displayDepthNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox displayPriceTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox displayDate;
        private System.Windows.Forms.Label label6;
    }
}