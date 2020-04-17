using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestDemo.UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.InstalledApp("com.companyname.uitestdemo").StartApp();//ApkFile("C:/Users/shashanks/source/repos/UITestDemo/UITestDemo/UITestDemo.Android/bin/Release/com.companyname.uitestdemo.apk").
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}