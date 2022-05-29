namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD150
{
    public String REG { get; set; } = "D150";

    public String COD_MUN_ORIG { get; set; }
    
    public String COD_MUN_DEST { get; set; }
    
    public String VEIC_ID  { get; set; }
    
    public String VIAGEM { get; set; }

    public String IND_TFA { get; set; }

    public String COD_MUVL_PESO_TXN_ORIG { get; set; }
    
    public String VL_TX_TERR { get; set; }
    
    public String VL_TX_RED  { get; set; }
    
    public String VL_OUT { get; set; }

    public String VL_TX_ADV { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_MUN_ORIG}|{COD_MUN_DEST}|{VL_SERV}|{VIAGEM}||{IND_TFA}|{COD_MUVL_PESO_TXN_ORIG}|{VL_TX_TERR}|{VL_TX_RED}|{VL_OUT}|{VL_TX_ADV}|";
        
        return ret;
    }
}