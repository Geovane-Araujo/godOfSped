
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoA100
{
    public String REG { get; } = "A100";
    
    public String IND_OPER { get; set; }
    
    public String IND_EMIT { get; set; }
    
    public String COD_PART { get; set; }
    
    public String COD_SIT { get; set; }
    
    public String SER { get; set; }
    
    public String SUB { get; set; }
    
    public String NUM_DOC { get; set; }
    
    public String CHV_NFSE { get; set; }
    
    public String DT_DOC { get; set; }
    
    public String DT_EXE_SERV { get; set; }
    
    public String VL_DOC { get; set; }
    
    public String IND_PGTO { get; set; }
    
    public String VL_DESC { get; set; }
    
    public String VL_BC_PIS { get; set; }
    
    public String VL_PIS { get; set; }
    
    public String VL_BC_COFINS { get; set; }
    
    public String VL_COFINS { get; set; }
    
    public String VL_PIS_RET { get; set; }
    
    public String VL_COFINS_RET { get; set; }
    
    public String VL_ISS { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{IND_OPER}|{IND_EMIT}|{COD_PART}|{COD_SIT}|{SER}|{SUB}|{NUM_DOC}|{CHV_NFSE}|" +
                     $"{DT_DOC}|{DT_EXE_SERV}|{VL_DOC}|{IND_PGTO}|{VL_DESC}|{VL_BC_PIS}|{VL_PIS}|{VL_BC_COFINS}|{VL_COFINS}|{VL_PIS_RET}|{VL_COFINS_RET}|{VL_ISS}|";
        
        return ret;
    }
}