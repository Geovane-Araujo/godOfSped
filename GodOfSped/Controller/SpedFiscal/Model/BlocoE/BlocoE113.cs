namespace GodOfSped.Controller.SpedFiscal.Model.BlocoE;

public class BlocoE113
{
    public String REG { get; set; } = "E113";

    public String COD_PART { get; set; }

    public String COD_MOD { get; set; }

    public String SER { get; set; }

    public String SUB { get; set; }

    public String NUM_DOC { get; set; } 

    public String DT_DOC { get; set; }

    public String COD_ITEM { get; set; }

    public String VL_AJ_ITEM { get; set; }

    public String CHV_DOCe { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_PART}|{COD_MOD}|{SER}|{SUB}|{NUM_DOC}|{DT_DOC}|{COD_ITEM}|{VL_AJ_ITEM}|{CHV_DOCe}|";
        
        return ret;
    }
    
}