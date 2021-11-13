
namespace WindowsFormsApp2
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.abd_19DataSet = new WindowsFormsApp2.abd_19DataSet();
            this.abd19DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abd_19DataSet1 = new WindowsFormsApp2.abd_19DataSet1();
            this.prodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodTableAdapter = new WindowsFormsApp2.abd_19DataSet1TableAdapters.prodTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abd_19DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abd19DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abd_19DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Фильтрация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.prodBindingSource;
            this.comboBox1.DisplayMember = "kolvo";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 287);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "kolvo";
            // 
            // abd_19DataSet
            // 
            this.abd_19DataSet.DataSetName = "abd_19DataSet";
            this.abd_19DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // abd19DataSetBindingSource
            // 
            this.abd19DataSetBindingSource.DataSource = this.abd_19DataSet;
            this.abd19DataSetBindingSource.Position = 0;
            // 
            // abd_19DataSet1
            // 
            this.abd_19DataSet1.DataSetName = "abd_19DataSet1";
            this.abd_19DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodBindingSource
            // 
            this.prodBindingSource.DataMember = "prod";
            this.prodBindingSource.DataSource = this.abd_19DataSet1;
            // 
            // prodTableAdapter
            // 
            this.prodTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 420);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Прод";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abd_19DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abd19DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abd_19DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private abd_19DataSet abd_19DataSet;
        private System.Windows.Forms.BindingSource abd19DataSetBindingSource;
        private abd_19DataSet1 abd_19DataSet1;
        private System.Windows.Forms.BindingSource prodBindingSource;
        private abd_19DataSet1TableAdapters.prodTableAdapter prodTableAdapter;
    }
}