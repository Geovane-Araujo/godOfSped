namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD161
{
    public String REG { get; set; } = "D161";

    public String IND_CARGA { get; set; }

    public String CNPJ_CPF_COL { get; set; }

    public String IE_COL { get; set; }
    
    public String COD_MUN_COL { get; set; }

    public String CNPJ_CPF_ENTG { get; set; }

    public String IE_ENTG { get; set; }

    public String COD_MUN_ENTG { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_CARGA}|{CNPJ_CPF_COL}||{IE_COL}|{COD_MUN_COL}|{CNPJ_CPF_ENTG}||{IE_ENTG}|{COD_MUN_ENTG}|";
     
        return ret;
    }
}