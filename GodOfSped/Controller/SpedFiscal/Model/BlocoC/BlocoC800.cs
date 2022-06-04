namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC800
{
    public String REG { get; set; } = "C800";
    
    public String COD_MOD { get; set; }
    
    public String COD_SIT { get; set; }
    
    public String NUM_CFE  { get; set; }
    
    public String DT_DOC { get; set; }
    
    public String VL_CFE { get; set; }
    
    public String VL_PIS { get; set; }

    public String VL_COFINS { get; set; } 

    public String CNPJ_CPF { get; set; }  

    public String NR_SAT { get; set; } 

    public String CHV_CFE { get; set; }  

    public String VL_DESC { get; set; } 

    public String VL_MERC { get; set; }  
     
    public String VL_OUT_DA { get; set; } 
      
    public String VL_ICMS { get; set; }  
    
    public String VL_PIS_ST { get; set; }  

    public String VL_COFINS_ST { get; set; }   

    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD}|{COD_SIT}|{NUM_CFE}|{DT_DOC}|{VL_CFE}|{VL_PIS}|{VL_COFINS}|{CNPJ_CPF}|{NR_SAT}|{CHV_CFE}|{VL_DESC}|{VL_MERC}|{VL_OUT_DA}|{VL_ICMS}|{VL_PIS_ST}|{VL_COFINS_ST}|";
        
        return ret;
    }
}