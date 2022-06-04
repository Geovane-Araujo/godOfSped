namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC181
{
    public String REG { get; set; } = "C181";
    
    public String COD_MOT_REST_COMPL { get; set; }
    
    public String QUANT_CONV { get; set; }
    
    public String UNID { get; set; }
    
    public String COD_MOD_SAIDA { get; set; }
    
    public String SERIE_SAIDA { get; set; }
    
    public String ECF_FAB_SAIDA { get; set; }
    
    public String NUM_DOC_SAIDA { get; set; }
    
    public String CHV_DFE_SAIDA { get; set; }
    
    public String DT_DOC_SAIDA { get; set; }
    
    public String NUM_ITEM_SAIDA { get; set; }
    
    public String VL_UNIT_CONV_SAIDA { get; set; }

    public String VL_UNIT_ICMS_OP_ESTOQUE_CONV_SAIDA { get; set; }

    public String VL_UNIT_ICMS_ST_ESTOQUE_CONV_SAIDA { get; set; }

    public String VL_UNIT_FCP_ICMS_ST_ESTOQUE_CONV_SAIDA { get; set; }

    public String VL_UNIT_ICMS_NA_OPERACAO_CONV_SAIDA { get; set; }

    public String VL_UNIT_ICMS_OP_CONV_SAIDA { get; set; }

    public String VL_UNIT_ICMS_ST_CONV_REST { get; set; }

    public String VL_UNIT_FCP_ST_CONV_REST { get; set; }

    public String VL_UNIT_ICMS_ST_CONV_COMPL { get; set; }

    public String VL_UNIT_FCP_ST_CONV_COMPL { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOT_REST_COMPL}|{QUANT_CONV}|{UNID}|{COD_MOD_SAIDA}|{SERIE_SAIDA}|{ECF_FAB_SAIDA}|{NUM_DOC_SAIDA}|{CHV_DFE_SAIDA}|{DT_DOC_SAIDA}|{NUM_ITEM_SAIDA}|{VL_UNIT_CONV_SAIDA}|{VL_UNIT_ICMS_OP_ESTOQUE_CONV_SAIDA}|{VL_UNIT_ICMS_ST_ESTOQUE_CONV_SAIDA}|{VL_UNIT_FCP_ICMS_ST_ESTOQUE_CONV_SAIDA}|{VL_UNIT_ICMS_NA_OPERACAO_CONV_SAIDA}|{VL_UNIT_ICMS_OP_CONV_SAIDA}|{VL_UNIT_ICMS_ST_CONV_REST}|{VL_UNIT_FCP_ST_CONV_REST}|{VL_UNIT_ICMS_ST_CONV_COMPL}|{VL_UNIT_FCP_ST_CONV_COMPL}|";
        
        return ret;
    }
}