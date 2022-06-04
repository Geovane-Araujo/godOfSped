namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD410
{
    public String REG { get; set; } = "D410";

    public String COD_MOD { get; set; }
    
    public String SER { get; set; }
    
    public String SUB  { get; set; }
    
    public String NUM_DOC_INI { get; set; }

    public String NUM_DOC_FIN { get; set; }

    public String DT_DOC { get; set; }
    
    public String CST_ICMS { get; set; }
    
    public String CFOP  { get; set; }
    
    public String ALIQ_ICMS { get; set; }

    public String VL_OPR { get; set; }

    public String VL_DESC  { get; set; }
    
    public String VL_SERV { get; set; }

    public String VL_BC_ICMS { get; set; }

    public String VL_ICMS { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD}|{SER}|{SUB}|{NUM_DOC_INI}||{NUM_DOC_FIN}|{DT_DOC}|{CST_ICMS}|{CFOP}|{ALIQ_ICMS}|{VL_OPR}||{VL_DESC}|{VL_SERV}|{VL_BC_ICMS}|{VL_ICMS}|";
        
        return ret;
    }
}