namespace GodOfSped.Controller.SpedFiscal.Model.BlocoK;

public class BlocoK265
{
     public String REG { get; set; } = "K265";

    public String COD_ITEM { get; set; }

    public String QTD_CONS { get; set; }

    public String QTD_RET { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_ITEM}|{QTD_CONS}|{QTD_RET}|";
        
        return ret;
    }
    


    
}