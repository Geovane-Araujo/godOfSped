namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1910
{
    public String REG { get; set; } = "1910";

    public String DT_INI { get; set; }

    public String DT_FIN { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{DT_INI}|{DT_FIN}|";
        
        return ret;
    }

    
}