
namespace proyectofinal
{
    partial class menuprincipal
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
            this.btnclientes = new System.Windows.Forms.Button();
            this.btnventas = new System.Windows.Forms.Button();
            this.btninventario = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAlLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ferre Sur S.R.L";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.Location = new System.Drawing.Point(87, 126);
            this.btnclientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(93, 62);
            this.btnclientes.TabIndex = 4;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btnventas
            // 
            this.btnventas.Location = new System.Drawing.Point(248, 126);
            this.btnventas.Margin = new System.Windows.Forms.Padding(2);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(93, 62);
            this.btnventas.TabIndex = 5;
            this.btnventas.Text = "ventas";
            this.btnventas.UseVisualStyleBackColor = true;
            this.btnventas.Click += new System.EventHandler(this.btabogados_Click);
            // 
            // btninventario
            // 
            this.btninventario.Location = new System.Drawing.Point(407, 126);
            this.btninventario.Margin = new System.Windows.Forms.Padding(2);
            this.btninventario.Name = "btninventario";
            this.btninventario.Size = new System.Drawing.Size(93, 62);
            this.btninventario.TabIndex = 6;
            this.btninventario.Text = "inventario";
            this.btninventario.UseVisualStyleBackColor = true;
            this.btninventario.Click += new System.EventHandler(this.btexpedientes_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverAlLoginToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.opcionesToolStripMenuItem.Text = "opciones";
            this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.opcionesToolStripMenuItem_Click_1);
            // 
            // volverAlLoginToolStripMenuItem
            // 
            this.volverAlLoginToolStripMenuItem.Name = "volverAlLoginToolStripMenuItem";
            this.volverAlLoginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.volverAlLoginToolStripMenuItem.Text = "volver al login";
            this.volverAlLoginToolStripMenuItem.Click += new System.EventHandler(this.volverAlLoginToolStripMenuItem_Click);
            // 
            // menuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 264);
            this.Controls.Add(this.btninventario);
            this.Controls.Add(this.btnventas);
            this.Controls.Add(this.btnclientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "menuprincipal";
            this.Text = "menuprincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btnventas;
        private System.Windows.Forms.Button btninventario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAlLoginToolStripMenuItem;
    }
}