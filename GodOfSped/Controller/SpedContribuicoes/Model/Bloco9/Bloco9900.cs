﻿
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco9900
{
    public String REG { get; } = "9900";
    
    public String REG_BLC { get; set; }
    
    public String QTD_REG_BLC { get; set; }
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{REG_BLC}|{QTD_REG_BLC}|";
        
        return ret;
    }
}