
namespace TesterEncodingString
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSource = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblLongSource = new System.Windows.Forms.Label();
            this.lblLongResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(42, 39);
            this.txtSource.MaxLength = 32767000;
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(660, 126);
            this.txtSource.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enconding ASCII";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(42, 275);
            this.txtResult.MaxLength = 32767000;
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(660, 126);
            this.txtResult.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Enconding Special Chars";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Enconding UTF 8";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(258, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 28);
            this.button4.TabIndex = 5;
            this.button4.Text = "Enconding NonprintableChars";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblLongSource
            // 
            this.lblLongSource.AutoSize = true;
            this.lblLongSource.Location = new System.Drawing.Point(588, 187);
            this.lblLongSource.Name = "lblLongSource";
            this.lblLongSource.Size = new System.Drawing.Size(16, 17);
            this.lblLongSource.TabIndex = 6;
            this.lblLongSource.Text = "0";
            // 
            // lblLongResult
            // 
            this.lblLongResult.AutoSize = true;
            this.lblLongResult.Location = new System.Drawing.Point(588, 415);
            this.lblLongResult.Name = "lblLongResult";
            this.lblLongResult.Size = new System.Drawing.Size(16, 17);
            this.lblLongResult.TabIndex = 7;
            this.lblLongResult.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLongResult);
            this.Controls.Add(this.lblLongSource);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSource);
            this.Name = "Form1";
            this.Text = "Text Encoding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblLongSource;
        private System.Windows.Forms.Label lblLongResult;
    }
}

