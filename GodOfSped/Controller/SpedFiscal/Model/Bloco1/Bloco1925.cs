namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1925
{
    public String REG { get; set; } = "1925";

    public String COD_INF_ADIC { get; set; }

    public String VL_INF_ADIC { get; set; }

    public String DESCR_COMPL_AJ { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{DESCR_COMPL_AJ}|{COD_INF_ADIC}|{VL_INF_ADIC}|";
        
        return ret;
    }

    
}