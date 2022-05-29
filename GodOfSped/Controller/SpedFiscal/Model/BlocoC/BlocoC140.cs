namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC140
{
    public String REG { get; set; } = "C140";

    public String IND_EMIT { get; set; }

    public String IND_TIT { get; set; }

    public String DESC_TIT { get; set; }
    
    public String NUM_TIT { get; set; }

    public String QTD_PARC { get; set; }

    public String VL_TIT { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_EMIT}|{IND_TIT}|{DESC_TIT}|{NUM_TIT}|{QTD_PARC}|{VL_TIT}|";
        
        return ret;
    }
}