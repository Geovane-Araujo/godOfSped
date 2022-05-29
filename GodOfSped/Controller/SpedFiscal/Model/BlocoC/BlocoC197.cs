namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC197
{
    public String REG { get; set; } = "C197";

    public String COD_AJ { get; set; }

    public String DESCR_COMPL_AJ { get; set; }

    public String COD_ITEM { get; set; }

    public String VL_BC_ICMS { get; set; }

    public String ALIQ_ICMS { get; set; }

    public String VL_ICMS { get; set; }

    public String VL_OUTROS { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_AJ}|{DESCR_COMPL_AJ}|{COD_ITEM}|{VL_BC_ICMS}|{ALIQ_ICMS}||{VL_ICMS}|{VL_OUTROS}|";
        
        return ret;
    }
}