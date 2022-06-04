namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC370
{
    public String REG { get; set; } = "C370";
    
    public String COD_ITEM { get; set; }
    
    public String QTD { get; set; }
    
    public String QTD_CANC { get; set; }
    
    public String UNID { get; set; }
    
    public String VL_ITEM { get; set; }
    
    public String CST_ICMS { get; set; }
    
    public String CFOP { get; set; }
    
    public String ALIQ_ICMS { get; set; }

    public String VL_PIS { get; set; }
    
    public String VL_COFINS { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{COD_ITEM}|{QTD}|{QTD_CANC}|{UNID}|{VL_ITEM}|{CST_ICMS}|{CFOP}|{ALIQ_ICMS}|{VL_PIS}|{VL_COFINS}|";
        
        return ret;
    }
}