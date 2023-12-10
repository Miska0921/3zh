namespace _3zh
{
    partial class dataview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            brandBindingSource = new BindingSource(components);
            modelBindingSource = new BindingSource(components);
            upForSaleBindingSource = new BindingSource(components);
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttondelete = new Button();
            bindingSource1 = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            modelIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horsepowerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fuelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sellerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mileageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upForSaleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, brandIdDataGridViewTextBoxColumn, modelIdDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, horsepowerDataGridViewTextBoxColumn, fuelDataGridViewTextBoxColumn, sellerDataGridViewTextBoxColumn, mileageDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn });
            dataGridView1.DataSource = upForSaleBindingSource;
            dataGridView1.Location = new Point(221, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(345, 333);
            dataGridView1.TabIndex = 0;
            // 
            // brandBindingSource
            // 
            brandBindingSource.DataSource = typeof(Models.Brand);
            // 
            // modelBindingSource
            // 
            modelBindingSource.DataSource = typeof(Models.Model);
            // 
            // upForSaleBindingSource
            // 
            upForSaleBindingSource.DataSource = typeof(Models.UpForSale);
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 62);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(121, 319);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(130, 62);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(85, 319);
            listBox2.TabIndex = 2;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 33);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(85, 23);
            textBox2.TabIndex = 4;
            // 
            // buttondelete
            // 
            buttondelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttondelete.Location = new Point(462, 372);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(117, 49);
            buttondelete.TabIndex = 5;
            buttondelete.Text = "Kiválasztott hirdetés törlése";
            buttondelete.UseVisualStyleBackColor = true;
            buttondelete.Click += buttondelete_Click;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // brandIdDataGridViewTextBoxColumn
            // 
            brandIdDataGridViewTextBoxColumn.DataPropertyName = "BrandId";
            brandIdDataGridViewTextBoxColumn.DataSource = brandBindingSource;
            brandIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            brandIdDataGridViewTextBoxColumn.HeaderText = "BrandId";
            brandIdDataGridViewTextBoxColumn.Name = "brandIdDataGridViewTextBoxColumn";
            brandIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            brandIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            brandIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // modelIdDataGridViewTextBoxColumn
            // 
            modelIdDataGridViewTextBoxColumn.DataPropertyName = "ModelId";
            modelIdDataGridViewTextBoxColumn.DataSource = modelBindingSource;
            modelIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            modelIdDataGridViewTextBoxColumn.HeaderText = "ModelId";
            modelIdDataGridViewTextBoxColumn.Name = "modelIdDataGridViewTextBoxColumn";
            modelIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            modelIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            modelIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // horsepowerDataGridViewTextBoxColumn
            // 
            horsepowerDataGridViewTextBoxColumn.DataPropertyName = "Horsepower";
            horsepowerDataGridViewTextBoxColumn.HeaderText = "Horsepower";
            horsepowerDataGridViewTextBoxColumn.Name = "horsepowerDataGridViewTextBoxColumn";
            // 
            // fuelDataGridViewTextBoxColumn
            // 
            fuelDataGridViewTextBoxColumn.DataPropertyName = "Fuel";
            fuelDataGridViewTextBoxColumn.HeaderText = "Fuel";
            fuelDataGridViewTextBoxColumn.Name = "fuelDataGridViewTextBoxColumn";
            // 
            // sellerDataGridViewTextBoxColumn
            // 
            sellerDataGridViewTextBoxColumn.DataPropertyName = "Seller";
            sellerDataGridViewTextBoxColumn.HeaderText = "Seller";
            sellerDataGridViewTextBoxColumn.Name = "sellerDataGridViewTextBoxColumn";
            // 
            // mileageDataGridViewTextBoxColumn
            // 
            mileageDataGridViewTextBoxColumn.DataPropertyName = "Mileage";
            mileageDataGridViewTextBoxColumn.HeaderText = "Mileage";
            mileageDataGridViewTextBoxColumn.Name = "mileageDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            modelDataGridViewTextBoxColumn.HeaderText = "Model";
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // dataview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttondelete);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Name = "dataview";
            Size = new Size(582, 424);
            Load += dataview_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)modelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)upForSaleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ListBox listBox1;
        private ListBox listBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttondelete;
        private BindingSource bindingSource1;
        private BindingSource brandBindingSource;
        private BindingSource upForSaleBindingSource;
        private BindingSource modelBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn brandIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn modelIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horsepowerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fuelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sellerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mileageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
    }
}
