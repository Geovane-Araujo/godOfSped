namespace GodOfSped.Controller.SpedFiscal.Model.BlocoK;

public class BlocoK990
{
     public String REG { get; set; } = "K990";
    
    public String QTD_LIN_K { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{QTD_LIN_K}|";
        
        return ret;
    }


    
}