using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playnary
{
    public partial class Game : Form
    {
        public static int radix = 2;
        public Game()
        {
            InitializeComponent();
        }

        private void bits_Scroll(object sender, ScrollEventArgs e)
        {
            mode.Text = "BIT MODE: " + bits.Value;
            challenge.Text = new Random().Next((int) Math.Pow(2, bits.Value)).ToString();
            Console.Beep(5000, 64);
            binary.MaxLength = bits.Value;
            binary.ResetText();
        }

        private void binary_TextChanged(object sender, EventArgs e)
        {
            try {
                if (binary.TextLength == bits.Value && Convert.ToInt32(binary.Text, 2) == Convert.ToInt32(challenge.Text))
                {
                    score.Text = (Convert.ToInt32(score.Text) + 1).ToString();
                    challenge.Text = new Random().Next((int) Math.Pow(2, bits.Value)).ToString();
                    Console.Beep(2000, 256);
                    binary.MaxLength = bits.Value;
                    binary.ResetText();
                }
            }
            catch
            {
                binary.ResetText();
            }
            finally
            {
                if (binary.TextLength > 0)
                {
                    if (binary.Text[binary.TextLength - 1] == '0')
                    {
                        Console.Beep(3000, 64);
                    }
                    if (binary.Text[binary.TextLength - 1] == '1')
                    {
                        Console.Beep(4000, 64);
                    }
                }
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            challenge.Text = new Random().Next((int) Math.Pow(2, bits.Value)).ToString();
            binary.MaxLength = bits.Value;
            binary.ResetText();
        }

        private void bases_Scroll(object sender, ScrollEventArgs e)
        {
            baseMode.Text = "BASE: " + bases.Value;
            challenge.Text = new Random().Next((int)Math.Pow(2, bits.Value)).ToString();
            Console.Beep(5000, 64);
            binary.ResetText();
        }
    }
}
