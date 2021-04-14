using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLabirint
{
    public partial class ChoseLevel : Form
    {
        MenuForm menu=new MenuForm();
      
        public ChoseLevel(bool checkSound)
        {
          
            InitializeComponent();
             menu.checkSound=checkSound;
        }
        private void level1_Click(object sender, EventArgs e)
        {
            Level1 level = new Level1(menu.checkSound);         
            Hide();
            level.ShowDialog();
            menu.ShowDialog();
        }
        private void level2_Click(object sender, EventArgs e)
        {
            Level3 level = new Level3(menu.checkSound);
            Hide();
            level.ShowDialog();
            menu.ShowDialog();
        }
        private void level3_Click(object sender, EventArgs e)
        {
            level2 level = new level2(menu.checkSound);
            Hide();
            level.ShowDialog();
            menu.ShowDialog();
        }
        private void CloseLabel_Click(object sender, EventArgs e)
        {       
            Hide();
            menu.ShowDialog();
        }
    }
}
