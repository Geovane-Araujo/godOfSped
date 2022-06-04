namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC110
{
    public String REG { get; set; } = "C110";

    public String NUM_PROC { get; set; }

    public String IND_PROC { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{NUM_PROC}|{IND_PROC}|";
        
        return ret;
    }
}