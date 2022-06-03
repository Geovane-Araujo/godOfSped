﻿
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco0100
{
    public String REG { get; } = "0100";
    
    public String NOME { get; set; }
    
    public String CPF { get; set; }
    
    public String CRC { get; set; }
    
    public String CNPJ { get; set; }
    
    public String CEP { get; set; }
    
    public String END { get; set; }
    
    public String NUM { get; set; }
    
    public String COMPL { get; set; }
    
    public String BAIRRO { get; set; }
    
    public String FONE { get; set; }
    
    public String FAX { get; set; }
    
    public String EMAIL { get; set; }
    
    public String COD_MUN { get; set; }
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{Persistense.replaceCharacters(NOME)}|{CPF}|{CRC}|{CNPJ}|{CEP}|{END}|{NUM}|{COMPL}|{BAIRRO}|{FONE}|{FAX}|{EMAIL}|{COD_MUN}|";
        
        return ret;
    }
}