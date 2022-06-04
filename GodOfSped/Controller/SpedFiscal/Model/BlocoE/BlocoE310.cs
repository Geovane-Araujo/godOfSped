namespace GodOfSped.Controller.SpedFiscal.Model.BlocoE;

public class BlocoE310
{
    public String REG { get; set; } = "E310";

    public String IND_MOV_FCP_DIFAL { get; set; }

    public String VL_SLD_CRED_ANT_DIFAL { get; set; }

    public String VL_TOT_DEBITOS_DIFAL { get; set; }

    public String VL_OUT_DEB_DIFAL { get; set; }

    public String VL_TOT_CREDITOS_DIFAL { get; set; } 

    public String VL_OUT_CRED_DIFAL { get; set; }

    public String VL_SLD_DEV_ANT_DIFAL { get; set; }

    public String VL_DEDUÇÕES_DIFAL { get; set; }

    public String VL_RECOL_DIFAL  { get; set; }

    public String VL_SLD_CRED_TRANS_PORTAR_DIFAL  { get; set; }

    public String DEB_ESP_DIFAL  { get; set; }

    public String VL_SLD_CRED_ANT_FCP  { get; set; }

    public String VL_TOT_DEB_FCP  { get; set; }

    public String VL_OUT_DEB_FCP  { get; set; }

    public String VL_TOT_CRED_FCP  { get; set; }

    public String VL_OUT_CRED_FCP  { get; set; }

    public String VL_SLD_DEV_ANT_FCP  { get; set; }

    public String VL_DEDUÇÕES_FCP  { get; set; }

    public String VL_RECOL_FCP  { get; set; }

    public String VL_SLD_CRED_TRANS_PORTAR_FCP { get; set; }

    public String DEB_ESP_FC  { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_MOV_FCP_DIFAL}|{VL_SLD_CRED_ANT_DIFAL}|{VL_TOT_DEBITOS_DIFAL}|{VL_OUT_DEB_DIFAL}|{VL_TOT_CREDITOS_DIFAL}|{VL_OUT_CRED_DIFAL}|{VL_SLD_DEV_ANT_DIFAL}|{VL_DEDUÇÕES_DIFAL}|{VL_RECOL_DIFAL}|{VL_SLD_CRED_TRANS_PORTAR_DIFAL}|{DEB_ESP_DIFAL}|{VL_SLD_CRED_ANT_FCP}|{VL_TOT_DEB_FCP}|{VL_OUT_DEB_FCP}|{VL_TOT_CRED_FCP}|{VL_OUT_CRED_FCP}|{VL_SLD_DEV_ANT_FCP}|{VL_DEDUÇÕES_FCP}|{VL_RECOL_FCP}|{VL_SLD_CRED_TRANS_PORTAR_FCP}|{DEB_ESP_FC}|";       
        return ret;
    }
    
}