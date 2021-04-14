using System;
using System.Windows.Forms;

namespace MyLabirint
{
    /// <summary>
    /// Базовый класс , для следующих уровней
    /// </summary>
    public partial class LevelForm : Form
    {
       protected bool checkSound; //флаг , отвечающий за звук
        public LevelForm(bool sound)
        {
            InitializeComponent();
            checkSound = sound;
        }
        /// <summary>
        /// Метод , закрывающий уровни
        /// </summary>
        protected  void FinishGame()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;   
        }
        /// <summary>
        /// Метод  вызываемый  при задевании стены
        /// </summary>
        protected void TouchWall()
        {
            if (checkSound) Sound.PlayHit();
     DialogResult dr= MessageBox.Show("Стены задевать нельзя!\nПопробовать еще раз?","Вы проиграли",MessageBoxButtons.YesNo);
     if (dr == System.Windows.Forms.DialogResult.Yes)
        {
            StartGame();
        }
     else
        {
            FinishGame();
        }
      }
        /// <summary>
        /// Метод для переопределения , отвечающий за состояние полей , при начале игры
        /// </summary>
        protected virtual void StartGame()
        {
       
        }
        /// <summary>
        /// Метод для переопределения , отвечающий за переход на другой уровень
        /// </summary>
        protected virtual void NextLevel()
        {
            if (checkSound) Sound.PlayLevel12();
        }
        /// <summary>
        /// Событие , вызываемое при выходе за рамки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wall2_MouseEnter(object sender, EventArgs e)
        {
            TouchWall();
        }  
    }
}
