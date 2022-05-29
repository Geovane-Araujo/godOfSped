namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1980
{
    public String REG { get; set; } = "1980";

    public String IND_AP { get; set; }

    public String G4_01 { get; set; }

    public String G4_02 { get; set; }

    public String G4_03 { get; set; }

    public String G4_04 { get; set; }

    public String G4_05 { get; set; }

    public String G4_06 { get; set; }

    public String G4_07 { get; set; }

    public String G4_08 { get; set; }

    public String G4_09 { get; set; }

    public String G4_10 { get; set; }

    public String G4_11 { get; set; }

    public String G4_12 { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{G4_02}|{G4_03}|{IND_AP}|{G4_01}|{G4_04}|{G4_05}|{G4_06}|{G4_07}|{G4_08}|{G4_09}|{G4_10}|{G4_11}|{G4_12}|";
        
        return ret;
    }

    
}