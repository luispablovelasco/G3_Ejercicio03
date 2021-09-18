namespace G3_Ejercicio3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdescrip = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvlistado = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.ofdimagen = new System.Windows.Forms.OpenFileDialog();
            this.btngargarimagen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btngargarimagen);
            this.groupBox1.Controls.Add(this.txtstock);
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.txtmarca);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtdescrip);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Location = new System.Drawing.Point(373, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento de productos";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(18, 305);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(224, 23);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stock:";
            // 
            // txtdescrip
            // 
            this.txtdescrip.Location = new System.Drawing.Point(91, 89);
            this.txtdescrip.Name = "txtdescrip";
            this.txtdescrip.Size = new System.Drawing.Size(151, 20);
            this.txtdescrip.TabIndex = 6;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(91, 50);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(151, 20);
            this.txtnombre.TabIndex = 7;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(91, 125);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(151, 20);
            this.txtmarca.TabIndex = 8;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(91, 165);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(151, 20);
            this.txtprecio.TabIndex = 9;
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(91, 207);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(151, 20);
            this.txtstock.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "LISTADO DE PRODUCTOS";
            // 
            // dgvlistado
            // 
            this.dgvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistado.Location = new System.Drawing.Point(15, 42);
            this.dgvlistado.Name = "dgvlistado";
            this.dgvlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlistado.Size = new System.Drawing.Size(352, 258);
            this.dgvlistado.TabIndex = 2;
            this.dgvlistado.DoubleClick += new System.EventHandler(this.dgvlistado_DoubleClick);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(15, 317);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(76, 32);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // ofdimagen
            // 
            this.ofdimagen.FileName = "openFileDialog1";
            // 
            // btngargarimagen
            // 
            this.btngargarimagen.Location = new System.Drawing.Point(21, 244);
            this.btngargarimagen.Name = "btngargarimagen";
            this.btngargarimagen.Size = new System.Drawing.Size(221, 23);
            this.btngargarimagen.TabIndex = 11;
            this.btngargarimagen.Text = "Cargar imagen";
            this.btngargarimagen.UseVisualStyleBackColor = true;
            this.btngargarimagen.Click += new System.EventHandler(this.btngargarimagen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 365);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.dgvlistado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ejercicio 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdescrip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvlistado;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btngargarimagen;
        private System.Windows.Forms.OpenFileDialog ofdimagen;
    }
}

