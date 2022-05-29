namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC113
{
    public String REG { get; set; } = "C113";

    public String IND_OPER { get; set; }

    public String IND_EMIT { get; set; }

    public String COD_PART { get; set; }

    public String COD_MOD { get; set; }

    public String SER { get; set; }

    public String SUB { get; set; }

    public String NUM_DOC { get; set; }

    public String DT_DOC { get; set; }

    public String CHV_DOCe { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_OPER}|{IND_EMIT}||{COD_PART}|{COD_MOD}|{SER}||{SUB}|{NUM_DOC}|{DT_DOC}|{CHV_DOCe}|";
        
        return ret;
    }
}