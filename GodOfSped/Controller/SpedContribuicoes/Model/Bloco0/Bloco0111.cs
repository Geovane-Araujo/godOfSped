
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco0111
{
    public String REG { get; } = "0111";
    
    public String REC_BRU_NCUM_TRIB_MI { get; set; }
    
    public String REC_BRU_NCUM_EXP { get; set; }
    
    public String REC_BRU_CUM { get; set; }
    
    public String REC_BRU_TOTAL { get; set; }

    
    public String ToString()
    {
        String ret = $"|{REG}|{REC_BRU_NCUM_TRIB_MI}|{REC_BRU_NCUM_EXP}|{REC_BRU_CUM}|{REC_BRU_TOTAL}|";
        
        return ret;
    }
}