using CAD.CD.Search.TestFramework.PageObjects.PageElements;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Vk.TestFramework.Utils
{
    public class CommonUtilities
    {
        public static string GetPath(string fileName) => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);

        public static void UploadFile(WebElement element, string path) => element.SendKeys(path);
    }
}
