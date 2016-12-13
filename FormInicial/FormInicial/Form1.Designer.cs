namespace FormInicial
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dactiloscopiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.psicologiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.educativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juridicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dactiloscopiaToolStripMenuItem,
            this.visitasToolStripMenuItem,
            this.medicoToolStripMenuItem,
            this.psicologiaToolStripMenuItem,
            this.educativoToolStripMenuItem,
            this.juridicoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dactiloscopiaToolStripMenuItem
            // 
            this.dactiloscopiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoRegistroToolStripMenuItem});
            this.dactiloscopiaToolStripMenuItem.Name = "dactiloscopiaToolStripMenuItem";
            this.dactiloscopiaToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.dactiloscopiaToolStripMenuItem.Text = "Dactiloscopia";
            // 
            // visitasToolStripMenuItem
            // 
            this.visitasToolStripMenuItem.Name = "visitasToolStripMenuItem";
            this.visitasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.visitasToolStripMenuItem.Text = "Visitas";
            // 
            // medicoToolStripMenuItem
            // 
            this.medicoToolStripMenuItem.Name = "medicoToolStripMenuItem";
            this.medicoToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.medicoToolStripMenuItem.Text = "Medico";
            // 
            // psicologiaToolStripMenuItem
            // 
            this.psicologiaToolStripMenuItem.Name = "psicologiaToolStripMenuItem";
            this.psicologiaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.psicologiaToolStripMenuItem.Text = "Psicologia";
            // 
            // educativoToolStripMenuItem
            // 
            this.educativoToolStripMenuItem.Name = "educativoToolStripMenuItem";
            this.educativoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.educativoToolStripMenuItem.Text = "Educativo";
            // 
            // juridicoToolStripMenuItem
            // 
            this.juridicoToolStripMenuItem.Name = "juridicoToolStripMenuItem";
            this.juridicoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.juridicoToolStripMenuItem.Text = "Juridico";
            // 
            // nuevoRegistroToolStripMenuItem
            // 
            this.nuevoRegistroToolStripMenuItem.Name = "nuevoRegistroToolStripMenuItem";
            this.nuevoRegistroToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.nuevoRegistroToolStripMenuItem.Text = "Nuevo Registro";
            this.nuevoRegistroToolStripMenuItem.Click += new System.EventHandler(this.nuevoRegistroToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dactiloscopiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem psicologiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem educativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juridicoToolStripMenuItem;
    }
}

