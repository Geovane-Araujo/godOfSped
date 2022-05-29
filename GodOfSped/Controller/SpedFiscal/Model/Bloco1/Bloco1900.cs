namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1900
{
    public String REG { get; set; } = "1900";

    public String IND_APUR_ICMS { get; set; }

    public String DESCR_COMPL_OUT_APUR { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_APUR_ICMS}|{DESCR_COMPL_OUT_APUR}|";
        
        return ret;
    }

    
}