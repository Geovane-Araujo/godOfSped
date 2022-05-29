namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class Bloco0460
{
    public String REG { get; set; } = "0460";
    
    public String COD_OBS { get; set; }
    
    public String TXT { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_OBS}|{TXT}|";
        
        return ret;
    }
}