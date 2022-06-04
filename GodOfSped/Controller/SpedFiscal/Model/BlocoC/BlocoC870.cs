namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC870
{
    public String REG { get; set; } = "C870";
    
    public String COD_ITEM { get; set; }
    
    public String QTD { get; set; }
    
    public String UNID  { get; set; }
    
    public String CFOP { get; set; }
    
    public String CST_ICMS { get; set; } 

    public String ToString()
    {
        String ret = $"|{REG}|{VL_ICMS}|{COD_OBS}|{UNID}|{CST_ICMS}|";
        
        return ret;
    }
}