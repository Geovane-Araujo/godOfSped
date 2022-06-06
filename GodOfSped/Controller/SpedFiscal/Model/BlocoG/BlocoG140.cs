﻿namespace GodOfSped.Controller.SpedFiscal.Model.BlocoH;

public class BlocoG140
{
    public String REG { get; set; } = "G140";

    public String NUM_ITEM { get; set; }

    public String COD_ITEM { get; set; }
    
    public String QTDE { get; set; }

    public String UNID { get; set; }

    public String VL_ICMS_OP_APLICADO { get; set; }

    public String VL_ICMS_ST_APLICADO { get; set; }

    public String VL_ICMS_FRT_APLICADO { get; set; }

    public String VL_ICMS_DIF_APLICADO { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{NUM_ITEM}|{COD_ITEM}|{QTDE}|" +
                     $"{UNID}|{VL_ICMS_OP_APLICADO}|{VL_ICMS_ST_APLICADO}|" +
                     $"{VL_ICMS_FRT_APLICADO}|{VL_ICMS_DIF_APLICADO}|";
        
        return ret;
    }
    
    
    
}