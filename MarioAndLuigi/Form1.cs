using MarioAndLuigi.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarioAndLuigi
{
    public partial class Form1 : Form
    {
        private List<CharaBase> _charas = new List<CharaBase>();
        private CharaBase _selectedChara;

        public Form1()
        {
            InitializeComponent();

            _charas.Add(new Mario());
            _charas.Add(new Luigi());

            _selectedChara = _charas[0];
        }

        private void radioButtonMario_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMario.Checked)
            {
                _selectedChara = _charas[0];
            }
            else
            {
                _selectedChara = _charas[1];
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach(var chara in _charas)
            {
                e.Graphics.FillRectangle(
                    new SolidBrush(chara.Color), chara.X, chara.Y, 30, 30);
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            _selectedChara.Right();
            panelMain.Refresh();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if(_selectedChara.IsMessageExist())
            {
                MessageBox.Show(_selectedChara.GetMessage());
            }
        }
    }
}
