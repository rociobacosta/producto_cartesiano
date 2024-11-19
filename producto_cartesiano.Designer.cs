namespace producto_cartesiano
{
    partial class producto_cartesiano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(producto_cartesiano));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listResultado = new System.Windows.Forms.ListBox();
            this.btnGenerarConjunto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxSegundoConjunto = new System.Windows.Forms.TextBox();
            this.txtboxPrimerConjunto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // listResultado
            // 
            resources.ApplyResources(this.listResultado, "listResultado");
            this.listResultado.FormattingEnabled = true;
            this.listResultado.Name = "listResultado";
            // 
            // btnGenerarConjunto
            // 
            resources.ApplyResources(this.btnGenerarConjunto, "btnGenerarConjunto");
            this.btnGenerarConjunto.Name = "btnGenerarConjunto";
            this.btnGenerarConjunto.UseVisualStyleBackColor = true;
            this.btnGenerarConjunto.Click += new System.EventHandler(this.btnGenerarConjunto_Click_1);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtboxSegundoConjunto
            // 
            resources.ApplyResources(this.txtboxSegundoConjunto, "txtboxSegundoConjunto");
            this.txtboxSegundoConjunto.Name = "txtboxSegundoConjunto";
            // 
            // txtboxPrimerConjunto
            // 
            resources.ApplyResources(this.txtboxPrimerConjunto, "txtboxPrimerConjunto");
            this.txtboxPrimerConjunto.Name = "txtboxPrimerConjunto";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.listResultado);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnSalir
            // 
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // producto_cartesiano
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::producto_cartesiano.Properties.Resources.matematicas_recurso_bbva_1920x918_1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGenerarConjunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxSegundoConjunto);
            this.Controls.Add(this.txtboxPrimerConjunto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "producto_cartesiano";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listResultado;
        private System.Windows.Forms.Button btnGenerarConjunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxSegundoConjunto;
        private System.Windows.Forms.TextBox txtboxPrimerConjunto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
    }
}

