using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_1214064
{
    public partial class ExForms : Form
    {
        public ExForms()
        {
            InitializeComponent();
        }

        private void tsbMouse_Click(object sender, EventArgs e)
        {
            if (rbMouse.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Mouse.";
            }
            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah\n Ini Gambar Mouse!";
            }
        }

        private void tsbMonitor_Click(object sender, EventArgs e)
        {
            if (rbMonitor.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Monitor.";
            }
            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah\n Ini Gambar Monitor!";
            }
        }

        private void tsbPrinter_Click(object sender, EventArgs e)
        {
            if (rbPrinter.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Printer.";
            }
            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah\n Ini Gambar Printer!";
            }
        }

        private void tsbKeyboard_Click(object sender, EventArgs e)
        {
            if (rbKeyboard.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Keyboard.";
            }
            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah\n Ini Gambar Keyboard!";
            }
        }

        private void tsbScanner_Click(object sender, EventArgs e)
        {
            if (rbScanner.Checked == true)
            {
                tslKetGambar.Text = "Cocok! Ini adalah gambar Scanner.";
            }
            else
            {
                tslKetGambar.Text = "Tidak Cocok! Anda memilih gambar yang salah\n Ini Gambar Scanner!";
            }
        }
    }
}
