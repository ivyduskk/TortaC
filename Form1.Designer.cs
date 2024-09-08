namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSubtotal = new TextBox();
            txtIVA = new TextBox();
            txtTotal = new TextBox();
            txtCodigoObsequio = new TextBox();
            txtDescripcionObsequio = new TextBox();
            btnBuscarObsequio = new Button();
            btnCalcularPago = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbObsequio = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            listBoxTortas = new ListBox();
            listBoxRefresco = new ListBox();
            listBoxPostre = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Location = new Point(418, 222);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(100, 23);
            txtSubtotal.TabIndex = 0;
            // 
            // txtIVA
            // 
            txtIVA.Enabled = false;
            txtIVA.Location = new Point(418, 261);
            txtIVA.Name = "txtIVA";
            txtIVA.Size = new Size(100, 23);
            txtIVA.TabIndex = 1;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(418, 302);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 2;
            // 
            // txtCodigoObsequio
            // 
            txtCodigoObsequio.Enabled = false;
            txtCodigoObsequio.Location = new Point(123, 219);
            txtCodigoObsequio.Name = "txtCodigoObsequio";
            txtCodigoObsequio.Size = new Size(100, 23);
            txtCodigoObsequio.TabIndex = 3;
            txtCodigoObsequio.TextChanged += txtCodigoObsequio_TextChanged;
            // 
            // txtDescripcionObsequio
            // 
            txtDescripcionObsequio.Enabled = false;
            txtDescripcionObsequio.Location = new Point(123, 261);
            txtDescripcionObsequio.Name = "txtDescripcionObsequio";
            txtDescripcionObsequio.Size = new Size(100, 23);
            txtDescripcionObsequio.TabIndex = 4;
            // 
            // btnBuscarObsequio
            // 
            btnBuscarObsequio.Enabled = false;
            btnBuscarObsequio.Location = new Point(238, 219);
            btnBuscarObsequio.Name = "btnBuscarObsequio";
            btnBuscarObsequio.Size = new Size(75, 23);
            btnBuscarObsequio.TabIndex = 5;
            btnBuscarObsequio.Text = "Buscar";
            btnBuscarObsequio.UseVisualStyleBackColor = true;
            btnBuscarObsequio.Click += btnBuscarObsequio_Click;
            // 
            // btnCalcularPago
            // 
            btnCalcularPago.BackColor = SystemColors.ActiveCaption;
            btnCalcularPago.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcularPago.Location = new Point(277, 170);
            btnCalcularPago.Name = "btnCalcularPago";
            btnCalcularPago.Size = new Size(106, 23);
            btnCalcularPago.TabIndex = 9;
            btnCalcularPago.Text = "Calcular Pago";
            btnCalcularPago.UseVisualStyleBackColor = false;
            btnCalcularPago.Click += btnCalcularPago_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(108, 29);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 10;
            label1.Text = "Torta";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(277, 29);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 11;
            label2.Text = "Refresco";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(455, 29);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 12;
            label3.Text = "Postre";
            // 
            // lbObsequio
            // 
            lbObsequio.AutoSize = true;
            lbObsequio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbObsequio.Location = new Point(26, 222);
            lbObsequio.Name = "lbObsequio";
            lbObsequio.Size = new Size(62, 15);
            lbObsequio.TabIndex = 13;
            lbObsequio.Text = "Obsequio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(349, 225);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 14;
            label4.Text = "Subtotal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(368, 264);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 15;
            label5.Text = "IVA:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(366, 310);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 16;
            label6.Text = "Total:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TORTA;
            pictureBox1.Location = new Point(593, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // listBoxTortas
            // 
            listBoxTortas.FormattingEnabled = true;
            listBoxTortas.ItemHeight = 15;
            listBoxTortas.Items.AddRange(new object[] { "PAQUETE KIDS", "JALAPENO", "ITALIANA", "JAMON", "NINGUNO" });
            listBoxTortas.Location = new Point(65, 52);
            listBoxTortas.Name = "listBoxTortas";
            listBoxTortas.Size = new Size(120, 94);
            listBoxTortas.TabIndex = 18;
            listBoxTortas.SelectedIndexChanged += listBoxTortas_SelectedIndexChanged;
            // 
            // listBoxRefresco
            // 
            listBoxRefresco.FormattingEnabled = true;
            listBoxRefresco.ItemHeight = 15;
            listBoxRefresco.Items.AddRange(new object[] { "CHICA", "MEDIANA", "GRANDE", "NINGUNO" });
            listBoxRefresco.Location = new Point(238, 52);
            listBoxRefresco.Name = "listBoxRefresco";
            listBoxRefresco.Size = new Size(120, 94);
            listBoxRefresco.TabIndex = 19;
            listBoxRefresco.SelectedIndexChanged += listBoxRefresco_SelectedIndexChanged;
            // 
            // listBoxPostre
            // 
            listBoxPostre.FormattingEnabled = true;
            listBoxPostre.ItemHeight = 15;
            listBoxPostre.Items.AddRange(new object[] { "GALLETAS", "PAY DE QUESO", "NIEVE", "NIGNUNO" });
            listBoxPostre.Location = new Point(418, 52);
            listBoxPostre.Name = "listBoxPostre";
            listBoxPostre.Size = new Size(120, 94);
            listBoxPostre.TabIndex = 20;
            listBoxPostre.SelectedIndexChanged += listBoxPostre_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 346);
            Controls.Add(listBoxPostre);
            Controls.Add(listBoxRefresco);
            Controls.Add(listBoxTortas);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbObsequio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcularPago);
            Controls.Add(btnBuscarObsequio);
            Controls.Add(txtDescripcionObsequio);
            Controls.Add(txtCodigoObsequio);
            Controls.Add(txtTotal);
            Controls.Add(txtIVA);
            Controls.Add(txtSubtotal);
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSubtotal;
        private TextBox txtIVA;
        private TextBox txtTotal;
        private TextBox txtCodigoObsequio;
        private TextBox txtDescripcionObsequio;
        private Button btnBuscarObsequio;
        private Button btnCalcularPago;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbObsequio;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private ListBox listBoxTortas;
        private ListBox listBoxRefresco;
        private ListBox listBoxPostre;
    }
}
