using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Sturct_Class : Form
    {
        public Sturct_Class()
        {
            InitializeComponent();
        }

        struct structPlayer
        {
            public int iCount; // player가 몇회 진행 중인지
            public int iSun;    // 해에 대한 값
            public int iMoon;   // 달에 대한 값
            public int iStar;   // 별에 대한 값
            public int iCardSum;    // 해, 달, 별을 더한 값
        }

        structPlayer _stPlayer1;
        structPlayer _stPlayer2;

        CPlayer cPlayer1 = new CPlayer();
        CPlayer cPlayer2 = new CPlayer();


        Random _rd = new Random();
        private void All_button_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);  
            PictureBox pBox_Name = (PictureBox)sender;
            string name = pBox_Name.Name;

            if (name == "pboxSun")
            {
                if (rdoPlayer1.Checked) cPlayer1.iSun = iNumber;
                if (rdoPlayer2.Checked) cPlayer2.iSun = iNumber;
            }
            else if (name == "pboxMoon")
            {
                if (rdoPlayer1.Checked) cPlayer1.iMoon = iNumber;
                if (rdoPlayer2.Checked) cPlayer2.iMoon = iNumber;
            }
            else if (name == "pboxStar")
            {
                if (rdoPlayer1.Checked) cPlayer1.iStar= iNumber;
                if (rdoPlayer2.Checked) cPlayer2.iStar = iNumber;
            }            

            Result();
            iCheckedChange();
            if (cPlayer1.iCount >= 5 && cPlayer2.iCount >= 5)
            {
                if (cPlayer1.iCardSum > cPlayer2.iCardSum)
                {
                    MessageBox.Show("Player 1이 이겼습니다.");                    
                }
                else if (cPlayer1.iCardSum < cPlayer2.iCardSum)
                {
                    MessageBox.Show("Player 2이 이겼습니다.");                    
                }
                else if (_stPlayer1.iCardSum == cPlayer2.iCardSum)
                {
                    MessageBox.Show("무승부 입니다.");                    
                }
                lboxResult1.Items.Clear();
                lboxResult2.Items.Clear();
                _stPlayer1 = new structPlayer();
                _stPlayer2 = new structPlayer();
                return;
            }
        }

        private void iCheckedChange()
        {
            if (rdoPlayer1.Checked)
            {
                rdoPlayer2.Checked = true;
            }
            else
            {
                rdoPlayer1.Checked = true;
            }
        }
        private void Result()
        {
            
            CPlayer cPlayer = rdoPlayer1.Checked ? cPlayer1 : cPlayer2;
            var selectedListbox = rdoPlayer1.Checked ? lboxResult1 : lboxResult2;


            cPlayer.iCardSum = cPlayer.CardSun(cPlayer.iSun, cPlayer.iMoon, cPlayer.iStar);

            cPlayer.iCount++;
            string strResult = cPlayer.ResultText();

            
            selectedListbox.Items.Add(strResult);
        }



    }
}

