namespace MAQUINAS_GRANJA
{
    partial class combustible
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
            this.label2 = new System.Windows.Forms.Label();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datefechacom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscar_C = new System.Windows.Forms.Button();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBuscarpor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBorrar_C = new System.Windows.Forms.Button();
            this.btnActualizar_C = new System.Windows.Forms.Button();
            this.btnLimpiar_C = new System.Windows.Forms.Button();
            this.btnGuardar_C = new System.Windows.Forms.Button();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textCombustible = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad";
            // 
            // textCantidad
            // 
            this.textCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCantidad.Location = new System.Drawing.Point(30, 149);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(414, 24);
            this.textCantidad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha";
            // 
            // datefechacom
            // 
            this.datefechacom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datefechacom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datefechacom.Location = new System.Drawing.Point(30, 202);
            this.datefechacom.Name = "datefechacom";
            this.datefechacom.Size = new System.Drawing.Size(414, 24);
            this.datefechacom.TabIndex = 7;
            this.datefechacom.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio galon";
            // 
            // textPrecio
            // 
            this.textPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecio.Location = new System.Drawing.Point(30, 260);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(414, 24);
            this.textPrecio.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio total";
            // 
            // textTotal
            // 
            this.textTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotal.Location = new System.Drawing.Point(30, 311);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(414, 24);
            this.textTotal.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 24.25F);
            this.label6.Location = new System.Drawing.Point(448, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 40);
            this.label6.TabIndex = 38;
            this.label6.Text = "Combustible";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(472, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 209);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnBuscar_C
            // 
            this.btnBuscar_C.Location = new System.Drawing.Point(913, 82);
            this.btnBuscar_C.Name = "btnBuscar_C";
            this.btnBuscar_C.Size = new System.Drawing.Size(112, 23);
            this.btnBuscar_C.TabIndex = 44;
            this.btnBuscar_C.Text = "Buscar";
            this.btnBuscar_C.UseVisualStyleBackColor = true;
            this.btnBuscar_C.Click += new System.EventHandler(this.btnBuscar_C_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar.Location = new System.Drawing.Point(687, 79);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(119, 24);
            this.textBuscar.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(687, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 18);
            this.label9.TabIndex = 42;
            this.label9.Text = "Dato a buscar:";
            // 
            // comboBuscarpor
            // 
            this.comboBuscarpor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBuscarpor.FormattingEnabled = true;
            this.comboBuscarpor.Location = new System.Drawing.Point(473, 79);
            this.comboBuscarpor.Name = "comboBuscarpor";
            this.comboBuscarpor.Size = new System.Drawing.Size(208, 26);
            this.comboBuscarpor.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(472, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 40;
            this.label8.Text = "Buscar por:";
            // 
            // btnBorrar_C
            // 
            this.btnBorrar_C.Location = new System.Drawing.Point(657, 353);
            this.btnBorrar_C.Name = "btnBorrar_C";
            this.btnBorrar_C.Size = new System.Drawing.Size(112, 23);
            this.btnBorrar_C.TabIndex = 48;
            this.btnBorrar_C.Text = "Borrar";
            this.btnBorrar_C.UseVisualStyleBackColor = true;
            this.btnBorrar_C.Click += new System.EventHandler(this.btnBorrar_C_Click);
            // 
            // btnActualizar_C
            // 
            this.btnActualizar_C.Location = new System.Drawing.Point(421, 353);
            this.btnActualizar_C.Name = "btnActualizar_C";
            this.btnActualizar_C.Size = new System.Drawing.Size(112, 23);
            this.btnActualizar_C.TabIndex = 47;
            this.btnActualizar_C.Text = "Actualizar";
            this.btnActualizar_C.UseVisualStyleBackColor = true;
            this.btnActualizar_C.Click += new System.EventHandler(this.btnActualizar_C_Click);
            // 
            // btnLimpiar_C
            // 
            this.btnLimpiar_C.Location = new System.Drawing.Point(539, 353);
            this.btnLimpiar_C.Name = "btnLimpiar_C";
            this.btnLimpiar_C.Size = new System.Drawing.Size(112, 23);
            this.btnLimpiar_C.TabIndex = 46;
            this.btnLimpiar_C.Text = "Limpiar";
            this.btnLimpiar_C.UseVisualStyleBackColor = true;
            this.btnLimpiar_C.Click += new System.EventHandler(this.btnLimpiar_C_Click);
            // 
            // btnGuardar_C
            // 
            this.btnGuardar_C.Location = new System.Drawing.Point(303, 353);
            this.btnGuardar_C.Name = "btnGuardar_C";
            this.btnGuardar_C.Size = new System.Drawing.Size(112, 23);
            this.btnGuardar_C.TabIndex = 45;
            this.btnGuardar_C.Text = "Guardar";
            this.btnGuardar_C.UseVisualStyleBackColor = true;
            this.btnGuardar_C.Click += new System.EventHandler(this.btnGuardar_C_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(30, 29);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(70, 20);
            this.txtfecha.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Combustible";
            // 
            // textCombustible
            // 
            this.textCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCombustible.Location = new System.Drawing.Point(30, 98);
            this.textCombustible.Name = "textCombustible";
            this.textCombustible.Size = new System.Drawing.Size(414, 24);
            this.textCombustible.TabIndex = 3;
            this.textCombustible.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCombustible_KeyPress);
            // 
            // combustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 388);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.btnBorrar_C);
            this.Controls.Add(this.btnActualizar_C);
            this.Controls.Add(this.btnLimpiar_C);
            this.Controls.Add(this.btnGuardar_C);
            this.Controls.Add(this.btnBuscar_C);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBuscarpor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datefechacom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCombustible);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "combustible";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "combustuble";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datefechacom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar_C;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBuscarpor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBorrar_C;
        private System.Windows.Forms.Button btnActualizar_C;
        private System.Windows.Forms.Button btnLimpiar_C;
        private System.Windows.Forms.Button btnGuardar_C;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCombustible;
    }
}