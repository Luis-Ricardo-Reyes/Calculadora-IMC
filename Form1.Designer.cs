namespace CalculadoraIMC
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
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Niagara Solid", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 55);
            label1.Name = "label1";
            label1.Size = new Size(54, 33);
            label1.TabIndex = 0;
            label1.Text = "Peso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Niagara Solid", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 132);
            label2.Name = "label2";
            label2.Size = new Size(78, 33);
            label2.TabIndex = 1;
            label2.Text = "Estatura:";
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Niagara Solid", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtPeso.Location = new Point(192, 53);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(150, 40);
            txtPeso.TabIndex = 2;
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Niagara Solid", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltura.Location = new Point(192, 125);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(150, 40);
            txtAltura.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Niagara Solid", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(113, 266);
            button1.Name = "button1";
            button1.Size = new Size(143, 62);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            Controls.Add(button1);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Indice de Masa Corporal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button button1;
    }
}