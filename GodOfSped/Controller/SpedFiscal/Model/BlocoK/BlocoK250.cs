namespace GodOfSped.Controller.SpedFiscal.Model.BlocoK;

public class BlocoK250
{
     public String REG { get; set; } = "K250";

    public String DT_PROD { get; set; }

    public String COD_ITEM { get; set; }

    public String QTD { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{DT_PROD}|{COD_ITEM}|{QTD}|";
        
        return ret;
    }
    


    
}