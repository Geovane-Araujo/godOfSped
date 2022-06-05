namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC495
{
    public String REG { get; set; } = "C495";
    
    public String ALIQ_ICMS { get; set; }
    
    public String COD_ITEM { get; set; }
    
    public String QTD { get; set; }
    
    public String QTD_CANC { get; set; }
    
    public String UNID { get; set; }
    
    public String VL_ITEM { get; set; }
    
    public String VL_DESC { get; set; }
    
    public String VL_CANC { get; set; }

    public String VL_ACMO { get; set; }
    
    public String VL_BC_ICMS { get; set; }

    public String VL_ICMS { get; set; }  

    public String VL_ISEN { get; set; }

    public String VL_NT { get; set; }
    
    public String VL_ICMS_ST { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{VL_CANC}|{COD_ITEM}|" +
                     $"{QTD}|{QTD_CANC}|{UNID}|{CST_ICMS}|{VL_DESC}|" +
                     $"{ALIQ_ICMS}|{VL_ACMO}|{VL_BC_ICMS}|{VL_ICMS}|{VL_ISEN}|" +
                     $"{VL_NT}|{VL_ICMS_ST}|";
        
        return ret;
    }
}