using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Vk.TestFramework.Config;
using WebDriverManager.DriverConfigs.Impl;

namespace Vk.TestFramework.Driver
{
    public class WebDriver
    {
        private IWebDriver _currentWebDriver;
        private WebDriverWait _wait;

        public IWebDriver Current
        {
            get
            {
                if (_currentWebDriver == null)
                {
                    _currentWebDriver = GetWebDriver();
                }

                return _currentWebDriver;
            }
        }


        public WebDriverWait Wait
        {
            get
            {
                if (_wait == null)
                {
                    this._wait = new WebDriverWait(Current, TimeSpan.FromSeconds(20));
                }
                return _wait;
            }
        }

        private IWebDriver GetWebDriver()
        {
            string remoteAddressConfigSetting = null;
            string browserName = ConfigLoader.LoadJson("testConfig")["BrowserName"];
            //string currentEnvironment = ConfigLoader.LoadJson("testConfig")["Current_Environment"];
            string testRemotelyConfigSetting = ConfigLoader.LoadJson("testConfig")["TestRemotely"];
            var testRemotely = testRemotelyConfigSetting == null ? false : Boolean.Parse(testRemotelyConfigSetting);
            var dirPath = Assembly.GetExecutingAssembly().Location;
            dirPath = Path.GetDirectoryName(dirPath);

            switch (browserName)
            {

                case "Chrome":
                    ChromeOptions chromeOptions = new ChromeOptions();
                    if (testRemotely)
                    {
                        return new RemoteWebDriver(new Uri(remoteAddressConfigSetting), chromeOptions.ToCapabilities(), TimeSpan.FromMinutes(5));
                    }
                    else
                    {
                        return new ChromeDriver(ChromeDriverService.CreateDefaultService(dirPath + "/Resources/Drivers"), chromeOptions, TimeSpan.FromMinutes(5));
                    }

                case "Firefox":
                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    if (testRemotely)
                    {
                        return new RemoteWebDriver(new Uri(remoteAddressConfigSetting), firefoxOptions.ToCapabilities(), TimeSpan.FromMinutes(5));
                    }
                    else
                    {
                        return new FirefoxDriver(FirefoxDriverService.CreateDefaultService(dirPath + "/Resources/Drivers"), firefoxOptions, TimeSpan.FromMinutes(5));
                    }

                case "IE":
                    InternetExplorerOptions ieOptions = new InternetExplorerOptions();
                    if (testRemotely)
                    {
                        return new RemoteWebDriver(new Uri(remoteAddressConfigSetting), ieOptions.ToCapabilities(), TimeSpan.FromMinutes(5));
                    }
                    else
                    {
                        return new InternetExplorerDriver(InternetExplorerDriverService.CreateDefaultService(dirPath + "/Resources/Drivers"), ieOptions, TimeSpan.FromMinutes(5));
                    }

                default:
                    throw new NotSupportedException("not supported browser: <null>");
            }
        }

        public void Quit()
        {
            _currentWebDriver?.Quit();
        }
    }
}
