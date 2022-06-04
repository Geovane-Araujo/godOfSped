namespace GodOfSped.Controller.SpedFiscal.Model.BlocoH;

public class BlocoH020
{
    public String REG { get; set; } = "H020";

    public String CST_ICMS { get; set; }

    public String BC_ICMS { get; set; }

    public String VL_ICMS { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{CST_ICMS}|{BC_ICMS}|{VL_ICMS}|";
        
        return ret;
    }
    
    
    
}