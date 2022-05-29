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
        private SqlConnection con = new();

        public SpedContribuicoesBlocos(String db)
        {
            con = Connection.NewInstanceSqlServer(db);
        }

        public List<String> GerarBloco0()
        {

            List<String> bloco0000 = Bloco0.Bloco0Ini(this.con, "");
            List<String> bloco0001 = Bloco0.Bloco0001(this.con, "");
            
            return null;
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
