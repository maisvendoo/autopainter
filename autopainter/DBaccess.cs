//-------------------------------------------------------------------
//
//      Module for color's data base access
//      (c) maisvendoo, 2015-03-17
//
//-------------------------------------------------------------------
using System;
using System.Data.OleDb;

//-------------------------------------------------------------------
//
//-------------------------------------------------------------------
public class CDBaccess
{
    // Constructor
    public CDBaccess()
    {
        this.db_path = "E:\\";
        this.db_filename = "yatu.mdb";
        this.db_passwd = "yatu";
        this.db_provider = "Microsoft.Jet.OLEDB.4.0";

        connection = new OleDbConnection();
    }

    private const string MODEL_DATA = "ModelColor";
    
    private string db_path;
    private string db_passwd;
    private string db_filename;

    private string db_provider;

    private OleDbConnection connection;

    public int open(string db_path, string db_filename, string db_passwd)
    {
        int err_code = 0;
        connection.ConnectionString = "Provider=" +
                               db_provider + ";" +
                               "Data Source=" +
                               db_path + "\\" + db_filename + ";" +
                               "Jet OLEDB:Database Password=" +
                               db_passwd + ";";
        

        try
        {
            connection.Open();
        }
        catch (Exception ex)
        {
            err_code = -1;
        }
        finally
        {
            err_code = 0;
        }

        return err_code;
    }

    public void close()
    {
        connection.Close();
    }

    public void get_colors_data(string query, ref TColorsData[] colors_data)
    {
        for (int i = 0; i < 10; i++)
        {
            Array.Resize(ref colors_data, i+1);

            colors_data[i].ColorCode = "300";
            colors_data[i].Manufacturer = "BMW";
            colors_data[i].ColorName = "BLUE SHIT";
            colors_data[i].RefColor = "";
            colors_data[i].StockCode = "";
        }
    }
}