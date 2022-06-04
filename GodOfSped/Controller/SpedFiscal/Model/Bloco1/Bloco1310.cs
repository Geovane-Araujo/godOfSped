namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1310
{
    public String REG { get; set; } = "1310";

    public String NUM_TANQUE { get; set; }

    public String ESTQ_ABERT { get; set; }

    public String VOL_ENTR { get; set; }

    public String VOL_DISP { get; set; }

    public String VOL_SAIDAS { get; set; }

    public String ESTQ_ESCR { get; set; }

    public String VAL_AJ_PERDA { get; set; }

    public String VAL_AJ_GANHO { get; set; }

    public String FECH_FISICO { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{VOL_ENTR}|{VOL_DISP}|{NUM_TANQUE}|{ESTQ_ABERT}|{VOL_SAIDAS}|{ESTQ_ESCR}|{VAL_AJ_PERDA}|{VAL_AJ_GANHO}|{FECH_FISICO}|";
        
        return ret;
    }

    
}