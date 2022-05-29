
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco1020
{
    public String REG { get; } = "1020";
    
    public String NUM_PROC { get; set; } = "";
    
    public String IND_NAT_ACAO { get; set; } = "";
    
    public String DT_DEC_ADM { get; set; } = "";
    
    public String ToString()
    {
        String ret = $"|{REG}|{NUM_PROC}|{IND_NAT_ACAO}|{DT_DEC_ADM}|";
        
        return ret;
    }
}