namespace GodOfSped.Controller.SpedFiscal.Model.BlocoE;

public class BlocoE300
{
    public String REG { get; set; } = "E300";

    public String UF { get; set; }

    public String DT_INI { get; set; }

    public String DT_FIN { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{UF}|{DT_INI}|{DT_FIN}|";
        
        return ret;
    }
    
}