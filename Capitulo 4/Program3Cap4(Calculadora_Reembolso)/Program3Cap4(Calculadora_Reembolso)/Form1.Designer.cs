namespace Program3Cap4_Calculadora_Reembolso_
{
    partial class Reembolso
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
            this.lblQInicial = new System.Windows.Forms.Label();
            this.lblQFinal = new System.Windows.Forms.Label();
            this.numericQuilometragemInicial = new System.Windows.Forms.NumericUpDown();
            this.numericQuilometragemFinal = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReembolso = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnMostraQuilometragem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuilometragemInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuilometragemFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQInicial
            // 
            this.lblQInicial.AutoSize = true;
            this.lblQInicial.Location = new System.Drawing.Point(13, 13);
            this.lblQInicial.Name = "lblQInicial";
            this.lblQInicial.Size = new System.Drawing.Size(113, 13);
            this.lblQInicial.TabIndex = 0;
            this.lblQInicial.Text = "Quilometragem Inicial: ";
            // 
            // lblQFinal
            // 
            this.lblQFinal.AutoSize = true;
            this.lblQFinal.Location = new System.Drawing.Point(13, 56);
            this.lblQFinal.Name = "lblQFinal";
            this.lblQFinal.Size = new System.Drawing.Size(108, 13);
            this.lblQFinal.TabIndex = 1;
            this.lblQFinal.Text = "Quilometragem Final: ";
            // 
            // numericQuilometragemInicial
            // 
            this.numericQuilometragemInicial.Location = new System.Drawing.Point(132, 11);
            this.numericQuilometragemInicial.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericQuilometragemInicial.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuilometragemInicial.Name = "numericQuilometragemInicial";
            this.numericQuilometragemInicial.Size = new System.Drawing.Size(120, 20);
            this.numericQuilometragemInicial.TabIndex = 2;
            this.numericQuilometragemInicial.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericQuilometragemFinal
            // 
            this.numericQuilometragemFinal.Location = new System.Drawing.Point(132, 54);
            this.numericQuilometragemFinal.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericQuilometragemFinal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuilometragemFinal.Name = "numericQuilometragemFinal";
            this.numericQuilometragemFinal.Size = new System.Drawing.Size(120, 20);
            this.numericQuilometragemFinal.TabIndex = 3;
            this.numericQuilometragemFinal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor Reembolso";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblReembolso
            // 
            this.lblReembolso.AutoSize = true;
            this.lblReembolso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReembolso.Location = new System.Drawing.Point(128, 89);
            this.lblReembolso.Name = "lblReembolso";
            this.lblReembolso.Size = new System.Drawing.Size(0, 20);
            this.lblReembolso.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(16, 128);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(76, 28);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnMostraQuilometragem
            // 
            this.btnMostraQuilometragem.Location = new System.Drawing.Point(132, 121);
            this.btnMostraQuilometragem.Name = "btnMostraQuilometragem";
            this.btnMostraQuilometragem.Size = new System.Drawing.Size(115, 42);
            this.btnMostraQuilometragem.TabIndex = 7;
            this.btnMostraQuilometragem.Text = "Mostrar Quilometragem";
            this.btnMostraQuilometragem.UseVisualStyleBackColor = true;
            this.btnMostraQuilometragem.Click += new System.EventHandler(this.btnMostraQuilometragem_Click);
            // 
            // Reembolso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 186);
            this.Controls.Add(this.btnMostraQuilometragem);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblReembolso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericQuilometragemFinal);
            this.Controls.Add(this.numericQuilometragemInicial);
            this.Controls.Add(this.lblQFinal);
            this.Controls.Add(this.lblQInicial);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reembolso";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Reembolso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuilometragemInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuilometragemFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQInicial;
        private System.Windows.Forms.Label lblQFinal;
        private System.Windows.Forms.NumericUpDown numericQuilometragemInicial;
        private System.Windows.Forms.NumericUpDown numericQuilometragemFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReembolso;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnMostraQuilometragem;
    }
}

