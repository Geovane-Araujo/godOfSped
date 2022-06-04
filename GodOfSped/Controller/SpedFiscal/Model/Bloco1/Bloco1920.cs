namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1920
{
    public String REG { get; set; } = "1920";

    public String VL_TOT_TRANSF_DEBITOS_OA { get; set; }

    public String VL_TOT_AJ_DEBITOS_OA { get; set; }

    public String VL_ESTORNOS_CRED_OA { get; set; }

    public String VL_TOT_TRANSF_CREDITOS_OA { get; set; }

    public String VL_TOT_AJ_CREDITOS_OA	 { get; set; }

    public String VL_ESTORNOS_DEB_OA { get; set; }

    public String VL_SLD_CREDOR_ANT_OA { get; set; }

    public String VL_SLD_APURADO_OA { get; set; }

    public String VL_TOT_DED { get; set; }

    public String VL_ICMS_RECOLHER_OA { get; set; }

    public String VL_SLD_CREDOR_TRANSP_OA { get; set; }

    public String DEB_ESP_OA { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{VL_ESTORNOS_CRED_OA}|{VL_TOT_TRANSF_CREDITOS_OA}|{VL_TOT_TRANSF_DEBITOS_OA}|{VL_TOT_AJ_DEBITOS_OA}|{VL_TOT_AJ_CREDITOS_OA}|{VL_ESTORNOS_DEB_OA}|{VL_SLD_CREDOR_ANT_OA}|{VL_SLD_APURADO_OA}|{VL_TOT_DED}|{VL_ICMS_RECOLHER_OA}|{VL_SLD_CREDOR_TRANSP_OA}|{DEB_ESP_OA}|";
        
        return ret;
    }

    
}