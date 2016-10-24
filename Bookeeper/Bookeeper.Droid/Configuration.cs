using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite.Net.Interop;
using Xamarin.Forms;
[assembly: Dependency(typeof(Bookeeper.Droid.Configuration))]

namespace Bookeeper.Droid
{
    public class Configuration : IConfiguration
    {
        private string Dir;
        private ISQLitePlatform Platform;

        public string dir
        {
            get
            {
                if (string.IsNullOrEmpty(Dir))
                {
                    Dir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                }

                return Dir;
            }
        }

        public ISQLitePlatform platform
        {
            get
            {
                if (Platform == null)
                {
                    Platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
                }

                return Platform;
            }
        }
    }
}