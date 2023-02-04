/***********************************************************************
*  File Name:
*     Form2
*
*  Author:
*     John Ellefson
*
*  Summary:
*     Creates a second Form thats used to prompt the user for a new name
*     for the currently selected player.
************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroScape_Army_Randomizer
{
    // The class for the secondary form that simply asks for a new name for a player
    public partial class Form2 : Form
    {
        // Default constructor for Form 2
        public Form2()
        {
            InitializeComponent();
        }


        // Confirms the player name update, changes their name and closes this form
        private void btn_OK_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.UpdatePlayerName(tb_NewPlayerName.Text);
            this.Close();
        }


        // Cancels the player name update and closes this form
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
