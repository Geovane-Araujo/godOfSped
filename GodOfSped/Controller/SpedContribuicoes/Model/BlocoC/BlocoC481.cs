﻿
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoC481
{
    public String REG { get; } = "C481";
    
    public String CST_PIS { get; set; } = "";
    
    public String VL_ITEM { get; set; } = "";
    
    public String VL_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS { get; set; } = "";
    
    public String QUANT_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS_QUANT { get; set; } = "";
    
    public String VL_PIS { get; set; } = "";
    
    public String COD_ITEM { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{CST_PIS}|{VL_ITEM}|{VL_BC_PIS}|{ALIQ_PIS}|{QUANT_BC_PIS}|{ALIQ_PIS_QUANT}|" +
                     $"{VL_PIS}|{COD_ITEM}|{COD_CTA}|";
        return ret;
    }
}