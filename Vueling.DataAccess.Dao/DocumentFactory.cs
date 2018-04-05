using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Model;

namespace Vueling.DataAccess.Dao
{
    public static class DocumentFactory<T> where T : VuelingObject
    {
        public static Idocument<T> getFormat(TipoFichero dataType)
        {
            switch (dataType)
            {
                case TipoFichero.TXT:
                    return new DocumentTxt<T>();
                case TipoFichero.JSON:
                    return new DocumentJson<T>();
                case TipoFichero.XML:
                    return new DocumentXml<T>();
                default:
                    return null;
            }
        }
    }
}
