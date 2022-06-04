namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC321
{
    public String REG { get; set; } = "C321";

    public String COD_ITEM { get; set; }

    public String QTD { get; set; }

    public String UNID { get; set; }

    public String VL_ITEM { get; set; }

    public String VL_DESC { get; set; }

    public String VL_BC_ICMS { get; set; }

    public String VL_ICMS { get; set; }

    public String VL_PIS { get; set; }

    public String VL_COFINS { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_ITEM}|{QTD}|{UNID}|{VL_ITEM}|{VL_DESC}|{VL_BC_ICMS}|{VL_ICMS}|{VL_PIS}|{VL_COFINS}|";
        
        return ret;
    }
}