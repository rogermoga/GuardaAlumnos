using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Model;

namespace Vueling.Common.Logic.Utils
{
    public class DocumentManager
    {

        public static string path;
        private TipoFichero tipo;

        public DocumentManager(TipoFichero tipo)
        {
            this.tipo = tipo;
            LoadDocument();
        }

        public string GetPath()
        {
            string fileName = string.Empty;
            switch (tipo)
            {
                case TipoFichero.TXT:

                    fileName = Environment.GetEnvironmentVariable("txtfile", EnvironmentVariableTarget.User);  
                    break;

                case TipoFichero.JSON:
                    fileName = Environment.GetEnvironmentVariable("jsonfile", EnvironmentVariableTarget.User);
                    break;

                case TipoFichero.XML:
                    fileName = Environment.GetEnvironmentVariable("xmlfile", EnvironmentVariableTarget.User);
                    break;

            }
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + fileName;
        }
        public void LoadDocument()
        {
            path = GetPath();
            if (!File.Exists(path))
            {
                File.Create(path);

            }
        }


    }
}
