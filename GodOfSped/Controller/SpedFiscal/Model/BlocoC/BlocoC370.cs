namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC370
{
    public String REG { get; set; } = "C370";

    public String NUM_ITEM { get; set; }

    public String COD_ITEM { get; set; }

    public String QTD { get; set; }

    public String UNID { get; set; }

    public String VL_ITEM { get; set; }

    public String VL_DESC { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{NUM_ITEM}|{COD_ITEM}|{QTD}|{UNID}|{VL_ITEM}|{VL_DESC}|";
        
        return ret;
    }
}