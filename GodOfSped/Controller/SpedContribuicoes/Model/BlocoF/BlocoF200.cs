
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoF200
{
    public String REG { get; } = "F200";
    
    public String IND_OPER { get; set; } = "";
    
    public String UNID_IMOB { get; set; } = "";
    
    public String IDENT_EMP { get; set; } = "";
    
    public String DESC_UNID_IMOB { get; set; } = "";
    
    public String NUM_CONT { get; set; } = "";
    
    public String CPF_CNPJ_ADQU { get; set; } = "";
    
    public String DT_OPER { get; set; } = "";
    
    public String VL_TOT_VEND { get; set; } = "";
    
    public String VL_REC_ACUM { get; set; } = "";
    
    public String VL_TOT_REC { get; set; } = "";
    
    public String CST_PIS { get; set; } = "";
    
    public String VL_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS { get; set; } = "";
    
    public String VL_PIS { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String VL_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    public String PERC_REC_RECEB { get; set; } = "";
    
    public String IND_NAT_EMP { get; set; } = "";
    
    public String INF_COMP { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{IND_OPER}|{UNID_IMOB}|{IDENT_EMP}|{DESC_UNID_IMOB}|{NUM_CONT}|{CPF_CNPJ_ADQU}|" +
                     $"{DT_OPER}|{VL_TOT_VEND}|{VL_REC_ACUM}|{VL_TOT_REC}|{CST_PIS}|{VL_BC_PIS}|{ALIQ_PIS}|" +
                     $"{VL_PIS}|{CST_COFINS}|{VL_BC_COFINS}|{ALIQ_COFINS}|{VL_COFINS}|{PERC_REC_RECEB}|{IND_NAT_EMP}|{INF_COMP}|";
        
        return ret;
    }
}