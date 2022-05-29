
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoD300
{
    public String REG { get; } = "D300";
    
    public String COD_MOD { get; set; } = "";
    
    public String SER { get; set; } = "";
    
    public String SUB { get; set; } = "";
    
    public String NUM_DOC_INI { get; set; } = "";
    
    public String NUM_DOC_FIN { get; set; } = "";
    
    public String CFOP { get; set; } = "";
    
    public String DT_REF { get; set; } = "";
    
    public String VL_DOC { get; set; } = "";
    
    public String VL_DESC { get; set; } = "";
    
    public String CST_PIS { get; set; } = "";
    
    public String VL_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS { get; set; } = "";
    
    public String VL_PIS { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String VL_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD}|{SER}|{SUB}|{NUM_DOC_INI}|{NUM_DOC_FIN}|{CFOP}|" +
                     $"{DT_REF}|{VL_DOC}|{VL_DESC}|{CST_PIS}|" +
                     $"{VL_BC_PIS}|{ALIQ_PIS}|{VL_PIS}|{CST_COFINS}|{VL_BC_COFINS}|{ALIQ_COFINS}|{VL_COFINS}|{COD_CTA}|";
        return ret;
    }
}