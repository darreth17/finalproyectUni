
namespace proyectofinal
{
    partial class menuventas
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
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtcanti = new System.Windows.Forms.TextBox();
            this.txtcantidadavender = new System.Windows.Forms.TextBox();
            this.txtcoproducto = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtidentificaciondelcli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbidentificacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpreciou = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.datacliente = new System.Windows.Forms.DataGridView();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAlMenuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnbuscarcli = new System.Windows.Forms.Button();
            this.dataGridinventario = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datacliente)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridinventario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(380, 438);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(268, 55);
            this.btnguardar.TabIndex = 33;
            this.btnguardar.Text = "emitir factura";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtcanti
            // 
            this.txtcanti.Location = new System.Drawing.Point(315, 384);
            this.txtcanti.Margin = new System.Windows.Forms.Padding(2);
            this.txtcanti.Name = "txtcanti";
            this.txtcanti.Size = new System.Drawing.Size(107, 20);
            this.txtcanti.TabIndex = 30;
            // 
            // txtcantidadavender
            // 
            this.txtcantidadavender.Location = new System.Drawing.Point(217, 435);
            this.txtcantidadavender.Margin = new System.Windows.Forms.Padding(2);
            this.txtcantidadavender.Name = "txtcantidadavender";
            this.txtcantidadavender.Size = new System.Drawing.Size(102, 20);
            this.txtcantidadavender.TabIndex = 29;
            this.txtcantidadavender.TextChanged += new System.EventHandler(this.txtclitcorreo_TextChanged);
            // 
            // txtcoproducto
            // 
            this.txtcoproducto.Location = new System.Drawing.Point(54, 384);
            this.txtcoproducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtcoproducto.Name = "txtcoproducto";
            this.txtcoproducto.Size = new System.Drawing.Size(115, 20);
            this.txtcoproducto.TabIndex = 28;
            this.txtcoproducto.TextChanged += new System.EventHandler(this.txtabocelular_TextChanged);
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(404, 223);
            this.txtapellidos.Margin = new System.Windows.Forms.Padding(2);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(126, 20);
            this.txtapellidos.TabIndex = 27;
            // 
            // txtidentificaciondelcli
            // 
            this.txtidentificaciondelcli.Location = new System.Drawing.Point(59, 223);
            this.txtidentificaciondelcli.Margin = new System.Windows.Forms.Padding(2);
            this.txtidentificaciondelcli.Name = "txtidentificaciondelcli";
            this.txtidentificaciondelcli.Size = new System.Drawing.Size(131, 20);
            this.txtidentificaciondelcli.TabIndex = 26;
            this.txtidentificaciondelcli.TextChanged += new System.EventHandler(this.txtidentificaciondelcli_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 369);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 369);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "precio unitario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "cantidad";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Apellidos";
            // 
            // lbidentificacion
            // 
            this.lbidentificacion.AutoSize = true;
            this.lbidentificacion.Location = new System.Drawing.Point(82, 203);
            this.lbidentificacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbidentificacion.Name = "lbidentificacion";
            this.lbidentificacion.Size = new System.Drawing.Size(69, 13);
            this.lbidentificacion.TabIndex = 19;
            this.lbidentificacion.Text = "identificacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 39);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ventas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 369);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "codigo del producto";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(247, 223);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(116, 20);
            this.txtnombre.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "nombre";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtpreciou
            // 
            this.txtpreciou.Location = new System.Drawing.Point(437, 384);
            this.txtpreciou.Margin = new System.Windows.Forms.Padding(2);
            this.txtpreciou.Name = "txtpreciou";
            this.txtpreciou.Size = new System.Drawing.Size(107, 20);
            this.txtpreciou.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 438);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "cantidad a vender";
            // 
            // datacliente
            // 
            this.datacliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datacliente.Location = new System.Drawing.Point(59, 65);
            this.datacliente.Margin = new System.Windows.Forms.Padding(2);
            this.datacliente.Name = "datacliente";
            this.datacliente.RowHeadersWidth = 51;
            this.datacliente.RowTemplate.Height = 24;
            this.datacliente.Size = new System.Drawing.Size(613, 122);
            this.datacliente.TabIndex = 44;
            this.datacliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.datacliente.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataabogado_RowHeaderMouseClick);
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(181, 384);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(116, 20);
            this.txtproducto.TabIndex = 45;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverAlMenuPrincipalToolStripMenuItem,
            this.registroDeVentasToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.opcionesToolStripMenuItem.Text = "opciones";
            // 
            // volverAlMenuPrincipalToolStripMenuItem
            // 
            this.volverAlMenuPrincipalToolStripMenuItem.Name = "volverAlMenuPrincipalToolStripMenuItem";
            this.volverAlMenuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.volverAlMenuPrincipalToolStripMenuItem.Text = "volver al menu principal";
            this.volverAlMenuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.volverAlMenuPrincipalToolStripMenuItem_Click);
            // 
            // registroDeVentasToolStripMenuItem
            // 
            this.registroDeVentasToolStripMenuItem.Name = "registroDeVentasToolStripMenuItem";
            this.registroDeVentasToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.registroDeVentasToolStripMenuItem.Text = "registro de ventas";
            this.registroDeVentasToolStripMenuItem.Click += new System.EventHandler(this.registroDeVentasToolStripMenuItem_Click);
            // 
            // btnbuscarcli
            // 
            this.btnbuscarcli.Location = new System.Drawing.Point(572, 203);
            this.btnbuscarcli.Margin = new System.Windows.Forms.Padding(2);
            this.btnbuscarcli.Name = "btnbuscarcli";
            this.btnbuscarcli.Size = new System.Drawing.Size(119, 40);
            this.btnbuscarcli.TabIndex = 47;
            this.btnbuscarcli.Text = "buscar cliente";
            this.btnbuscarcli.UseVisualStyleBackColor = true;
            this.btnbuscarcli.Click += new System.EventHandler(this.btnbuscarcli_Click);
            // 
            // dataGridinventario
            // 
            this.dataGridinventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridinventario.Location = new System.Drawing.Point(59, 250);
            this.dataGridinventario.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridinventario.Name = "dataGridinventario";
            this.dataGridinventario.RowHeadersWidth = 51;
            this.dataGridinventario.RowTemplate.Height = 24;
            this.dataGridinventario.Size = new System.Drawing.Size(613, 117);
            this.dataGridinventario.TabIndex = 48;
            this.dataGridinventario.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridinventario_RowHeaderMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 373);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 40);
            this.button1.TabIndex = 49;
            this.button1.Text = "buscar producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(217, 467);
            this.txttotal.Margin = new System.Windows.Forms.Padding(2);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(102, 20);
            this.txttotal.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 470);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "total a pagar";
            // 
            // menuventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 517);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridinventario);
            this.Controls.Add(this.btnbuscarcli);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.datacliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtpreciou);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtcanti);
            this.Controls.Add(this.txtcantidadavender);
            this.Controls.Add(this.txtcoproducto);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtidentificaciondelcli);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbidentificacion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "menuventas";
            this.Text = "menuventa";
            ((System.ComponentModel.ISupportInitialize)(this.datacliente)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridinventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtcanti;
        private System.Windows.Forms.TextBox txtcantidadavender;
        private System.Windows.Forms.TextBox txtcoproducto;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtidentificaciondelcli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbidentificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpreciou;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView datacliente;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAlMenuPrincipalToolStripMenuItem;
        private System.Windows.Forms.Button btnbuscarcli;
        private System.Windows.Forms.DataGridView dataGridinventario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem registroDeVentasToolStripMenuItem;
    }
}