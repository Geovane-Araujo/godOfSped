
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoD600
{
    public String REG { get; } = "D600";
    
    public String COD_MOD { get; set; } = "";
    
    public String COD_MUN { get; set; } = "";
    
    public String SER { get; set; } = "";
    
    public String SUB { get; set; } = "";
    
    public String IND_REC { get; set; } = "";
    
    public String QTD_CONS { get; set; } = "";
    
    public String DT_DOC_INI { get; set; } = "";
    
    public String DT_DOC_FIN { get; set; } = "";
    
    public String VL_DOC { get; set; } = "";
    
    public String VL_DESC { get; set; } = "";
    
    public String VL_SERV { get; set; } = "";
    
    public String VL_SERV_NT { get; set; } = "";
    
    public String VL_TERC { get; set; } = "";
    
    public String VL_DA { get; set; } = "";
    
    public String VL_BC_ICMS { get; set; } = "";
    
    public String VL_ICMS { get; set; } = "";
    
    public String VL_PIS { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD}|{COD_MUN}|{SER}|{SUB}|{IND_REC}|{QTD_CONS}|" +
                     $"{DT_DOC_INI}|{DT_DOC_FIN}|{VL_DOC}|{VL_DESC}|" +
                     $"{VL_SERV}|{VL_SERV_NT}|{VL_TERC}|{VL_DA}|{VL_BC_ICMS}|{VL_ICMS}|{VL_PIS}|{VL_COFINS}|";
        return ret;
    }
}