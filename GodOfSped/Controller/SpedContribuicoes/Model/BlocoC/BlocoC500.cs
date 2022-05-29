
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoC500
{
    public String REG { get; } = "C500";
    
    public String COD_PART { get; set; } = "";
    
    public String COD_MOD { get; set; } = "";
    
    
    public String COD_SIT { get; set; } = "";
    
    public String SER { get; set; } = "";
    
    public String SUB { get; set; } = "";
    
    public String NUM_DOC { get; set; } = "";
    
    public String DT_DOC { get; set; } = "";
    
    public String DT_ENT { get; set; } = "";
    
    public String VL_DOC { get; set; } = "";
    
    public String VL_ICMS { get; set; } = "";
    
    public String COD_INF { get; set; } = "";
    
    public String VL_PIS { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    public String CHV_DOCe { get; set; } = "";
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_PART}|{COD_MOD}|{COD_SIT}|{SER}|{SUB}|{NUM_DOC}|" +
                     $"{DT_DOC}|{DT_ENT}|{VL_DOC}|{VL_ICMS}|{COD_INF}|" +
                     $"{VL_PIS}|{VL_COFINS}|{CHV_DOCe}|";
        return ret;
    }
}