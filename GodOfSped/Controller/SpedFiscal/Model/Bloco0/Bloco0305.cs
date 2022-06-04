namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class Bloco0305
{
    public String REG { get; set; } = "0305";
    
    public String COD_CCUS { get; set; }
    
    public String FUNC { get; set; }
    
    public String VIDA_UTIL { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_CCUS}|{FUNC}|{VIDA_UTIL}|";
        
        return ret;
    }
}