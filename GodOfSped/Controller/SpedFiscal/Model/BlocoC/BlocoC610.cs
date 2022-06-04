namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC610
{
    public String REG { get; set; } = "C610";
    
    public String COD_CLASS { get; set; }
    
    public String COD_ITEM { get; set; }
    
    public String QTD  { get; set; }
    
    public String UNID { get; set; }
    
    public String VL_ITEM { get; set; }
    
    public String VL_DESC { get; set; }

    public String CST_ICMS { get; set; } 

    public String CFOP { get; set; }  

    public String ALIQ_ICMS { get; set; } 

    public String VL_BC_ICMS { get; set; }  

    public String VL_ICMS { get; set; } 

    public String VL_BC_ICMS_ST { get; set; }  
     
    public String VL_ICMS_ST { get; set; } 

    public String VL_PIS { get; set; }  

    public String VL_COFINS { get; set; }  
    
    public String COD_CTA { get; set; }  

    public String ToString()
    {
        String ret = $"|{REG}|{COD_CLASS}|{COD_ITEM}|{QTD}|{UNID}|{VL_ITEM}|{VL_DESC}|{CST_ICMS}|{CFOP}|{ALIQ_ICMS}|{VL_BC_ICMS}|{VL_ICMS}|{VL_BC_ICMS_ST}|{VL_ICMS_ST}| {VL_PIS}|{VL_COFINS}|{COD_CTA}|";
        
        return ret;
    }
}