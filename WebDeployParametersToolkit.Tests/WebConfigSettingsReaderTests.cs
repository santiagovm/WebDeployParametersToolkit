using System;
using System.Linq;
using NUnit.Framework;
using WebDeployParametersToolkit.Utilities;

namespace WebDeployParametersToolkit.Tests
{
    [TestFixture]
    public class WebConfigSettingsReaderTests
    {
        [Test]
        public void test_reading_app_settings()
        {
            // arrange
            var appBasePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            var fileName = $"{appBasePath}\\Resources\\web-config-with-app-settings.txt";

            var sut = new WebConfigSettingsReader(fileName)
            {
                IncludeAppSettings = true,

                IncludeApplicationSettings = false,
                IncludeCompilationDebug = false,
                IncludeMailSettings = false,
                IncludeSessionStateSettings = false
            };
            
            // act
            var webConfigSettingsList = sut.Read().ToArray();

            // assert
            Assert.AreEqual(2, webConfigSettingsList.Length);

            Assert.AreEqual("appSettings/foo-key", webConfigSettingsList[0].Name);
            Assert.AreEqual("/configuration/appSettings/add[@key='foo-key']/@value", webConfigSettingsList[0].NodePath);

            Assert.AreEqual("appSettings/bar-key", webConfigSettingsList[1].Name);
            Assert.AreEqual("/configuration/appSettings/add[@key='bar-key']/@value", webConfigSettingsList[1].NodePath);
        }
    }
}
