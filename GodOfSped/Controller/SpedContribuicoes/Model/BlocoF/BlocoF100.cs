
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoF100
{
    public String REG { get; } = "F100";
    
    public String IND_OPER { get; set; } = "";
    
    public String COD_PART { get; set; } = "";
    
    public String COD_ITEM { get; set; } = "";
    
    public String DT_OPER { get; set; } = "";
    
    public String VL_OPER { get; set; } = "";
    
    public String CST_PIS { get; set; } = "";
    
    public String VL_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS { get; set; } = "";
    
    public String VL_PIS { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String VL_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    public String NAT_BC_CRED { get; set; } = "";
    
    public String IND_ORIG_CRED { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    public String COD_CCUS { get; set; } = "";
    
    public String DESC_COMPL { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{IND_OPER}|{COD_PART}|{COD_ITEM}|{DT_OPER}|{VL_OPER}|{CST_PIS}|" +
                     $"{VL_BC_PIS}|{ALIQ_PIS}|{VL_PIS}|{CST_COFINS}|{VL_BC_COFINS}|{ALIQ_COFINS}|{VL_COFINS}|" +
                     $"{NAT_BC_CRED}|{IND_ORIG_CRED}|{COD_CTA}|{COD_CCUS}|{DESC_COMPL}|";
        
        return ret;
    }
}