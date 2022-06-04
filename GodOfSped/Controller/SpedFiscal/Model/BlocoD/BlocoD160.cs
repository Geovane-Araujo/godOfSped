namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD160
{
    public String REG { get; set; } = "D160";

    public String DESPACHO { get; set; }

    public String CNPJ_CPF_REM { get; set; }

    public String IE_REM { get; set; }
    
    public String COD_MUN_ORI { get; set; }

    public String CNPJ_CPF_DEST { get; set; }

    public String IE_DEST { get; set; }

    public String COD_MUN_DEST { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{DESPACHO}|{CNPJ_CPF_REM}|{IE_REM}|{COD_MUN_ORI}|{CNPJ_CPF_DEST}|{IE_DEST}|{COD_MUN_DEST}|";
     
        return ret;
    }
}