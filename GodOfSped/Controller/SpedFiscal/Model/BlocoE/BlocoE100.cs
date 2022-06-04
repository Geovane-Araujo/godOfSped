namespace GodOfSped.Controller.SpedFiscal.Model.BlocoE;

public class BlocoE100
{
    public String REG { get; set; } = "E100";

    public String DT_INI { get; set; }

    public String DT_FIN { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{DT_INI}|{DT_FIN}|";
        
        return ret;
    }
    
}