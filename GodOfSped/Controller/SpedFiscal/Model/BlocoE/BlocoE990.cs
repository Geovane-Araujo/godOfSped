namespace GodOfSped.Controller.SpedFiscal.Model.BlocoE;

public class BlocoE990
{
    public String REG { get; set; } = "E990";
    
    public String QTD_LIN_E { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{QTD_LIN_E}|";
        
        return ret;
    }
    
}