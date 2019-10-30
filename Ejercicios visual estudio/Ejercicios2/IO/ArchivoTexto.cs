using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public class ArchivoTexto
    {
        public static void Guardar(string path, string texto)
        {
            StreamWriter archivo = new StreamWriter(path, true);
            archivo.WriteLine(texto);
            archivo.Close();
        }

        public static string Leer(string path)
        {
            StreamReader archivo = new StreamReader(path);
            if(archivo == null)
            {
                throw new FileNotFoundException();
            }
            return archivo.ReadToEnd();
        }
    }
}
