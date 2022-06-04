namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1390
{
    public String REG { get; set; } = "1390";
    
    public String COD_PROD { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_PROD}|";
        
        return ret;
    }

    
}