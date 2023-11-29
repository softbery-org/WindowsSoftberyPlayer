// Version: 1.0.0.499
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;
using Translator;

namespace WindowsSoftberyPlayer
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // Read config
            Config.Read();
            // Set application translation language
            Language.SetLanguage(Config.Parameters["Player"]["Language"]);
            
            // Application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.FormMain());
        }

        
    }

    public static class Language
    {
        public static ILanguage Translation { get; private set; }
        public static IList<ILanguage> LanguagesList { get; private set; } = new List<ILanguage>();
        
        /// <summary>
        /// Change or refresh language
        /// </summary>
        public static void ChangeLanguage()
        {
            Translation = Translation.UseLanguage() as ILanguage;
        }

        public static void ChangeLanguage(string language)
        {
            foreach (var item in LanguagesList)
            {
                if (item.Name == language)
                {
                    Translation = item.UseLanguage() as ILanguage;
                }
            }
        }

        public static void ChangeLanguage(this object obj, string language = null)
        {
            if (language != null)
            {
                ChangeLanguage(language);
            }
            var control = obj as Control;
            control.Refresh();
        }

        public static void SetLanguage(string lang)
        {
            var languages = Translator.Language.LoadLanguage();
            
            LanguagesList = languages;

            foreach (var language in LanguagesList)
            {
                if (language.Name == lang)
                {
                    Translation = language.UseLanguage() as ILanguage;
                }
            }
        }
    }
    
    public static class Config
    {
        private static string _directory = AppDomain.CurrentDomain.BaseDirectory;
        /// <summary>
        /// Ini configuration
        /// </summary>
        public static IniData Parameters { get; private set; }

        /// <summary>
        /// Read config file - 'config.ini'
        /// </summary>
        /// <param name="directory">Path to directory where ini file exist</param>
        public static void Read()
        {
            var config = new FileInfo(_directory + "config.ini");
            if (config.Exists)
            {
                var ini = new IniParser.FileIniDataParser();
                Parameters = ini.ReadFile(config.FullName);
            }
            else
            {
                createConfig(config);
                Read();
            }
        }

        public static void Write()
        {
            var config = new FileInfo(_directory + "config.ini");
            var ini = new IniParser.FileIniDataParser();
            ini.WriteFile(config.FullName, Parameters);
            Read();
        }

        static void createConfig(FileInfo file)
        {
            try
            {
                // Create a new file     
                using (FileStream fs = file.Create())
                {
                    Byte[] application = new UTF8Encoding(true).GetBytes($"[Player]{Environment.NewLine}");
                    fs.Write(application, 0, application.Length);
                    Byte[] lang = new UTF8Encoding(true).GetBytes($"Language=English{Environment.NewLine}");
                    fs.Write(lang, 0, lang.Length);
                    Byte[] control_template = new UTF8Encoding(true).GetBytes($"ControlTemplate=Default{Environment.NewLine}");
                    fs.Write(control_template, 0, control_template.Length);
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nie mogę utworzyć pliku z konfiguracją aplikacji!{Environment.NewLine}[{ex.HResult}]: {ex.Message}");
            }
        }

        static void mergeFile(string directory)
        {
            var config = new FileInfo(directory + "config.ini");
            var parser = new IniParser.Parser.IniDataParser();

            IniData player = parser.Parse(File.ReadAllText(directory + "config.ini"));
            IniData user = parser.Parse(File.ReadAllText("user_config.ini"));
            player.Merge(user);
        }
    }
}
