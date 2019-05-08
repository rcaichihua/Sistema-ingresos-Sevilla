using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace GUI_SEVILLA
{
    public class ProtegerConfig
    {
        public static void ProtegerConexion()
        {
            Configuration configura = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (!configura.ConnectionStrings.SectionInformation.IsProtected)
            {
                configura.ConnectionStrings.SectionInformation.ProtectSection(null);
                configura.Save(ConfigurationSaveMode.Full, true);
            }
        }

        public static void ProtegerVariables()
        {
            Configuration configura = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (!configura.AppSettings.SectionInformation.IsProtected)
            {
                configura.AppSettings.SectionInformation.ProtectSection(null);
                configura.Save(ConfigurationSaveMode.Full, true);
            }
        }

        public static void ProtegerConexionVariables()
        {
            Configuration configura = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            bool grabar = false;
            if (!configura.ConnectionStrings.SectionInformation.IsProtected)
            {
                configura.ConnectionStrings.SectionInformation.ProtectSection(null);
                grabar = true;
            }
            if (!configura.AppSettings.SectionInformation.IsProtected)
            {
                configura.AppSettings.SectionInformation.ProtectSection(null);
                grabar = true;
            }
            if(grabar) configura.Save(ConfigurationSaveMode.Full, true);
        }
    }
}
