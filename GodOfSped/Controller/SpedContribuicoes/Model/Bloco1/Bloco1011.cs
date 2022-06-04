
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco1011
{
    public String REG { get; } = "1011";
    
    public String REG_REF { get; set; } = "";
    
    public String CHAVE_DOC { get; set; } = "";
    
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
    
    public String CST_PIS_SUSP { get; set; } = "";
    
    public String VL_BC_PIS_SUSP { get; set; } = "";
    
    public String ALIQ_PIS_SUSP { get; set; } = "";
    
    public String VL_PIS_SUSP { get; set; } = "";
    
    public String CST_COFINS_SUSP { get; set; } = "";
    
    public String VL_BC_COFINS_SUSP { get; set; } = "";
    
    public String ALIQ_COFINS_SUSP { get; set; } = "";
    
    public String VL_COFINS_SUSP { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    public String COD_CCUS { get; set; } = "";
    
    public String DESC_DOC_OPER { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{REG_REF}|{CHAVE_DOC}|{COD_PART}|{COD_ITEM}|{DT_OPER}|{VL_OPER}|{CST_PIS}|{VL_BC_PIS}|" +
                     $"{ALIQ_PIS}|{VL_PIS}|{CST_COFINS}|{VL_BC_COFINS}|{ALIQ_COFINS}|{VL_COFINS}|{CST_PIS_SUSP}|{VL_BC_PIS_SUSP}|{ALIQ_PIS_SUSP}|" +
                     $"{VL_PIS_SUSP}|{CST_COFINS_SUSP}|{VL_BC_COFINS_SUSP}|{ALIQ_COFINS_SUSP}|{VL_COFINS_SUSP}|{COD_CTA}|{COD_CCUS}|{DESC_DOC_OPER}|";
        
        return ret;
    }
}