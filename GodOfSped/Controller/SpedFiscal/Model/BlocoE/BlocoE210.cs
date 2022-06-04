namespace GodOfSped.Controller.SpedFiscal.Model.BlocoE;

public class BlocoE210
{
    public String REG { get; set; } = "E210";

    public String IND_MOV_ST { get; set; }

    public String VL_SLD_CRED_ANT_ST { get; set; }

    public String VL_DEVOL_ST { get; set; }

    public String VL_RESSARC_ST { get; set; }

    public String VL_OUT_CRED_ST { get; set; } 

    public String VL_AJ_CREDITOS_ST { get; set; }

    public String VL_RETENCAO_ST { get; set; }

    public String VL_OUT_DEB_ST { get; set; }

    public String VL_AJ_DEBITOS_ST  { get; set; }

    public String VL_SLD_DEV_ANT_ST  { get; set; }

    public String VL_DEDUCOES_ST  { get; set; }

    public String VL_ICMS_RECOL_ST  { get; set; }

    public String VL_SLD_CRED_ST_TRANSPORTAR  { get; set; }

    public String DEB_ESP_ST  { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_MOV_ST}|{VL_SLD_CRED_ANT_ST}|{VL_DEVOL_ST}|{VL_RESSARC_ST}|{VL_OUT_CRED_ST}|{VL_AJ_CREDITOS_ST}|{VL_RETENCAO_ST}|{VL_OUT_DEB_ST}|{VL_AJ_DEBITOS_ST}|{VL_SLD_DEV_ANT_ST}|{VL_DEDUCOES_ST}|{VL_ICMS_RECOL_ST}|{VL_SLD_CRED_ST_TRANSPORTAR}|{DEB_ESP_ST}|";
        
        return ret;
    }
    
}