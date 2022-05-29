using System.Data.SqlTypes;

namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco0000
{
    public String REG { get; set; } = "0000";
    
    public String COD_VER { get; set; } = "006";
    
    public String TIPO_ESCRIT { get; set; } = "0";
    
    public String IND_SIT_ESP { get; set; } = "";
    
    public String NUM_REC_ANTERIOR { get; set; } = "";// Número do Recibo da Escrituração Anterior, a ser retificada. Utilizado quando TIPO_ESCRIT for igual a 1
    
    public String DT_INI { get; set; } = "";
    
    public String DT_FIN { get; set; } = "";
    
    public String NOME { get; set; } = "";
    
    public String CNPJ { get; set; } = "";
    
    public String UF { get; set; } = "";
    
    public String COD_MUN { get; set; } = "";
    
    public String SUFRAMA { get; set; } = "";
    
    public String IND_NAT_PJ { get; set; } = "";
    
    public String IND_ATIV { get; set; } = "";
    

    public String ToString()
    {
        String ret = $"|{REG}|{COD_VER}|{TIPO_ESCRIT}|{IND_SIT_ESP}|{NUM_REC_ANTERIOR}|{DT_INI}|{DT_FIN}|{NOME}|{CNPJ}|{UF}|{COD_MUN}|{SUFRAMA}|{IND_NAT_PJ}|{IND_ATIV}|";
        
        return ret;
    }
}