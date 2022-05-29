namespace GodOfSped.Controller.SpedFiscal.Model.BlocoK;

public class BlocoK301
{
     public String REG { get; set; } = "K301";

    public String COD_ITEM { get; set; }

    public String QTD { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_ITEM}|{QTD}|";
        
        return ret;
    }
    


    
}