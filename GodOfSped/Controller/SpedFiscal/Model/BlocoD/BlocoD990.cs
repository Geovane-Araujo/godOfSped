namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD990
{
    public String REG { get; set; } = "D990";
    
    public String QTD_LIN_D { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{QTD_LIN_D}|";
        
        return ret;
    }
}