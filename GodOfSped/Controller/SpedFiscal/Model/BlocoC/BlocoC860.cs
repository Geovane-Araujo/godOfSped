namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC860
{
    public String REG { get; set; } = "C860";
    
    public String COD_MOD { get; set; }
    
    public String NR_SAT { get; set; }
    
    public String DT_DOC  { get; set; }
    
    public String DOC_INI { get; set; }
    
    public String DOC_FIM { get; set; } 

    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD}|{NR_SAT}|{DT_DOC}|{DOC_INI}|{DOC_FIM}|";
        
        return ret;
    }
}