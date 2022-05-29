namespace GodOfSped.Controller.SpedFiscal.Model.BlocoG;

public class BlocoG990
{
    public String REG { get; set; } = "G990";
    
    public String QTD_LIN_G { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{QTD_LIN_G}|";
        
        return ret;
    }
    
}