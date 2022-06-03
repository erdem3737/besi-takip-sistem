namespace Besin_Ön_Takip
{
    partial class Form2
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
            this.gvMalzemeler = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMarkasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBirim = new System.Windows.Forms.ComboBox();
            this.tbMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btEkle = new System.Windows.Forms.Button();
            this.bilgiDataSet = new Besin_Ön_Takip.bilgiDataSet();
            this.veriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veriTableAdapter = new Besin_Ön_Takip.bilgiDataSetTableAdapters.veriTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvMalzemeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gvMalzemeler
            // 
            this.gvMalzemeler.AllowUserToOrderColumns = true;
            this.gvMalzemeler.AutoGenerateColumns = false;
            this.gvMalzemeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvMalzemeler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gvMalzemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMalzemeler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.maDataGridViewTextBoxColumn,
            this.mbDataGridViewTextBoxColumn,
            this.mmDataGridViewTextBoxColumn});
            this.gvMalzemeler.DataSource = this.veriBindingSource;
            this.gvMalzemeler.Location = new System.Drawing.Point(3, 250);
            this.gvMalzemeler.Margin = new System.Windows.Forms.Padding(2);
            this.gvMalzemeler.Name = "gvMalzemeler";
            this.gvMalzemeler.RowTemplate.Height = 24;
            this.gvMalzemeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMalzemeler.Size = new System.Drawing.Size(455, 161);
            this.gvMalzemeler.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(125, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Birimi";
            // 
            // tbMarkasi
            // 
            this.tbMarkasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMarkasi.Location = new System.Drawing.Point(230, 94);
            this.tbMarkasi.Margin = new System.Windows.Forms.Padding(2);
            this.tbMarkasi.Name = "tbMarkasi";
            this.tbMarkasi.Size = new System.Drawing.Size(167, 29);
            this.tbMarkasi.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(109, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Markası";
            // 
            // cbBirim
            // 
            this.cbBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBirim.FormattingEnabled = true;
            this.cbBirim.Items.AddRange(new object[] {
            "Kg",
            "Ton",
            "Tane "});
            this.cbBirim.Location = new System.Drawing.Point(230, 54);
            this.cbBirim.Margin = new System.Windows.Forms.Padding(2);
            this.cbBirim.Name = "cbBirim";
            this.cbBirim.Size = new System.Drawing.Size(167, 32);
            this.cbBirim.TabIndex = 16;
            this.cbBirim.SelectedIndexChanged += new System.EventHandler(this.cbBirim_SelectedIndexChanged);
            // 
            // tbMalzemeAdi
            // 
            this.tbMalzemeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMalzemeAdi.Location = new System.Drawing.Point(230, 17);
            this.tbMalzemeAdi.Margin = new System.Windows.Forms.Padding(2);
            this.tbMalzemeAdi.Name = "tbMalzemeAdi";
            this.tbMalzemeAdi.Size = new System.Drawing.Size(167, 29);
            this.tbMalzemeAdi.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(65, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Malzeme Adı:";
            // 
            // btEkle
            // 
            this.btEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btEkle.Location = new System.Drawing.Point(23, 136);
            this.btEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btEkle.Name = "btEkle";
            this.btEkle.Size = new System.Drawing.Size(373, 37);
            this.btEkle.TabIndex = 13;
            this.btEkle.Text = "Ekle";
            this.btEkle.UseVisualStyleBackColor = true;
            this.btEkle.Click += new System.EventHandler(this.btEkle_Click);
            // 
            // bilgiDataSet
            // 
            this.bilgiDataSet.DataSetName = "bilgiDataSet";
            this.bilgiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veriBindingSource
            // 
            this.veriBindingSource.DataMember = "veri";
            this.veriBindingSource.DataSource = this.bilgiDataSet;
            // 
            // veriTableAdapter
            // 
            this.veriTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // maDataGridViewTextBoxColumn
            // 
            this.maDataGridViewTextBoxColumn.DataPropertyName = "m_a";
            this.maDataGridViewTextBoxColumn.HeaderText = "Malzeme Adı";
            this.maDataGridViewTextBoxColumn.Name = "maDataGridViewTextBoxColumn";
            // 
            // mbDataGridViewTextBoxColumn
            // 
            this.mbDataGridViewTextBoxColumn.DataPropertyName = "m_b";
            this.mbDataGridViewTextBoxColumn.HeaderText = "Malzeme Birimi";
            this.mbDataGridViewTextBoxColumn.Name = "mbDataGridViewTextBoxColumn";
            // 
            // mmDataGridViewTextBoxColumn
            // 
            this.mmDataGridViewTextBoxColumn.DataPropertyName = "m_m";
            this.mmDataGridViewTextBoxColumn.HeaderText = "Malzeme Markası";
            this.mmDataGridViewTextBoxColumn.Name = "mmDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 408);
            this.Controls.Add(this.gvMalzemeler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMarkasi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBirim);
            this.Controls.Add(this.tbMalzemeAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEkle);
            this.Name = "Form2";
            this.Text = "Takip Bölümü";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMalzemeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvMalzemeler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMarkasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBirim;
        private System.Windows.Forms.TextBox tbMalzemeAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEkle;
        private bilgiDataSet bilgiDataSet;
        private System.Windows.Forms.BindingSource veriBindingSource;
        private bilgiDataSetTableAdapters.veriTableAdapter veriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mmDataGridViewTextBoxColumn;
    }
}