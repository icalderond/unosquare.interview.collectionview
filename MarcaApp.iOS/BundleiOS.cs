using System;
using MarcaApp.Interfaces;
using MarcaApp.iOS;
using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: Dependency(typeof(BundleiOS))]
namespace MarcaApp.iOS
{
    public class BundleiOS : IPackageName
    {
        public string GetPackageName()
        {
            return AppInfo.PackageName;
        }
    }
}
