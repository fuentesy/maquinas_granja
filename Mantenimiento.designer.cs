namespace MAQUINAS_GRANJA
{
    partial class Mantenimiento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textDescripcionM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewMantenimiento = new System.Windows.Forms.DataGridView();
            this.comboMaquinaM = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonBuscarM = new System.Windows.Forms.Button();
            this.txtdato = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbbuscar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonBorrarM = new System.Windows.Forms.Button();
            this.buttonActualizarM = new System.Windows.Forms.Button();
            this.buttonLimpiarM = new System.Windows.Forms.Button();
            this.buttonGuardarM = new System.Windows.Forms.Button();
            this.textRecomendacionesM = new System.Windows.Forms.TextBox();
            this.dateTimePickerMant = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTipoM = new System.Windows.Forms.ComboBox();
            this.txtfecha22 = new System.Windows.Forms.TextBox();
            this.btnreoaracion = new System.Windows.Forms.Button();
            this.txtid_mantenimiento = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtid_maquina = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion del daño";
            // 
            // textDescripcionM
            // 
            this.textDescripcionM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescripcionM.Location = new System.Drawing.Point(12, 93);
            this.textDescripcionM.Name = "textDescripcionM";
            this.textDescripcionM.Size = new System.Drawing.Size(433, 24);
            this.textDescripcionM.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de mantenimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Detalle del mantenimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Maquina";
            // 
            // dataGridViewMantenimiento
            // 
            this.dataGridViewMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMantenimiento.Location = new System.Drawing.Point(472, 122);
            this.dataGridViewMantenimiento.Name = "dataGridViewMantenimiento";
            this.dataGridViewMantenimiento.Size = new System.Drawing.Size(540, 260);
            this.dataGridViewMantenimiento.TabIndex = 9;
            this.dataGridViewMantenimiento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMantenimiento_CellDoubleClick);
            // 
            // comboMaquinaM
            // 
            this.comboMaquinaM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMaquinaM.FormattingEnabled = true;
            this.comboMaquinaM.Location = new System.Drawing.Point(12, 201);
            this.comboMaquinaM.Name = "comboMaquinaM";
            this.comboMaquinaM.Size = new System.Drawing.Size(433, 26);
            this.comboMaquinaM.TabIndex = 10;
            this.comboMaquinaM.SelectedIndexChanged += new System.EventHandler(this.comboMaquinaM_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Recomendaciones";
            // 
            // buttonBuscarM
            // 
            this.buttonBuscarM.Location = new System.Drawing.Point(900, 92);
            this.buttonBuscarM.Name = "buttonBuscarM";
            this.buttonBuscarM.Size = new System.Drawing.Size(112, 23);
            this.buttonBuscarM.TabIndex = 28;
            this.buttonBuscarM.Text = "Buscar";
            this.buttonBuscarM.UseVisualStyleBackColor = true;
            // 
            // txtdato
            // 
            this.txtdato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdato.Location = new System.Drawing.Point(686, 90);
            this.txtdato.Name = "txtdato";
            this.txtdato.Size = new System.Drawing.Size(208, 24);
            this.txtdato.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(683, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Dato a buscar:";
            // 
            // cmbbuscar
            // 
            this.cmbbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbuscar.FormattingEnabled = true;
            this.cmbbuscar.Location = new System.Drawing.Point(472, 88);
            this.cmbbuscar.Name = "cmbbuscar";
            this.cmbbuscar.Size = new System.Drawing.Size(208, 26);
            this.cmbbuscar.TabIndex = 25;
            this.cmbbuscar.SelectedIndexChanged += new System.EventHandler(this.cmbbuscar_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(469, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Buscar por:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(420, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 35);
            this.label7.TabIndex = 29;
            this.label7.Text = "Manteniemiento";
            // 
            // buttonBorrarM
            // 
            this.buttonBorrarM.Location = new System.Drawing.Point(843, 441);
            this.buttonBorrarM.Name = "buttonBorrarM";
            this.buttonBorrarM.Size = new System.Drawing.Size(112, 23);
            this.buttonBorrarM.TabIndex = 33;
            this.buttonBorrarM.Text = "Borrar";
            this.buttonBorrarM.UseVisualStyleBackColor = true;
            this.buttonBorrarM.Click += new System.EventHandler(this.buttonBorrarM_Click);
            // 
            // buttonActualizarM
            // 
            this.buttonActualizarM.Location = new System.Drawing.Point(607, 441);
            this.buttonActualizarM.Name = "buttonActualizarM";
            this.buttonActualizarM.Size = new System.Drawing.Size(112, 23);
            this.buttonActualizarM.TabIndex = 32;
            this.buttonActualizarM.Text = "Actualizar";
            this.buttonActualizarM.UseVisualStyleBackColor = true;
            this.buttonActualizarM.Click += new System.EventHandler(this.buttonActualizarM_Click);
            // 
            // buttonLimpiarM
            // 
            this.buttonLimpiarM.Location = new System.Drawing.Point(725, 441);
            this.buttonLimpiarM.Name = "buttonLimpiarM";
            this.buttonLimpiarM.Size = new System.Drawing.Size(112, 23);
            this.buttonLimpiarM.TabIndex = 31;
            this.buttonLimpiarM.Text = "Limpiar";
            this.buttonLimpiarM.UseVisualStyleBackColor = true;
            this.buttonLimpiarM.Click += new System.EventHandler(this.buttonLimpiarM_Click);
            // 
            // buttonGuardarM
            // 
            this.buttonGuardarM.Location = new System.Drawing.Point(489, 441);
            this.buttonGuardarM.Name = "buttonGuardarM";
            this.buttonGuardarM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonGuardarM.Size = new System.Drawing.Size(112, 23);
            this.buttonGuardarM.TabIndex = 30;
            this.buttonGuardarM.Text = "Guardar";
            this.buttonGuardarM.UseVisualStyleBackColor = true;
            this.buttonGuardarM.Click += new System.EventHandler(this.buttonGuardarM_Click);
            // 
            // textRecomendacionesM
            // 
            this.textRecomendacionesM.Location = new System.Drawing.Point(12, 416);
            this.textRecomendacionesM.Multiline = true;
            this.textRecomendacionesM.Name = "textRecomendacionesM";
            this.textRecomendacionesM.Size = new System.Drawing.Size(433, 82);
            this.textRecomendacionesM.TabIndex = 34;
            // 
            // dateTimePickerMant
            // 
            this.dateTimePickerMant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerMant.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerMant.Location = new System.Drawing.Point(12, 45);
            this.dateTimePickerMant.Name = "dateTimePickerMant";
            this.dateTimePickerMant.Size = new System.Drawing.Size(141, 24);
            this.dateTimePickerMant.TabIndex = 35;
            this.dateTimePickerMant.ValueChanged += new System.EventHandler(this.dateTimePickerMant_ValueChanged);
            // 
            // comboBoxTipoM
            // 
            this.comboBoxTipoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoM.FormattingEnabled = true;
            this.comboBoxTipoM.Location = new System.Drawing.Point(13, 145);
            this.comboBoxTipoM.Name = "comboBoxTipoM";
            this.comboBoxTipoM.Size = new System.Drawing.Size(432, 26);
            this.comboBoxTipoM.TabIndex = 37;
            this.comboBoxTipoM.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoM_SelectedIndexChanged);
            // 
            // txtfecha22
            // 
            this.txtfecha22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha22.Location = new System.Drawing.Point(161, 47);
            this.txtfecha22.Name = "txtfecha22";
            this.txtfecha22.Size = new System.Drawing.Size(59, 24);
            this.txtfecha22.TabIndex = 38;
            // 
            // btnreoaracion
            // 
            this.btnreoaracion.Location = new System.Drawing.Point(350, 371);
            this.btnreoaracion.Name = "btnreoaracion";
            this.btnreoaracion.Size = new System.Drawing.Size(95, 23);
            this.btnreoaracion.TabIndex = 39;
            this.btnreoaracion.Text = "agregar detalle";
            this.btnreoaracion.UseVisualStyleBackColor = true;
            this.btnreoaracion.Click += new System.EventHandler(this.btnreoaracion_Click);
            // 
            // txtid_mantenimiento
            // 
            this.txtid_mantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_mantenimiento.Location = new System.Drawing.Point(226, 47);
            this.txtid_mantenimiento.Name = "txtid_mantenimiento";
            this.txtid_mantenimiento.Size = new System.Drawing.Size(59, 24);
            this.txtid_mantenimiento.TabIndex = 41;
            this.txtid_mantenimiento.TextChanged += new System.EventHandler(this.txtid_mantenimiento_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 102);
            this.dataGridView1.TabIndex = 42;
            // 
            // txtid_maquina
            // 
            this.txtid_maquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_maquina.Location = new System.Drawing.Point(291, 47);
            this.txtid_maquina.Name = "txtid_maquina";
            this.txtid_maquina.Size = new System.Drawing.Size(59, 24);
            this.txtid_maquina.TabIndex = 43;
            this.txtid_maquina.TextChanged += new System.EventHandler(this.txtmaquina_TextChanged);
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 510);
            this.Controls.Add(this.txtid_maquina);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtid_mantenimiento);
            this.Controls.Add(this.btnreoaracion);
            this.Controls.Add(this.txtfecha22);
            this.Controls.Add(this.comboBoxTipoM);
            this.Controls.Add(this.dateTimePickerMant);
            this.Controls.Add(this.textRecomendacionesM);
            this.Controls.Add(this.buttonBorrarM);
            this.Controls.Add(this.buttonActualizarM);
            this.Controls.Add(this.buttonLimpiarM);
            this.Controls.Add(this.buttonGuardarM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonBuscarM);
            this.Controls.Add(this.txtdato);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbbuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboMaquinaM);
            this.Controls.Add(this.dataGridViewMantenimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDescripcionM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.Mantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDescripcionM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewMantenimiento;
        private System.Windows.Forms.ComboBox comboMaquinaM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBuscarM;
        private System.Windows.Forms.TextBox txtdato;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbbuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonBorrarM;
        private System.Windows.Forms.Button buttonActualizarM;
        private System.Windows.Forms.Button buttonLimpiarM;
        private System.Windows.Forms.Button buttonGuardarM;
        private System.Windows.Forms.TextBox textRecomendacionesM;
        private System.Windows.Forms.DateTimePicker dateTimePickerMant;
        private System.Windows.Forms.ComboBox comboBoxTipoM;
        private System.Windows.Forms.TextBox txtfecha22;
        private System.Windows.Forms.Button btnreoaracion;
        private System.Windows.Forms.TextBox txtid_mantenimiento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtid_maquina;
    }
}