namespace GodOfSped.Controller.SpedFiscal.Model.BlocoE;

public class BlocoE110
{
    public String REG { get; set; } = "E110";

    public String VL_TOT_DEBITOS { get; set; }

    public String VL_AJ_DEBITOS { get; set; }

    public String VL_TOT_AJ_DEBITOS { get; set; }

    public String VL_ESTORNOS_CRED { get; set; }

    public String VL_TOT_CREDITOS { get; set; } 

    public String VL_AJ_CREDITOS { get; set; }

    public String VL_TOT_AJ_CREDITOS { get; set; }

    public String VL_ESTORNOS_DEB { get; set; }

    public String VL_SLD_CREDOR_ANT  { get; set; }

    public String VL_SLD_APURADO  { get; set; }

    public String VL_TOT_DED  { get; set; }

    public String VL_ICMS_RECOLHER  { get; set; }

    public String VL_SLD_CREDOR_TRANSPORTAR  { get; set; }
    
    public String DEB_ESP  { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{VL_TOT_DEBITOS}|{VL_AJ_DEBITOS}|{VL_TOT_AJ_DEBITOS}|{VL_ESTORNOS_CRED}|{VL_TOT_CREDITOS}|{VL_AJ_CREDITOS}|{VL_TOT_AJ_CREDITOS}|{VL_ESTORNOS_DEB}|{VL_SLD_CREDOR_ANT}|{VL_SLD_APURADO}|{VL_TOT_DED}|{VL_ICMS_RECOLHER}|{VL_SLD_CREDOR_TRANSPORTAR}|{DEB_ESP}|";
        
        return ret;
    }
    
}