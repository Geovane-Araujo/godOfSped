using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GodOfSped.Model.SpedContribuicoes.Controller;

namespace GodOfSped.Model.SpedContribuicoes
{
    public class SpedContribuicoesBlocos
    {
        private SpedContriConfiguration _spedContriConfiguration = new();
        private List<String> bloco0000 = new List<string>();
        private List<String> bloco0001 = new List<string>();
        private List<String> bloco0110 = new List<string>();

        public SpedContribuicoesBlocos(SpedContriConfiguration spedContriConfiguration)
        {
            this._spedContriConfiguration = spedContriConfiguration;
        }

        public List<String> GerarBloco0()
        {
            List<String> final = new();
            bloco0000 = Bloco0.Bloco0Ini(_spedContriConfiguration);
            bloco0001 = Bloco0.Bloco0001(bloco0110);
            bloco0110 = Bloco0.Bloco0110(_spedContriConfiguration);
            
            final.AddRange(bloco0000);
            final.AddRange(bloco0001);
            final.AddRange(bloco0110);
            
            
            return final;
        }

        public List<String> GerarBlocoA()
        {
            return null;
        }

        public List<String> GerarBlocoC()
        {
            return null;
        }

        public List<String> GerarBlocoD()
        {
            return null;
        }


        public List<String> GerarBlocoF()
        {
            return null;
        }

        public List<String> GerarBlocoI()
        {
            return null;
        }

        public List<String> GerarBlocoM()
        {
            return null;
        }

        public List<String> GerarBlocoP()
        {
            return null;
        }

        public List<String> GerarBloco1()
        {
            return null;
        }

        public List<String> GerarBloco9()
        {
            return null;
        }

        public String GerarSped()
        {
            return null;
        }

    }
}
