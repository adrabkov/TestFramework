using Newtonsoft.Json;
using System.IO;
using System.Reflection;

namespace CAD.CD.Search.TestFramework.Config
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
