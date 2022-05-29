namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class Bloco0990
{
    public String REG { get; set; } = "0990";
    
    public String QTD_LIN_0 { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{QTD_LIN_0}|";
        
        return ret;
    }
}