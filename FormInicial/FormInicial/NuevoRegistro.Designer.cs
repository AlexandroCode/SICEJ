namespace FormInicial
{
    partial class NuevoRegistro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApp = new System.Windows.Forms.Label();
            this.txtApp = new System.Windows.Forms.TextBox();
            this.txtApm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(146, 10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(372, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Location = new System.Drawing.Point(26, 41);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(114, 13);
            this.lblApp.TabIndex = 2;
            this.lblApp.Text = "APELLIDO PATERNO";
            // 
            // txtApp
            // 
            this.txtApp.Location = new System.Drawing.Point(147, 41);
            this.txtApp.Name = "txtApp";
            this.txtApp.Size = new System.Drawing.Size(371, 20);
            this.txtApp.TabIndex = 3;
            // 
            // txtApm
            // 
            this.txtApm.Location = new System.Drawing.Point(147, 68);
            this.txtApm.Name = "txtApm";
            this.txtApm.Size = new System.Drawing.Size(371, 20);
            this.txtApm.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "APELLIDO MATERNO";
            // 
            // NuevoRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApm);
            this.Controls.Add(this.txtApp);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "NuevoRegistro";
            this.Text = "NuevoRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.TextBox txtApp;
        private System.Windows.Forms.TextBox txtApm;
        private System.Windows.Forms.Label label2;
    }
}