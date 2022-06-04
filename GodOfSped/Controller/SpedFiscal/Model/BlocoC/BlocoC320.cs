namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC320
{
    public String REG { get; set; } = "C320";

    public String CST_ICMS { get; set; }

    public String CFOP { get; set; }

    public String ALIQ_ICMS { get; set; }

    public String VL_OPR { get; set; }

    public String VL_BC_ICMS { get; set; }

    public String VL_ICMS { get; set; }

    public String VL_RED_BC { get; set; }

    public String COD_OBS { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{CST_ICMS}|{CFOP}|{ALIQ_ICMS}|{VL_OPR}|{VL_BC_ICMS}|{VL_ICMS}|{VL_RED_BC}|{COD_OBS}|";
        
        return ret;
    }
}