namespace GodOfSped.Controller.SpedFiscal.Model.BlocoE;

public class BlocoE230
{
    public String REG { get; set; } = "E230";

    public String NUM_DA { get; set; }

    public String NUM_PROC { get; set; }

    public String IND_PROC { get; set; }

    public String PROC { get; set; }

    public String TXT_COMPL { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{NUM_DA}|{NUM_PROC}|{IND_PROC}|{PROC}|{TXT_COMPL}|";
        
        return ret;
    }
    
}