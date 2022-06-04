using System.Data.SqlClient;
using GodOfSped.Model.SpedContribuicoes.Model;

namespace GodOfSped.Model.SpedContribuicoes;

public class SpedContriConfiguration
{
    public bool geraC { get; set; } = false;
    
    public DateTime dataini { get; set; }
    
    public DateTime datafim { get; set; }
    
    public Int32 idpessoa { get; set; }
    
    public SqlConnection cnn { get; set; }

    public Bloco0110 Bloco0110;
    
    public SpedContriConfiguration(){}
    public SpedContriConfiguration(bool geraC)
    {
        this.geraC = geraC;
    }
}