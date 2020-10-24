namespace Tarea4_Allan_Fuentes.Formularios
{
    partial class FormVentas_diarias
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
            this.Dventas = new System.Windows.Forms.DataGridView();
            this.Ccodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnombre = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cfecha = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtventas = new System.Windows.Forms.TextBox();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.Btncancelar = new System.Windows.Forms.Button();
            this.Dtime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Vto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Sp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dventas)).BeginInit();
            this.SuspendLayout();
            // 
            // Dventas
            // 
            this.Dventas.AllowUserToAddRows = false;
            this.Dventas.AllowUserToDeleteRows = false;
            this.Dventas.AllowUserToResizeColumns = false;
            this.Dventas.AllowUserToResizeRows = false;
            this.Dventas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ccodigo,
            this.Cnombre,
            this.Cruta,
            this.Cfecha,
            this.Cventa});
            this.Dventas.Location = new System.Drawing.Point(39, 184);
            this.Dventas.Name = "Dventas";
            this.Dventas.Size = new System.Drawing.Size(630, 150);
            this.Dventas.TabIndex = 0;
            this.Dventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ccodigo
            // 
            this.Ccodigo.HeaderText = "Codigo";
            this.Ccodigo.Name = "Ccodigo";
            this.Ccodigo.Width = 80;
            // 
            // Cnombre
            // 
            this.Cnombre.HeaderText = "Nombre";
            this.Cnombre.Name = "Cnombre";
            this.Cnombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cnombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cnombre.Width = 200;
            // 
            // Cruta
            // 
            this.Cruta.HeaderText = "Ruta";
            this.Cruta.Name = "Cruta";
            // 
            // Cfecha
            // 
            this.Cfecha.HeaderText = "Fecha";
            this.Cfecha.Name = "Cfecha";
            this.Cfecha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cfecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Cventa
            // 
            this.Cventa.HeaderText = "Ventas";
            this.Cventa.Name = "Cventa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(94, 18);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(82, 26);
            this.txtcodigo.TabIndex = 2;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(94, 59);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(343, 26);
            this.txtnombre.TabIndex = 4;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ruta";
            // 
            // txtruta
            // 
            this.txtruta.Location = new System.Drawing.Point(94, 104);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(109, 26);
            this.txtruta.TabIndex = 6;
            this.txtruta.TextChanged += new System.EventHandler(this.txtruta_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ventas";
            // 
            // txtventas
            // 
            this.txtventas.Location = new System.Drawing.Point(393, 107);
            this.txtventas.Name = "txtventas";
            this.txtventas.Size = new System.Drawing.Size(109, 26);
            this.txtventas.TabIndex = 8;
            this.txtventas.TextChanged += new System.EventHandler(this.txtventas_TextChanged);
            // 
            // Btnagregar
            // 
            this.Btnagregar.Location = new System.Drawing.Point(312, 14);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(75, 35);
            this.Btnagregar.TabIndex = 9;
            this.Btnagregar.Text = "Agregar";
            this.Btnagregar.UseVisualStyleBackColor = true;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // Btncancelar
            // 
            this.Btncancelar.Location = new System.Drawing.Point(410, 14);
            this.Btncancelar.Name = "Btncancelar";
            this.Btncancelar.Size = new System.Drawing.Size(75, 35);
            this.Btncancelar.TabIndex = 10;
            this.Btncancelar.Text = "Cancelar";
            this.Btncancelar.UseVisualStyleBackColor = true;
            this.Btncancelar.Click += new System.EventHandler(this.Btncancelar_Click);
            // 
            // Dtime
            // 
            this.Dtime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtime.Location = new System.Drawing.Point(94, 152);
            this.Dtime.Name = "Dtime";
            this.Dtime.Size = new System.Drawing.Size(95, 26);
            this.Dtime.TabIndex = 11;
            this.Dtime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ventas Totales\r\n";
            // 
            // Vto
            // 
            this.Vto.Location = new System.Drawing.Point(555, 341);
            this.Vto.Name = "Vto";
            this.Vto.ReadOnly = true;
            this.Vto.Size = new System.Drawing.Size(109, 26);
            this.Vto.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sueldo a pagar";
            // 
            // Sp
            // 
            this.Sp.Location = new System.Drawing.Point(555, 381);
            this.Sp.Name = "Sp";
            this.Sp.ReadOnly = true;
            this.Sp.Size = new System.Drawing.Size(109, 26);
            this.Sp.TabIndex = 15;
            // 
            // FormVentas_diarias
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(704, 410);
            this.Controls.Add(this.Sp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Vto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dtime);
            this.Controls.Add(this.Btncancelar);
            this.Controls.Add(this.Btnagregar);
            this.Controls.Add(this.txtventas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dventas);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormVentas_diarias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas diarias";
            ((System.ComponentModel.ISupportInitialize)(this.Dventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccodigo;
        private System.Windows.Forms.DataGridViewButtonColumn Cnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cruta;
        private System.Windows.Forms.DataGridViewButtonColumn Cfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cventa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtventas;
        private System.Windows.Forms.Button Btnagregar;
        private System.Windows.Forms.Button Btncancelar;
        private System.Windows.Forms.DateTimePicker Dtime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Vto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Sp;
    }
}