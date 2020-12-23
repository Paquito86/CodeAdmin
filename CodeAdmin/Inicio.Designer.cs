
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
            this.paco_codeadminDataSet = new CodeAdmin.paco_codeadminDataSet();
            this.cadfeaturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cad_featuresTableAdapter = new CodeAdmin.paco_codeadminDataSetTableAdapters.cad_featuresTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.fcodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fprojectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paco_codeadminDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadfeaturesBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1063, 268);
            this.dataGridView1.TabIndex = 1;
            // 
            // paco_codeadminDataSet
            // 
            this.paco_codeadminDataSet.DataSetName = "paco_codeadminDataSet";
            this.paco_codeadminDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadfeaturesBindingSource
            // 
            this.cadfeaturesBindingSource.DataMember = "cad_features";
            this.cadfeaturesBindingSource.DataSource = this.paco_codeadminDataSet;
            // 
            // cad_featuresTableAdapter
            // 
            this.cad_featuresTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Características (Features):";
            // 
            // fcodDataGridViewTextBoxColumn
            // 
            this.fcodDataGridViewTextBoxColumn.DataPropertyName = "Fcod";
            this.fcodDataGridViewTextBoxColumn.HeaderText = "Feature Code";
            this.fcodDataGridViewTextBoxColumn.Name = "fcodDataGridViewTextBoxColumn";
            this.fcodDataGridViewTextBoxColumn.Width = 88;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Feature Name";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.Width = 91;
            // 
            // fdescriptionDataGridViewTextBoxColumn
            // 
            this.fdescriptionDataGridViewTextBoxColumn.DataPropertyName = "Fdescription";
            this.fdescriptionDataGridViewTextBoxColumn.HeaderText = "Feature Description";
            this.fdescriptionDataGridViewTextBoxColumn.Name = "fdescriptionDataGridViewTextBoxColumn";
            this.fdescriptionDataGridViewTextBoxColumn.Width = 114;
            // 
            // fprojectDataGridViewTextBoxColumn
            // 
            this.fprojectDataGridViewTextBoxColumn.DataPropertyName = "Fproject";
            this.fprojectDataGridViewTextBoxColumn.HeaderText = "Linked Project";
            this.fprojectDataGridViewTextBoxColumn.Name = "fprojectDataGridViewTextBoxColumn";
            this.fprojectDataGridViewTextBoxColumn.Width = 92;
            // 
            // fcategoryDataGridViewTextBoxColumn
            // 
            this.fcategoryDataGridViewTextBoxColumn.DataPropertyName = "Fcategory";
            this.fcategoryDataGridViewTextBoxColumn.HeaderText = "Linked Category";
            this.fcategoryDataGridViewTextBoxColumn.Name = "fcategoryDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 718);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CodeAdmin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paco_codeadminDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadfeaturesBindingSource)).EndInit();
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
    }
}

