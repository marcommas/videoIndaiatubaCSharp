namespace VideoIndaiatuba
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btVideo1 = new System.Windows.Forms.Button();
            this.btVideo2 = new System.Windows.Forms.Button();
            this.btVideo3 = new System.Windows.Forms.Button();
            this.btVideo4 = new System.Windows.Forms.Button();
            this.btVideo5 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btVideo6 = new System.Windows.Forms.Button();
            this.pnSair = new System.Windows.Forms.Panel();
            this.btfecharsair = new System.Windows.Forms.Button();
            this.btFechaPrograma = new System.Windows.Forms.Button();
            this.tbSair = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.pnSair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btVideo1
            // 
            this.btVideo1.Location = new System.Drawing.Point(185, 156);
            this.btVideo1.Name = "btVideo1";
            this.btVideo1.Size = new System.Drawing.Size(64, 64);
            this.btVideo1.TabIndex = 0;
            this.btVideo1.Text = "button1";
            this.btVideo1.UseVisualStyleBackColor = true;
            this.btVideo1.Click += new System.EventHandler(this.btVideo1_Click);
            // 
            // btVideo2
            // 
            this.btVideo2.Location = new System.Drawing.Point(386, 177);
            this.btVideo2.Name = "btVideo2";
            this.btVideo2.Size = new System.Drawing.Size(75, 23);
            this.btVideo2.TabIndex = 1;
            this.btVideo2.Text = "button2";
            this.btVideo2.UseVisualStyleBackColor = true;
            this.btVideo2.Click += new System.EventHandler(this.btVideo2_Click);
            // 
            // btVideo3
            // 
            this.btVideo3.Location = new System.Drawing.Point(324, 360);
            this.btVideo3.Name = "btVideo3";
            this.btVideo3.Size = new System.Drawing.Size(75, 23);
            this.btVideo3.TabIndex = 2;
            this.btVideo3.Text = "button3";
            this.btVideo3.UseVisualStyleBackColor = true;
            this.btVideo3.Click += new System.EventHandler(this.btVideo3_Click);
            // 
            // btVideo4
            // 
            this.btVideo4.Location = new System.Drawing.Point(194, 476);
            this.btVideo4.Name = "btVideo4";
            this.btVideo4.Size = new System.Drawing.Size(64, 64);
            this.btVideo4.TabIndex = 3;
            this.btVideo4.Text = "button4";
            this.btVideo4.UseVisualStyleBackColor = true;
            this.btVideo4.Click += new System.EventHandler(this.btVideo4_Click);
            // 
            // btVideo5
            // 
            this.btVideo5.Location = new System.Drawing.Point(450, 476);
            this.btVideo5.Name = "btVideo5";
            this.btVideo5.Size = new System.Drawing.Size(64, 64);
            this.btVideo5.TabIndex = 4;
            this.btVideo5.Text = "button5";
            this.btVideo5.UseVisualStyleBackColor = true;
            this.btVideo5.Click += new System.EventHandler(this.btVideo5_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(22, 316);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(120, 158);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // btVideo6
            // 
            this.btVideo6.Location = new System.Drawing.Point(591, 473);
            this.btVideo6.Name = "btVideo6";
            this.btVideo6.Size = new System.Drawing.Size(75, 23);
            this.btVideo6.TabIndex = 6;
            this.btVideo6.Text = "button6";
            this.btVideo6.UseVisualStyleBackColor = true;
            this.btVideo6.Click += new System.EventHandler(this.btVideo6_Click);
            // 
            // pnSair
            // 
            this.pnSair.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnSair.Controls.Add(this.btfecharsair);
            this.pnSair.Controls.Add(this.btFechaPrograma);
            this.pnSair.Controls.Add(this.tbSair);
            this.pnSair.Location = new System.Drawing.Point(22, 26);
            this.pnSair.Name = "pnSair";
            this.pnSair.Size = new System.Drawing.Size(315, 179);
            this.pnSair.TabIndex = 14;
            this.pnSair.Visible = false;
            // 
            // btfecharsair
            // 
            this.btfecharsair.BackColor = System.Drawing.Color.Brown;
            this.btfecharsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btfecharsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfecharsair.ForeColor = System.Drawing.Color.Black;
            this.btfecharsair.Location = new System.Drawing.Point(261, 12);
            this.btfecharsair.Name = "btfecharsair";
            this.btfecharsair.Size = new System.Drawing.Size(41, 33);
            this.btfecharsair.TabIndex = 2;
            this.btfecharsair.Text = "X";
            this.btfecharsair.UseVisualStyleBackColor = false;
            // 
            // btFechaPrograma
            // 
            this.btFechaPrograma.BackColor = System.Drawing.Color.Brown;
            this.btFechaPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechaPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechaPrograma.Location = new System.Drawing.Point(79, 109);
            this.btFechaPrograma.Name = "btFechaPrograma";
            this.btFechaPrograma.Size = new System.Drawing.Size(155, 48);
            this.btFechaPrograma.TabIndex = 1;
            this.btFechaPrograma.Text = "Sair";
            this.btFechaPrograma.UseVisualStyleBackColor = false;
            // 
            // tbSair
            // 
            this.tbSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSair.Location = new System.Drawing.Point(15, 51);
            this.tbSair.MaxLength = 10;
            this.tbSair.Name = "tbSair";
            this.tbSair.Size = new System.Drawing.Size(280, 40);
            this.tbSair.TabIndex = 0;
            this.tbSair.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSair.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::VideoIndaiatuba.Properties.Resources.brasao_indaiatuba;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(646, 703);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 117);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::VideoIndaiatuba.Properties.Resources.dengue;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ErrorImage = global::VideoIndaiatuba.Properties.Resources.dengue;
            this.pictureBox2.Location = new System.Drawing.Point(256, 722);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(321, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::VideoIndaiatuba.Properties.Resources.logo_do_sus;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::VideoIndaiatuba.Properties.Resources.logo_do_sus;
            this.pictureBox1.Location = new System.Drawing.Point(12, 734);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.Transparent;
            this.btFechar.BackgroundImage = global::VideoIndaiatuba.Properties.Resources.fechar;
            this.btFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFechar.FlatAppearance.BorderSize = 0;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Location = new System.Drawing.Point(612, 26);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(115, 115);
            this.btFechar.TabIndex = 7;
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 832);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnSair);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btVideo6);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btVideo5);
            this.Controls.Add(this.btVideo4);
            this.Controls.Add(this.btVideo3);
            this.Controls.Add(this.btVideo2);
            this.Controls.Add(this.btVideo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prefeitura de Indaiatuba";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.pnSair.ResumeLayout(false);
            this.pnSair.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btVideo1;
        private System.Windows.Forms.Button btVideo2;
        private System.Windows.Forms.Button btVideo3;
        private System.Windows.Forms.Button btVideo4;
        private System.Windows.Forms.Button btVideo5;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btVideo6;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Panel pnSair;
        private System.Windows.Forms.Button btfecharsair;
        private System.Windows.Forms.Button btFechaPrograma;
        private System.Windows.Forms.TextBox tbSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

