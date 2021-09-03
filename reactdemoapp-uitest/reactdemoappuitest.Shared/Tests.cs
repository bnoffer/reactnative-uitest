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
    }
}
