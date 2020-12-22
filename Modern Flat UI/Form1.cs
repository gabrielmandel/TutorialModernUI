using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Modern_Flat_UI.Forms;

namespace Modern_Flat_UI
{

    public partial class frmMain : Form
    {
        private IconButton btnAtual;
        private Panel btnEsquerda;
        private Form frmChildAtual;

        public frmMain()
        {
            InitializeComponent();
            btnEsquerda = new Panel();
            btnEsquerda.Size = new Size(7, 40);
            panelMenu.Controls.Add(btnEsquerda);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void AtivarBtn(object senderBtn, Color color)
        {
            if( senderBtn != null)
            {
                DesativarBtn();
                btnAtual = (IconButton)senderBtn;
                btnAtual.BackColor = Color.FromArgb(128, 0, 128);
                btnAtual.ForeColor = color;
                btnAtual.TextAlign = ContentAlignment.MiddleCenter;
                btnAtual.IconColor = color;
                btnAtual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnAtual.ImageAlign = ContentAlignment.MiddleRight;

                btnEsquerda.BackColor = color;
                btnEsquerda.Location = new Point(0,btnAtual.Location.Y);
                btnEsquerda.Visible = true;
                btnEsquerda.BringToFront();

                iconHome.IconChar = btnAtual.IconChar;
                iconHome.IconColor = color;
            }            
        }
        private void DesativarBtn()
        {
            if(btnAtual != null)
            {
                btnAtual.BackColor = Color.FromArgb(86, 34, 171);
                btnAtual.ForeColor = Color.White;
                btnAtual.TextAlign = ContentAlignment.MiddleCenter;
                btnAtual.IconColor = Color.White;
                btnAtual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnAtual.ImageAlign = ContentAlignment.MiddleLeft;

                iconHome.IconChar = IconChar.Home;
                iconHome.IconColor = Color.White;
                lblTituloHome.Text = "Home";
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (frmChildAtual != null)
            {
                frmChildAtual.Close();
            }
            frmChildAtual = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTituloHome.Text = childForm.Text;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AtivarBtn(sender, RGBcolors.color1);
            OpenChildForm(new frmDashboard());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AtivarBtn(sender, RGBcolors.color2);
            OpenChildForm(new frmPedidos());
        }

        private void brnProdutos_Click(object sender, EventArgs e)
        {
            AtivarBtn(sender, RGBcolors.color3);
            OpenChildForm(new frmProdutos());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AtivarBtn(sender, RGBcolors.color4);
            OpenChildForm(new frmClientes());
        }

        private void btnMarketing_Click(object sender, EventArgs e)
        {
            AtivarBtn(sender, RGBcolors.color5);
            OpenChildForm(new frmMarketing());
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            AtivarBtn(sender, RGBcolors.color6);
            OpenChildForm(new frmConfig());

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmChildAtual.Close();
            Reset();
        }

        private void Reset()
        {
            DesativarBtn();
            btnEsquerda.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxmizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
