using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SoundOfQuality.Model;

namespace SoundOfQuality
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static PegakhinSoundOfQualityEntities context = new PegakhinSoundOfQualityEntities();

        public static Managers currentManager;
    }
}
