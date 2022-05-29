﻿namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC330
{
    public String REG { get; set; } = "C330";

    public String COD_MOT_REST_COMPL { get; set; }

    public String QUANT_CONV { get; set; }

    public String UNID { get; set; }

    public String VL_UNIT_CONV { get; set; }

    public String VL_UNIT_ICMS_NA_OPERACAO_CONV { get; set; }

    public String VL_UNIT_ICMS_OP_CONV { get; set; }

    public String VL_UNIT_ICMS_OP_ESTOQUE_CONV { get; set; }

    public String VL_UNIT_ICMS_ST_ESTOQUE_CON { get; set; }

    public String VL_UNIT_FCP_ICMS_ST_ESTOQUE_CONV { get; set; }
    
    public String VL_UNIT_ICMS_ST_CONV_REST { get; set; }

    public String VL_UNIT_FCP_ST_CONV_REST { get; set; }

    public String VL_UNIT_ICMS_ST_CONV_COMPL { get; set; }
    
    public String VL_UNIT_FCP_ST_CONVs_COMPL { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOT_REST_COMPL}|{QUANT_CONV}|{UNID}|{VL_UNIT_CONV}|{VL_UNIT_ICMS_NA_OPERACAO_CONV}|{VL_UNIT_ICMS_OP_CONV}|{VL_UNIT_ICMS_OP_ESTOQUE_CONV}|{VL_UNIT_ICMS_ST_ESTOQUE_CON}|{VL_UNIT_FCP_ICMS_ST_ESTOQUE_CONV}|{VL_UNIT_ICMS_ST_CONV_REST}|{VL_UNIT_FCP_ST_CONVs_COMPL}|{VL_UNIT_ICMS_ST_CONV_COMPL}|{VL_UNIT_FCP_ST_CONV_REST}|";
        
        return ret;
    }
}