using System.Data.SqlClient;

namespace GodOfSped;

public class Connection
{
    public static SqlConnection NewInstanceSqlServer(String db)
    {
        String stringconn = $"Persist Security Info=False; Data Source={Environment.MachineName}\\SQLEXPRESS2019;Initial Catalog={db};User ID=sa; Password=553322@@##";
        try
        {
            SqlConnection cnn = new(stringconn);
            cnn.Open();
            return cnn;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }
}