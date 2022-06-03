
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoC100
{
    public Int32 IDNOTA;
    public String REG { get; } = "C100";
    
    public String IND_OPER { get; set; } = "";
    
    public String IND_EMIT { get; set; } = "";
    
    public String COD_PART { get; set; } = "";
    
    public String COD_MOD { get; set; } = "";
    
    public String COD_SIT { get; set; } = "";
    
    public String SER { get; set; } = "";
    
    public String NUM_DOC { get; set; } = "";
    
    public String CHV_NFE { get; set; } = "";
    
    public String DT_DOC { get; set; } = "";
    
    public String DT_E_S { get; set; } = "";
    
    public String VL_DOC { get; set; } = "";
    
    public String IND_PGTO { get; set; } = "";
    
    public String VL_DESC { get; set; } = "";
    
    public String VL_ABAT_NT { get; set; } = "";
    
    public String VL_MERC { get; set; } = "";
    
    public String IND_FRT { get; set; } = "";
    
    public String VL_FRT { get; set; } = "";
    
    public String VL_SEG { get; set; } = "";
    
    public String VL_OUT_DA { get; set; } = "";
    
    public String VL_BC_ICMS { get; set; } = "";
    
    public String VL_ICMS { get; set; } = "";
    
    public String VL_BC_ICMS_ST { get; set; } = "";
    
    public String VL_ICMS_ST { get; set; } = "";
    
    public String VL_IPI { get; set; } = "";
    
    public String VL_PIS { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    public String VL_PIS_ST { get; set; } = "";
    
    public String VL_COFINS_ST { get; set; } = "";
    
    public String ToString()
    {
        String ret = $"|{REG}|{IND_OPER}|{IND_EMIT}|{COD_PART}|{COD_MOD}|{COD_SIT}|{SER}|" +
                     $"{NUM_DOC}|{CHV_NFE}|{DT_DOC}|{DT_E_S}|" +
                     $"{VL_DOC}|{IND_PGTO}|{VL_DESC}|{VL_ABAT_NT}|{VL_MERC}|{IND_FRT}|{VL_FRT}|{VL_SEG}|{VL_OUT_DA}|" +
                     $"{VL_BC_ICMS}|{VL_ICMS}|{VL_BC_ICMS_ST}|{VL_ICMS_ST}|{VL_IPI}|{VL_PIS}|{VL_COFINS}|" +
                     $"{VL_PIS_ST}|{VL_COFINS_ST}|";
        return ret;
    }
}