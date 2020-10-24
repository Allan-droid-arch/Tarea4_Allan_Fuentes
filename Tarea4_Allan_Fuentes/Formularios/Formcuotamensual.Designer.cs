namespace Tarea4_Allan_Fuentes.Formularios
{
    partial class Formcuotamensual
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
            this.rn = new System.Windows.Forms.RadioButton();
            this.rd = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.pre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tot = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rn
            // 
            this.rn.AutoSize = true;
            this.rn.Location = new System.Drawing.Point(91, 110);
            this.rn.Name = "rn";
            this.rn.Size = new System.Drawing.Size(68, 24);
            this.rn.TabIndex = 0;
            this.rn.TabStop = true;
            this.rn.Text = "Normal";
            this.rn.UseVisualStyleBackColor = true;
            // 
            // rd
            // 
            this.rd.AutoSize = true;
            this.rd.Location = new System.Drawing.Point(186, 110);
            this.rd.Name = "rd";
            this.rd.Size = new System.Drawing.Size(87, 24);
            this.rd.TabIndex = 1;
            this.rd.TabStop = true;
            this.rd.Text = "Descuento";
            this.rd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(122, 31);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 25);
            this.nom.TabIndex = 4;
            // 
            // pre
            // 
            this.pre.Location = new System.Drawing.Point(122, 62);
            this.pre.Name = "pre";
            this.pre.Size = new System.Drawing.Size(100, 25);
            this.pre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total a pagar";
            // 
            // tot
            // 
            this.tot.Location = new System.Drawing.Point(130, 156);
            this.tot.Name = "tot";
            this.tot.Size = new System.Drawing.Size(100, 25);
            this.tot.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Formcuotamensual
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(398, 267);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pre);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rd);
            this.Controls.Add(this.rn);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Formcuotamensual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuota mensual";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rn;
        private System.Windows.Forms.RadioButton rd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox pre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}