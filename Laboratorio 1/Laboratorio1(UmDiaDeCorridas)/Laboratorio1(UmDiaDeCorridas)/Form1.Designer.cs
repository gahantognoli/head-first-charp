namespace Laboratorio1_UmDiaDeCorridas_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PistaCorrida = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.SalaApostas = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblApostaJoe = new System.Windows.Forms.Label();
            this.lblApostaBob = new System.Windows.Forms.Label();
            this.lblApostaAl = new System.Windows.Forms.Label();
            this.btn_Correr = new System.Windows.Forms.Button();
            this.Numero_Cao = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Valor_Aposta = new System.Windows.Forms.NumericUpDown();
            this.Btn_Apostar = new System.Windows.Forms.Button();
            this.lblApostador = new System.Windows.Forms.Label();
            this.radioButtonAl = new System.Windows.Forms.RadioButton();
            this.radioButtonBob = new System.Windows.Forms.RadioButton();
            this.radioButtonJoe = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PistaCorrida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SalaApostas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numero_Cao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Valor_Aposta)).BeginInit();
            this.SuspendLayout();
            // 
            // PistaCorrida
            // 
            this.PistaCorrida.Image = ((System.Drawing.Image)(resources.GetObject("PistaCorrida.Image")));
            this.PistaCorrida.Location = new System.Drawing.Point(0, 4);
            this.PistaCorrida.Name = "PistaCorrida";
            this.PistaCorrida.Size = new System.Drawing.Size(635, 215);
            this.PistaCorrida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PistaCorrida.TabIndex = 0;
            this.PistaCorrida.TabStop = false;
            this.PistaCorrida.Click += new System.EventHandler(this.PistaCorrida_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 56);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 110);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(94, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 170);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(94, 37);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // SalaApostas
            // 
            this.SalaApostas.Controls.Add(this.groupBox1);
            this.SalaApostas.Controls.Add(this.btn_Correr);
            this.SalaApostas.Controls.Add(this.Numero_Cao);
            this.SalaApostas.Controls.Add(this.label3);
            this.SalaApostas.Controls.Add(this.Valor_Aposta);
            this.SalaApostas.Controls.Add(this.Btn_Apostar);
            this.SalaApostas.Controls.Add(this.lblApostador);
            this.SalaApostas.Controls.Add(this.radioButtonAl);
            this.SalaApostas.Controls.Add(this.radioButtonBob);
            this.SalaApostas.Controls.Add(this.radioButtonJoe);
            this.SalaApostas.Controls.Add(this.label1);
            this.SalaApostas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaApostas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SalaApostas.Location = new System.Drawing.Point(12, 225);
            this.SalaApostas.Name = "SalaApostas";
            this.SalaApostas.Size = new System.Drawing.Size(614, 162);
            this.SalaApostas.TabIndex = 5;
            this.SalaApostas.TabStop = false;
            this.SalaApostas.Text = "Salão de Apostas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblApostaJoe);
            this.groupBox1.Controls.Add(this.lblApostaBob);
            this.groupBox1.Controls.Add(this.lblApostaAl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(309, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apostas";
            // 
            // lblApostaJoe
            // 
            this.lblApostaJoe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApostaJoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApostaJoe.ForeColor = System.Drawing.Color.Black;
            this.lblApostaJoe.Location = new System.Drawing.Point(6, 22);
            this.lblApostaJoe.Name = "lblApostaJoe";
            this.lblApostaJoe.Size = new System.Drawing.Size(287, 19);
            this.lblApostaJoe.TabIndex = 10;
            this.lblApostaJoe.Text = "Joe apostou";
            // 
            // lblApostaBob
            // 
            this.lblApostaBob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApostaBob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApostaBob.ForeColor = System.Drawing.Color.Black;
            this.lblApostaBob.Location = new System.Drawing.Point(6, 48);
            this.lblApostaBob.Name = "lblApostaBob";
            this.lblApostaBob.Size = new System.Drawing.Size(287, 19);
            this.lblApostaBob.TabIndex = 11;
            this.lblApostaBob.Text = "Bob apostou";
            // 
            // lblApostaAl
            // 
            this.lblApostaAl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApostaAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApostaAl.ForeColor = System.Drawing.Color.Black;
            this.lblApostaAl.Location = new System.Drawing.Point(6, 73);
            this.lblApostaAl.Name = "lblApostaAl";
            this.lblApostaAl.Size = new System.Drawing.Size(287, 19);
            this.lblApostaAl.TabIndex = 12;
            this.lblApostaAl.Text = "Al apostou";
            // 
            // btn_Correr
            // 
            this.btn_Correr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Correr.ForeColor = System.Drawing.Color.Black;
            this.btn_Correr.Location = new System.Drawing.Point(520, 126);
            this.btn_Correr.Name = "btn_Correr";
            this.btn_Correr.Size = new System.Drawing.Size(88, 30);
            this.btn_Correr.TabIndex = 13;
            this.btn_Correr.Text = "Correr!";
            this.btn_Correr.UseVisualStyleBackColor = true;
            // 
            // Numero_Cao
            // 
            this.Numero_Cao.Location = new System.Drawing.Point(347, 135);
            this.Numero_Cao.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Numero_Cao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numero_Cao.Name = "Numero_Cao";
            this.Numero_Cao.Size = new System.Drawing.Size(71, 21);
            this.Numero_Cao.TabIndex = 8;
            this.Numero_Cao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(203, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "reais no cão número";
            // 
            // Valor_Aposta
            // 
            this.Valor_Aposta.Location = new System.Drawing.Point(121, 135);
            this.Valor_Aposta.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.Valor_Aposta.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Valor_Aposta.Name = "Valor_Aposta";
            this.Valor_Aposta.Size = new System.Drawing.Size(76, 21);
            this.Valor_Aposta.TabIndex = 6;
            this.Valor_Aposta.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Btn_Apostar
            // 
            this.Btn_Apostar.Location = new System.Drawing.Point(41, 133);
            this.Btn_Apostar.Name = "Btn_Apostar";
            this.Btn_Apostar.Size = new System.Drawing.Size(73, 23);
            this.Btn_Apostar.TabIndex = 5;
            this.Btn_Apostar.Text = "Aposta";
            this.Btn_Apostar.UseVisualStyleBackColor = true;
            // 
            // lblApostador
            // 
            this.lblApostador.AutoSize = true;
            this.lblApostador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApostador.ForeColor = System.Drawing.Color.Black;
            this.lblApostador.Location = new System.Drawing.Point(4, 135);
            this.lblApostador.Name = "lblApostador";
            this.lblApostador.Size = new System.Drawing.Size(31, 17);
            this.lblApostador.TabIndex = 4;
            this.lblApostador.Text = "Joe";
            // 
            // radioButtonAl
            // 
            this.radioButtonAl.AutoSize = true;
            this.radioButtonAl.Location = new System.Drawing.Point(10, 93);
            this.radioButtonAl.Name = "radioButtonAl";
            this.radioButtonAl.Size = new System.Drawing.Size(35, 19);
            this.radioButtonAl.TabIndex = 3;
            this.radioButtonAl.TabStop = true;
            this.radioButtonAl.Text = "Al";
            this.radioButtonAl.UseVisualStyleBackColor = true;
            // 
            // radioButtonBob
            // 
            this.radioButtonBob.AutoSize = true;
            this.radioButtonBob.Location = new System.Drawing.Point(10, 68);
            this.radioButtonBob.Name = "radioButtonBob";
            this.radioButtonBob.Size = new System.Drawing.Size(47, 19);
            this.radioButtonBob.TabIndex = 2;
            this.radioButtonBob.TabStop = true;
            this.radioButtonBob.Text = "Bob\r\n";
            this.radioButtonBob.UseVisualStyleBackColor = true;
            // 
            // radioButtonJoe
            // 
            this.radioButtonJoe.AutoSize = true;
            this.radioButtonJoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonJoe.ForeColor = System.Drawing.Color.Black;
            this.radioButtonJoe.Location = new System.Drawing.Point(10, 43);
            this.radioButtonJoe.Name = "radioButtonJoe";
            this.radioButtonJoe.Size = new System.Drawing.Size(45, 19);
            this.radioButtonJoe.TabIndex = 1;
            this.radioButtonJoe.TabStop = true;
            this.radioButtonJoe.Text = "Joe";
            this.radioButtonJoe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aposta Mínima";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 391);
            this.Controls.Add(this.SalaApostas);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PistaCorrida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PistaCorrida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.SalaApostas.ResumeLayout(false);
            this.SalaApostas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Numero_Cao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Valor_Aposta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PistaCorrida;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox SalaApostas;
        private System.Windows.Forms.NumericUpDown Numero_Cao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Valor_Aposta;
        private System.Windows.Forms.Button Btn_Apostar;
        private System.Windows.Forms.Label lblApostador;
        private System.Windows.Forms.RadioButton radioButtonAl;
        private System.Windows.Forms.RadioButton radioButtonBob;
        private System.Windows.Forms.RadioButton radioButtonJoe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblApostaAl;
        private System.Windows.Forms.Label lblApostaBob;
        private System.Windows.Forms.Label lblApostaJoe;
        private System.Windows.Forms.Button btn_Correr;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

