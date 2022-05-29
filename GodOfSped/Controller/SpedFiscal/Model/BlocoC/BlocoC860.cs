namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC850
{
    public String REG { get; set; } = "C850";
    
    public String COD_MOD { get; set; }
    
    public String NR_SAT { get; set; }
    
    public String DT_DOC  { get; set; }
    
    public String DOC_INI { get; set; }
    
    public String DOC_FIM { get; set; } 

    public String ToString()
    {
        String ret = $"|{REG}|{VL_ICMS}|{COD_OBS}|{DT_DOC}|{DOC_FIM}|";
        
        return ret;
    }
}