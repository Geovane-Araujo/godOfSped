namespace GodOfSped.Controller.SpedFiscal.Model.BlocoK;

public class BlocoK275
{
     public String REG { get; set; } = "K275";

    public String COD_ITEM { get; set; }

    public String QTD_COR_POS { get; set; }

    public String QTD_COR_NEG { get; set; }

    public String COD_INS_SUBST { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_ITEM}|{QTD_COR_POS}|{QTD_COR_NEG}|{COD_INS_SUBST}|";
        
        return ret;
    }
    


    
}