namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC186
{
    public String REG { get; set; } = "C186";
    
    public String NUM_ITEM { get; set; }
    
    public String COD_ITEM { get; set; }
    
    public String CST_ICMS { get; set; }
    
    public String CFOP { get; set; }
    
    public String COD_MOT_REST_COMPL { get; set; }
    
    public String QUANT_CONV { get; set; }
    
    public String UNID { get; set; }
    
    public String COD_MOD_ENTRADA { get; set; }
    
    public String SERIE_ENTRADA { get; set; }
    
    public String NUM_DOC_ENTRADA { get; set; }
    
    public String CHV_DFE_ENTRADA { get; set; }

    public String DT_DOC_ENTRADA { get; set; }

    public String NUM_ITEM_ENTRADA { get; set; }

    public String VL_UNIT_CONV_ENTRADA { get; set; }

    public String VL_UNIT_ICMS_OP_CONV_ENTRADA { get; set; }

    public String VL_UNIT_BC_ICMS_ST_CONV_ENTRADA { get; set; }

    public String VL_UNIT_ICMS_ST_CONV_ENTRADA { get; set; }

    public String VL_UNIT_FCP_ST_CONV_ENTRADA { get; set; }  

    public String ToString()
    {
        String ret = $"|{REG}|{NUM_ITEM}|{COD_ITEM}|{CST_ICMS}|{CFOP}|{COD_MOT_REST_COMPL}|{QUANT_CONV}|{UNID}|{COD_MOD_ENTRADA}|{SERIE_ENTRADA}|{NUM_DOC_ENTRADA}|{CHV_DFE_ENTRADA}|{DT_DOC_ENTRADA}|{NUM_ITEM_ENTRADA}|{VL_UNIT_CONV_ENTRADA}|{VL_UNIT_ICMS_OP_CONV_ENTRADA}|{VL_UNIT_BC_ICMS_ST_CONV_ENTRADA}|{VL_UNIT_ICMS_ST_CONV_ENTRADA}|{VL_UNIT_FCP_ST_CONV_ENTRADA}|";
        
        return ret;
    }
}