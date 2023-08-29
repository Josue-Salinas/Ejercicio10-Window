namespace Ejercicio10
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
            label1 = new Label();
            label2 = new Label();
            lblresultado = new Label();
            label4 = new Label();
            lblimportetotal = new Label();
            button1 = new Button();
            textcosto = new TextBox();
            label3 = new Label();
            textdescuento = new TextBox();
            textsubtotal = new TextBox();
            textimpuesto = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 33);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "BOLETA DE VENTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 179);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "DESCUENTO";
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(201, 239);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(62, 15);
            lblresultado.TabIndex = 2;
            lblresultado.Text = "IMPUESTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 210);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "SUBTOTAL";
            // 
            // lblimportetotal
            // 
            lblimportetotal.AutoSize = true;
            lblimportetotal.Location = new Point(201, 343);
            lblimportetotal.Name = "lblimportetotal";
            lblimportetotal.Size = new Size(96, 15);
            lblimportetotal.TabIndex = 4;
            lblimportetotal.Text = "IMPORTE TOTAL: ";
            // 
            // button1
            // 
            button1.Location = new Point(688, 97);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textcosto
            // 
            textcosto.Location = new Point(487, 98);
            textcosto.Name = "textcosto";
            textcosto.Size = new Size(100, 23);
            textcosto.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 101);
            label3.Name = "label3";
            label3.Size = new Size(177, 15);
            label3.TabIndex = 10;
            label3.Text = "¿Cuál es el costo de los platillos?";
            // 
            // textdescuento
            // 
            textdescuento.Location = new Point(350, 176);
            textdescuento.Name = "textdescuento";
            textdescuento.Size = new Size(100, 23);
            textdescuento.TabIndex = 11;
            // 
            // textsubtotal
            // 
            textsubtotal.Location = new Point(350, 207);
            textsubtotal.Name = "textsubtotal";
            textsubtotal.Size = new Size(100, 23);
            textsubtotal.TabIndex = 12;
            // 
            // textimpuesto
            // 
            textimpuesto.Location = new Point(350, 236);
            textimpuesto.Name = "textimpuesto";
            textimpuesto.Size = new Size(100, 23);
            textimpuesto.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textimpuesto);
            Controls.Add(textsubtotal);
            Controls.Add(textdescuento);
            Controls.Add(label3);
            Controls.Add(textcosto);
            Controls.Add(button1);
            Controls.Add(lblimportetotal);
            Controls.Add(label4);
            Controls.Add(lblresultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblresultado;
        private Label label4;
        private Label lblimportetotal;
        private Button button1;
        private TextBox textcosto;
        private Label label3;
        private TextBox textdescuento;
        private TextBox textsubtotal;
        private TextBox textimpuesto;
    }
}