namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1960
{
    public String REG { get; set; } = "1960";

    public String IND_AP { get; set; }

    public String G1_01 { get; set; }

    public String G1_02 { get; set; }

    public String G1_03 { get; set; }

    public String G1_04 { get; set; }

    public String G1_05 { get; set; }

    public String G1_06 { get; set; }

    public String G1_07 { get; set; }

    public String G1_08 { get; set; }

    public String G1_09 { get; set; }

    public String G1_10 { get; set; }

    public String G1_11 { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{G1_02}|{G1_03}|{IND_AP}|{G1_01}|{G1_04}|{G1_05}|{G1_06}|{G1_07}|{G1_08}|{G1_09}|{G1_10}|{G1_11}|";
        
        return ret;
    }

    
}