namespace GodOfSped.Controller.SpedFiscal.Model.BlocoE;

public class BlocoE112
{
    public String REG { get; set; } = "E121";

    public String NUM_DA { get; set; }

    public String NUM_PROC { get; set; }

    public String PROC { get; set; }

    public String TXT_COMPL { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{NUM_DA}|{NUM_PROC}|{PROC}|{TXT_COMPL}|";
        
        return ret;
    }
    
}