namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD301
{
    public String REG { get; set; } = "D301";
    
    public String NUM_DOC_CANC { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{NUM_DOC_CANC}|";
        
        return ret;
    }
}