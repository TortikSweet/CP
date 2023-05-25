using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CP_WPF_1
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Entities.A_Database_AEntities Context
        { get; } = new Entities.A_Database_AEntities();

        public static Entities.User CurrentUser = null;
    }
}
