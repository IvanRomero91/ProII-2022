
namespace Veterinaria
{
    partial class FrmVeterinaria
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
            this.lbxClientes = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cbxMascotas = new System.Windows.Forms.ComboBox();
            this.lblMascotas = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbxClientes
            // 
            this.lbxClientes.FormattingEnabled = true;
            this.lbxClientes.Location = new System.Drawing.Point(40, 74);
            this.lbxClientes.Name = "lbxClientes";
            this.lbxClientes.Size = new System.Drawing.Size(120, 95);
            this.lbxClientes.TabIndex = 1;
            this.lbxClientes.SelectedIndexChanged += new System.EventHandler(this.lbxClientes_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 374);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(372, 374);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // cbxMascotas
            // 
            this.cbxMascotas.FormattingEnabled = true;
            this.cbxMascotas.Location = new System.Drawing.Point(233, 83);
            this.cbxMascotas.Name = "cbxMascotas";
            this.cbxMascotas.Size = new System.Drawing.Size(121, 21);
            this.cbxMascotas.TabIndex = 4;
            // 
            // lblMascotas
            // 
            this.lblMascotas.AutoSize = true;
            this.lblMascotas.Location = new System.Drawing.Point(230, 42);
            this.lblMascotas.Name = "lblMascotas";
            this.lblMascotas.Size = new System.Drawing.Size(53, 13);
            this.lblMascotas.TabIndex = 5;
            this.lblMascotas.Text = "Mascotas";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Location = new System.Drawing.Point(37, 42);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(44, 13);
            this.lblClientes.TabIndex = 5;
            this.lblClientes.Text = "Clientes";
            // 
            // FrmVeterinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblMascotas);
            this.Controls.Add(this.cbxMascotas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbxClientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmVeterinaria";
            this.Text = "Veterinaria";
            this.Load += new System.EventHandler(this.FrmVeterinaria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox lbxClientes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cbxMascotas;
        private System.Windows.Forms.Label lblMascotas;
        private System.Windows.Forms.Label lblClientes;
    }
}

