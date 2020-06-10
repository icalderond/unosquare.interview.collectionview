using System;
using Android.Content;
using MarcaApp.Droid;
using MarcaApp.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(PackageNameDroid))]
namespace MarcaApp.Droid
{
    public class PackageNameDroid : IPackageName
    {
        public string GetPackageName()
        {
            return "test";
        }
    }
}
