namespace GodOfSped.Controller.SpedFiscal.Model.BlocoE;

public class BlocoE115
{
    public String REG { get; set; } = "E115";

    public String COD_INF_ADIC { get; set; }

    public String VL_INF_ADIC { get; set; }

    public String DESCR_COMPL_AJ { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{COD_INF_ADIC}|{VL_INF_ADIC}|{DESCR_COMPL_AJ}|";
        
        return ret;
    }
    
}