namespace GodOfSped.Controller.SpedFiscal.Model.BlocoK;

public class BlocoK010
{
     public String REG { get; set; } = "K010";
    
    public String IND_TP_LEIAUTE { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_TP_LEIAUTE}|";
        
        return ret;
    }


    
}