namespace GodOfSped.Controller.SpedFiscal.Model.BlocoK;

public class BlocoK220
{
     public String REG { get; set; } = "K220";

    public String DT_MOV { get; set; }

    public String COD_ITEM_ORI { get; set; }

    public String COD_ITEM_DEST { get; set; }

    public String QTD_ORI { get; set; }

    public String QTD_DEST { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{COD_ITEM_DEST}|{QTD_ORI}|{DT_MOV}|{COD_ITEM_ORI}|{QTD_DEST}|";
        
        return ret;
    }
    


    
}