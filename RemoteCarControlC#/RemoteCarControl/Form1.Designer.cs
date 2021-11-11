namespace RemoteCarControl
{
    partial class Form1
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
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPORT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imgbgln = new System.Windows.Forms.PictureBox();
            this.imgcikis = new System.Windows.Forms.PictureBox();
            this.pileri = new System.Windows.Forms.PictureBox();
            this.psag = new System.Windows.Forms.PictureBox();
            this.psol = new System.Windows.Forms.PictureBox();
            this.pgeri = new System.Windows.Forms.PictureBox();
            this.pdur = new System.Windows.Forms.PictureBox();
            this.poto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgbgln)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Enabled = false;
            this.txtIP.Location = new System.Drawing.Point(16, 36);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(108, 22);
            this.txtIP.TabIndex = 9;
            this.txtIP.Text = "192.168.22.103";
            // 
            // txtPORT
            // 
            this.txtPORT.Enabled = false;
            this.txtPORT.Location = new System.Drawing.Point(132, 36);
            this.txtPORT.Margin = new System.Windows.Forms.Padding(4);
            this.txtPORT.Name = "txtPORT";
            this.txtPORT.Size = new System.Drawing.Size(84, 22);
            this.txtPORT.TabIndex = 10;
            this.txtPORT.Text = "8084";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "PORT";
            // 
            // imgbgln
            // 
            this.imgbgln.BackColor = System.Drawing.Color.Transparent;
            this.imgbgln.Image = global::RemoteCarControl.Properties.Resources.icon_19;
            this.imgbgln.Location = new System.Drawing.Point(224, 15);
            this.imgbgln.Margin = new System.Windows.Forms.Padding(4);
            this.imgbgln.Name = "imgbgln";
            this.imgbgln.Size = new System.Drawing.Size(56, 48);
            this.imgbgln.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbgln.TabIndex = 14;
            this.imgbgln.TabStop = false;
            this.imgbgln.Click += new System.EventHandler(this.imgbgln_Click);
            // 
            // imgcikis
            // 
            this.imgcikis.BackColor = System.Drawing.Color.Transparent;
            this.imgcikis.Image = global::RemoteCarControl.Properties.Resources.icon_12;
            this.imgcikis.Location = new System.Drawing.Point(288, 15);
            this.imgcikis.Margin = new System.Windows.Forms.Padding(4);
            this.imgcikis.Name = "imgcikis";
            this.imgcikis.Size = new System.Drawing.Size(56, 48);
            this.imgcikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgcikis.TabIndex = 15;
            this.imgcikis.TabStop = false;
            this.imgcikis.Click += new System.EventHandler(this.imgcikis_Click);
            // 
            // pileri
            // 
            this.pileri.BackColor = System.Drawing.Color.Transparent;
            this.pileri.Image = global::RemoteCarControl.Properties.Resources._12;
            this.pileri.Location = new System.Drawing.Point(132, 66);
            this.pileri.Margin = new System.Windows.Forms.Padding(4);
            this.pileri.Name = "pileri";
            this.pileri.Size = new System.Drawing.Size(111, 101);
            this.pileri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pileri.TabIndex = 0;
            this.pileri.TabStop = false;
            this.pileri.Click += new System.EventHandler(this.pileri_Click);
            this.pileri.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pileri_MouseDown);
            this.pileri.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pileri_MouseUp);
            // 
            // psag
            // 
            this.psag.BackColor = System.Drawing.Color.Transparent;
            this.psag.Image = global::RemoteCarControl.Properties.Resources._13;
            this.psag.Location = new System.Drawing.Point(251, 168);
            this.psag.Margin = new System.Windows.Forms.Padding(4);
            this.psag.Name = "psag";
            this.psag.Size = new System.Drawing.Size(111, 101);
            this.psag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.psag.TabIndex = 16;
            this.psag.TabStop = false;
            this.psag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.psag_MouseDown);
            this.psag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.psag_MouseUp);
            // 
            // psol
            // 
            this.psol.BackColor = System.Drawing.Color.Transparent;
            this.psol.Image = global::RemoteCarControl.Properties.Resources._15;
            this.psol.Location = new System.Drawing.Point(13, 168);
            this.psol.Margin = new System.Windows.Forms.Padding(4);
            this.psol.Name = "psol";
            this.psol.Size = new System.Drawing.Size(111, 101);
            this.psol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.psol.TabIndex = 17;
            this.psol.TabStop = false;
            this.psol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.psol_MouseDown);
            this.psol.MouseUp += new System.Windows.Forms.MouseEventHandler(this.psol_MouseUp);
            // 
            // pgeri
            // 
            this.pgeri.BackColor = System.Drawing.Color.Transparent;
            this.pgeri.Image = global::RemoteCarControl.Properties.Resources._14;
            this.pgeri.Location = new System.Drawing.Point(132, 168);
            this.pgeri.Margin = new System.Windows.Forms.Padding(4);
            this.pgeri.Name = "pgeri";
            this.pgeri.Size = new System.Drawing.Size(111, 101);
            this.pgeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pgeri.TabIndex = 0;
            this.pgeri.TabStop = false;
            this.pgeri.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pgeri_MouseDown);
            this.pgeri.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pgeri_MouseUp);
            // 
            // pdur
            // 
            this.pdur.BackColor = System.Drawing.Color.Transparent;
            this.pdur.Image = global::RemoteCarControl.Properties.Resources._16;
            this.pdur.Location = new System.Drawing.Point(251, 66);
            this.pdur.Margin = new System.Windows.Forms.Padding(4);
            this.pdur.Name = "pdur";
            this.pdur.Size = new System.Drawing.Size(111, 101);
            this.pdur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pdur.TabIndex = 18;
            this.pdur.TabStop = false;
            this.pdur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pdur_MouseDown);
            this.pdur.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pdur_MouseUp);
            // 
            // poto
            // 
            this.poto.BackColor = System.Drawing.Color.Transparent;
            this.poto.Image = global::RemoteCarControl.Properties.Resources._117511_matte_blue_and_white_square_icon_media_music_trumpet_sc44_2;
            this.poto.Location = new System.Drawing.Point(13, 66);
            this.poto.Margin = new System.Windows.Forms.Padding(4);
            this.poto.Name = "poto";
            this.poto.Size = new System.Drawing.Size(111, 101);
            this.poto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.poto.TabIndex = 19;
            this.poto.TabStop = false;
            this.poto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.poto_MouseDown);
            this.poto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.poto_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RemoteCarControl.Properties.Resources.background_1247931_960_720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(395, 300);
            this.Controls.Add(this.poto);
            this.Controls.Add(this.pdur);
            this.Controls.Add(this.pgeri);
            this.Controls.Add(this.psol);
            this.Controls.Add(this.psag);
            this.Controls.Add(this.pileri);
            this.Controls.Add(this.imgcikis);
            this.Controls.Add(this.imgbgln);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPORT);
            this.Controls.Add(this.txtIP);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.imgbgln)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPORT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgbgln;
        private System.Windows.Forms.PictureBox imgcikis;
        private System.Windows.Forms.PictureBox pileri;
        private System.Windows.Forms.PictureBox psag;
        private System.Windows.Forms.PictureBox psol;
        private System.Windows.Forms.PictureBox pgeri;
        private System.Windows.Forms.PictureBox pdur;
        private System.Windows.Forms.PictureBox poto;
    }
}

