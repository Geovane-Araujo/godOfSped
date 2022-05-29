namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoB020
{
    public String REG { get; set; } = "B020";
    
    public String IND_OPER { get; set; }
    
    public String IND_EMIT { get; set; }
    
    public String COD_PART { get; set; }
    
    public String COD_MOD { get; set; }
    
    public String COD_SIT { get; set; }
    
    public String SER { get; set; }
    
    public String NUM_DOC { get; set; }
    
    public String CHV_NFE { get; set; }
    
    public String DT_DOC { get; set; }
    
    public String COD_MUN_SERV { get; set; }
    
    public String VL_CONT { get; set; }
    
    public String VL_MAT_TERC { get; set; }
    
    public String VL_SUB { get; set; }

    public String VL_ISNT_ISS { get; set; }

    public String VL_DED_BC { get; set; }

    public String VL_BC_ISS { get; set; }

    public String VL_BC_ISS_RT { get; set; }

    public String VL_ISS_RT { get; set; }

    public String VL_ISS { get; set; }

    public String COD_INF_OBS { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{IND_OPER}|{IND_EMIT}|{COD_PART}|{COD_MOD}|{COD_SIT}|{SER}|{NUM_DOC}|{CHV_NFE}|{DT_DOC}|{COD_MUN_SERV}|{VL_CONT}|{VL_MAT_TERC}|{VL_SUB}|{VL_ISNT_ISS}|{VL_DED_BC}|{VL_BC_ISS}|{VL_BC_ISS_RT}|{VL_ISS_RT}|{VL_ISS}|{COD_INF_OBS}";
        
        return ret;
    }
}