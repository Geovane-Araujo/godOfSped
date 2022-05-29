
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoD350
{
    public String REG { get; } = "D350";
    
    public String COD_MOD { get; set; } = "";
    
    public String ECF_MOD { get; set; } = "";
    
    public String ECF_FAB { get; set; } = "";
    
    public String DT_DOC { get; set; } = "";
    
    public String CRO { get; set; } = "";
    
    public String CRZ { get; set; } = "";
    
    public String NUM_COO_FIN { get; set; } = "";
    
    public String GT_FIN { get; set; } = "";
    
    public String VL_BRT { get; set; } = "";
    
    public String CST_PIS { get; set; } = "";
    
    public String VL_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS { get; set; } = "";
    
    public String QUANT_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS_QUANT { get; set; } = "";
    
    public String VL_PIS { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String VL_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS { get; set; } = "";
    
    public String QUANT_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS_QUANT { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD}|{ECF_MOD}|{ECF_FAB}|{DT_DOC}|{CRO}|{CRZ}|" +
                     $"{NUM_COO_FIN}|{GT_FIN}|{VL_BRT}|{CST_PIS}|" +
                     $"{VL_BC_PIS}|{ALIQ_PIS}|{QUANT_BC_PIS}|{ALIQ_PIS_QUANT}|{VL_PIS}|{CST_COFINS}|{VL_BC_COFINS}|{ALIQ_COFINS}|{QUANT_BC_COFINS}|" +
                     $"{ALIQ_COFINS_QUANT}|{VL_COFINS}|{COD_CTA}|";
        return ret;
    }
}