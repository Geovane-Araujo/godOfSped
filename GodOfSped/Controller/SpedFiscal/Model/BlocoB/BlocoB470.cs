namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoB470
{
    public String REG { get; set; } = "B470";
    
    public String VL_CONT { get; set; }
    
    public String VL_MAT_TERC { get; set; }
    
    public String VL_MAT_PROP { get; set; }
    
    public String VL_SUB { get; set; }
    
    public String VL_ISNT { get; set; }
    
    public String VL_DED_BC { get; set; }
    
    public String VL_BC_ISS { get; set; }
    
    public String VL_BC_ISS_RT { get; set; }
    
    public String VL_ISS { get; set; }
    
    public String VL_ISS_RT { get; set; }
    
    public String VL_DED { get; set; }
    
    public String VL_ISS_REC { get; set; }
    
    public String VL_ISS_ST { get; set; }

    public String VL_ISS_REC_UNI { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{VL_CONT}|{VL_MAT_TERC}|{VL_MAT_PROP}|{VL_SUB}|{VL_ISNT}|{VL_DED_BC}|{VL_BC_ISS}|{VL_BC_ISS_RT}|{VL_ISS}|{VL_ISS_RT}|{VL_DED}|{VL_ISS_REC}|{VL_ISS_ST}|{VL_ISS_REC_UNI}|";
        
        return ret;
    }
}