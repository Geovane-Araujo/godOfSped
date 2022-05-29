namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class Bloco0175
{
    public String REG { get; set; } = "0175";
    
    public String DT_ALT { get; set; }
    
    public String NR_CAMPO { get; set; }
    
    public String CONT_ANT { get; set; }
    
    

    public String ToString()
    {
        String ret = $"|{REG}|{DT_ALT}|{NR_CAMPO}|{CONT_ANT}|";
        
        return ret;
    }
}