namespace Proyecto_Logica
{
    partial class PostLogin
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
            this.SalirTestBtn = new System.Windows.Forms.Button();
            this.AtrasBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalirTestBtn
            // 
            this.SalirTestBtn.Location = new System.Drawing.Point(589, 393);
            this.SalirTestBtn.Name = "SalirTestBtn";
            this.SalirTestBtn.Size = new System.Drawing.Size(103, 29);
            this.SalirTestBtn.TabIndex = 0;
            this.SalirTestBtn.Text = "Salir del test";
            this.SalirTestBtn.UseVisualStyleBackColor = true;
            this.SalirTestBtn.Click += new System.EventHandler(this.SalirTestBtn_Click);
            // 
            // AtrasBtn
            // 
            this.AtrasBtn.Location = new System.Drawing.Point(45, 393);
            this.AtrasBtn.Name = "AtrasBtn";
            this.AtrasBtn.Size = new System.Drawing.Size(92, 29);
            this.AtrasBtn.TabIndex = 1;
            this.AtrasBtn.Text = "Volver atrás";
            this.AtrasBtn.UseVisualStyleBackColor = true;
            this.AtrasBtn.Click += new System.EventHandler(this.AtrasBtn_Click);
            // 
            // PostLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.AtrasBtn);
            this.Controls.Add(this.SalirTestBtn);
            this.Name = "PostLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SalirTestBtn;
        private System.Windows.Forms.Button AtrasBtn;
    }
}