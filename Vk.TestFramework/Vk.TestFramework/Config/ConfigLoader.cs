using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Vk.TestFramework.Config
{
    class ConfigLoader
    {
        public static dynamic LoadJson(string configName)
        {
            var dirPath = Assembly.GetExecutingAssembly().Location;
            dirPath = Path.GetDirectoryName(dirPath);
            using (StreamReader r = new StreamReader(dirPath + "/Config/" + configName + ".json"))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject(json);
            }
        }
    }
}
