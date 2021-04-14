using System;
using System.Media;
using WMPLib;

namespace MyLabirint
{
    /// <summary>
    /// Класс для звуковых эффектов
    /// </summary>
   public static class Sound
    {
     public static WMPLib.WindowsMediaPlayer soundKey = new WMPLib.WindowsMediaPlayer();
     public static WMPLib.WindowsMediaPlayer soundWall = new WMPLib.WindowsMediaPlayer();
     public static WMPLib.WindowsMediaPlayer soundWinLevel12 = new WMPLib.WindowsMediaPlayer();
     public static WMPLib.WindowsMediaPlayer soundWin = new WMPLib.WindowsMediaPlayer();
     public static WMPLib.WindowsMediaPlayer soundCheck = new WMPLib.WindowsMediaPlayer();
        public static void PlayKey()
        {
            soundKey.URL = "Key.mp3";
            soundKey.controls.play();
        }
        public static void PlayCheck()
        {
            soundKey.URL = "Музыка.mp3";
            soundKey.controls.play();
        }
        public static void PlayHit()
        {
            soundKey.URL = "Звук удара.mp3";
            soundKey.controls.play();
        }
        public static void PlayLevel12()
        {
            soundKey.URL = "уровни 12.mp3";
            soundKey.controls.play();
        }
        public static void PlayWin()
        {
            soundKey.URL = "пройдена игра.mp3";
            soundKey.controls.play();
        }

    }
}
