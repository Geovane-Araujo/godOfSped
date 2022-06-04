namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class Bloco0450
{
    public String REG { get; set; } = "0450";
    
    public String COD_INF { get; set; }
    
    public String TXT { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_INF}|{TXT}|";
        
        return ret;
    }
}