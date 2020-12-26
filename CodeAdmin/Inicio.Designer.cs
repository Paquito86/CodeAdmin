
namespace CodeAdmin
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fcodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fprojectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadfeaturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paco_codeadminDataSet = new CodeAdmin.paco_codeadminDataSet();
            this.cad_featuresTableAdapter = new CodeAdmin.paco_codeadminDataSetTableAdapters.cad_featuresTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFSave = new System.Windows.Forms.Button();
            this.comboBoxFCategory = new System.Windows.Forms.ComboBox();
            this.cadcategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxFProject = new System.Windows.Forms.ComboBox();
            this.cadprojectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFDescription = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cad_projectsTableAdapter = new CodeAdmin.paco_codeadminDataSetTableAdapters.cad_projectsTableAdapter();
            this.cad_categoriesTableAdapter = new CodeAdmin.paco_codeadminDataSetTableAdapters.cad_categoriesTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadfeaturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paco_codeadminDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadcategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadprojectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Software de Gestión de Características e Ideas para Softwares";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fcodDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.fdescriptionDataGridViewTextBoxColumn,
            this.fprojectDataGridViewTextBoxColumn,
            this.fcategoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cadfeaturesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 268);
            this.dataGridView1.TabIndex = 1;
            // 
            // fcodDataGridViewTextBoxColumn
            // 
            this.fcodDataGridViewTextBoxColumn.DataPropertyName = "Fcod";
            this.fcodDataGridViewTextBoxColumn.HeaderText = "Feature Code";
            this.fcodDataGridViewTextBoxColumn.Name = "fcodDataGridViewTextBoxColumn";
            this.fcodDataGridViewTextBoxColumn.ReadOnly = true;
            this.fcodDataGridViewTextBoxColumn.Width = 88;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Feature Name";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fnameDataGridViewTextBoxColumn.Width = 91;
            // 
            // fdescriptionDataGridViewTextBoxColumn
            // 
            this.fdescriptionDataGridViewTextBoxColumn.DataPropertyName = "Fdescription";
            this.fdescriptionDataGridViewTextBoxColumn.HeaderText = "Feature Description";
            this.fdescriptionDataGridViewTextBoxColumn.Name = "fdescriptionDataGridViewTextBoxColumn";
            this.fdescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fdescriptionDataGridViewTextBoxColumn.Width = 114;
            // 
            // fprojectDataGridViewTextBoxColumn
            // 
            this.fprojectDataGridViewTextBoxColumn.DataPropertyName = "Fproject";
            this.fprojectDataGridViewTextBoxColumn.HeaderText = "Linked Project";
            this.fprojectDataGridViewTextBoxColumn.Name = "fprojectDataGridViewTextBoxColumn";
            this.fprojectDataGridViewTextBoxColumn.ReadOnly = true;
            this.fprojectDataGridViewTextBoxColumn.Width = 92;
            // 
            // fcategoryDataGridViewTextBoxColumn
            // 
            this.fcategoryDataGridViewTextBoxColumn.DataPropertyName = "Fcategory";
            this.fcategoryDataGridViewTextBoxColumn.HeaderText = "Linked Category";
            this.fcategoryDataGridViewTextBoxColumn.Name = "fcategoryDataGridViewTextBoxColumn";
            this.fcategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cadfeaturesBindingSource
            // 
            this.cadfeaturesBindingSource.DataMember = "cad_features";
            this.cadfeaturesBindingSource.DataSource = this.paco_codeadminDataSet;
            // 
            // paco_codeadminDataSet
            // 
            this.paco_codeadminDataSet.DataSetName = "paco_codeadminDataSet";
            this.paco_codeadminDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cad_featuresTableAdapter
            // 
            this.cad_featuresTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Características (Features):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFSave);
            this.groupBox1.Controls.Add(this.comboBoxFCategory);
            this.groupBox1.Controls.Add(this.comboBoxFProject);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxFDescription);
            this.groupBox1.Controls.Add(this.textBoxFName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11F);
            this.groupBox1.Location = new System.Drawing.Point(12, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 339);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear nueva Feature:";
            // 
            // buttonFSave
            // 
            this.buttonFSave.Location = new System.Drawing.Point(375, 16);
            this.buttonFSave.Name = "buttonFSave";
            this.buttonFSave.Size = new System.Drawing.Size(150, 56);
            this.buttonFSave.TabIndex = 8;
            this.buttonFSave.Text = "Guardar Nueva Feature";
            this.buttonFSave.UseVisualStyleBackColor = true;
            this.buttonFSave.Click += new System.EventHandler(this.ButtonFSave_Click);
            // 
            // comboBoxFCategory
            // 
            this.comboBoxFCategory.DataSource = this.cadcategoriesBindingSource;
            this.comboBoxFCategory.DisplayMember = "Cname";
            this.comboBoxFCategory.Font = new System.Drawing.Font("Verdana", 8F);
            this.comboBoxFCategory.FormattingEnabled = true;
            this.comboBoxFCategory.Location = new System.Drawing.Point(254, 303);
            this.comboBoxFCategory.Name = "comboBoxFCategory";
            this.comboBoxFCategory.Size = new System.Drawing.Size(240, 21);
            this.comboBoxFCategory.TabIndex = 7;
            this.comboBoxFCategory.ValueMember = "Ccod";
            // 
            // cadcategoriesBindingSource
            // 
            this.cadcategoriesBindingSource.DataMember = "cad_categories";
            this.cadcategoriesBindingSource.DataSource = this.paco_codeadminDataSet;
            // 
            // comboBoxFProject
            // 
            this.comboBoxFProject.DataSource = this.cadprojectsBindingSource;
            this.comboBoxFProject.DisplayMember = "Pname";
            this.comboBoxFProject.Font = new System.Drawing.Font("Verdana", 8F);
            this.comboBoxFProject.FormattingEnabled = true;
            this.comboBoxFProject.Location = new System.Drawing.Point(9, 303);
            this.comboBoxFProject.Name = "comboBoxFProject";
            this.comboBoxFProject.Size = new System.Drawing.Size(239, 21);
            this.comboBoxFProject.TabIndex = 6;
            this.comboBoxFProject.ValueMember = "Pcode";
            // 
            // cadprojectsBindingSource
            // 
            this.cadprojectsBindingSource.DataMember = "cad_projects";
            this.cadprojectsBindingSource.DataSource = this.paco_codeadminDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8F);
            this.label6.Location = new System.Drawing.Point(251, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Asociar a una Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8F);
            this.label5.Location = new System.Drawing.Point(6, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Asociar a un Project:";
            // 
            // textBoxFDescription
            // 
            this.textBoxFDescription.Location = new System.Drawing.Point(9, 110);
            this.textBoxFDescription.Multiline = true;
            this.textBoxFDescription.Name = "textBoxFDescription";
            this.textBoxFDescription.Size = new System.Drawing.Size(322, 173);
            this.textBoxFDescription.TabIndex = 3;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(9, 55);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(322, 25);
            this.textBoxFName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8F);
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8F);
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // cad_projectsTableAdapter
            // 
            this.cad_projectsTableAdapter.ClearBeforeFill = true;
            // 
            // cad_categoriesTableAdapter
            // 
            this.cad_categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(549, 353);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(594, 353);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(39, 20);
            this.textBox2.TabIndex = 5;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 683);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "CodeAdmin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadfeaturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paco_codeadminDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadcategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadprojectsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private paco_codeadminDataSet paco_codeadminDataSet;
        private System.Windows.Forms.BindingSource cadfeaturesBindingSource;
        private paco_codeadminDataSetTableAdapters.cad_featuresTableAdapter cad_featuresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fcodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fprojectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFDescription;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFSave;
        private System.Windows.Forms.ComboBox comboBoxFCategory;
        private System.Windows.Forms.ComboBox comboBoxFProject;
        private System.Windows.Forms.BindingSource cadprojectsBindingSource;
        private paco_codeadminDataSetTableAdapters.cad_projectsTableAdapter cad_projectsTableAdapter;
        private System.Windows.Forms.BindingSource cadcategoriesBindingSource;
        private paco_codeadminDataSetTableAdapters.cad_categoriesTableAdapter cad_categoriesTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

