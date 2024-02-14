namespace Ejercicio9_Descuento_Articulos
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
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblDescuento = new Label();
            txtDescuento = new TextBox();
            btnCalcular = new Button();
            lblMonto = new Label();
            lblDescuentoAplicado = new Label();
            lblItbis = new Label();
            lblMontoNeto = new Label();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            txtResultadoMonto = new TextBox();
            txtResultadoDescuento = new TextBox();
            txtResultadoItbis = new TextBox();
            txtResultadoMontoNeto = new TextBox();
            SuspendLayout();
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblPrecio.Location = new Point(92, 34);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(72, 26);
            lblPrecio.TabIndex = 0;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = SystemColors.Highlight;
            txtPrecio.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.ForeColor = SystemColors.InactiveBorder;
            txtPrecio.Location = new Point(210, 31);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 34);
            txtPrecio.TabIndex = 1;
            txtPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblDescuento.Location = new Point(92, 96);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(111, 26);
            lblDescuento.TabIndex = 2;
            lblDescuento.Text = "Descuento";
            // 
            // txtDescuento
            // 
            txtDescuento.BackColor = SystemColors.ButtonFace;
            txtDescuento.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescuento.ForeColor = Color.Black;
            txtDescuento.Location = new Point(210, 88);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(125, 34);
            txtDescuento.TabIndex = 3;
            txtDescuento.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.Highlight;
            btnCalcular.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnCalcular.ForeColor = Color.Transparent;
            btnCalcular.Location = new Point(431, 388);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 50);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblMonto.Location = new Point(92, 166);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(74, 26);
            lblMonto.TabIndex = 6;
            lblMonto.Text = "Monto";
            // 
            // lblDescuentoAplicado
            // 
            lblDescuentoAplicado.AutoSize = true;
            lblDescuentoAplicado.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblDescuentoAplicado.Location = new Point(92, 223);
            lblDescuentoAplicado.Name = "lblDescuentoAplicado";
            lblDescuentoAplicado.Size = new Size(204, 26);
            lblDescuentoAplicado.TabIndex = 7;
            lblDescuentoAplicado.Text = "Descuento a Aplicar";
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblItbis.Location = new Point(92, 280);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(54, 26);
            lblItbis.TabIndex = 9;
            lblItbis.Text = "Itbis";
            // 
            // lblMontoNeto
            // 
            lblMontoNeto.AutoSize = true;
            lblMontoNeto.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblMontoNeto.Location = new Point(92, 331);
            lblMontoNeto.Name = "lblMontoNeto";
            lblMontoNeto.Size = new Size(121, 26);
            lblMontoNeto.TabIndex = 11;
            lblMontoNeto.Text = "Monto neto";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.Highlight;
            btnLimpiar.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.Transparent;
            btnLimpiar.Location = new Point(549, 388);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 50);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.Highlight;
            btnCerrar.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.Transparent;
            btnCerrar.Location = new Point(667, 388);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(112, 50);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtResultadoMonto
            // 
            txtResultadoMonto.BackColor = SystemColors.ButtonFace;
            txtResultadoMonto.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultadoMonto.ForeColor = Color.Black;
            txtResultadoMonto.Location = new Point(192, 163);
            txtResultadoMonto.Name = "txtResultadoMonto";
            txtResultadoMonto.Size = new Size(125, 34);
            txtResultadoMonto.TabIndex = 15;
            txtResultadoMonto.TextAlign = HorizontalAlignment.Center;
            // 
            // txtResultadoDescuento
            // 
            txtResultadoDescuento.BackColor = SystemColors.ButtonFace;
            txtResultadoDescuento.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultadoDescuento.ForeColor = Color.Black;
            txtResultadoDescuento.Location = new Point(301, 223);
            txtResultadoDescuento.Name = "txtResultadoDescuento";
            txtResultadoDescuento.Size = new Size(125, 34);
            txtResultadoDescuento.TabIndex = 16;
            txtResultadoDescuento.TextAlign = HorizontalAlignment.Center;
            // 
            // txtResultadoItbis
            // 
            txtResultadoItbis.BackColor = SystemColors.ButtonFace;
            txtResultadoItbis.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultadoItbis.ForeColor = Color.Black;
            txtResultadoItbis.Location = new Point(178, 277);
            txtResultadoItbis.Name = "txtResultadoItbis";
            txtResultadoItbis.Size = new Size(125, 34);
            txtResultadoItbis.TabIndex = 17;
            txtResultadoItbis.TextAlign = HorizontalAlignment.Center;
            // 
            // txtResultadoMontoNeto
            // 
            txtResultadoMontoNeto.BackColor = SystemColors.ButtonFace;
            txtResultadoMontoNeto.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultadoMontoNeto.ForeColor = Color.Black;
            txtResultadoMontoNeto.Location = new Point(252, 328);
            txtResultadoMontoNeto.Name = "txtResultadoMontoNeto";
            txtResultadoMontoNeto.Size = new Size(125, 34);
            txtResultadoMontoNeto.TabIndex = 18;
            txtResultadoMontoNeto.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultadoMontoNeto);
            Controls.Add(txtResultadoItbis);
            Controls.Add(txtResultadoDescuento);
            Controls.Add(txtResultadoMonto);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(lblMontoNeto);
            Controls.Add(lblItbis);
            Controls.Add(lblDescuentoAplicado);
            Controls.Add(lblMonto);
            Controls.Add(btnCalcular);
            Controls.Add(txtDescuento);
            Controls.Add(lblDescuento);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblDescuento;
        private TextBox txtDescuento;
        private Button btnCalcular;
        private Label lblMonto;
        private Label lblDescuentoAplicado;
        private Label lblItbis;
        private Label lblMontoNeto;
        private Button btnLimpiar;
        private Button btnCerrar;
        private TextBox txtResultadoMonto;
        private TextBox txtResultadoDescuento;
        private TextBox txtResultadoItbis;
        private TextBox txtResultadoMontoNeto;
    }
}