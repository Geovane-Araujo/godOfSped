namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC310
{
    public String REG { get; set; } = "C310";
    
    public String NUM_DOC_CANC { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{NUM_DOC_CANC}|";
        
        return ret;
    }
}