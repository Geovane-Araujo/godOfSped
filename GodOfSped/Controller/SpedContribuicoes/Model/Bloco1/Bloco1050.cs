
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco1050
{
    public String REG { get; } = "1050";
    
    public String DT_REF { get; set; } = "";
    
    public String IND_AJ_BC { get; set; } = "";
    
    public String CNPJ { get; set; } = "";
    
    public String VL_AJ_TOT { get; set; } = "";
    
    public String VL_AJ_CST01 { get; set; } = "";
    
    public String VL_AJ_CST02 { get; set; } = "";
    
    public String VL_AJ_CST03 { get; set; } = "";
    
    public String VL_AJ_CST04 { get; set; } = "";
    
    public String VL_AJ_CST05 { get; set; } = "";
    
    
    public String VL_AJ_CST06 { get; set; } = "";
    
    public String VL_AJ_CST07 { get; set; } = "";
    
    public String VL_AJ_CST08 { get; set; } = "";
    
    public String VL_AJ_CST09 { get; set; } = "";
    
    public String VL_AJ_CST49 { get; set; } = "";
    
    public String VL_AJ_CST99 { get; set; } = "";
    
    public String IND_APROP { get; set; } = "";
    
    public String NUM_REC { get; set; } = "";
    
    public String INFO_COMPL { get; set; } = "";
    
    public String ToString()
    {
        String ret = $"|{REG}|{DT_REF}|{IND_AJ_BC}|{CNPJ}|{VL_AJ_TOT}|{VL_AJ_CST01}|{VL_AJ_CST02}|{VL_AJ_CST03}|{VL_AJ_CST04}|" +
                     $"{VL_AJ_CST05}|{VL_AJ_CST06}|{VL_AJ_CST07}|{VL_AJ_CST08}|{VL_AJ_CST09}|{VL_AJ_CST49}|{VL_AJ_CST99}|{IND_APROP}|{NUM_REC}|" +
                     $"{INFO_COMPL}|";
        
        return ret;
    }
}