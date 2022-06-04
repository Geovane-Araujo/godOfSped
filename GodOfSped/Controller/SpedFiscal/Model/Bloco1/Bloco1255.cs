namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1255
{
    public String REG { get; set; } = "1255";

    public String COD_MOT_REST_COMPL { get; set; }

    public String VL_ICMS_ST_REST_MOT { get; set; }

    public String VL_FCP_ST_REST_MOT { get; set; }

    public String VL_ICMS_ST_COMPL_MOT { get; set; }

    public String VL_FCP_ST_COMPL_MOT { get; set; }

    public String VL_CREDITO_ICMS_OP_MOT { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{VL_FCP_ST_REST_MOT}|{VL_ICMS_ST_COMPL_MOT}|{COD_MOT_REST_COMPL}|{VL_ICMS_ST_REST_MOT}|{VL_FCP_ST_COMPL_MOT}|{VL_CREDITO_ICMS_OP_MOT}|";
        
        return ret;
    }

    
}