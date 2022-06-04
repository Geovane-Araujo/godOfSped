
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoF120
{
    public String REG { get; } = "F120";
    
    public String NAT_BC_CRED { get; set; } = "";
    
    public String IDENT_BEM_IMOB { get; set; } = "";
    
    public String IND_ORIG_CRED { get; set; } = "";
    
    public String IND_UTIL_BEM_IMOB { get; set; } = "";
    
    public String VL_OPER_DEP { get; set; } = "";
    
    public String PARC_OPER_NAO_BC_CRED { get; set; } = "";
    
    public String CST_PIS { get; set; } = "";
    
    public String VL_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS { get; set; } = "";
    
    public String VL_PIS { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String VL_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    public String COD_CCUS { get; set; } = "";
    
    public String DESC_BEM_IMOB { get; set; } = "";
    
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{NAT_BC_CRED}|{IDENT_BEM_IMOB}|{IND_ORIG_CRED}|{IND_UTIL_BEM_IMOB}|{VL_OPER_DEP}|{PARC_OPER_NAO_BC_CRED}|" +
                     $"{CST_PIS}|{VL_BC_PIS}|{ALIQ_PIS}|{VL_PIS}|{CST_COFINS}|{VL_BC_COFINS}|{ALIQ_COFINS}|" +
                     $"{VL_COFINS}|{COD_CTA}|{COD_CCUS}|{DESC_BEM_IMOB}|";
        
        return ret;
    }
}