namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1710
{
    public String REG { get; set; } = "1710";

    public String NUM_DOC_INI { get; set; }

    public String NUM_DOC_FIN { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{NUM_DOC_INI}|{NUM_DOC_FIN}|";
        
        return ret;
    }

    
}