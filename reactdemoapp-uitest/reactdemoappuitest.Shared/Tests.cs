/*
 * Xamarin UI Test shared test cases code.
 */
using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace reactdemoappuitest
{
    public partial class Tests
    {
        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void ChangeColors()
        {
            app.Screenshot("screenshot_Started");
            app.Tap("red");
            app.Screenshot("screenshot_red");
            app.Tap("blue");
            app.Screenshot("screenshot_blue");
            app.Tap("green");
            app.Screenshot("screenshot_green");
        }
    }
}
