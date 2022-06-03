using System;
using System.Collections;
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
        private List<String> bloco0100 = new List<string>();
        private List<String> bloco0110 = new List<string>();
        private List<String> bloco0140 = new List<string>();
        private List<String> bloco0150 = new List<string>();
        private List<String> bloco0190 = new List<string>();
        private List<String> bloco0200 = new List<string>();
        private List<String> bloco0500 = new List<string>();
        private List<String> bloco0990 = new List<string>();
        
        private List<String> bloco9001 = new List<string>();
        private List<String> bloco9900 = new List<string>();
        private List<String> bloco9990 = new List<string>();
        private List<String> bloco9999 = new List<string>();


        private Dictionary<String,List<String>> tableBloco0 = new();
        private List<String> arrBloco9 = new();
        private List<String> arrBloco0 = new();

        public SpedContribuicoesBlocos(SpedContriConfiguration spedContriConfiguration)
        {
            this._spedContriConfiguration = spedContriConfiguration;
        }

        public List<String> GerarBloco0()
        {
            
            bloco0000 = Bloco0.Bloco0Ini(_spedContriConfiguration);
            bloco0001 = Bloco0.Bloco0001(bloco0110);
            bloco0100 = Bloco0.Bloco0100(_spedContriConfiguration);
            bloco0110 = Bloco0.Bloco0110(_spedContriConfiguration);
            bloco0140 = Bloco0.Bloco0140(_spedContriConfiguration);
            bloco0150 = Bloco0.Bloco0150(_spedContriConfiguration);
            bloco0190 = Bloco0.Bloco0190(_spedContriConfiguration);
            bloco0200 = Bloco0.Bloco0200(_spedContriConfiguration);
            bloco0500 = Bloco0.Bloco0500(_spedContriConfiguration);
            
            
            
            arrBloco0.AddRange(bloco0000);
            arrBloco0.AddRange(bloco0001);
            arrBloco0.AddRange(bloco0100);
            arrBloco0.AddRange(bloco0110);
            arrBloco0.AddRange(bloco0140);
            arrBloco0.AddRange(bloco0150);
            arrBloco0.AddRange(bloco0190);
            arrBloco0.AddRange(bloco0200);
            arrBloco0.AddRange(bloco0500);
            
            bloco0990 = Bloco0.Bloco0Fim(arrBloco0);
            arrBloco0.AddRange(bloco0990);
            
            
            tableBloco0.Add("0000",bloco0000);
            tableBloco0.Add("0001",bloco0001);
            tableBloco0.Add("0100",bloco0100);
            tableBloco0.Add("0110",bloco0110);
            tableBloco0.Add("0140",bloco0140);
            tableBloco0.Add("0150",bloco0150);
            tableBloco0.Add("0190",bloco0190);
            tableBloco0.Add("0200",bloco0200);
            tableBloco0.Add("0500",bloco0500);
            tableBloco0.Add("0990",bloco0990);
            
            return arrBloco0;
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
            bloco9001 = Bloco9.Bloco9Ini(0);
            bloco9900 = Bloco9.Bloco9900(tableBloco0);
            bloco9990 = Bloco9.Bloco9990(bloco9900);
            
            arrBloco9.AddRange(bloco9001);
            arrBloco9.AddRange(bloco9900);
            arrBloco9.AddRange(bloco9990);
            arrBloco9.AddRange(bloco9999);
            
            return arrBloco9;
        }

        public List<String> GerarSped()
        {
            List<String> contrib = new();
            contrib.AddRange(GerarBloco0());
            contrib.AddRange(GerarBloco9());
            
            bloco9999 = Bloco9.Bloco9999(contrib);
            
            // finaleira
            contrib.AddRange(bloco9999);
            return contrib;
        }

    }
}
