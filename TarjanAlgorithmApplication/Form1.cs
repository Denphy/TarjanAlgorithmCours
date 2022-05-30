using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TarjanAlgorithmApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelFileSubmenu.Visible = false;
            panelTextSubmenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelFileSubmenu.Visible == true)
                panelFileSubmenu.Visible = false;
            if (panelTextSubmenu.Visible == true)
                panelTextSubmenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void setDefaultColor()
        {
            buttonFileInput.BackColor = Color.FromArgb(5, 44, 26);
            buttonFileMatrix.BackColor = Color.FromArgb(16, 54, 33);
            buttonFileList.BackColor = Color.FromArgb(16, 54, 33);
            buttonTextInput.BackColor = Color.FromArgb(5, 44, 26);
            buttonTextMatrix.BackColor = Color.FromArgb(16, 54, 33);
            buttonTextList.BackColor = Color.FromArgb(16, 54, 33);
        }
        private void colorMenu(int idButton)
        {
            switch (idButton)
            {
                case 0:
                    setDefaultColor();
                    buttonFileInput.BackColor = Color.FromArgb(16, 54, 33);
                    buttonFileMatrix.BackColor = Color.FromArgb(22, 74, 45);
                    break;
                case 1:
                    setDefaultColor();
                    buttonFileInput.BackColor = Color.FromArgb(16, 54, 33);
                    buttonFileList.BackColor = Color.FromArgb(22, 74, 45);
                    break;
                case 2:
                    setDefaultColor();
                    buttonTextInput.BackColor = Color.FromArgb(16, 54, 33);
                    buttonTextMatrix.BackColor = Color.FromArgb(22, 74, 45);
                    break;
                case 3:
                    setDefaultColor();
                    buttonTextInput.BackColor = Color.FromArgb(16, 54, 33);
                    buttonTextList.BackColor = Color.FromArgb(22, 74, 45);
                    break;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void buttonFileInput_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFileSubmenu);
        }

        private void buttonTextInput_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTextSubmenu);
        }

        private void buttonFileMatrix_Click(object sender, EventArgs e)
        {
            openChildForm(new FormFileMatrix());
            colorMenu(0);
            hideSubMenu();
        }

        private void buttonFileList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormFileList());
            colorMenu(1);
            hideSubMenu();
        }

        private void buttonTextMatrix_Click(object sender, EventArgs e)
        {
            openChildForm(new FormTextMatrix());
            colorMenu(2);
            hideSubMenu();
        }

        private void buttonTextList_Click(object sender, EventArgs e)
        {
            openChildForm(new FormTextList());
            colorMenu(3);
            hideSubMenu();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
