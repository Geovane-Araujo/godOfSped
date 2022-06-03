using System.Data.SqlClient;
using GodOfSped.Model.SpedContribuicoes.Model;

namespace GodOfSped.Model.SpedContribuicoes;

public class SpedContriConfiguration
{
    public bool geraC { get; set; } = false;
    
    public bool geraM { get; set; } = false;
    
    public bool geraI { get; set; } = false;
    
    public bool gera1 { get; set; } = false;
    
    public bool geraP { get; set; } = false;
    public DateTime dataini { get; set; }
    
    public DateTime datafim { get; set; }
    
    public Int32 idpessoa { get; set; }
    
    public String cnpjEmpresa { get; set; }


    public String IND_ESCRI { get; set; } = "2"; 	// Indicador da apuração das contribuições e créditos, na escrituração das operações por NF-e e ECF, no período:

    public SqlConnection cnn { get; set; }

    public Bloco0110 Bloco0110;
    
    public SpedContriConfiguration(){}
    public SpedContriConfiguration(bool geraC)
    {
        this.geraC = geraC;
    }
}