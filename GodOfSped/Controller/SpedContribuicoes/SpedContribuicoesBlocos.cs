using GodOfSped.Model.SpedContribuicoes.Controller;

namespace GodOfSped.Model.SpedContribuicoes
{
    public class SpedContribuicoesBlocos
    {
        private SpedContriConfiguration _spedContriConfiguration = new();
        // bloco 0
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
        
        // bloco A
        private List<String> blocoA001 = new List<string>();
        private List<String> blocoA990 = new List<string>();
        
        // bloco D
        private List<String> blocoD001 = new List<string>();
        private List<String> blocoD990 = new List<string>();
        
        // bloco F
        private List<String> blocoF001 = new List<string>();
        private List<String> blocoF990 = new List<string>();
        
        // bloco I
        private List<String> blocoI001 = new List<string>();
        private List<String> blocoI990 = new List<string>();
        
        
        // bloco p
        private List<String> blocoP001 = new List<string>();
        private List<String> blocoP990 = new List<string>();
        
        // bloco 1
        private List<String> bloco1001 = new List<string>();
        private List<String> bloco1990 = new List<string>();
        
        private List<String> bloco9001 = new List<string>();
        private List<String> bloco9900 = new List<string>();
        private List<String> bloco9990 = new List<string>();
        private List<String> bloco9999 = new List<string>();


        private Dictionary<String,List<String>> tableBlocos = new();
        private List<String> arrBloco9 = new();
        private List<String> arrBloco0 = new();
        private List<String> arrBlocoA = new();
        private List<String> arrBlocoD = new();
        private List<String> arrBlocoF = new();
        private List<String> arrBlocoI = new();
        private List<String> arrBlocoP = new();
        private List<String> arrBloco1 = new();

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
            
            
            tableBlocos.Add("0000",bloco0000);
            tableBlocos.Add("0001",bloco0001);
            tableBlocos.Add("0100",bloco0100);
            tableBlocos.Add("0110",bloco0110);
            tableBlocos.Add("0140",bloco0140);
            tableBlocos.Add("0150",bloco0150);
            tableBlocos.Add("0190",bloco0190);
            tableBlocos.Add("0200",bloco0200);
            tableBlocos.Add("0500",bloco0500);
            tableBlocos.Add("0990",bloco0990);
            
            return arrBloco0;
        }

        public List<String> GerarBlocoA()
        {
            blocoA001 = BlocoA.BlocoIni(1);
            blocoA990 = BlocoA.BlocoFim(blocoA001);
            
            arrBlocoA.AddRange(blocoA001);
            arrBlocoA.AddRange(blocoA990);
            
            tableBlocos.Add("A001",blocoA001);
            tableBlocos.Add("A990",blocoA990);
            
            return arrBlocoA;
        }

        public List<String> GerarBlocoC()
        {
            
            return null;
        }

        public List<String> GerarBlocoD()
        {
            
            blocoD001 = BlocoD.BlocoIni(1);
            blocoD990= BlocoD.BlocoFim(blocoD001);
            
            arrBlocoD.AddRange(blocoD001);
            arrBlocoD.AddRange(blocoD990);
            
            tableBlocos.Add("D001",blocoD001);
            tableBlocos.Add("D990",blocoD990);
            
            return arrBlocoD;
        }


        public List<String> GerarBlocoF()
        {
            blocoF001 = BlocoF.BlocoIni(1);
            blocoF990= BlocoF.BlocoFim(blocoF001);
            
            arrBlocoF.AddRange(blocoF001);
            arrBlocoF.AddRange(blocoF990);
            
            tableBlocos.Add("F001",blocoF001);
            tableBlocos.Add("F990",blocoF990);
            
            return arrBlocoF;
        }

        public List<String> GerarBlocoI()
        {
            blocoI001 = BlocoI.BlocoIni(1);
            blocoI990= BlocoI.BlocoFim(blocoI001);
            
            arrBlocoI.AddRange(blocoI001);
            arrBlocoI.AddRange(blocoI990);
            
            tableBlocos.Add("I001",blocoI001);
            tableBlocos.Add("I990",blocoI990);
            
            return arrBlocoI;
        }

        public List<String> GerarBlocoM()
        {
            return null;
        }

        public List<String> GerarBlocoP()
        {
            blocoP001 = BlocoP.BlocoIni(1);
            blocoP990= BlocoP.BlocoFim(blocoP001);
            
            arrBlocoP.AddRange(blocoP001);
            arrBlocoP.AddRange(blocoP990);
            
            tableBlocos.Add("P001",blocoP001);
            tableBlocos.Add("P990",blocoP990);
            
            return arrBlocoP;
        }

        public List<String> GerarBloco1()
        {
            bloco1001 = BlocoP.BlocoIni(1);
            bloco1990= BlocoP.BlocoFim(bloco1001);
            
            arrBloco1.AddRange(bloco1001);
            arrBloco1.AddRange(bloco1990);
            
            tableBlocos.Add("1001",bloco1001);
            tableBlocos.Add("1990",bloco1990);
            
            return arrBloco1;
        }

        public List<String> GerarBloco9()
        {
            bloco9001 = Bloco9.Bloco9Ini(0);
            bloco9900 = Bloco9.Bloco9900(tableBlocos);
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
            contrib.AddRange(GerarBlocoA());
            contrib.AddRange(GerarBlocoD());
            contrib.AddRange(GerarBlocoF());
            contrib.AddRange(GerarBlocoI());
            contrib.AddRange(GerarBlocoP());
            contrib.AddRange(GerarBloco1());
            contrib.AddRange(GerarBloco9());
            
            bloco9999 = Bloco9.Bloco9999(contrib);
            
            // finaleira
            contrib.AddRange(bloco9999);
            return contrib;
        }

    }
}
