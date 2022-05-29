namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD390
{
    public String REG { get; set; } = "D390";

    public String CST_ICMS { get; set; }
    
    public String CFOP { get; set; }
    
    public String ALIQ_ICMS  { get; set; }
    
    public String VL_OPR { get; set; }

    public String VL_BC_ISSQN { get; set; }

    public String ALIQ_ISSQN { get; set; }
    
    public String VL_ISSQN { get; set; }
    
    public String VL_BC_ICMS  { get; set; }
    
    public String VL_ICMS { get; set; }

    public String COD_OBS { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{CST_ICMS}|{CFOP}|{VL_SERV}|{VL_OPR}||{VL_BC_ISSQN}|{ALIQ_ISSQN}|{VL_ISSQN}|{VL_BC_ICMS}|{VL_ICMS}|{COD_OBS}|";
        
        return ret;
    }
}