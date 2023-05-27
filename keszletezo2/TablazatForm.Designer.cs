namespace keszletezo2
{
    partial class TablazatForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.betoltesBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bvinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBvinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variantIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityReservedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityAvailableForSaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowStockPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outOfStockPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Az alábbi termékekből van kevesebb, mint 5:";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bvinDataGridViewTextBoxColumn,
            this.productBvinDataGridViewTextBoxColumn,
            this.variantIdDataGridViewTextBoxColumn,
            this.quantityOnHandDataGridViewTextBoxColumn,
            this.quantityReservedDataGridViewTextBoxColumn,
            this.quantityAvailableForSaleDataGridViewTextBoxColumn,
            this.lowStockPointDataGridViewTextBoxColumn,
            this.lastUpdatedDataGridViewTextBoxColumn,
            this.storeIdDataGridViewTextBoxColumn,
            this.outOfStockPointDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.adatBindingSource;
            this.dgv.Location = new System.Drawing.Point(17, 136);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(721, 350);
            this.dgv.TabIndex = 1;
            // 
            // betoltesBtn
            // 
            this.betoltesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.betoltesBtn.Location = new System.Drawing.Point(17, 12);
            this.betoltesBtn.Name = "betoltesBtn";
            this.betoltesBtn.Size = new System.Drawing.Size(278, 55);
            this.betoltesBtn.TabIndex = 2;
            this.betoltesBtn.Text = "&Adatok betöltése";
            this.betoltesBtn.UseVisualStyleBackColor = true;
            this.betoltesBtn.Click += new System.EventHandler(this.betoltesBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(313, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(425, 55);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // bvinDataGridViewTextBoxColumn
            // 
            this.bvinDataGridViewTextBoxColumn.DataPropertyName = "bvin";
            this.bvinDataGridViewTextBoxColumn.HeaderText = "bvin";
            this.bvinDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bvinDataGridViewTextBoxColumn.Name = "bvinDataGridViewTextBoxColumn";
            this.bvinDataGridViewTextBoxColumn.Width = 150;
            // 
            // productBvinDataGridViewTextBoxColumn
            // 
            this.productBvinDataGridViewTextBoxColumn.DataPropertyName = "ProductBvin";
            this.productBvinDataGridViewTextBoxColumn.HeaderText = "ProductBvin";
            this.productBvinDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productBvinDataGridViewTextBoxColumn.Name = "productBvinDataGridViewTextBoxColumn";
            this.productBvinDataGridViewTextBoxColumn.Width = 150;
            // 
            // variantIdDataGridViewTextBoxColumn
            // 
            this.variantIdDataGridViewTextBoxColumn.DataPropertyName = "VariantId";
            this.variantIdDataGridViewTextBoxColumn.HeaderText = "VariantId";
            this.variantIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.variantIdDataGridViewTextBoxColumn.Name = "variantIdDataGridViewTextBoxColumn";
            this.variantIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityOnHandDataGridViewTextBoxColumn
            // 
            this.quantityOnHandDataGridViewTextBoxColumn.DataPropertyName = "QuantityOnHand";
            this.quantityOnHandDataGridViewTextBoxColumn.HeaderText = "QuantityOnHand";
            this.quantityOnHandDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityOnHandDataGridViewTextBoxColumn.Name = "quantityOnHandDataGridViewTextBoxColumn";
            this.quantityOnHandDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityReservedDataGridViewTextBoxColumn
            // 
            this.quantityReservedDataGridViewTextBoxColumn.DataPropertyName = "QuantityReserved";
            this.quantityReservedDataGridViewTextBoxColumn.HeaderText = "QuantityReserved";
            this.quantityReservedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityReservedDataGridViewTextBoxColumn.Name = "quantityReservedDataGridViewTextBoxColumn";
            this.quantityReservedDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityAvailableForSaleDataGridViewTextBoxColumn
            // 
            this.quantityAvailableForSaleDataGridViewTextBoxColumn.DataPropertyName = "QuantityAvailableForSale";
            this.quantityAvailableForSaleDataGridViewTextBoxColumn.HeaderText = "QuantityAvailableForSale";
            this.quantityAvailableForSaleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityAvailableForSaleDataGridViewTextBoxColumn.Name = "quantityAvailableForSaleDataGridViewTextBoxColumn";
            this.quantityAvailableForSaleDataGridViewTextBoxColumn.Width = 150;
            // 
            // lowStockPointDataGridViewTextBoxColumn
            // 
            this.lowStockPointDataGridViewTextBoxColumn.DataPropertyName = "LowStockPoint";
            this.lowStockPointDataGridViewTextBoxColumn.HeaderText = "LowStockPoint";
            this.lowStockPointDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lowStockPointDataGridViewTextBoxColumn.Name = "lowStockPointDataGridViewTextBoxColumn";
            this.lowStockPointDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastUpdatedDataGridViewTextBoxColumn
            // 
            this.lastUpdatedDataGridViewTextBoxColumn.DataPropertyName = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.HeaderText = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastUpdatedDataGridViewTextBoxColumn.Name = "lastUpdatedDataGridViewTextBoxColumn";
            this.lastUpdatedDataGridViewTextBoxColumn.Width = 150;
            // 
            // storeIdDataGridViewTextBoxColumn
            // 
            this.storeIdDataGridViewTextBoxColumn.DataPropertyName = "StoreId";
            this.storeIdDataGridViewTextBoxColumn.HeaderText = "StoreId";
            this.storeIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.storeIdDataGridViewTextBoxColumn.Name = "storeIdDataGridViewTextBoxColumn";
            this.storeIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // outOfStockPointDataGridViewTextBoxColumn
            // 
            this.outOfStockPointDataGridViewTextBoxColumn.DataPropertyName = "OutOfStockPoint";
            this.outOfStockPointDataGridViewTextBoxColumn.HeaderText = "OutOfStockPoint";
            this.outOfStockPointDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.outOfStockPointDataGridViewTextBoxColumn.Name = "outOfStockPointDataGridViewTextBoxColumn";
            this.outOfStockPointDataGridViewTextBoxColumn.Width = 150;
            // 
            // adatBindingSource
            // 
            this.adatBindingSource.DataSource = typeof(keszletezo.Model.Adat);
            // 
            // TablazatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 498);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.betoltesBtn);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Name = "TablazatForm";
            this.Text = "Listázás";
            this.Load += new System.EventHandler(this.dgv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn bvinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBvinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn variantIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityOnHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityReservedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityAvailableForSaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowStockPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outOfStockPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource adatBindingSource;
        private System.Windows.Forms.Button betoltesBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}