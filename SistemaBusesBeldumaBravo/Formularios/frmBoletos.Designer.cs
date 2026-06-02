namespace SistemaBusesBeldumaBravo.Formularios
{
    partial class frmBoletos
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
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvBoletos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNumAsiento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPasajero = new System.Windows.Forms.ComboBox();
            this.cmbViaje = new System.Windows.Forms.ComboBox();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletos)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 28);
            this.label5.TabIndex = 102;
            this.label5.Text = "BOLETOS";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(128, 367);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 53);
            this.button5.TabIndex = 101;
            this.button5.Text = "Limpiar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 53);
            this.button3.TabIndex = 100;
            this.button3.Text = "Eliminar\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 53);
            this.button2.TabIndex = 99;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 53);
            this.button1.TabIndex = 98;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvBoletos
            // 
            this.dgvBoletos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoletos.Location = new System.Drawing.Point(257, 77);
            this.dgvBoletos.Name = "dgvBoletos";
            this.dgvBoletos.Size = new System.Drawing.Size(514, 343);
            this.dgvBoletos.TabIndex = 97;
            this.dgvBoletos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoletos_CellContentClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(422, 39);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(349, 20);
            this.txtBuscar.TabIndex = 96;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(119, 176);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 93;
            // 
            // txtNumAsiento
            // 
            this.txtNumAsiento.Location = new System.Drawing.Point(120, 143);
            this.txtNumAsiento.Name = "txtNumAsiento";
            this.txtNumAsiento.Size = new System.Drawing.Size(100, 20);
            this.txtNumAsiento.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Buscar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Fecha Compra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Pasajero:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(80, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 85;
            this.label11.Text = "Valor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 84;
            this.label9.Text = "Num Asiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Viaje:";
            // 
            // cmbPasajero
            // 
            this.cmbPasajero.FormattingEnabled = true;
            this.cmbPasajero.Location = new System.Drawing.Point(119, 77);
            this.cmbPasajero.Name = "cmbPasajero";
            this.cmbPasajero.Size = new System.Drawing.Size(100, 21);
            this.cmbPasajero.TabIndex = 103;
            // 
            // cmbViaje
            // 
            this.cmbViaje.FormattingEnabled = true;
            this.cmbViaje.Location = new System.Drawing.Point(120, 110);
            this.cmbViaje.Name = "cmbViaje";
            this.cmbViaje.Size = new System.Drawing.Size(100, 21);
            this.cmbViaje.TabIndex = 104;
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCompra.Location = new System.Drawing.Point(119, 209);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(102, 20);
            this.dtpFechaCompra.TabIndex = 105;
            // 
            // frmBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpFechaCompra);
            this.Controls.Add(this.cmbViaje);
            this.Controls.Add(this.cmbPasajero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvBoletos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNumAsiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Name = "frmBoletos";
            this.Text = "frmBoletos";
            this.Load += new System.EventHandler(this.frmBoletos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvBoletos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNumAsiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPasajero;
        private System.Windows.Forms.ComboBox cmbViaje;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
    }
}