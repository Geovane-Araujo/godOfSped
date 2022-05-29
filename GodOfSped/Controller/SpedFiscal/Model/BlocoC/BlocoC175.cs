namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC175
{
    public String REG { get; set; } = "C175";
    
    public String IND_VEIC_OPER { get; set; }

    public String CNPJ { get; set; }
    
    public String UF { get; set; }

    public String CHASSI_VEIC { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_VEIC_OPER}|{CNPJ}|{UF}|{CHASSI_VEIC}|";
        
        return ret;
    }
}