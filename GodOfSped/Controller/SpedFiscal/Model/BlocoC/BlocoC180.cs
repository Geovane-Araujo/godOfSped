namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC180
{
    public String REG { get; set; } = "C180";
    
    public String COD_RESP_RET { get; set; }
    
    public String QUANT_CONV { get; set; }
    
    public String UNID { get; set; }
    
    public String VL_UNIT_CONV { get; set; }
    
    public String VL_UNIT_ICMS_OP_CONV { get; set; }
    
    public String VL_UNIT_BC_ICMS_ST_CONV { get; set; }
    
    public String VL_UNIT_ICMS_ST_CONV { get; set; }
    
    public String VL_UNIT_FCP_ST_CONV { get; set; }
    
    public String COD_DA { get; set; }
    
    public String NUM_DA { get; set; }
    
    
    

    public String ToString()
    {
        String ret = $"|{REG}|{COD_RESP_RET}|{QUANT_CONV}|{UNID}|{VL_UNIT_CONV}|{VL_UNIT_BC_ICMS_ST_CONV}|{VL_UNIT_ICMS_ST_CONV}|{VL_UNIT_FCP_ST_CONV}|{COD_DA}|{NUM_DA}|";
        
        return ret;
    }
}