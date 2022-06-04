namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1921
{
    public String REG { get; set; } = "1921";

    public String COD_AJ_APUR { get; set; }

    public String DESCR_COMPL_AJ { get; set; }

    public String VL_AJ_APUR { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{VL_AJ_APUR}|{COD_AJ_APUR}|{DESCR_COMPL_AJ}|";
        
        return ret;
    }

    
}