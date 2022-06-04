namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC790
{
    public String REG { get; set; } = "C790";
    
    public String CST_ICMS { get; set; }
    
    public String CFOP { get; set; }
    
    public String ALIQ_ICMS  { get; set; }
    
    public String VL_OPR { get; set; }
    
    public String VL_BC_ICMS { get; set; }
    
    public String VL_ICMS { get; set; }
    
    public String VL_BC_ICMS_ST { get; set; }

    public String VL_ICMS_ST { get; set; }

    public String VL_RED_BC { get; set; }
    
    public String COD_OBS { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{CST_ICMS}|{CFOP}|{ALIQ_ICMS}|{VL_BC_ICMS}|{VL_OPR}|{VL_ICMS}|{VL_BC_ICMS_ST}|{VL_ICMS_ST}|{VL_RED_BC}|{COD_OBS}|";
        
        return ret;
    }
}