using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using AxWMPLib;
using System.IO;

namespace VideoIndaiatuba
{
    public partial class Home : Form
    {
        private int idAudio;
       
        public Home()
        {
            InitializeComponent();
            PlayFile();
        }

        /*
         * PARA AUDIO
         */
        WMPLib.WindowsMediaPlayer Player;

        private void PlayFile()
        {
            Player = new WMPLib.WindowsMediaPlayer();
            Player.PlayStateChange +=
                new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            Player.MediaError +=
                new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);

            Random random = new Random();
            idAudio = Convert.ToInt32(random.Next(1, 3).ToString());

            switch (idAudio)
            {
                case 1:
                    Player.URL = "C:\\VideoIndaiatuba\\audio1.mp3";
                    break;

                case 2:
                    Player.URL = "C:\\VideoIndaiatuba\\audio2.mp3";
                    break;

                default:
                    Player.URL = "C:\\VideoIndaiatuba\\audio1.mp3";
                    break;
            }

            Player.controls.play();
        }


        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsMediaEnded )
            {
                PlayFile();
            }
        }

        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Não foi possível abrir o audio.");
        }


        /*
         * PARA VIDEO 
         */
        private void btVideo1_Click(object sender, EventArgs e)
        {
            MostraVideo(1);
        }

        private void btVideo2_Click(object sender, EventArgs e)
        {
            MostraVideo(2);
        }

        private void btVideo3_Click(object sender, EventArgs e)
        {
            MostraVideo(3);
        }

        private void btVideo4_Click(object sender, EventArgs e)
        {
            MostraVideo(4);
        }

        private void btVideo5_Click(object sender, EventArgs e)
        {
            MostraVideo(5);
        }

        private void btVideo6_Click(object sender, EventArgs e)
        {
            MostraVideo(6);
        }

        private void MostraVideo(int idVideo)
        {
            switch (idVideo)
            {
                case 1:
                    axWindowsMediaPlayer1.URL = "C:\\VideoIndaiatuba\\video1.wmv";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;

                case 2:
                    axWindowsMediaPlayer1.URL = "C:\\VideoIndaiatuba\\video2.wmv";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;

                case 3:
                    axWindowsMediaPlayer1.URL = "C:\\VideoIndaiatuba\\video3.wmv";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;

                case 4:
                    axWindowsMediaPlayer1.URL = "C:\\VideoIndaiatuba\\video4.wmv";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;

                case 5:
                    axWindowsMediaPlayer1.URL = "C:\\VideoIndaiatuba\\video5.wmv";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;

                case 6:
                    axWindowsMediaPlayer1.URL = "C:\\VideoIndaiatuba\\video6.mp4";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;

            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //QUANDO VIDEO FOR PARADO
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying )
            {
                //PARA O AUDIO DE FUNDO
                Player.controls.stop();
                axWindowsMediaPlayer1.fullScreen = true;
            }

            //QUANDO VIDEO FOR PARADO
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                //O VIDEO FOI PARADO, PARA CONTINUAR PRECISA CLICAR EM OK
                if (MessageBox.Show("Video Parado. Clique aqui para continuar!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }

            //VOLTA O AUDIO DE FUNDO
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded )
            {
                //Player.controls.play();
                PlayFile();
            }
        }


        //PARA SAIR DO SISTEMA SÃO FEITOS OS SEGUINTES COMANDOS
        private void btFechar_Click(object sender, EventArgs e)
        {
            pnSair.Visible = true;
            pnSair.Location = new Point((this.Width / 2) - (pnSair.Width / 2), (this.Height / 2) - (pnSair.Height / 2));
            tbSair.Focus();

        }

        private bool obrigatorioSenha()
        {
            string titulo = "";
            MessageBoxButtons botao = MessageBoxButtons.OK;
            if (tbSair.Text == "")
            {
                MessageBox.Show("O CAMPO SENHA É OBRIGATÓRIO!", titulo, botao, MessageBoxIcon.Error);
                this.ActiveControl = tbSair;
                return false;
            }

            return true;
        }

        private void btfecharsair_Click(object sender, EventArgs e)
        {
            pnSair.Visible = false;
        }

        private void btFechaPrograma_Click(object sender, EventArgs e)
        {
            if (obrigatorioSenha())
            {
                if (tbSair.Text.ToString() == "master123")
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("A SENHA ESTÁ INCORRETA!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbSair.Clear();
                    this.ActiveControl = tbSair;
                }
            }
        }
    }
}
