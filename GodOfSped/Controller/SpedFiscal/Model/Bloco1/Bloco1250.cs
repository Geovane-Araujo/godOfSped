namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1250
{
    public String REG { get; set; } = "1250";

    public String VL_CREDITO_ICMS_OP { get; set; }

    public String VL_FCP_ST_REST { get; set; }

    public String VL_ICMS_ST_COMPL { get; set; }

    public String VL_FCP_ST_COMPL { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{VL_ICMS_ST_COMPL}|{VL_FCP_ST_COMPL}|{VL_CREDITO_ICMS_OP}|{VL_FCP_ST_REST}|";
        
        return ret;
    }

    
}