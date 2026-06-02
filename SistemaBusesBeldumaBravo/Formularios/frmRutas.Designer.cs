namespace SistemaBusesBeldumaBravo.Formularios
{
    partial class frmRutas
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
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvRutas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(99, 115);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(124, 20);
            this.txtDestino.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Destino:";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(99, 79);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(125, 20);
            this.txtOrigen.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Origen:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(98, 177);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(124, 20);
            this.txtPrecio.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Precio:";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(98, 141);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(125, 20);
            this.txtDistancia.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Distancia (km)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(375, 38);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(401, 20);
            this.txtBuscar.TabIndex = 69;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(124, 268);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 53);
            this.button5.TabIndex = 73;
            this.button5.Text = "Limpiar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 53);
            this.button3.TabIndex = 72;
            this.button3.Text = "Eliminar\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 47);
            this.button2.TabIndex = 71;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 47);
            this.button1.TabIndex = 70;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvRutas
            // 
            this.dgvRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutas.Location = new System.Drawing.Point(242, 79);
            this.dgvRutas.Name = "dgvRutas";
            this.dgvRutas.Size = new System.Drawing.Size(534, 242);
            this.dgvRutas.TabIndex = 74;
            this.dgvRutas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRutas_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 34);
            this.label4.TabIndex = 75;
            this.label4.Text = "RUTAS";
            // 
            // frmRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvRutas);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.label6);
            this.Name = "frmRutas";
            this.Text = "frmRutas";
            this.Load += new System.EventHandler(this.frmRutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvRutas;
        private System.Windows.Forms.Label label4;
    }
}