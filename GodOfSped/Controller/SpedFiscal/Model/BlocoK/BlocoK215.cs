namespace GodOfSped.Controller.SpedFiscal.Model.BlocoK;

public class BlocoK215
{
     public String REG { get; set; } = "K215";

    public String COD_ITEM_DES { get; set; }

    public String QTD_DES { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_ITEM_DES}|{QTD_DES}|";
        
        return ret;
    }
    


    
}