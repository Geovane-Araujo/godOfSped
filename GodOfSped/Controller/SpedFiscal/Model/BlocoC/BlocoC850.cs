namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC850
{
    public String REG { get; set; } = "C850";
    
    public String CST_ICMS { get; set; }
    
    public String CFOP { get; set; }
    
    public String ALIQ_ICMS  { get; set; }
    
    public String VL_OPR { get; set; }
    
    public String VL_BC_ICMS { get; set; }
    
    public String VL_ICMS { get; set; }

    public String COD_OBS { get; set; }   

    public String ToString()
    {
        String ret = $"|{REG}|{VL_ICMS}|{COD_OBS}|{ALIQ_ICMS}|{VL_BC_ICMS}|{VL_OPR}|{CST_ICMS}|{CFOP}|";
        
        return ret;
    }
}