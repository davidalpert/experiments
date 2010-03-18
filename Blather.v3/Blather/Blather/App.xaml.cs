using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using Blather.Models;
using Blather.Core.Helpers;

namespace Blather
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Console c = new Console();

            ConsoleViewModel vm = new ConsoleViewModel();

			vm.SomeString = "hello";
            vm.SetImage(new RandomBitmapFactory().BuildRandomBitmap().Bitmap);

            c.DataContext = vm;

            c.Show();
        }
    }
}
