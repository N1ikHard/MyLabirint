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
    public partial class level2 : LevelForm
    {
        public level2(bool sound):base(sound)       //Вариант конструктора с переменной для работы звука
        {
            InitializeComponent();
            StartGame();
        }
        bool key;                                   //Ключ , для прохождения уровня
        int counter = 0;                            //Счетчик времени
        bool wall91;                                //Переключатели стен
        bool wall89;
        bool wall84;
        bool wall83;
        bool wall82;
        bool wall59;
        bool wall48;
        bool wall23;
        bool wall40;
        bool wall80;
        bool wall71;
        bool wall4;
        bool wall5;
        bool wall47;
        bool wall30;
        bool wall120;
        bool wall44;
        bool wall81;
        bool wall57;
        bool wall19;
        bool wall891;
        bool wall86;
        bool wall78;
        bool wall711;
        bool wall73;
        bool wall27;
        bool wall36;
        bool wall32;
        bool wall1201;
        bool wall15;
        bool wall12;
        bool wall43;
        bool wall401;
        bool wall38;
        bool wall93;

        bool wall62;
        bool wall60;
        bool wall55;
        bool wall53;
        bool wall49;
        bool wall37;
        bool wall34;
        bool wall13;
        bool wall65;
        bool wall67;
        bool wall74;
        bool wall76;
        bool wall72;
        bool wall42;
        bool wall63;
        bool wall61;
        bool wall56;
        bool wall79;
        bool wall77;
        bool wall66;
        bool wall11;
        bool wall2;
        bool wall6;
        bool wall1;
        bool wall16;
        bool wall33;
        bool wall118;
        bool wall35;
        bool wall50;
        bool wall54;
        bool wall41;
        /// <summary>
        /// Метод при загрузки стены
        /// </summary>
        protected override void StartGame()
        {
            Point point = button_start.Location;
            point.Offset(point.X / 10, point.Y / 10);           //Установка курсора
            Cursor.Position = PointToScreen(point);
            key = false;                                        //Переменная ключа 
            panel_key.Visible = true;                           //Видимость ключа
        }
        /// <summary>
        /// Событие ,при задевании стены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            base.TouchWall();
        }
        /// <summary>
        /// Таймер , отвечающий за рост стен
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            GrowWallUP(button91, 98, 70, ref wall91);
            GrowWallUP(button84, 39, 23, ref wall84);
            GrowWallUP(button82, 48, 23, ref wall82);
            GrowWallUP(button59, 39, 23, ref wall59);
            GrowWallUP(button48, 39, 23, ref wall48);
            GrowWallUP(button23, 138, 108, ref wall23);
            GrowWallUP(button40, 138, 108, ref wall40);
            GrowWallUP(button80, 232, 198, ref wall80);
            GrowWallUP(button71, 271, 198, ref wall71);
            GrowWallUP(button4, 232, 195, ref wall4);
            GrowWallUP(button5, 232, 195, ref wall5);
            GrowWallUP(button47, 232, 195, ref wall47);
            GrowWallUP(button30, 268, 232, ref wall30);
            GrowWallUP(button120, 265, 232, ref wall120);
            GrowWallUP(button44, 329, 293, ref wall44);

            GrowWallDown(button83, 54, 86, ref wall83);
            GrowWallDown(button81, 54, 85, ref wall81);
            GrowWallDown(button57, 97, 105, ref wall57);
            GrowWallDown(button19, 63, 93, ref wall19);
            GrowWallDown(button89, 52, 88, ref wall891);
            GrowWallDown(button78, 118, 133, ref wall78);
            GrowWallDown(button71, 126, 157, ref wall711);
            GrowWallDown(button73, 48, 84, ref wall73);
            GrowWallDown(button27, 32, 54, ref wall27);
            GrowWallDown(button36, 56, 97, ref wall36);
            GrowWallDown(button32, 67, 106, ref wall32);
            GrowWallDown(button15, 54, 77, ref wall15);
            GrowWallDown(button12, 54, 79, ref wall12);
            GrowWallDown(button43, 112, 137, ref wall43);
            GrowWallDown(button40, 112, 137, ref wall401);
            GrowWallDown(button38, 112, 142, ref wall38);
        }
        protected override void NextLevel()
        {
            //Метод из базовго класса , для перехода на новый уровень 
        }
        /// <summary>
        /// Событие , для прохождения уровня
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_finish_MouseEnter(object sender, EventArgs e)
        {
            if (key == true)   //Если ключ подобран , игра заканчивается
            {
                if (checkSound) Sound.PlayWin();
                MessageBox.Show("Игра пройдена!", "Победа");
                MenuForm menu = new MenuForm();
                Hide();
                menu.Show();
            }
        }
        /// <summary>
        /// Метод , меняющий положение ключа по трем разным точкам
        /// </summary>
        private void HideKey()
        {
            Random rnd = new Random();
            byte count = (byte)rnd.Next(0, 3);
            switch (count)
            {
                case 0:
                    panel_key.Location = new Point(731, 29);
                    break;
                case 1:
                    panel_key.Location = new Point(731, 387);
                    break;
                case 2:
                    panel_key.Location = new Point(37, 387);
                    break;
            }
        }
        /// <summary>
        /// Другой таймер , отвечающий за рост стен
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BlockTimer_Tick(object sender, EventArgs e)
        {
            GrowWallRight(button93, 150, 113, ref wall93);
            GrowWallRight(button62, 167, 1139, ref wall62);
            GrowWallRight(button60, 167, 139, ref wall60);
            GrowWallRight(button55, 139, 109, ref wall55);
            GrowWallRight(button53, 139, 109, ref wall53);
            GrowWallRight(button49, 90, 66, ref wall49);
            GrowWallRight(button37, 96, 66, ref wall37);
            GrowWallRight(button34, 166, 136, ref wall34);
            GrowWallRight(button13, 71, 47, ref wall13);
            GrowWallRight(button65, 287, 259, ref wall65);
            GrowWallRight(button67, 287, 259, ref wall67);
            GrowWallRight(button74, 157, 108, ref wall74);
            GrowWallRight(button76, 157, 108, ref wall76);
            GrowWallRight(button72, 291, 270, ref wall72);
            GrowWallRight(button42, 83, 60, ref wall42);

            GrowWallLeft(button86, 186, 220, ref wall86);
            GrowWallLeft(button63, 326, 354, ref wall63);
            GrowWallLeft(button61, 326, 354, ref wall61);
            GrowWallLeft(button56, 326, 354, ref wall56);
            GrowWallLeft(button79, 0, 50, ref wall79);
            GrowWallLeft(button77, 122, 171, ref wall77);
            GrowWallLeft(button66, 122, 149, ref wall66);
            GrowWallLeft(button11, 305, 333, ref wall11);
            GrowWallLeft(button_wall2, 305, 334, ref wall2);
            GrowWallLeft(button6, 266, 305, ref wall6);
            GrowWallLeft(button1, 334, 371, ref wall1);
            GrowWallLeft(button33, 533, 568, ref wall33);
            GrowWallLeft(button118, 533, 568, ref wall118);
            GrowWallLeft(button35, 642, 622, ref wall35);
            GrowWallLeft(button50, 504, 547, ref wall50);
            GrowWallLeft(button54, 560, 590, ref wall54);
            GrowWallLeft(button41, 689, 751, ref wall41);
            counter++;
            if (counter % 10 == 0) HideKey();
        }
        /// <summary>
        /// Методы , отвечающие за рост стены , принимают в себя стену , точку до которой надо изменяться , исходную точку и переключатель
        /// </summary>
        /// <param name="wall"></param>
        /// <param name="Yone"></param>
        /// <param name="Ytwo"></param>
        /// <param name="NumWall"></param>
        private void GrowWallUP(Button wall, int Yone, int Ytwo, ref bool NumWall)
        {
            if (wall.Location.Y == Ytwo) NumWall = false;
            if (wall.Location.Y == Yone) NumWall = true;
            if (NumWall & wall.Location.Y > Ytwo)
            {
                wall.Location = new Point(wall.Location.X, wall.Location.Y - 1);
                wall.Height++;
            }
            if (!NumWall & wall.Location.Y < Yone)
            {
                wall.Location = new Point(wall.Location.X, wall.Location.Y + 1);
                wall.Height--;
            }
        }
        private void GrowWallDown(Button wall, int UpPoint, int DownPoint, ref bool NumWall)
        {
            if (wall.Height == DownPoint) NumWall = false;
            if (wall.Height == UpPoint) NumWall = true;
            if (NumWall & wall.Height < DownPoint)
            {
                wall.Height++;
            }
            if (!NumWall & wall.Height > UpPoint)
            {

                wall.Height--;
            }
        }
        private void GrowWallRight(Button wall, int LeftPoint, int RightPoint, ref bool NumWall)
        {
            if (wall.Width == LeftPoint) NumWall = false;
            if (wall.Width == RightPoint) NumWall = true;
            if (NumWall & wall.Width < LeftPoint)
            {
                wall.Width++;
            }
            if (!NumWall & wall.Width > RightPoint)
            {

                wall.Width--;
            }
        }
        private void GrowWallLeft(Button wall, int LeftPoint, int RightPoint, ref bool NumWall)
        {
            if (wall.Location.X == LeftPoint) NumWall = true;
            if (wall.Location.X == RightPoint) NumWall = false;
            if (NumWall & wall.Location.X < RightPoint)
            {
                wall.Location = new Point(wall.Location.X + 1, wall.Location.Y);
                wall.Width--;
            }
            if (!NumWall & wall.Location.X > LeftPoint)
            {
                wall.Location = new Point(wall.Location.X - 1, wall.Location.Y);
                wall.Width++;
            }
        }
        /// <summary>
        /// Событие , при задевании стены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button72_MouseEnter(object sender, EventArgs e)
        {
            base.TouchWall();
        }
        /// <summary>
        /// Событие , при задевании стены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button94_MouseEnter(object sender, EventArgs e)
        {
            base.TouchWall();
        }
        /// <summary>
        /// Событие , при задевании стены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button20_MouseEnter(object sender, EventArgs e)
        {
            base.TouchWall();
        }
        /// <summary>
        /// Событие , при задевании стены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            base.TouchWall();
        }
        /// <summary>
        /// Событие , при задевании ключа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_key_MouseEnter(object sender, EventArgs e)
        {
            key = true;
            panel_key.Visible = false;
        }
        /// <summary>
        /// Событие , при прохождении замка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            if (key == true) panel1.BackgroundImage = null; // исчезновение замка , если ключ подобран
            else
            {
                Point point = button_start.Location;
                point.Offset(point.X / 10, point.Y / 10);
                Cursor.Position = PointToScreen(point);
            }
        }
    }
}
