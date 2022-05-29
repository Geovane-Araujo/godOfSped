namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class Bloco9990
{   
    public String REG { get; set; } = "9990";
    
    public String QTD_LIN_9 { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{QTD_LIN_9}|";
        
        return ret;
    }
    
}