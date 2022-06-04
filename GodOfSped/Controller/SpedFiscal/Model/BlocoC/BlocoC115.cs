namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC115
{
    public String REG { get; set; } = "C115";

    public String IND_CARGA { get; set; }

    public String CNPJ_COL { get; set; }

    public String IE_COL { get; set; }
    
    public String CPF_COL { get; set; }

    public String COD_MUN_COL { get; set; }

    public String CNPJ_ENTG { get; set; }

    public String IE_ENTG { get; set; }

    public String CPF_ENTG { get; set; }

    public String COD_MUN_ENTG { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_CARGA}|{CNPJ_COL}|{IE_COL}|{CPF_COL}|{COD_MUN_COL}|{CNPJ_ENTG}|{IE_ENTG}|{CPF_ENTG}|{COD_MUN_ENTG}|";
     
        return ret;
    }
}