
namespace Modern_Flat_UI.Forms
{
    partial class frmClientes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxListaClientes = new System.Windows.Forms.GroupBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxListaClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBoxListaClientes
            // 
            this.groupBoxListaClientes.Controls.Add(this.dataGridView1);
            this.groupBoxListaClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxListaClientes.Location = new System.Drawing.Point(0, 0);
            this.groupBoxListaClientes.Name = "groupBoxListaClientes";
            this.groupBoxListaClientes.Size = new System.Drawing.Size(800, 218);
            this.groupBoxListaClientes.TabIndex = 1;
            this.groupBoxListaClientes.TabStop = false;
            this.groupBoxListaClientes.Text = "Lista de Clientes";
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(12, 224);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(244, 81);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Adicionar";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(87)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.groupBoxListaClientes);
            this.Name = "frmClientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxListaClientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxListaClientes;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}