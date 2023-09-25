namespace button._8
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
            this.btnekle = new System.Windows.Forms.Button();
            this.txtmeyve = new System.Windows.Forms.TextBox();
            this.list = new System.Windows.Forms.ListBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(57, 182);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(100, 57);
            this.btnekle.TabIndex = 0;
            this.btnekle.Text = "sepete ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txtmeyve
            // 
            this.txtmeyve.Location = new System.Drawing.Point(57, 119);
            this.txtmeyve.Name = "txtmeyve";
            this.txtmeyve.Size = new System.Drawing.Size(100, 20);
            this.txtmeyve.TabIndex = 1;
            this.txtmeyve.TextChanged += new System.EventHandler(this.txtmeyve_TextChanged);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(225, 119);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(120, 147);
            this.list.TabIndex = 2;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(57, 254);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(100, 57);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "sepeti sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 431);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.list);
            this.Controls.Add(this.txtmeyve);
            this.Controls.Add(this.btnekle);
            this.Name = "Form1";
            this.Text = "MANAV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txtmeyve;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button btnsil;
    }
}

