
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco1610
{
    public String REG { get; } = "1600";
    
    public String COD_EST { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String COD_PART { get; set; } = "";
    
    public String DT_OPER { get; set; } = "";
    
    public String VL_OPER { get; set; } = "";
    
    public String VL_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    public String DESC_COMPL { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_EST}|{CST_COFINS}|{COD_PART}|{DT_OPER}|{VL_OPER}|{VL_BC_COFINS}|" +
                     $"{ALIQ_COFINS}|{VL_COFINS}|{COD_CTA}|{DESC_COMPL}|";
        
        return ret;
    }
}