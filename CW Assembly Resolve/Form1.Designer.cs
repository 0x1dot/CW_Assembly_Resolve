namespace CW_Assembly_Resolve
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
            this.txtSikistirYol = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGozat = new System.Windows.Forms.Button();
            this.btnSikistir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGozat1 = new System.Windows.Forms.Button();
            this.btnCikart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAcYol = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSikistirYol
            // 
            this.txtSikistirYol.Location = new System.Drawing.Point(9, 24);
            this.txtSikistirYol.Name = "txtSikistirYol";
            this.txtSikistirYol.ReadOnly = true;
            this.txtSikistirYol.Size = new System.Drawing.Size(198, 20);
            this.txtSikistirYol.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(282, 108);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGozat);
            this.tabPage1.Controls.Add(this.btnSikistir);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtSikistirYol);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(274, 82);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sıkıştır";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGozat
            // 
            this.btnGozat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGozat.Location = new System.Drawing.Point(213, 22);
            this.btnGozat.Name = "btnGozat";
            this.btnGozat.Size = new System.Drawing.Size(53, 23);
            this.btnGozat.TabIndex = 4;
            this.btnGozat.Text = "Gözat";
            this.btnGozat.UseVisualStyleBackColor = true;
            this.btnGozat.Click += new System.EventHandler(this.btnGozat_Click);
            // 
            // btnSikistir
            // 
            this.btnSikistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSikistir.Location = new System.Drawing.Point(9, 51);
            this.btnSikistir.Name = "btnSikistir";
            this.btnSikistir.Size = new System.Drawing.Size(257, 23);
            this.btnSikistir.TabIndex = 3;
            this.btnSikistir.Text = "Sıkıştır";
            this.btnSikistir.UseVisualStyleBackColor = true;
            this.btnSikistir.Click += new System.EventHandler(this.btnSikistir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dosya seçiniz";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGozat1);
            this.tabPage2.Controls.Add(this.btnCikart);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtAcYol);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(274, 82);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Çıkart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGozat1
            // 
            this.btnGozat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGozat1.Location = new System.Drawing.Point(213, 22);
            this.btnGozat1.Name = "btnGozat1";
            this.btnGozat1.Size = new System.Drawing.Size(53, 23);
            this.btnGozat1.TabIndex = 9;
            this.btnGozat1.Text = "Gözat";
            this.btnGozat1.UseVisualStyleBackColor = true;
            this.btnGozat1.Click += new System.EventHandler(this.btnGozat1_Click);
            // 
            // btnCikart
            // 
            this.btnCikart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikart.Location = new System.Drawing.Point(9, 51);
            this.btnCikart.Name = "btnCikart";
            this.btnCikart.Size = new System.Drawing.Size(257, 23);
            this.btnCikart.TabIndex = 8;
            this.btnCikart.Text = "Çıkart";
            this.btnCikart.UseVisualStyleBackColor = true;
            this.btnCikart.Click += new System.EventHandler(this.btnCikart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dosya seçiniz";
            // 
            // txtAcYol
            // 
            this.txtAcYol.Location = new System.Drawing.Point(9, 24);
            this.txtAcYol.Name = "txtAcYol";
            this.txtAcYol.ReadOnly = true;
            this.txtAcYol.Size = new System.Drawing.Size(198, 20);
            this.txtAcYol.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 108);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Assembly Resolve";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSikistirYol;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGozat;
        private System.Windows.Forms.Button btnSikistir;
        private System.Windows.Forms.Button btnGozat1;
        private System.Windows.Forms.Button btnCikart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAcYol;
    }
}

