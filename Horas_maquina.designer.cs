namespace MAQUINAS_GRANJA
{
    partial class Horas_maquina
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
            this.btnBuscart = new System.Windows.Forms.Button();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBuscarpor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataTrabajo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txttrabajo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerfechatraba = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsalida = new System.Windows.Forms.TextBox();
            this.txtllegada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txthorometro = new System.Windows.Forms.TextBox();
            this.txttotal_horas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbmaquina = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmboperario = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txtId_maquinaa = new System.Windows.Forms.TextBox();
            this.txtid_combustible = new System.Windows.Forms.TextBox();
            this.txtid_operario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTrabajo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscart
            // 
            this.btnBuscart.Location = new System.Drawing.Point(933, 88);
            this.btnBuscart.Name = "btnBuscart";
            this.btnBuscart.Size = new System.Drawing.Size(109, 23);
            this.btnBuscart.TabIndex = 39;
            this.btnBuscart.Text = "Buscar";
            this.btnBuscart.UseVisualStyleBackColor = true;
            // 
            // textBuscar
            // 
            this.textBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar.Location = new System.Drawing.Point(719, 88);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(208, 24);
            this.textBuscar.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(718, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 18);
            this.label9.TabIndex = 37;
            this.label9.Text = "Dato a buscar:";
            // 
            // comboBuscarpor
            // 
            this.comboBuscarpor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBuscarpor.FormattingEnabled = true;
            this.comboBuscarpor.Location = new System.Drawing.Point(495, 88);
            this.comboBuscarpor.Name = "comboBuscarpor";
            this.comboBuscarpor.Size = new System.Drawing.Size(208, 26);
            this.comboBuscarpor.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(492, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "Buscar por:";
            // 
            // dataTrabajo
            // 
            this.dataTrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTrabajo.Location = new System.Drawing.Point(495, 121);
            this.dataTrabajo.Name = "dataTrabajo";
            this.dataTrabajo.Size = new System.Drawing.Size(547, 246);
            this.dataTrabajo.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "trabajo a realizar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txttrabajo
            // 
            this.txttrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttrabajo.Location = new System.Drawing.Point(15, 95);
            this.txttrabajo.Name = "txttrabajo";
            this.txttrabajo.Size = new System.Drawing.Size(208, 24);
            this.txttrabajo.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "Fecha";
            // 
            // dateTimePickerfechatraba
            // 
            this.dateTimePickerfechatraba.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerfechatraba.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerfechatraba.Location = new System.Drawing.Point(249, 95);
            this.dateTimePickerfechatraba.Name = "dateTimePickerfechatraba";
            this.dateTimePickerfechatraba.Size = new System.Drawing.Size(112, 24);
            this.dateTimePickerfechatraba.TabIndex = 47;
            this.dateTimePickerfechatraba.ValueChanged += new System.EventHandler(this.dateTimePickerfechatraba_ValueChanged);
            this.dateTimePickerfechatraba.VisibleChanged += new System.EventHandler(this.dateTimePickerfechatraba_VisibleChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "Hora salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "Hora llegada";
            // 
            // txtsalida
            // 
            this.txtsalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalida.Location = new System.Drawing.Point(12, 145);
            this.txtsalida.Name = "txtsalida";
            this.txtsalida.Size = new System.Drawing.Size(208, 24);
            this.txtsalida.TabIndex = 50;
            // 
            // txtllegada
            // 
            this.txtllegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtllegada.Location = new System.Drawing.Point(249, 144);
            this.txtllegada.Name = "txtllegada";
            this.txtllegada.Size = new System.Drawing.Size(229, 24);
            this.txtllegada.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(249, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "Horometro";
            // 
            // txthorometro
            // 
            this.txthorometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorometro.Location = new System.Drawing.Point(249, 190);
            this.txthorometro.Name = "txthorometro";
            this.txthorometro.Size = new System.Drawing.Size(229, 24);
            this.txthorometro.TabIndex = 53;
            // 
            // txttotal_horas
            // 
            this.txttotal_horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal_horas.Location = new System.Drawing.Point(15, 191);
            this.txttotal_horas.Name = "txttotal_horas";
            this.txttotal_horas.Size = new System.Drawing.Size(208, 24);
            this.txttotal_horas.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 54;
            this.label6.Text = "Total horas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(298, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(341, 35);
            this.label7.TabIndex = 56;
            this.label7.Text = "Trabajo de la maquina";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 57;
            this.label10.Text = "Maquina";
            // 
            // cmbmaquina
            // 
            this.cmbmaquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmaquina.FormattingEnabled = true;
            this.cmbmaquina.Location = new System.Drawing.Point(18, 242);
            this.cmbmaquina.Name = "cmbmaquina";
            this.cmbmaquina.Size = new System.Drawing.Size(205, 26);
            this.cmbmaquina.TabIndex = 58;
            this.cmbmaquina.SelectedIndexChanged += new System.EventHandler(this.cmbmaquina_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 18);
            this.label12.TabIndex = 61;
            this.label12.Text = "Operario";
            // 
            // cmboperario
            // 
            this.cmboperario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboperario.FormattingEnabled = true;
            this.cmboperario.Location = new System.Drawing.Point(18, 296);
            this.cmboperario.Name = "cmboperario";
            this.cmboperario.Size = new System.Drawing.Size(205, 26);
            this.cmboperario.TabIndex = 62;
            this.cmboperario.SelectedIndexChanged += new System.EventHandler(this.cmboperario_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(13, 339);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 23);
            this.btnGuardar.TabIndex = 67;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(131, 339);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(112, 23);
            this.btnActualizar.TabIndex = 68;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(249, 339);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 23);
            this.btnLimpiar.TabIndex = 69;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(367, 339);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(112, 23);
            this.btnBorrar.TabIndex = 70;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.Location = new System.Drawing.Point(367, 97);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(111, 24);
            this.txtfecha.TabIndex = 71;
            // 
            // txtId_maquinaa
            // 
            this.txtId_maquinaa.Location = new System.Drawing.Point(18, 41);
            this.txtId_maquinaa.Name = "txtId_maquinaa";
            this.txtId_maquinaa.Size = new System.Drawing.Size(40, 20);
            this.txtId_maquinaa.TabIndex = 73;
            // 
            // txtid_combustible
            // 
            this.txtid_combustible.Location = new System.Drawing.Point(64, 41);
            this.txtid_combustible.Name = "txtid_combustible";
            this.txtid_combustible.Size = new System.Drawing.Size(40, 20);
            this.txtid_combustible.TabIndex = 74;
            // 
            // txtid_operario
            // 
            this.txtid_operario.Location = new System.Drawing.Point(110, 41);
            this.txtid_operario.Name = "txtid_operario";
            this.txtid_operario.Size = new System.Drawing.Size(40, 20);
            this.txtid_operario.TabIndex = 75;
            // 
            // Horas_maquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 427);
            this.Controls.Add(this.txtid_operario);
            this.Controls.Add(this.txtid_combustible);
            this.Controls.Add(this.txtId_maquinaa);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmboperario);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbmaquina);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttotal_horas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txthorometro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtllegada);
            this.Controls.Add(this.txtsalida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerfechatraba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttrabajo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscart);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBuscarpor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataTrabajo);
            this.Name = "Horas_maquina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horas_maquina";
            this.Load += new System.EventHandler(this.Horas_maquina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTrabajo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscart;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBuscarpor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataTrabajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttrabajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerfechatraba;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsalida;
        private System.Windows.Forms.TextBox txtllegada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txthorometro;
        private System.Windows.Forms.TextBox txttotal_horas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbmaquina;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmboperario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txtId_maquinaa;
        private System.Windows.Forms.TextBox txtid_combustible;
        private System.Windows.Forms.TextBox txtid_operario;
    }
}