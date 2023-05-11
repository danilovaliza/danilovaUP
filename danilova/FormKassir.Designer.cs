
namespace danilova
{
    partial class FormKassir
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
            this.biletiDataSet1 = new danilova.BiletiDataSet1();
            this.biletiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biletiTableAdapter = new danilova.BiletiDataSet1TableAdapters.BiletiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nazvanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ryadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beiltiiiDataSet1 = new danilova.BeiltiiiDataSet1();
            this.view_2TableAdapter = new danilova.BeiltiiiDataSet1TableAdapters.View_2TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kodbiletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavozvrataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvovozvrataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozvratiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vozbratDataSet1 = new danilova.VozbratDataSet1();
            this.vozvratiTableAdapter = new danilova.VozbratDataSet1TableAdapters.VozvratiTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.danilovaaDataSet1 = new danilova.DanilovaaDataSet1();
            this.biletiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.biletiTableAdapter1 = new danilova.DanilovaaDataSet1TableAdapters.BiletiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.biletiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beiltiiiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozvratiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozbratDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danilovaaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // biletiDataSet1
            // 
            this.biletiDataSet1.DataSetName = "BiletiDataSet1";
            this.biletiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // biletiBindingSource
            // 
            this.biletiBindingSource.DataMember = "Bileti";
            this.biletiBindingSource.DataSource = this.biletiDataSet1;
            // 
            // biletiTableAdapter
            // 
            this.biletiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazvanieDataGridViewTextBoxColumn,
            this.mestoDataGridViewTextBoxColumn,
            this.ryadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.view2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 157);
            this.dataGridView1.TabIndex = 0;
            // 
            // nazvanieDataGridViewTextBoxColumn
            // 
            this.nazvanieDataGridViewTextBoxColumn.DataPropertyName = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.HeaderText = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.Name = "nazvanieDataGridViewTextBoxColumn";
            // 
            // mestoDataGridViewTextBoxColumn
            // 
            this.mestoDataGridViewTextBoxColumn.DataPropertyName = "Mesto";
            this.mestoDataGridViewTextBoxColumn.HeaderText = "Mesto";
            this.mestoDataGridViewTextBoxColumn.Name = "mestoDataGridViewTextBoxColumn";
            // 
            // ryadDataGridViewTextBoxColumn
            // 
            this.ryadDataGridViewTextBoxColumn.DataPropertyName = "Ryad";
            this.ryadDataGridViewTextBoxColumn.HeaderText = "Ryad";
            this.ryadDataGridViewTextBoxColumn.Name = "ryadDataGridViewTextBoxColumn";
            // 
            // view2BindingSource
            // 
            this.view2BindingSource.DataMember = "View_2";
            this.view2BindingSource.DataSource = this.beiltiiiDataSet1;
            // 
            // beiltiiiDataSet1
            // 
            this.beiltiiiDataSet1.DataSetName = "BeiltiiiDataSet1";
            this.beiltiiiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_2TableAdapter
            // 
            this.view_2TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поступившие заказы:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(422, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Поиск:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodbiletaDataGridViewTextBoxColumn,
            this.datavozvrataDataGridViewTextBoxColumn,
            this.kolvovozvrataDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.vozvratiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 205);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(343, 150);
            this.dataGridView2.TabIndex = 6;
            // 
            // kodbiletaDataGridViewTextBoxColumn
            // 
            this.kodbiletaDataGridViewTextBoxColumn.DataPropertyName = "Kod_bileta";
            this.kodbiletaDataGridViewTextBoxColumn.HeaderText = "Kod_bileta";
            this.kodbiletaDataGridViewTextBoxColumn.Name = "kodbiletaDataGridViewTextBoxColumn";
            // 
            // datavozvrataDataGridViewTextBoxColumn
            // 
            this.datavozvrataDataGridViewTextBoxColumn.DataPropertyName = "Data_vozvrata";
            this.datavozvrataDataGridViewTextBoxColumn.HeaderText = "Data_vozvrata";
            this.datavozvrataDataGridViewTextBoxColumn.Name = "datavozvrataDataGridViewTextBoxColumn";
            // 
            // kolvovozvrataDataGridViewTextBoxColumn
            // 
            this.kolvovozvrataDataGridViewTextBoxColumn.DataPropertyName = "Kol-vo_vozvrata";
            this.kolvovozvrataDataGridViewTextBoxColumn.HeaderText = "Kol-vo_vozvrata";
            this.kolvovozvrataDataGridViewTextBoxColumn.Name = "kolvovozvrataDataGridViewTextBoxColumn";
            // 
            // vozvratiBindingSource
            // 
            this.vozvratiBindingSource.DataMember = "Vozvrati";
            this.vozvratiBindingSource.DataSource = this.vozbratDataSet1;
            // 
            // vozbratDataSet1
            // 
            this.vozbratDataSet1.DataSetName = "VozbratDataSet1";
            this.vozbratDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vozvratiTableAdapter
            // 
            this.vozvratiTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Возвраты:\r\n";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Оформление возврата:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DataSource = this.biletiBindingSource1;
            this.comboBox1.DisplayMember = "Kod_bileta";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(434, 217);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "Kod_bileta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(437, 256);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(449, 295);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Билет №:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Дата\r\nвозврата:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Количество:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(504, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Оформить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(12, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(93, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(255, 363);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 18;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(207, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Поиск:";
            // 
            // danilovaaDataSet1
            // 
            this.danilovaaDataSet1.DataSetName = "DanilovaaDataSet1";
            this.danilovaaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // biletiBindingSource1
            // 
            this.biletiBindingSource1.DataMember = "Bileti";
            this.biletiBindingSource1.DataSource = this.danilovaaDataSet1;
            // 
            // biletiTableAdapter1
            // 
            this.biletiTableAdapter1.ClearBeforeFill = true;
            // 
            // FormKassir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(591, 398);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(907, 737);
            this.MinimumSize = new System.Drawing.Size(607, 437);
            this.Name = "FormKassir";
            this.Text = "Форма кассира";
            this.Load += new System.EventHandler(this.FormKassir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biletiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beiltiiiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozvratiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozbratDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danilovaaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BiletiDataSet1 biletiDataSet1;
        private System.Windows.Forms.BindingSource biletiBindingSource;
        private BiletiDataSet1TableAdapters.BiletiTableAdapter biletiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BeiltiiiDataSet1 beiltiiiDataSet1;
        private System.Windows.Forms.BindingSource view2BindingSource;
        private BeiltiiiDataSet1TableAdapters.View_2TableAdapter view_2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ryadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private VozbratDataSet1 vozbratDataSet1;
        private System.Windows.Forms.BindingSource vozvratiBindingSource;
        private VozbratDataSet1TableAdapters.VozvratiTableAdapter vozvratiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodbiletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavozvrataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvovozvrataDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private DanilovaaDataSet1 danilovaaDataSet1;
        private System.Windows.Forms.BindingSource biletiBindingSource1;
        private DanilovaaDataSet1TableAdapters.BiletiTableAdapter biletiTableAdapter1;
    }
}