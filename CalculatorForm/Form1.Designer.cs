namespace proxy
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
            this.tbno1 = new System.Windows.Forms.TextBox();
            this.tbno2 = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsubtract = new System.Windows.Forms.Button();
            this.btnmultiply = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.lblequlas = new System.Windows.Forms.Label();
            this.tbanswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbno1
            // 
            this.tbno1.Location = new System.Drawing.Point(13, 13);
            this.tbno1.Name = "tbno1";
            this.tbno1.Size = new System.Drawing.Size(157, 22);
            this.tbno1.TabIndex = 0;
            // 
            // tbno2
            // 
            this.tbno2.Location = new System.Drawing.Point(12, 100);
            this.tbno2.Name = "tbno2";
            this.tbno2.Size = new System.Drawing.Size(158, 22);
            this.tbno2.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(13, 41);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsubtract
            // 
            this.btnsubtract.Location = new System.Drawing.Point(95, 40);
            this.btnsubtract.Name = "btnsubtract";
            this.btnsubtract.Size = new System.Drawing.Size(75, 23);
            this.btnsubtract.TabIndex = 3;
            this.btnsubtract.Text = "-";
            this.btnsubtract.UseVisualStyleBackColor = true;
            this.btnsubtract.Click += new System.EventHandler(this.btnsubtract_Click);
            // 
            // btnmultiply
            // 
            this.btnmultiply.Location = new System.Drawing.Point(13, 71);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(75, 23);
            this.btnmultiply.TabIndex = 4;
            this.btnmultiply.Text = "x";
            this.btnmultiply.UseVisualStyleBackColor = true;
            this.btnmultiply.Click += new System.EventHandler(this.btnmultiply_Click);
            // 
            // btndivide
            // 
            this.btndivide.Location = new System.Drawing.Point(95, 70);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(75, 23);
            this.btndivide.TabIndex = 5;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = true;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // lblequlas
            // 
            this.lblequlas.AutoSize = true;
            this.lblequlas.Location = new System.Drawing.Point(13, 129);
            this.lblequlas.Name = "lblequlas";
            this.lblequlas.Size = new System.Drawing.Size(16, 17);
            this.lblequlas.TabIndex = 6;
            this.lblequlas.Text = "=";
            // 
            // tbanswer
            // 
            this.tbanswer.Location = new System.Drawing.Point(13, 150);
            this.tbanswer.Name = "tbanswer";
            this.tbanswer.Size = new System.Drawing.Size(100, 22);
            this.tbanswer.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 206);
            this.Controls.Add(this.tbanswer);
            this.Controls.Add(this.lblequlas);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnmultiply);
            this.Controls.Add(this.btnsubtract);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.tbno2);
            this.Controls.Add(this.tbno1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbno1;
        private System.Windows.Forms.TextBox tbno2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsubtract;
        private System.Windows.Forms.Button btnmultiply;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Label lblequlas;
        private System.Windows.Forms.TextBox tbanswer;
    }
}

