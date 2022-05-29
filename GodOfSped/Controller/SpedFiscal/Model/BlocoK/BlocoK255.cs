namespace GodOfSped.Controller.SpedFiscal.Model.BlocoK;

public class BlocoK255
{
     public String REG { get; set; } = "K255";

    public String DT_CONS { get; set; }

    public String COD_ITEM { get; set; }

    public String QTD { get; set; }

    public String COD_INS_SUBST { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{QTD}|{COD_INS_SUBST}|{DT_CONS}|{COD_ITEM}|";
        
        return ret;
    }
    


    
}