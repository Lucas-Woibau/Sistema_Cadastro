using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaIgreja
{
    public class ConfiguracoesDb
    {
        public static string stringConexao = File.ReadAllText("C:\\Users\\lucas\\Desktop\\SistemaIgrejaCompleto\\SistemaIgreja\\SistemaIgreja\\bin\\Debug\\ConnectionString.txt");

        public void Exibir()
        {
            MessageBox.Show(stringConexao.ToString());
        }
    }
}
