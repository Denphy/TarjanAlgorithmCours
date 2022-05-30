using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarjanAlgorithmApplication
{
    public partial class FormInstructions : Form
    {
        public FormInstructions()
        {
            InitializeComponent();
        }
        public FormInstructions(int typeOfInstruction)
        {
            InitializeComponent();
            switch(typeOfInstruction)
            {
                default:
                    Bitmap bit1 = new Bitmap(Properties.Resources.InstructionMatrixFile);
                    pictureBox1.Image = bit1;
                    break;

                case 2:
                    Bitmap bit2 = new Bitmap(Properties.Resources.InstructionListFile);
                    pictureBox1.Image = bit2;
                    break;

                case 3:
                    Bitmap bit3 = new Bitmap(Properties.Resources.InstructionMatrixText);
                    pictureBox1.Image = bit3;
                    break;

                case 4:
                    Bitmap bit4 = new Bitmap(Properties.Resources.InstructionListText);
                    pictureBox1.Image = bit4;
                    break;
            }
        }
    }
}
