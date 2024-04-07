using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using winform_task2_1_anket.Database;

namespace winform_task2_1_anket.File_works
{
    public class File_class
    {
        public static void WriteHumanToFile(Human human)
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(human, options);

            File.WriteAllText($"{human.Nickname}.json", jsonString);
        }
        public static Human ReadHumanToFile(string nickname)
        {
           // nickname = "Simon";
            JsonSerializerOptions options = new()
            {
                WriteIndented = true
            };
            string a = $"{nickname}.json";
            string jsonString = File.ReadAllText(a);
            Human human = JsonSerializer.Deserialize<Human>(jsonString, options);
            return human;
        }
    }
}
