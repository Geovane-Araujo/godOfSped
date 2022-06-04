namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1922
{
    public String REG { get; set; } = "1922";

    public String NUM_DA { get; set; }

    public String NUM_PROC { get; set; }

    public String IND_PROC { get; set; }

    public String PROC { get; set; }

    public String TXT_COMPL { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_PROC}|{PROC}|{NUM_DA}|{NUM_PROC}|{TXT_COMPL}|";
        
        return ret;
    }

    
}