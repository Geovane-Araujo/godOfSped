namespace GodOfSped.Controller.SpedFiscal.Model.BlocoE;

public class BlocoE500
{
    public String REG { get; set; } = "E500";

    public String IND_APUR { get; set; }

    public String DT_INI { get; set; }

    public String DT_FIN { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_APUR}|{DT_INI}|{DT_FIN}|";
        
        return ret;
    }
    
}