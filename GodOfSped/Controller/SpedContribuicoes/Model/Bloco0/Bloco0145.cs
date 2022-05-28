
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco0145
{
    public String REG { get; } = "0145";
    
    public String COD_INC_TRIB { get; set; }
    
    public String VL_REC_TOT { get; set; }
    
    public String VL_REC_ATIV { get; set; }
    
    public String VL_REC_DEMAIS_ATIV { get; set; }
    
    public String INFO_COMPL { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_INC_TRIB}|{VL_REC_TOT}|{VL_REC_ATIV}|{VL_REC_DEMAIS_ATIV}|{INFO_COMPL}|";
        
        return ret;
    }
}