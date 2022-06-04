namespace GodOfSped.Controller.SpedFiscal.Model.BlocoE;

public class BlocoE311
{
    public String REG { get; set; } = "E311";

    public String COD_AJ_APUR { get; set; }

    public String DESCR_COMPL_AJ { get; set; }

    public String VL_AJ_APUR { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{COD_AJ_APUR}|{DESCR_COMPL_AJ}|{VL_AJ_APUR}|";
        
        return ret;
    }
    
}