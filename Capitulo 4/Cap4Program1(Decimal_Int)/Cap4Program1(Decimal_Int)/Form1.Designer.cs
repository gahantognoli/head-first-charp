namespace Cap4Program1_Decimal_Int_
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
            this.brnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brnCalc
            // 
            this.brnCalc.Location = new System.Drawing.Point(58, 44);
            this.brnCalc.Name = "brnCalc";
            this.brnCalc.Size = new System.Drawing.Size(75, 23);
            this.brnCalc.TabIndex = 0;
            this.brnCalc.Text = "Botão";
            this.brnCalc.UseVisualStyleBackColor = true;
            this.brnCalc.Click += new System.EventHandler(this.brnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 133);
            this.Controls.Add(this.brnCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button brnCalc;
    }
}

