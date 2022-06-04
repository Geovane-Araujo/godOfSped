namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC176
{
    public String REG { get; set; } = "C176";
    
    public String COD_MOD_ULT_E { get; set; }
    
    public String NUM_DOC_ULT_E { get; set; }
    
    public String SER_ULT_E { get; set; }
    
    public String DT_ULT_E { get; set; }
    
    public String COD_PART_ULT_E { get; set; }
    
    public String QUANT_ULT_E { get; set; }
    
    public String VL_UNIT_ULT_E { get; set; }
    
    public String VL_UNIT_BC_ST { get; set; }
    
    public String CHAVE_NFE_ULT_E { get; set; }
    
    public String NUM_ITEM_ULT_E { get; set; }
    
    public String VL_UNIT_BC_ICMS_ULT_E { get; set; }

    public String VL_UNIT_LIMITE_BC_ICMS_ULT_E { get; set; }

    public String VL_UNIT_ICMS_ULT_E { get; set; }

    public String ALIQ_ST_ULT_E { get; set; }

    public String VL_UNIT_RES { get; set; }

    public String COD_RESP_RET { get; set; }

    public String COD_MOT_RES { get; set; }

    public String CHAVE_NFE_RET { get; set; }

    public String COD_PART_NFE_RET { get; set; }

    public String SER_NFE_RET { get; set; }

    public String NUM_NFE_RET { get; set; }

    public String ITEM_NFE_RET { get; set; }

    public String COD_DA { get; set; }

    public String NUM_DA { get; set; }
    
    public String VL_UNIT_RES_FCP_ST { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD_ULT_E}|{NUM_DOC_ULT_E}|{SER_ULT_E}|{DT_ULT_E}|{COD_PART_ULT_E}|{QUANT_ULT_E}|{VL_UNIT_ULT_E}|{VL_UNIT_BC_ST}|{CHAVE_NFE_ULT_E}|{	NUM_ITEM_ULT_E}|{VL_UNIT_BC_ICMS_ULT_E}|{VL_UNIT_LIMITE_BC_ICMS_ULT_E}|{VL_UNIT_ICMS_ULT_E}|{ALIQ_ST_ULT_E}|{VL_UNIT_RES}|{COD_RESP_RET}|{COD_MOT_RES}|{CHAVE_NFE_RET}|{COD_PART_NFE_RET}|{SER_NFE_RET}|{NUM_NFE_RET}|{ITEM_NFE_RET}|{COD_DA}|{NUM_DA}|{VL_UNIT_RES_FCP_ST}|";
        
        return ret;
    }
}