namespace GodOfSped.Controller.SpedFiscal.Model.BlocoK;

public class BlocoK300
{
     public String REG { get; set; } = "K300";

    public String DT_PROD { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{DT_PROD}|";
        
        return ret;
    }
    


    
}