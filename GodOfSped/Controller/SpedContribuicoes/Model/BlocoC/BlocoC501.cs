﻿
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoC501
{
    public String REG { get; } = "C501";
    
    public String CST_PIS { get; set; } = "";
    
    public String VL_ITEM { get; set; } = "";
    
    
    public String NAT_BC_CRED { get; set; } = "";
    
    public String VL_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS { get; set; } = "";
    
    public String VL_PIS { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{CST_PIS}|{VL_ITEM}|{NAT_BC_CRED}|{VL_BC_PIS}|{ALIQ_PIS}|{VL_PIS}|" +
                     $"{COD_CTA}|";
        return ret;
    }
}