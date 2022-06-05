namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC880
{
    public String REG { get; set; } = "C880";
    
    public String COOD_MOT_REST_COMPL { get; set; }
    
    public String QUANT_CONV { get; set; }
    
    public String UNID  { get; set; }
    
    public String VL_UNIT_CONV { get; set; }
    
    public String VL_UNIT_ICMS_NA_OPERACAO_CONV { get; set; }
    
    public String VL_UNIT_ICMS_OP_CONV { get; set; }

    public String VL_UNIT_BC_ICMS_ST_ESTOQUE_CONV { get; set; }
    
    public String VL_UNIT_ICMS_ST_ESTOQUE_CONV { get; set; }

    public String VL_UNIT_FCP_ICMS_ST_ESTOQUE_CONV { get; set; }

    public String VL_UNIT_ICMS_ST_CONV_REST { get; set; }

    public String VL_UNIT_FCP_ST_CONV_REST { get; set; }

    public String VL_UNIT_ICMS_ST_CONV_COMPL { get; set; }
    
    public String VL_UNIT_FCP_ST_CONV_COMPL { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{COOD_MOT_REST_COMPL}|" +
                     $"{QUANT_CONV}|{UNID}|{VL_UNIT_CONV}|" +
                     $"{VL_UNIT_ICMS_NA_OPERACAO_CONV}|{VL_UNIT_ICMS_OP_CONV}|" +
                     $"{VL_UNIT_BC_ICMS_ST_ESTOQUE_CONV}|{VL_UNIT_ICMS_ST_ESTOQUE_CONV}|{VL_UNIT_FCP_ICMS_ST_ESTOQUE_CONV}|" +
                     $"{VL_UNIT_ICMS_ST_CONV_REST}|{VL_UNIT_FCP_ST_CONV_REST}|" +
                     $"{VL_UNIT_ICMS_ST_CONV_COMPL}|{VL_UNIT_FCP_ST_CONV_COMPL}|";
        
        return ret;
    }
}