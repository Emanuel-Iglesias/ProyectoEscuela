namespace ProyectoEscuela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bdEscuelaDataSet = new ProyectoEscuela.bdEscuelaDataSet();
            this.tbCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCursoTableAdapter = new ProyectoEscuela.bdEscuelaDataSetTableAdapters.tbCursoTableAdapter();
            this.tableAdapterManager = new ProyectoEscuela.bdEscuelaDataSetTableAdapters.TableAdapterManager();
            this.tbCursoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tbCursoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbCursoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbGradoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbGradoTableAdapter = new ProyectoEscuela.bdEscuelaDataSetTableAdapters.tbGradoTableAdapter();
            this.tbGradoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbEstudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbEstudianteTableAdapter = new ProyectoEscuela.bdEscuelaDataSetTableAdapters.tbEstudianteTableAdapter();
            this.tbEstudianteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdEscuelaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCursoBindingNavigator)).BeginInit();
            this.tbCursoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCursoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGradoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGradoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEstudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEstudianteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bdEscuelaDataSet
            // 
            this.bdEscuelaDataSet.DataSetName = "bdEscuelaDataSet";
            this.bdEscuelaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbCursoBindingSource
            // 
            this.tbCursoBindingSource.DataMember = "tbCurso";
            this.tbCursoBindingSource.DataSource = this.bdEscuelaDataSet;
            // 
            // tbCursoTableAdapter
            // 
            this.tbCursoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbCursoTableAdapter = this.tbCursoTableAdapter;
            this.tableAdapterManager.tbEstudianteTableAdapter = this.tbEstudianteTableAdapter;
            this.tableAdapterManager.tbGradoTableAdapter = this.tbGradoTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProyectoEscuela.bdEscuelaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbCursoBindingNavigator
            // 
            this.tbCursoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbCursoBindingNavigator.BindingSource = this.tbCursoBindingSource;
            this.tbCursoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbCursoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbCursoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbCursoBindingNavigatorSaveItem});
            this.tbCursoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbCursoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbCursoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbCursoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbCursoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbCursoBindingNavigator.Name = "tbCursoBindingNavigator";
            this.tbCursoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbCursoBindingNavigator.Size = new System.Drawing.Size(1018, 25);
            this.tbCursoBindingNavigator.TabIndex = 0;
            this.tbCursoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // tbCursoBindingNavigatorSaveItem
            // 
            this.tbCursoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCursoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbCursoBindingNavigatorSaveItem.Image")));
            this.tbCursoBindingNavigatorSaveItem.Name = "tbCursoBindingNavigatorSaveItem";
            this.tbCursoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbCursoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tbCursoBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbCursoBindingNavigatorSaveItem_Click);
            // 
            // tbCursoDataGridView
            // 
            this.tbCursoDataGridView.AutoGenerateColumns = false;
            this.tbCursoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbCursoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tbCursoDataGridView.DataSource = this.tbCursoBindingSource;
            this.tbCursoDataGridView.Location = new System.Drawing.Point(545, 94);
            this.tbCursoDataGridView.Name = "tbCursoDataGridView";
            this.tbCursoDataGridView.Size = new System.Drawing.Size(338, 220);
            this.tbCursoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCurso";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdCurso";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreCurso";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombreCurso";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdGrado";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdGrado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // tbGradoBindingSource
            // 
            this.tbGradoBindingSource.DataMember = "tbGrado";
            this.tbGradoBindingSource.DataSource = this.bdEscuelaDataSet;
            // 
            // tbGradoTableAdapter
            // 
            this.tbGradoTableAdapter.ClearBeforeFill = true;
            // 
            // tbGradoDataGridView
            // 
            this.tbGradoDataGridView.AutoGenerateColumns = false;
            this.tbGradoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbGradoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tbGradoDataGridView.DataSource = this.tbGradoBindingSource;
            this.tbGradoDataGridView.Location = new System.Drawing.Point(120, 94);
            this.tbGradoDataGridView.Name = "tbGradoDataGridView";
            this.tbGradoDataGridView.Size = new System.Drawing.Size(300, 220);
            this.tbGradoDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdGrado";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdGrado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NombreGrado";
            this.dataGridViewTextBoxColumn5.HeaderText = "NombreGrado";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tbEstudianteBindingSource
            // 
            this.tbEstudianteBindingSource.DataMember = "tbEstudiante";
            this.tbEstudianteBindingSource.DataSource = this.bdEscuelaDataSet;
            // 
            // tbEstudianteTableAdapter
            // 
            this.tbEstudianteTableAdapter.ClearBeforeFill = true;
            // 
            // tbEstudianteDataGridView
            // 
            this.tbEstudianteDataGridView.AutoGenerateColumns = false;
            this.tbEstudianteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbEstudianteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.tbEstudianteDataGridView.DataSource = this.tbEstudianteBindingSource;
            this.tbEstudianteDataGridView.Location = new System.Drawing.Point(130, 401);
            this.tbEstudianteDataGridView.Name = "tbEstudianteDataGridView";
            this.tbEstudianteDataGridView.Size = new System.Drawing.Size(715, 220);
            this.tbEstudianteDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdEstudiante";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdEstudiante";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn8.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Edad";
            this.dataGridViewTextBoxColumn9.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "IdGrado";
            this.dataGridViewTextBoxColumn10.HeaderText = "IdGrado";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "IdCurso";
            this.dataGridViewTextBoxColumn11.HeaderText = "IdCurso";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(124, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Grados Disponibles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(557, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cursos Disponibles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(320, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Estudiantes Inscritos";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1018, 679);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEstudianteDataGridView);
            this.Controls.Add(this.tbGradoDataGridView);
            this.Controls.Add(this.tbCursoDataGridView);
            this.Controls.Add(this.tbCursoBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdEscuelaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCursoBindingNavigator)).EndInit();
            this.tbCursoBindingNavigator.ResumeLayout(false);
            this.tbCursoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCursoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGradoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGradoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEstudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEstudianteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdEscuelaDataSet bdEscuelaDataSet;
        private System.Windows.Forms.BindingSource tbCursoBindingSource;
        private bdEscuelaDataSetTableAdapters.tbCursoTableAdapter tbCursoTableAdapter;
        private bdEscuelaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbCursoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbCursoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tbCursoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private bdEscuelaDataSetTableAdapters.tbGradoTableAdapter tbGradoTableAdapter;
        private System.Windows.Forms.BindingSource tbGradoBindingSource;
        private bdEscuelaDataSetTableAdapters.tbEstudianteTableAdapter tbEstudianteTableAdapter;
        private System.Windows.Forms.DataGridView tbGradoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource tbEstudianteBindingSource;
        private System.Windows.Forms.DataGridView tbEstudianteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}