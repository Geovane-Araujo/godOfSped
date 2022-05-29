namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC173
{
    public String REG { get; set; } = "C173";

    public String LOTE_MED { get; set; }

    public String QTD_ITEM { get; set; }

    public String DT_FAB { get; set; }
    
    public String DT_VAL { get; set; }

    public String IND_MED { get; set; }

    public String TP_PROD { get; set; }

    public String VL_TAB_MAX { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{LOTE_MED}|{QTD_ITEM}||{DT_FAB}|{DT_VAL}|{IND_MED}||{TP_PROD}|{VL_TAB_MAX}";
     
        return ret;
    }
}