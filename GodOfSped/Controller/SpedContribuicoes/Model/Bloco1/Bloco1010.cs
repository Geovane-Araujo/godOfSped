
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco1010
{
    public String REG { get; } = "1010";
    
    public String NUM_PROC { get; set; } = "";
    
    public String ID_SEC_JUD { get; set; } = "";
    
    public String ID_VARA { get; set; } = "";
    
    public String IND_NAT_ACAO { get; set; } = "";
    
    public String DESC_DEC_JUD { get; set; } = "";
    
    public String DT_SENT_JUD { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{NUM_PROC}|{ID_SEC_JUD}|{ID_VARA}|{IND_NAT_ACAO}|{DESC_DEC_JUD}|{DT_SENT_JUD}|";
        
        return ret;
    }
}