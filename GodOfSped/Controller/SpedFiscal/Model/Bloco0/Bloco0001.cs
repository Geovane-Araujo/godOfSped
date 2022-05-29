namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class Bloco0000
{
    public String REG { get; set; } = "0000";
    
    public String COD_VER { get; set; }
    
    public String TIPO_ESCRIT { get; set; }
    
    public String DT_INI { get; set; }
    
    public String DT_FIN { get; set; }
    
    public String NOME { get; set; }
    
    public String CNPJ { get; set; }
    
    public String CPF { get; set; }
    
    public String UF { get; set; }
    
    public String IE { get; set; }
    
    public String COD_MUN { get; set; }
    
    public String IM { get; set; }
    
    public String SUFRAMA { get; set; }
    
    public String IND_PERFIL { get; set; }

    public String IND_ATV { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{COD_VER}|{TIPO_ESCRIT}|{DT_INI}|{DT_FIN}|{NOME}|{CNPJ}|{CPF}|{UF}|{IE}|{COD_MUN}|{IM}|{SUFRAMA}|{IND_PERFIL}|{IND_ATV}|";
        
        return ret;
    }
}