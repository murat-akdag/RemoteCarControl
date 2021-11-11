using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteCarControl
{
    public partial class Form1 : Form
    {
        Socket istemciBaglantisi;
        NetworkStream agAkisi;
        StreamWriter yazici;
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Yazdir(string veri)
        {

            agAkisi = new NetworkStream(istemciBaglantisi);
            yazici = new StreamWriter(agAkisi);

            yazici.Write(veri);
            yazici.Flush();
            yazici.Close();

        }

       

        private void btnileri_MouseDown(object sender, MouseEventArgs e)
        {
            Yazdir("a");
        }

        private void btnileri_MouseUp(object sender, MouseEventArgs e)
        {
            Yazdir("s");
        }

        private void btngeri_MouseDown(object sender, MouseEventArgs e)
        {
            Yazdir("b");
        }

        private void btngeri_MouseUp(object sender, MouseEventArgs e)
        {
            Yazdir("s");
        }

        private void btnsag_MouseDown(object sender, MouseEventArgs e)
        {
            Yazdir("c");
        }

        private void btnsag_MouseUp(object sender, MouseEventArgs e)
        {
            Yazdir("s");
        }

        private void btnsol_MouseDown(object sender, MouseEventArgs e)
        {
            Yazdir("d");
        }

        private void btnsol_MouseUp(object sender, MouseEventArgs e)
        {
            Yazdir("s");
        }

        private void btndur_MouseDown(object sender, MouseEventArgs e)
        {
            Yazdir("s");
        }

        private void btndon_MouseDown(object sender, MouseEventArgs e)
        {
            Yazdir("e");
        }

        private void btndon_MouseUp(object sender, MouseEventArgs e)
        {
            Yazdir("s");
        }

        private void btnoto_Click(object sender, EventArgs e)
        {
            Yazdir("f");
        }

        private void imgbgln_Click(object sender, EventArgs e)
        {
            try
            {
                istemciBaglantisi = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                istemciBaglantisi.Connect(IPAddress.Parse(txtIP.Text), int.Parse(txtPORT.Text));
                MessageBox.Show("Port Açıldı");
            }
            catch (Exception)
            {
                MessageBox.Show("Port Kapalı");
            }
        }

        private void imgcikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış");
            istemciBaglantisi.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void pileri_MouseDown(object sender, MouseEventArgs e)
        {
            this.pileri.Image = global::RemoteCarControl.Properties.Resources._121353_matte_purple_and_white_square_icon_media_a_media34_up;
            Yazdir("a");
        }

        private void pileri_MouseUp(object sender, MouseEventArgs e)
        {
            this.pileri.Image = global::RemoteCarControl.Properties.Resources._12;
            Yazdir("s");
        }

        private void psag_MouseDown(object sender, MouseEventArgs e)
        {
            this.psag.Image = global::RemoteCarControl.Properties.Resources._121351_matte_purple_and_white_square_icon_media_a_media32_forward;
            Yazdir("c");
        }

        private void psag_MouseUp(object sender, MouseEventArgs e)
        {
            this.psag.Image = global::RemoteCarControl.Properties.Resources._13;
            Yazdir("s");
        }

        private void psol_MouseDown(object sender, MouseEventArgs e)
        {
            this.psol.Image = global::RemoteCarControl.Properties.Resources._121350_matte_purple_and_white_square_icon_media_a_media31_back;
            Yazdir("d");
        }

        private void psol_MouseUp(object sender, MouseEventArgs e)
        {
            this.psol.Image = global::RemoteCarControl.Properties.Resources._15;
            Yazdir("s");
        }

        private void pgeri_MouseDown(object sender, MouseEventArgs e)
        {
            this.pgeri.Image = global::RemoteCarControl.Properties.Resources._121352_matte_purple_and_white_square_icon_media_a_media33_down;
            Yazdir("b");
        }

        private void pgeri_MouseUp(object sender, MouseEventArgs e)
        {
            this.pgeri.Image = global::RemoteCarControl.Properties.Resources._14;
            Yazdir("s");
        }

        private void pdur_MouseDown(object sender, MouseEventArgs e)
        {
            this.pdur.Image = global::RemoteCarControl.Properties.Resources._121355_matte_purple_and_white_square_icon_media_a_media36_delete;
            Yazdir("s");
        }

        private void pdur_MouseUp(object sender, MouseEventArgs e)
        {
            Yazdir("s");
        }

        private void poto_MouseDown(object sender, MouseEventArgs e)
        {
            this.poto.Image = global::RemoteCarControl.Properties.Resources._121393_matte_purple_and_white_square_icon_media_music_trumpet_sc44_2;
            Yazdir("f");
        }

        private void poto_MouseUp(object sender, MouseEventArgs e)
        {
            this.poto.Image = global::RemoteCarControl.Properties.Resources._117511_matte_blue_and_white_square_icon_media_music_trumpet_sc44_2;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    this.pileri.Image = global::RemoteCarControl.Properties.Resources._121353_matte_purple_and_white_square_icon_media_a_media34_up;
                    Yazdir("a");
                    break;

                case Keys.Down:
                    this.pgeri.Image = global::RemoteCarControl.Properties.Resources._121352_matte_purple_and_white_square_icon_media_a_media33_down;
                    Yazdir("b");
                    break;


                case Keys.Right:
                    this.psag.Image = global::RemoteCarControl.Properties.Resources._121351_matte_purple_and_white_square_icon_media_a_media32_forward;
                    Yazdir("c");
                    break;

                case Keys.Left:
                    this.psol.Image = global::RemoteCarControl.Properties.Resources._121350_matte_purple_and_white_square_icon_media_a_media31_back;
                    Yazdir("d");
                    break;
                default:
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            this.pileri.Image = global::RemoteCarControl.Properties.Resources._12;
            this.psag.Image = global::RemoteCarControl.Properties.Resources._13;
            this.psol.Image = global::RemoteCarControl.Properties.Resources._15;
            this.pgeri.Image = global::RemoteCarControl.Properties.Resources._14;

            Yazdir("s");
        }

        private void pileri_Click(object sender, EventArgs e)
        {

        }
    }
}
