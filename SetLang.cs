using System;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using UAutoTranslate;
using UAutoTranslate.Properties;

namespace UAutoTranslate
{
    public class SetLang
    {
        private string ViewMS;
        MainWindow msg = new MainWindow();
        WebClient web = new WebClient();
        private readonly string UbisoftConnectDownloadLink = Settings.Default.UbisoftConnectDL;

        private readonly string GeForceExperiencePATH = @"C:\Program Files\NVIDIA Corporation\NVIDIA GeForce Experience\www\l10n\";
        private readonly string GeForceExperienceDownloadLink = Settings.Default.GeForceExperienceDL;

        private readonly string ShadowPlayPATH = @"C:\Program Files\NVIDIA Corporation\NVIDIA GeForce Experience\osc\l10n\";
        private readonly string ShadowPlayDownloadLink = Settings.Default.ShadowPlayDL;

        private bool setLangFor(bool search, string @Download_path, string File_save_name, string search_name, string Dop_path = "")
        {
            try
            {
                Process[] ap = Process.GetProcessesByName(@search_name);
                foreach (var p in ap)
                    ViewMS = p.MainModule.FileName.Replace(@search_name + ".exe", "");
                ViewMS = ViewMS + @Dop_path;

                msg.MSGEXShow($"Замінено у:\n{ViewMS}");
                web.DownloadFileAsync(new Uri(@Download_path), @ViewMS + File_save_name);

                return true;
            }
            catch (System.Exception ex)
            {
                msg.MSGEXShow($"Схоже виникла помилка, спробуйте запустити застосунок від імені адміністратора\n\n{ex}");
                return false;
            }
        }
        private bool setLangFor(string @Download_path, string @Save_path, string File_save_name)
        {
            try
            {
                msg.MSGEXShow($"Замінено у:\n{@Download_path}");
                web.DownloadFileAsync(new Uri(@Download_path), @Save_path + File_save_name);

                return true;
            }
            catch (System.Exception ex)
            {
                msg.MSGEXShow($"Схоже виникла помилка, спробуйте запустити застосунок від імені адміністратора\n\n{ex}");

                return false;
            }
            
        }
        public bool setLangByIndex(sbyte index)
        {
            switch (index)
            {
                case 0:
                    return setLangForUbiConn();
                case 1:
                    return setLangForGefExp();
                case 2:
                    return setLangForShadowPlay();
                default:
                    return false;
            }
        }

        private bool setLangForUbiConn()
        {

            return setLangFor(true, @UbisoftConnectDownloadLink, "ru-RU_loc.txt", "upc", @"data\loc\");
            //try
            //{                
            //    Process[] ap = Process.GetProcessesByName("upc");
            //    foreach (var p in ap)
            //        ViewMS = p.MainModule.FileName.Replace("upc.exe", "");
            //    ViewMS = ViewMS + @"data\loc\";
            //    msg.MSGEXShow($"{ViewMS}");
            //    web.DownloadFileAsync(new Uri(@UbisoftConnectDownloadLink), @ViewMS + "uk-UA_loc.txt");
            //    return true;
            //}
            //catch (System.Exception ex)
            //{                
            //    msg.MSGEXShow($"Схоже виникла помилка, спробуйте запустити застосунок від імені адміністратора\n\n{ex}");
            //    return false;
            //}
        }
        private bool setLangForGefExp()
        {
            return setLangFor(@GeForceExperienceDownloadLink, @GeForceExperiencePATH, "NVIDIA GeForce Exirience.zip");
        }
        private bool setLangForShadowPlay()
        {
            return setLangFor(@ShadowPlayDownloadLink, @ShadowPlayPATH, "ru-RU.json");
        }
        private bool setLangForLoopHero()
        {
            return false;
        }

    }

}
