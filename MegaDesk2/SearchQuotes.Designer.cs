namespace MegaDesk2
{
    partial class SearchQuotes
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
            this.dataGridSearch = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comFilterSurface = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSearch
            // 
            this.dataGridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearch.Location = new System.Drawing.Point(1, 143);
            this.dataGridSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridSearch.Name = "dataGridSearch";
            this.dataGridSearch.RowHeadersWidth = 82;
            this.dataGridSearch.RowTemplate.Height = 33;
            this.dataGridSearch.Size = new System.Drawing.Size(1235, 547);
            this.dataGridSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Surface Material:";
            // 
            // comFilterSurface
            // 
            this.comFilterSurface.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comFilterSurface.FormattingEnabled = true;
            this.comFilterSurface.Location = new System.Drawing.Point(265, 49);
            this.comFilterSurface.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comFilterSurface.Name = "comFilterSurface";
            this.comFilterSurface.Size = new System.Drawing.Size(250, 37);
            this.comFilterSurface.TabIndex = 2;
            this.comFilterSurface.SelectedValueChanged += new System.EventHandler(this.comFilterSurface_SelectedValueChanged);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 675);
            this.Controls.Add(this.comFilterSurface);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridSearch);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comFilterSurface;
    }
}