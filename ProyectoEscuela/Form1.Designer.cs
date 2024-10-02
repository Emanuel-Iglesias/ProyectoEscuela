namespace ProyectoEscuela
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdGradoGrado = new System.Windows.Forms.TextBox();
            this.txtNombreGrado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIngresarGrado = new System.Windows.Forms.Button();
            this.btnActualizarGrado = new System.Windows.Forms.Button();
            this.btnEliminarGrado = new System.Windows.Forms.Button();
            this.btnEliminarCursos = new System.Windows.Forms.Button();
            this.btnActualizarCursos = new System.Windows.Forms.Button();
            this.btnIngresarCursos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.txtIdCursoCursos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdGradoCursos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApellidoEstudiante = new System.Windows.Forms.TextBox();
            this.btnEliminarEstudiante = new System.Windows.Forms.Button();
            this.btnActualizarEstudiante = new System.Windows.Forms.Button();
            this.btnIngresarEstudiante = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.txtIdEstudiante = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIdGradoEstudiante = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIdCursoEstudiante = new System.Windows.Forms.TextBox();
            this.txtEdadEstudiante = new System.Windows.Forms.TextBox();
            this.bdEscuelaDataSet1 = new ProyectoEscuela.bdEscuelaDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbCursoTableAdapter = new ProyectoEscuela.bdEscuelaDataSetTableAdapters.tbCursoTableAdapter();
            this.bdEscuelaDataSet2 = new ProyectoEscuela.bdEscuelaDataSet();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbEstudianteTableAdapter = new ProyectoEscuela.bdEscuelaDataSetTableAdapters.tbEstudianteTableAdapter();
            this.bdEscuelaDataSet3 = new ProyectoEscuela.bdEscuelaDataSet();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tbGradoTableAdapter = new ProyectoEscuela.bdEscuelaDataSetTableAdapters.tbGradoTableAdapter();
            this.tableAdapterManager = new ProyectoEscuela.bdEscuelaDataSetTableAdapters.TableAdapterManager();
            this.btnRegistros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdEscuelaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdEscuelaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdEscuelaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(393, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 65);
            this.label2.TabIndex = 2;
            this.label2.Text = "Administración";
            // 
            // txtIdGradoGrado
            // 
            this.txtIdGradoGrado.Location = new System.Drawing.Point(220, 158);
            this.txtIdGradoGrado.Name = "txtIdGradoGrado";
            this.txtIdGradoGrado.Size = new System.Drawing.Size(152, 20);
            this.txtIdGradoGrado.TabIndex = 3;
            this.txtIdGradoGrado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNombreGrado
            // 
            this.txtNombreGrado.Location = new System.Drawing.Point(220, 208);
            this.txtNombreGrado.Name = "txtNombreGrado";
            this.txtNombreGrado.Size = new System.Drawing.Size(152, 20);
            this.txtNombreGrado.TabIndex = 4;
            this.txtNombreGrado.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(73, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Administrar Grado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Clave del Grado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nombre del Grado";
            // 
            // btnIngresarGrado
            // 
            this.btnIngresarGrado.Location = new System.Drawing.Point(79, 266);
            this.btnIngresarGrado.Name = "btnIngresarGrado";
            this.btnIngresarGrado.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarGrado.TabIndex = 11;
            this.btnIngresarGrado.Text = "Ingresar";
            this.btnIngresarGrado.UseVisualStyleBackColor = true;
            this.btnIngresarGrado.Click += new System.EventHandler(this.btnIngresarGrado_Click);
            // 
            // btnActualizarGrado
            // 
            this.btnActualizarGrado.Location = new System.Drawing.Point(186, 266);
            this.btnActualizarGrado.Name = "btnActualizarGrado";
            this.btnActualizarGrado.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarGrado.TabIndex = 12;
            this.btnActualizarGrado.Text = "Actualizar";
            this.btnActualizarGrado.UseVisualStyleBackColor = true;
            this.btnActualizarGrado.Click += new System.EventHandler(this.btnActualizarGrado_Click);
            // 
            // btnEliminarGrado
            // 
            this.btnEliminarGrado.Location = new System.Drawing.Point(285, 266);
            this.btnEliminarGrado.Name = "btnEliminarGrado";
            this.btnEliminarGrado.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarGrado.TabIndex = 13;
            this.btnEliminarGrado.Text = "Eliminar";
            this.btnEliminarGrado.UseVisualStyleBackColor = true;
            this.btnEliminarGrado.Click += new System.EventHandler(this.btnEliminarGrado_Click);
            // 
            // btnEliminarCursos
            // 
            this.btnEliminarCursos.Location = new System.Drawing.Point(285, 606);
            this.btnEliminarCursos.Name = "btnEliminarCursos";
            this.btnEliminarCursos.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCursos.TabIndex = 21;
            this.btnEliminarCursos.Text = "Eliminar";
            this.btnEliminarCursos.UseVisualStyleBackColor = true;
            this.btnEliminarCursos.Click += new System.EventHandler(this.btnEliminarCursos_Click);
            // 
            // btnActualizarCursos
            // 
            this.btnActualizarCursos.Location = new System.Drawing.Point(186, 606);
            this.btnActualizarCursos.Name = "btnActualizarCursos";
            this.btnActualizarCursos.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarCursos.TabIndex = 20;
            this.btnActualizarCursos.Text = "Actualizar";
            this.btnActualizarCursos.UseVisualStyleBackColor = true;
            this.btnActualizarCursos.Click += new System.EventHandler(this.btnActualizarCursos_Click);
            // 
            // btnIngresarCursos
            // 
            this.btnIngresarCursos.Location = new System.Drawing.Point(79, 606);
            this.btnIngresarCursos.Name = "btnIngresarCursos";
            this.btnIngresarCursos.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarCursos.TabIndex = 19;
            this.btnIngresarCursos.Text = "Ingresar";
            this.btnIngresarCursos.UseVisualStyleBackColor = true;
            this.btnIngresarCursos.Click += new System.EventHandler(this.btnIngresarCursos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nombre del Curso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Clave del Curso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(73, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 36);
            this.label8.TabIndex = 16;
            this.label8.Text = "Administrar Cursos";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(220, 482);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(152, 20);
            this.txtNombreCurso.TabIndex = 15;
            // 
            // txtIdCursoCursos
            // 
            this.txtIdCursoCursos.Location = new System.Drawing.Point(220, 432);
            this.txtIdCursoCursos.Name = "txtIdCursoCursos";
            this.txtIdCursoCursos.Size = new System.Drawing.Size(152, 20);
            this.txtIdCursoCursos.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 536);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "Clave de Grado";
            // 
            // txtIdGradoCursos
            // 
            this.txtIdGradoCursos.Location = new System.Drawing.Point(220, 536);
            this.txtIdGradoCursos.Name = "txtIdGradoCursos";
            this.txtIdGradoCursos.Size = new System.Drawing.Size(152, 20);
            this.txtIdGradoCursos.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(555, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 21);
            this.label10.TabIndex = 33;
            this.label10.Text = "Apellido";
            // 
            // txtApellidoEstudiante
            // 
            this.txtApellidoEstudiante.Location = new System.Drawing.Point(720, 378);
            this.txtApellidoEstudiante.Name = "txtApellidoEstudiante";
            this.txtApellidoEstudiante.Size = new System.Drawing.Size(152, 20);
            this.txtApellidoEstudiante.TabIndex = 32;
            // 
            // btnEliminarEstudiante
            // 
            this.btnEliminarEstudiante.Location = new System.Drawing.Point(772, 585);
            this.btnEliminarEstudiante.Name = "btnEliminarEstudiante";
            this.btnEliminarEstudiante.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarEstudiante.TabIndex = 31;
            this.btnEliminarEstudiante.Text = "Eliminar";
            this.btnEliminarEstudiante.UseVisualStyleBackColor = true;
            this.btnEliminarEstudiante.Click += new System.EventHandler(this.btnEliminarEstudiante_Click);
            // 
            // btnActualizarEstudiante
            // 
            this.btnActualizarEstudiante.Location = new System.Drawing.Point(673, 585);
            this.btnActualizarEstudiante.Name = "btnActualizarEstudiante";
            this.btnActualizarEstudiante.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarEstudiante.TabIndex = 30;
            this.btnActualizarEstudiante.Text = "Actualizar";
            this.btnActualizarEstudiante.UseVisualStyleBackColor = true;
            this.btnActualizarEstudiante.Click += new System.EventHandler(this.btnActualizarEstudiante_Click);
            // 
            // btnIngresarEstudiante
            // 
            this.btnIngresarEstudiante.Location = new System.Drawing.Point(566, 585);
            this.btnIngresarEstudiante.Name = "btnIngresarEstudiante";
            this.btnIngresarEstudiante.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarEstudiante.TabIndex = 29;
            this.btnIngresarEstudiante.Text = "Ingresar";
            this.btnIngresarEstudiante.UseVisualStyleBackColor = true;
            this.btnIngresarEstudiante.Click += new System.EventHandler(this.btnIngresarEstudiante_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(555, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 28;
            this.label11.Text = "Nombre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(555, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 21);
            this.label12.TabIndex = 27;
            this.label12.Text = "Clave Estudiante";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(538, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(365, 36);
            this.label13.TabIndex = 26;
            this.label13.Text = "Administrar Estudiantes";
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Location = new System.Drawing.Point(720, 324);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(152, 20);
            this.txtNombreEstudiante.TabIndex = 25;
            // 
            // txtIdEstudiante
            // 
            this.txtIdEstudiante.Location = new System.Drawing.Point(720, 274);
            this.txtIdEstudiante.Name = "txtIdEstudiante";
            this.txtIdEstudiante.Size = new System.Drawing.Size(152, 20);
            this.txtIdEstudiante.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(555, 524);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 21);
            this.label14.TabIndex = 39;
            this.label14.Text = "Clave de Grado";
            // 
            // txtIdGradoEstudiante
            // 
            this.txtIdGradoEstudiante.Location = new System.Drawing.Point(720, 524);
            this.txtIdGradoEstudiante.Name = "txtIdGradoEstudiante";
            this.txtIdGradoEstudiante.Size = new System.Drawing.Size(152, 20);
            this.txtIdGradoEstudiante.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(555, 470);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 21);
            this.label15.TabIndex = 37;
            this.label15.Text = "Clave de Curso";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(555, 417);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 21);
            this.label16.TabIndex = 36;
            this.label16.Text = "Edad";
            // 
            // txtIdCursoEstudiante
            // 
            this.txtIdCursoEstudiante.Location = new System.Drawing.Point(720, 470);
            this.txtIdCursoEstudiante.Name = "txtIdCursoEstudiante";
            this.txtIdCursoEstudiante.Size = new System.Drawing.Size(152, 20);
            this.txtIdCursoEstudiante.TabIndex = 35;
            // 
            // txtEdadEstudiante
            // 
            this.txtEdadEstudiante.Location = new System.Drawing.Point(720, 420);
            this.txtEdadEstudiante.Name = "txtEdadEstudiante";
            this.txtEdadEstudiante.Size = new System.Drawing.Size(152, 20);
            this.txtEdadEstudiante.TabIndex = 34;
            // 
            // bdEscuelaDataSet1
            // 
            this.bdEscuelaDataSet1.DataSetName = "bdEscuelaDataSet";
            this.bdEscuelaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tbCurso";
            this.bindingSource1.DataSource = this.bdEscuelaDataSet1;
            // 
            // tbCursoTableAdapter
            // 
            this.tbCursoTableAdapter.ClearBeforeFill = true;
            // 
            // bdEscuelaDataSet2
            // 
            this.bdEscuelaDataSet2.DataSetName = "bdEscuelaDataSet";
            this.bdEscuelaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "tbEstudiante";
            this.bindingSource2.DataSource = this.bdEscuelaDataSet1;
            // 
            // tbEstudianteTableAdapter
            // 
            this.tbEstudianteTableAdapter.ClearBeforeFill = true;
            // 
            // bdEscuelaDataSet3
            // 
            this.bdEscuelaDataSet3.DataSetName = "bdEscuelaDataSet";
            this.bdEscuelaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "tbGrado";
            this.bindingSource3.DataSource = this.bdEscuelaDataSet1;
            // 
            // tbGradoTableAdapter
            // 
            this.tbGradoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbCursoTableAdapter = this.tbCursoTableAdapter;
            this.tableAdapterManager.tbEstudianteTableAdapter = this.tbEstudianteTableAdapter;
            this.tableAdapterManager.tbGradoTableAdapter = this.tbGradoTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProyectoEscuela.bdEscuelaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnRegistros
            // 
            this.btnRegistros.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistros.ForeColor = System.Drawing.Color.IndianRed;
            this.btnRegistros.Location = new System.Drawing.Point(995, 293);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(172, 76);
            this.btnRegistros.TabIndex = 40;
            this.btnRegistros.Text = "Visualizar Registros ";
            this.btnRegistros.UseVisualStyleBackColor = true;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1266, 710);
            this.Controls.Add(this.btnRegistros);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtIdGradoEstudiante);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtIdCursoEstudiante);
            this.Controls.Add(this.txtEdadEstudiante);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtApellidoEstudiante);
            this.Controls.Add(this.btnEliminarEstudiante);
            this.Controls.Add(this.btnActualizarEstudiante);
            this.Controls.Add(this.btnIngresarEstudiante);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNombreEstudiante);
            this.Controls.Add(this.txtIdEstudiante);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdGradoCursos);
            this.Controls.Add(this.btnEliminarCursos);
            this.Controls.Add(this.btnActualizarCursos);
            this.Controls.Add(this.btnIngresarCursos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.txtIdCursoCursos);
            this.Controls.Add(this.btnEliminarGrado);
            this.Controls.Add(this.btnActualizarGrado);
            this.Controls.Add(this.btnIngresarGrado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreGrado);
            this.Controls.Add(this.txtIdGradoGrado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdEscuelaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdEscuelaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdEscuelaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdGradoGrado;
        private System.Windows.Forms.TextBox txtNombreGrado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIngresarGrado;
        private System.Windows.Forms.Button btnActualizarGrado;
        private System.Windows.Forms.Button btnEliminarGrado;
        private System.Windows.Forms.Button btnEliminarCursos;
        private System.Windows.Forms.Button btnActualizarCursos;
        private System.Windows.Forms.Button btnIngresarCursos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.TextBox txtIdCursoCursos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdGradoCursos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtApellidoEstudiante;
        private System.Windows.Forms.Button btnEliminarEstudiante;
        private System.Windows.Forms.Button btnActualizarEstudiante;
        private System.Windows.Forms.Button btnIngresarEstudiante;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.TextBox txtIdEstudiante;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIdGradoEstudiante;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtIdCursoEstudiante;
        private System.Windows.Forms.TextBox txtEdadEstudiante;
        private bdEscuelaDataSet bdEscuelaDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private bdEscuelaDataSetTableAdapters.tbCursoTableAdapter tbCursoTableAdapter;
        private bdEscuelaDataSet bdEscuelaDataSet2;
        private System.Windows.Forms.BindingSource bindingSource2;
        private bdEscuelaDataSetTableAdapters.tbEstudianteTableAdapter tbEstudianteTableAdapter;
        private bdEscuelaDataSet bdEscuelaDataSet3;
        private System.Windows.Forms.BindingSource bindingSource3;
        private bdEscuelaDataSetTableAdapters.tbGradoTableAdapter tbGradoTableAdapter;
        private bdEscuelaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnRegistros;
    }
}

