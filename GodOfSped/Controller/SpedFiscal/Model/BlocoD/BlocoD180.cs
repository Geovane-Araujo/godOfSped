namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD180
{
    public String REG { get; set; } = "D180";
    
    public String NUM_SEQ { get; set; }
    
    public String IND_EMIT { get; set; }
    
    public String CNPJ_CPF_EMIT  { get; set; }
    
    public String UF_EMIT { get; set; }
    
    public String IE_EMIT { get; set; }
    
    public String COD_MUN_ORIG { get; set; }

    public String CNPJ_CPF_TOM { get; set; }
    
    public String UF_TOM { get; set; }

    public String IE_TOM { get; set; }

    public String COD_MUN_DEST { get; set; }

    public String COD_MOD { get; set; }  
    
    public String SER { get; set; }

    public String SUB { get; set; }

    public String NUM_DOC { get; set; }

    public String DT_DOC { get; set; }

    public String VL_DOC { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{NUM_SEQ}|{IND_EMIT}|{CNPJ_CPF_EMIT}|{IE_EMIT}|{UF_EMIT}|{COD_MUN_ORIG}|{CNPJ_CPF_TOM}|{UF_TOM}|{IE_TOM}|{COD_MUN_DEST}|{COD_MOD}|{COD_MOD}|{SER}|{SUB}|{NUM_DOC}|{DT_DOC}|{VL_DOC}|";
        
        return ret;
    }
}