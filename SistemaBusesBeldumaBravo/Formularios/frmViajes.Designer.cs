namespace SistemaBusesBeldumaBravo.Formularios
{
    partial class frmViajes
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
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBus = new System.Windows.Forms.ComboBox();
            this.cmbConductor = new System.Windows.Forms.ComboBox();
            this.cmbRuta = new System.Windows.Forms.ComboBox();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaLlegada = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 28);
            this.label5.TabIndex = 102;
            this.label5.Text = "VIAJES";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(127, 359);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 53);
            this.button5.TabIndex = 101;
            this.button5.Text = "Limpiar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 53);
            this.button3.TabIndex = 100;
            this.button3.Text = "Eliminar\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 53);
            this.button2.TabIndex = 99;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 53);
            this.button1.TabIndex = 98;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvViajes
            // 
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Location = new System.Drawing.Point(256, 69);
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.Size = new System.Drawing.Size(514, 343);
            this.dgvViajes.TabIndex = 97;
            this.dgvViajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViajes_CellContentClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(421, 31);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(349, 20);
            this.txtBuscar.TabIndex = 96;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(97, 236);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(118, 21);
            this.cmbEstado.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Buscar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Estado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Conductor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 85;
            this.label11.Text = "Fecha LLegada:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 84;
            this.label9.Text = "Fecha Salida:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Ruta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "Bus:";
            // 
            // cmbBus
            // 
            this.cmbBus.FormattingEnabled = true;
            this.cmbBus.Location = new System.Drawing.Point(92, 70);
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.Size = new System.Drawing.Size(121, 21);
            this.cmbBus.TabIndex = 104;
            // 
            // cmbConductor
            // 
            this.cmbConductor.FormattingEnabled = true;
            this.cmbConductor.Location = new System.Drawing.Point(92, 99);
            this.cmbConductor.Name = "cmbConductor";
            this.cmbConductor.Size = new System.Drawing.Size(121, 21);
            this.cmbConductor.TabIndex = 105;
            // 
            // cmbRuta
            // 
            this.cmbRuta.FormattingEnabled = true;
            this.cmbRuta.Location = new System.Drawing.Point(92, 135);
            this.cmbRuta.Name = "cmbRuta";
            this.cmbRuta.Size = new System.Drawing.Size(121, 21);
            this.cmbRuta.TabIndex = 106;
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSalida.Location = new System.Drawing.Point(92, 171);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaSalida.TabIndex = 107;
            // 
            // dtpFechaLlegada
            // 
            this.dtpFechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLlegada.Location = new System.Drawing.Point(92, 208);
            this.dtpFechaLlegada.Name = "dtpFechaLlegada";
            this.dtpFechaLlegada.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaLlegada.TabIndex = 108;
            // 
            // frmViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpFechaLlegada);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.cmbRuta);
            this.Controls.Add(this.cmbConductor);
            this.Controls.Add(this.cmbBus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvViajes);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Name = "frmViajes";
            this.Text = "frmViajes";
            this.Load += new System.EventHandler(this.frmViajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.ComboBox cmbConductor;
        private System.Windows.Forms.ComboBox cmbRuta;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaLlegada;
    }
}