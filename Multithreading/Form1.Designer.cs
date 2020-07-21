namespace Multithreading
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
            this.btnStart01 = new System.Windows.Forms.Button();
            this.btnStart02 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnStart01
            // 
            this.btnStart01.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart01.Location = new System.Drawing.Point(32, 75);
            this.btnStart01.Name = "btnStart01";
            this.btnStart01.Size = new System.Drawing.Size(127, 56);
            this.btnStart01.TabIndex = 0;
            this.btnStart01.Text = "Basla";
            this.btnStart01.UseVisualStyleBackColor = true;
            this.btnStart01.Click += new System.EventHandler(this.btnStart01_Click);
            // 
            // btnStart02
            // 
            this.btnStart02.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart02.Location = new System.Drawing.Point(32, 271);
            this.btnStart02.Name = "btnStart02";
            this.btnStart02.Size = new System.Drawing.Size(127, 54);
            this.btnStart02.TabIndex = 1;
            this.btnStart02.Text = "Basla";
            this.btnStart02.UseVisualStyleBackColor = true;
            this.btnStart02.Click += new System.EventHandler(this.btnStart02_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(756, 47);
            this.progressBar1.TabIndex = 2;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(32, 198);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(756, 55);
            this.progressBar2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnStart02);
            this.Controls.Add(this.btnStart01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart01;
        private System.Windows.Forms.Button btnStart02;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}

