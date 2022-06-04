namespace GodOfSped.Controller.SpedFiscal.Model.BlocoK;

public class BlocoK235
{
     public String REG { get; set; } = "K235";

    public String DT_SAIDA { get; set; }

    public String COD_ITEM { get; set; }

    public String QTD { get; set; }

    public String COD_INS_SUBST { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{QTD}|{COD_INS_SUBST}|{DT_SAIDA}|{COD_ITEM}|";
        
        return ret;
    }
    


    
}