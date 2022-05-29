namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC300
{
    public String REG { get; set; } = "C300";

    public String COD_MOD { get; set; }

    public String SER { get; set; }

    public String SUB { get; set; }

    public String NUM_DOC_INI { get; set; }

    public String NUM_DOC_FIN { get; set; }

    public String DT_DOC { get; set; }

    public String VL_DOC { get; set; }

    public String VL_PIS { get; set; }

    public String VL_COFINS { get; set; }
    
    public String COD_CTA { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD}|{SER}|{SUB}|{NUM_DOC_INI}|{NUM_DOC_FIN}|{DT_DOC}|{VL_DOC}|{VL_PIS}|{VL_COFINS}|{COD_CTA}|";
        
        return ret;
    }
}