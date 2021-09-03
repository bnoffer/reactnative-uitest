/*
 * Xamarin UI Test initialization for Android
 */
using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace reactdemoappuitest
{
    [TestFixture]
    public partial class Tests
    {
        AndroidApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            app = ConfigureApp
                .Android
                .ApkFile("../../../../reactdemoapp/android/app/build/outputs/apk/debug/app-debug.apk")
                .StartApp();
        }
    }
}
