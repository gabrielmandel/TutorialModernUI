
namespace Modern_Flat_UI
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTituloHome = new System.Windows.Forms.Label();
            this.panelSombra = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconHome = new FontAwesome.Sharp.IconButton();
            this.btnConfig = new FontAwesome.Sharp.IconButton();
            this.btnMarketing = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.brnProdutos = new FontAwesome.Sharp.IconButton();
            this.btnPedidos = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnFechar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnMaxmizar = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(34)))), ((int)(((byte)(171)))));
            this.panelMenu.Controls.Add(this.btnConfig);
            this.panelMenu.Controls.Add(this.btnMarketing);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.brnProdutos);
            this.panelMenu.Controls.Add(this.btnPedidos);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 417);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 120);
            this.panelLogo.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(34)))), ((int)(((byte)(171)))));
            this.panelHeader.Controls.Add(this.btnMaxmizar);
            this.panelHeader.Controls.Add(this.btnMinimizar);
            this.panelHeader.Controls.Add(this.btnFechar);
            this.panelHeader.Controls.Add(this.lblTituloHome);
            this.panelHeader.Controls.Add(this.iconHome);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(220, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(641, 85);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // lblTituloHome
            // 
            this.lblTituloHome.AutoSize = true;
            this.lblTituloHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTituloHome.Location = new System.Drawing.Point(67, 33);
            this.lblTituloHome.Name = "lblTituloHome";
            this.lblTituloHome.Size = new System.Drawing.Size(49, 17);
            this.lblTituloHome.TabIndex = 1;
            this.lblTituloHome.Text = "Home";
            // 
            // panelSombra
            // 
            this.panelSombra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(20)))), ((int)(((byte)(103)))));
            this.panelSombra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSombra.Location = new System.Drawing.Point(220, 85);
            this.panelSombra.Name = "panelSombra";
            this.panelSombra.Size = new System.Drawing.Size(641, 5);
            this.panelSombra.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(87)))), ((int)(((byte)(221)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 90);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(641, 327);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.TabStop = true;
            // 
            // iconHome
            // 
            this.iconHome.FlatAppearance.BorderSize = 0;
            this.iconHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconHome.IconColor = System.Drawing.Color.White;
            this.iconHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHome.IconSize = 32;
            this.iconHome.Location = new System.Drawing.Point(22, 23);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(39, 36);
            this.iconHome.TabIndex = 0;
            this.iconHome.UseVisualStyleBackColor = true;
            // 
            // btnConfig
            // 
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfig.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnConfig.IconColor = System.Drawing.Color.White;
            this.btnConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfig.IconSize = 32;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(0, 320);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnConfig.Size = new System.Drawing.Size(220, 40);
            this.btnConfig.TabIndex = 6;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnMarketing
            // 
            this.btnMarketing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarketing.FlatAppearance.BorderSize = 0;
            this.btnMarketing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarketing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarketing.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMarketing.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.btnMarketing.IconColor = System.Drawing.Color.White;
            this.btnMarketing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMarketing.IconSize = 32;
            this.btnMarketing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarketing.Location = new System.Drawing.Point(0, 280);
            this.btnMarketing.Name = "btnMarketing";
            this.btnMarketing.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMarketing.Size = new System.Drawing.Size(220, 40);
            this.btnMarketing.TabIndex = 5;
            this.btnMarketing.Text = "Marketing";
            this.btnMarketing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarketing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarketing.UseVisualStyleBackColor = true;
            this.btnMarketing.Click += new System.EventHandler(this.btnMarketing_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnClientes.IconColor = System.Drawing.Color.White;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 32;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 240);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnClientes.Size = new System.Drawing.Size(220, 40);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // brnProdutos
            // 
            this.brnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.brnProdutos.FlatAppearance.BorderSize = 0;
            this.brnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnProdutos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.brnProdutos.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.brnProdutos.IconColor = System.Drawing.Color.White;
            this.brnProdutos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.brnProdutos.IconSize = 32;
            this.brnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnProdutos.Location = new System.Drawing.Point(0, 200);
            this.brnProdutos.Name = "brnProdutos";
            this.brnProdutos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.brnProdutos.Size = new System.Drawing.Size(220, 40);
            this.brnProdutos.TabIndex = 3;
            this.brnProdutos.Text = "Produtos";
            this.brnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.brnProdutos.UseVisualStyleBackColor = true;
            this.brnProdutos.Click += new System.EventHandler(this.brnProdutos_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPedidos.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnPedidos.IconColor = System.Drawing.Color.White;
            this.btnPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPedidos.IconSize = 32;
            this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.Location = new System.Drawing.Point(0, 160);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPedidos.Size = new System.Drawing.Size(220, 40);
            this.btnPedidos.TabIndex = 2;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 120);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 40);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.Image = global::Modern_Flat_UI.Properties.Resources._3fc204cb_c289_461d_8d78_ae7300ce7d57_200x200;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(220, 120);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnFechar.IconColor = System.Drawing.Color.Black;
            this.btnFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFechar.IconSize = 60;
            this.btnFechar.Location = new System.Drawing.Point(607, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnFechar.Size = new System.Drawing.Size(31, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.Black;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 32;
            this.btnMinimizar.Location = new System.Drawing.Point(533, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnMinimizar.Size = new System.Drawing.Size(31, 23);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaxmizar
            // 
            this.btnMaxmizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxmizar.FlatAppearance.BorderSize = 0;
            this.btnMaxmizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxmizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaxmizar.IconColor = System.Drawing.Color.Black;
            this.btnMaxmizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaxmizar.IconSize = 32;
            this.btnMaxmizar.Location = new System.Drawing.Point(570, 3);
            this.btnMaxmizar.Name = "btnMaxmizar";
            this.btnMaxmizar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnMaxmizar.Size = new System.Drawing.Size(31, 23);
            this.btnMaxmizar.TabIndex = 4;
            this.btnMaxmizar.UseVisualStyleBackColor = true;
            this.btnMaxmizar.Click += new System.EventHandler(this.btnMaxmizar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(861, 417);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelSombra);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmMain";
            this.Text = "Sword System";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnConfig;
        private FontAwesome.Sharp.IconButton btnMarketing;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton brnProdutos;
        private FontAwesome.Sharp.IconButton btnPedidos;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTituloHome;
        private FontAwesome.Sharp.IconButton iconHome;
        private System.Windows.Forms.Panel panelSombra;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnMaxmizar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnFechar;
    }
}

