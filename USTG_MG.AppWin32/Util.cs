using System.Collections.Generic;
using System.Drawing;
using System.IO;
using USTG_MG.Model;

namespace USTG_MG.AppWin32
{
    class Util
    {
        public static Usuario Usuario { get; set; }
        public static Configuracao Configuracao { get; set; }
        public static Image ObterFoto(List<ContingenteFoto> fotos)
        {
            using (Stream ms = new MemoryStream(fotos[fotos.Count - 1].Binario))
            {
                return Image.FromStream(ms);
            }
        }

    }
}

