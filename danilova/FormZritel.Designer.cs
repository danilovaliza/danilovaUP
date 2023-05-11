
namespace danilova
{
    partial class FormZritel
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
            this.spektakeliDataSet = new danilova.SpektakeliDataSet();
            this.view1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_1TableAdapter = new danilova.SpektakeliDataSetTableAdapters.View_1TableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.spektakliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spektakelDataSet = new danilova.SpektakelDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.spektakliTableAdapter = new danilova.SpektakelDataSetTableAdapters.SpektakliTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nazvanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Janr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vremya_nachala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vremya_okonchanie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spektakliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.showsDataSet1 = new danilova.ShowsDataSet1();
            this.spektakliTableAdapter1 = new danilova.ShowsDataSet1TableAdapters.SpektakliTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spektakeliDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spektakliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spektakelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spektakliBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // spektakeliDataSet
            // 
            this.spektakeliDataSet.DataSetName = "SpektakeliDataSet";
            this.spektakeliDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view1BindingSource
            // 
            this.view1BindingSource.DataMember = "View_1";
            this.view1BindingSource.DataSource = this.spektakeliDataSet;
            // 
            // view_1TableAdapter
            // 
            this.view_1TableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(68, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Заказ билета:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Название:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ряд:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Место:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(167, 282);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(55, 282);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(58, 20);
            this.textBox3.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DataSource = this.spektakliBindingSource;
            this.comboBox1.DisplayMember = "Nazvanie";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "Nazvanie";
            // 
            // spektakliBindingSource
            // 
            this.spektakliBindingSource.DataMember = "Spektakli";
            this.spektakliBindingSource.DataSource = this.spektakelDataSet;
            // 
            // spektakelDataSet
            // 
            this.spektakelDataSet.DataSetName = "SpektakelDataSet";
            this.spektakelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(23, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Заказать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // spektakliTableAdapter
            // 
            this.spektakliTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazvanieDataGridViewTextBoxColumn,
            this.Janr,
            this.Vremya_nachala,
            this.Vremya_okonchanie,
            this.Sena});
            this.dataGridView1.DataSource = this.spektakliBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 180);
            this.dataGridView1.TabIndex = 11;
            // 
            // nazvanieDataGridViewTextBoxColumn
            // 
            this.nazvanieDataGridViewTextBoxColumn.DataPropertyName = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.HeaderText = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.Name = "nazvanieDataGridViewTextBoxColumn";
            // 
            // Janr
            // 
            this.Janr.DataPropertyName = "Janr";
            this.Janr.HeaderText = "Janr";
            this.Janr.Name = "Janr";
            // 
            // Vremya_nachala
            // 
            this.Vremya_nachala.DataPropertyName = "Vremya_nachala";
            this.Vremya_nachala.HeaderText = "Vremya_nachala";
            this.Vremya_nachala.Name = "Vremya_nachala";
            // 
            // Vremya_okonchanie
            // 
            this.Vremya_okonchanie.DataPropertyName = "Vremya_okonchanie";
            this.Vremya_okonchanie.HeaderText = "Vremya_okonchanie";
            this.Vremya_okonchanie.Name = "Vremya_okonchanie";
            // 
            // Sena
            // 
            this.Sena.DataPropertyName = "Sena";
            this.Sena.HeaderText = "Sena";
            this.Sena.Name = "Sena";
            // 
            // spektakliBindingSource1
            // 
            this.spektakliBindingSource1.DataMember = "Spektakli";
            this.spektakliBindingSource1.DataSource = this.showsDataSet1;
            // 
            // showsDataSet1
            // 
            this.showsDataSet1.DataSetName = "ShowsDataSet1";
            this.showsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spektakliTableAdapter1
            // 
            this.spektakliTableAdapter1.ClearBeforeFill = true;
            // 
            // FormZritel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 360);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(785, 599);
            this.MinimumSize = new System.Drawing.Size(585, 399);
            this.Name = "FormZritel";
            this.Text = "Форма зрителя";
            this.Load += new System.EventHandler(this.FormZritel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spektakeliDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spektakliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spektakelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spektakliBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SpektakeliDataSet spektakeliDataSet;
        private System.Windows.Forms.BindingSource view1BindingSource;
        private SpektakeliDataSetTableAdapters.View_1TableAdapter view_1TableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private SpektakelDataSet spektakelDataSet;
        private System.Windows.Forms.BindingSource spektakliBindingSource;
        private SpektakelDataSetTableAdapters.SpektakliTableAdapter spektakliTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ShowsDataSet1 showsDataSet1;
        private System.Windows.Forms.BindingSource spektakliBindingSource1;
        private ShowsDataSet1TableAdapters.SpektakliTableAdapter spektakliTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Janr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vremya_nachala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vremya_okonchanie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sena;
    }
}