namespace GodOfSped.Controller.SpedFiscal.Model.BlocoH;

public class BlocoH010
{
    public String REG { get; set; } = "H010";

    public String COD_ITEM { get; set; }

    public String UNID { get; set; }
    
    public String QTD { get; set; }

    public String VL_UNIT { get; set; }

    public String VL_ITEM { get; set; }

    public String IND_PROP { get; set; }

    public String COD_PART { get; set; }

    public String TXT_COMPL { get; set; }

    public String COD_CTA { get; set; }
    
    public String VL_ITEM_IR { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_ITEM}|{UNID}|{QTD}|{VL_UNIT}|{VL_ITEM}|{IND_PROP}|{COD_PART}|{TXT_COMPL}|{COD_CTA}|{VL_ITEM_IR}|";
        
        return ret;
    }
    
    
    
}