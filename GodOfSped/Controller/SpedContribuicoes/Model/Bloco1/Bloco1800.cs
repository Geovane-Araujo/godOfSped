
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco1800
{
    public String REG { get; } = "1800";
    
    public String INC_IMOB { get; set; } = "";
    
    public String REC_RECEB_RET { get; set; } = "";
    
    public String REC_FIN_RET { get; set; } = "";
    
    public String BC_RET { get; set; } = "";
    
    public String ALIQ_RET { get; set; } = "";
    
    public String VL_REC_UNI { get; set; } = "";
    
    public String DT_REC_UNI { get; set; } = "";
    
    public String COD_REC { get; set; } = "";
    
    public String ToString()
    {
        String ret = $"|{REG}|{INC_IMOB}|{REC_RECEB_RET}|{REC_FIN_RET}|{BC_RET}|{ALIQ_RET}|{VL_REC_UNI}|" +
                     $"{DT_REC_UNI}|{COD_REC}|";
        
        return ret;
    }
}