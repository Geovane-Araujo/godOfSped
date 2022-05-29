
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco1210
{
    public String REG { get; } = "1210";
    
    public String CNPJ { get; set; } = "";
    
    public String CST_PIS { get; set; } = "";
    
    public String COD_PART { get; set; } = "";
    
    public String DT_OPER { get; set; } = "";
    
    public String VL_OPER { get; set; } = "";
    
    public String VL_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS { get; set; } = "";
    
    public String VL_PIS { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    public String DESC_COMPL { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{CNPJ}|{CST_PIS}|{COD_PART}|{DT_OPER}|{VL_OPER}|{VL_BC_PIS}|{ALIQ_PIS}|{VL_PIS}|" +
                     $"{COD_CTA}|{DESC_COMPL}|";
        
        return ret;
    }
}