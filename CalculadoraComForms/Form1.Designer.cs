namespace CalculadoraComForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            CaixadeTexto = new TextBox();
            Clear = new Button();
            Divisao = new Button();
            Multi = new Button();
            Soma = new Button();
            Sub = new Button();
            Zero = new Button();
            Um = new Button();
            Dois = new Button();
            Tres = new Button();
            Quatro = new Button();
            Cinco = new Button();
            Seis = new Button();
            Sete = new Button();
            Oito = new Button();
            Nove = new Button();
            Virgula = new Button();
            Igual = new Button();
            LabelOperador = new Label();
            SuspendLayout();
            // 
            // CaixadeTexto
            // 
            CaixadeTexto.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CaixadeTexto.Location = new Point(12, 39);
            CaixadeTexto.Name = "CaixadeTexto";
            CaixadeTexto.Size = new Size(270, 41);
            CaixadeTexto.TabIndex = 0;
            CaixadeTexto.TextAlign = HorizontalAlignment.Center;
            // 
            // Clear
            // 
            Clear.BackColor = Color.Crimson;
            Clear.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clear.ForeColor = SystemColors.ControlLightLight;
            Clear.Location = new Point(243, 90);
            Clear.Name = "Clear";
            Clear.Size = new Size(39, 40);
            Clear.TabIndex = 4;
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // Divisao
            // 
            Divisao.BackColor = Color.Gray;
            Divisao.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Divisao.ForeColor = SystemColors.ActiveCaptionText;
            Divisao.Location = new Point(243, 147);
            Divisao.Name = "Divisao";
            Divisao.Size = new Size(39, 40);
            Divisao.TabIndex = 11;
            Divisao.Text = "/";
            Divisao.UseVisualStyleBackColor = false;
            Divisao.Click += Divisao_Click;
            // 
            // Multi
            // 
            Multi.BackColor = Color.Gray;
            Multi.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Multi.ForeColor = SystemColors.ActiveCaptionText;
            Multi.Location = new Point(243, 200);
            Multi.Name = "Multi";
            Multi.Size = new Size(39, 40);
            Multi.TabIndex = 12;
            Multi.Text = "*";
            Multi.UseVisualStyleBackColor = false;
            Multi.Click += Multi_Click;
            // 
            // Soma
            // 
            Soma.BackColor = Color.Gray;
            Soma.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Soma.ForeColor = SystemColors.ActiveCaptionText;
            Soma.Location = new Point(243, 255);
            Soma.Name = "Soma";
            Soma.Size = new Size(39, 40);
            Soma.TabIndex = 15;
            Soma.Text = "+";
            Soma.UseVisualStyleBackColor = false;
            Soma.Click += Soma_Click;
            // 
            // Sub
            // 
            Sub.BackColor = Color.Gray;
            Sub.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sub.ForeColor = SystemColors.ActiveCaptionText;
            Sub.Location = new Point(243, 310);
            Sub.Name = "Sub";
            Sub.Size = new Size(39, 40);
            Sub.TabIndex = 16;
            Sub.Text = "-";
            Sub.UseVisualStyleBackColor = false;
            Sub.Click += Sub_Click;
            // 
            // Zero
            // 
            Zero.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Zero.Location = new Point(12, 255);
            Zero.Name = "Zero";
            Zero.Size = new Size(149, 40);
            Zero.TabIndex = 13;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = true;
            Zero.Click += Zero_Click;
            // 
            // Um
            // 
            Um.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Um.Location = new Point(12, 200);
            Um.Name = "Um";
            Um.Size = new Size(73, 40);
            Um.TabIndex = 8;
            Um.Text = "1";
            Um.UseVisualStyleBackColor = true;
            Um.Click += Um_Click;
            // 
            // Dois
            // 
            Dois.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dois.Location = new Point(91, 200);
            Dois.Name = "Dois";
            Dois.Size = new Size(70, 40);
            Dois.TabIndex = 9;
            Dois.Text = "2";
            Dois.UseVisualStyleBackColor = true;
            Dois.Click += Dois_Click;
            // 
            // Tres
            // 
            Tres.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tres.Location = new Point(167, 200);
            Tres.Name = "Tres";
            Tres.Size = new Size(70, 40);
            Tres.TabIndex = 10;
            Tres.Text = "3";
            Tres.UseVisualStyleBackColor = true;
            Tres.Click += Tres_Click;
            // 
            // Quatro
            // 
            Quatro.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Quatro.Location = new Point(12, 147);
            Quatro.Name = "Quatro";
            Quatro.Size = new Size(73, 40);
            Quatro.TabIndex = 5;
            Quatro.Text = "4";
            Quatro.UseVisualStyleBackColor = true;
            Quatro.Click += Quatro_Click;
            // 
            // Cinco
            // 
            Cinco.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cinco.Location = new Point(91, 147);
            Cinco.Name = "Cinco";
            Cinco.Size = new Size(70, 40);
            Cinco.TabIndex = 6;
            Cinco.Text = "5";
            Cinco.UseVisualStyleBackColor = true;
            Cinco.Click += Cinco_Click;
            // 
            // Seis
            // 
            Seis.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Seis.Location = new Point(167, 147);
            Seis.Name = "Seis";
            Seis.Size = new Size(70, 40);
            Seis.TabIndex = 7;
            Seis.Text = "6";
            Seis.UseVisualStyleBackColor = true;
            Seis.Click += Seis_Click;
            // 
            // Sete
            // 
            Sete.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sete.Location = new Point(12, 90);
            Sete.Name = "Sete";
            Sete.Size = new Size(73, 40);
            Sete.TabIndex = 1;
            Sete.Text = "7";
            Sete.UseVisualStyleBackColor = true;
            Sete.Click += Sete_Click;
            // 
            // Oito
            // 
            Oito.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Oito.Location = new Point(91, 90);
            Oito.Name = "Oito";
            Oito.Size = new Size(70, 40);
            Oito.TabIndex = 2;
            Oito.Text = "8";
            Oito.UseVisualStyleBackColor = true;
            Oito.Click += Oito_Click;
            // 
            // Nove
            // 
            Nove.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nove.Location = new Point(167, 90);
            Nove.Name = "Nove";
            Nove.Size = new Size(70, 40);
            Nove.TabIndex = 3;
            Nove.Text = "9";
            Nove.UseVisualStyleBackColor = true;
            Nove.Click += Nove_Click;
            // 
            // Virgula
            // 
            Virgula.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Virgula.Location = new Point(167, 255);
            Virgula.Name = "Virgula";
            Virgula.Size = new Size(70, 40);
            Virgula.TabIndex = 14;
            Virgula.Text = ",";
            Virgula.UseVisualStyleBackColor = true;
            Virgula.Click += Virgula_Click;
            // 
            // Igual
            // 
            Igual.BackColor = Color.Gray;
            Igual.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Igual.Location = new Point(12, 310);
            Igual.Name = "Igual";
            Igual.Size = new Size(225, 40);
            Igual.TabIndex = 17;
            Igual.Text = "=";
            Igual.UseVisualStyleBackColor = false;
            Igual.Click += Igual_Click;
            // 
            // LabelOperador
            // 
            LabelOperador.AutoSize = true;
            LabelOperador.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelOperador.Location = new Point(12, 19);
            LabelOperador.Name = "LabelOperador";
            LabelOperador.Size = new Size(171, 17);
            LabelOperador.TabIndex = 18;
            LabelOperador.Text = "Operação sendo realizada:  ";
            LabelOperador.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 375);
            Controls.Add(LabelOperador);
            Controls.Add(Igual);
            Controls.Add(Sub);
            Controls.Add(Soma);
            Controls.Add(Virgula);
            Controls.Add(Zero);
            Controls.Add(Multi);
            Controls.Add(Divisao);
            Controls.Add(Tres);
            Controls.Add(Dois);
            Controls.Add(Um);
            Controls.Add(Seis);
            Controls.Add(Cinco);
            Controls.Add(Quatro);
            Controls.Add(Clear);
            Controls.Add(Nove);
            Controls.Add(Oito);
            Controls.Add(Sete);
            Controls.Add(CaixadeTexto);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CaixadeTexto;
        private Button Sete;
        private Button Oito;
        private Button Nove;
        private Button Clear;
        private Button Quatro;
        private Button Cinco;
        private Button Seis;
        private Button Um;
        private Button Dois;
        private Button Tres;
        private Button Divisao;
        private Button Multi;
        private Button Zero;
        private Button Virgula;
        private Button Soma;
        private Button Sub;
        private Button Igual;
        private Label LabelOperador;
    }
}
