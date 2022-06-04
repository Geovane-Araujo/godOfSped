
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoF130
{
    public String REG { get; } = "F130";
    
    public String NAT_BC_CRED { get; set; } = "";
    
    public String IDENT_BEM_IMOB { get; set; } = "";
    
    public String IND_ORIG_CRED { get; set; } = "";
    
    public String IND_UTIL_BEM_IMOB { get; set; } = "";
    
    public String MES_OPER_AQUIS { get; set; } = "";
    
    public String VL_OPER_AQUIS { get; set; } = "";
    
    public String PARC_OPER_NAO_BC_CRED { get; set; } = "";
    
    public String VL_BC_CRED { get; set; } = "";
    
    public String IND_NR_PARC { get; set; } = "";
    
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
        String ret = $"|{REG}|{NAT_BC_CRED}|{IDENT_BEM_IMOB}|{IND_ORIG_CRED}|{IND_UTIL_BEM_IMOB}|{MES_OPER_AQUIS}|{VL_OPER_AQUIS}|" +
                     $"{PARC_OPER_NAO_BC_CRED}|{VL_BC_CRED}|{IND_NR_PARC}|{CST_PIS}|{VL_BC_PIS}|{ALIQ_PIS}|{VL_PIS}|" +
                     $"{CST_COFINS}|{VL_BC_COFINS}|{ALIQ_COFINS}|{VL_COFINS}|{COD_CTA}|{COD_CCUS}|{DESC_BEM_IMOB}|";
        
        return ret;
    }
}