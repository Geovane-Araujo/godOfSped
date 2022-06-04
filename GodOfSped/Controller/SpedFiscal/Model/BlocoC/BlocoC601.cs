namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC601
{
    public String REG { get; set; } = "C601";
    
    public String NUM_DOC_CANC { get; set; }

    
    public String ToString()
    {
        String ret = $"|{REG}|{NUM_DOC_CANC}|";
        
        return ret;
    }
}