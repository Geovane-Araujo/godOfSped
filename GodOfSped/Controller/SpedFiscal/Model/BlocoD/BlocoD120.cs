namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD120
{
    public String REG { get; set; } = "D120";

    public String COD_MUN_ORIG { get; set; }
    
    public String COD_MUN_DEST { get; set; }
    
    public String VEIC_ID  { get; set; }
    
    public String UF_ID { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_MUN_ORIG}|{COD_MUN_DEST}|{VEIC_ID}|{UF_ID}|";
        
        return ret;
    }
}