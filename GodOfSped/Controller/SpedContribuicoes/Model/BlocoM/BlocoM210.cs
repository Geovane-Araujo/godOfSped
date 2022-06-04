
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoM210
{
    public String REG { get; } = "M210";
    
    public String COD_CONT { get; set; } = "";
    
    public String VL_REC_BRT { get; set; } = "";
    
    public String VL_BC_CONT { get; set; } = "";
    
    public String VL_AJUS_ACRES_BC_PIS { get; set; } = "";
    
    public String VL_AJUS_REDUC_BC_PIS { get; set; } = "";
    
    public String VL_BC_CONT_AJUS { get; set; } = "";
    
    public String ALIQ_PIS { get; set; } = "";
    
    public String QUANT_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS_QUANT { get; set; } = "";
    
    public String VL_CONT_APUR { get; set; } = "";
    
    public String VL_AJUS_ACRES { get; set; } = "";
    
    public String VL_AJUS_REDUC { get; set; } = "";
    
    public String VL_CONT_DIFER { get; set; } = "";
    
    public String VL_CONT_DIFER_ANT { get; set; } = "";
    
    public String VL_CONT_PER { get; set; } = "";
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_CONT}|{VL_REC_BRT}|{VL_BC_CONT}|{VL_AJUS_ACRES_BC_PIS}|{VL_AJUS_REDUC_BC_PIS}|{VL_BC_CONT_AJUS}|" +
                     $"{ALIQ_PIS}|{QUANT_BC_PIS}|{ALIQ_PIS_QUANT}|{VL_CONT_APUR}|{VL_AJUS_ACRES}|{VL_AJUS_REDUC}|{VL_CONT_DIFER}|{VL_CONT_DIFER_ANT}|{VL_CONT_PER}|";
        
        return ret;
    }
}