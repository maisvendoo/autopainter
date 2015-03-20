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
        this.db_provider = "Microsoft.Jet.OLEDB.4.0";

        connection = new OleDbConnection();
    }

    // Tables names
    private const string MODEL_DATA = "ModelColor";
    private const string CAR_FACTORY = "CarFactory";
    private const string COLOR_SCHEME = "ColorScheme";   
    
    // Fields names MODEL_DATA
    private const string COLOR_ID = "colorId";
    private const string COLOR_NAME = "colorName";
    private const string MOD_ID = "id";
    private const string CAR_FACTORY_ID = "carFatoryId";

    // Fields names CAR_FACTORY
    private const string FACTORY_NAME = "name";
    private const string CAR_ID = "id";

    // Fields names COLOR_SCHEME
    private const string MODEL_COLOR_ID = "modelColorId";
    private const string YEAR = "year";
    private const string STOCK_CODE = "stockCode";
    private const string FORMULA_CODE = "formulaCode";
    private const string VARIANT = "variant";
    private const string BRAND = "brand";
    private const string COAT = "coat";
    private const string MODEL = "model";
    private const string SOURCE = "source";
    private const string DATE = "date";
    private const string COLOR_INDEX = "colorindex";

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

    //
    public void get_colors_data(TQueryData query_data, ref TColorsData[] colors_data)
    {
        string query = "SELECT ";
        string where = " WHERE";

        // Create begin of query string
        query += MODEL_DATA + "." + COLOR_ID + ", " +
                 CAR_FACTORY + "." + FACTORY_NAME + ", " +
                 MODEL_DATA + "." + COLOR_NAME + ", " +
                 MODEL_DATA + "." + MOD_ID;

        query += " FROM " + MODEL_DATA + ", " + CAR_FACTORY;

        // Create query conditions by text field's values

        // Check color code field
        if (query_data.ColorCode != "")
        {
            where += String.Format(" {1}.{2} = \'{0}\'", query_data.ColorCode, MODEL_DATA, COLOR_ID);
        }
        else
        {
            where += String.Format(" {0}.{1} LIKE \'%\'", MODEL_DATA, COLOR_ID);
        }

        // Check manufacturer field
        if (query_data.Manufacturer != "")
        {
            where += String.Format(" AND {1}.{2} = \'{0}\'", query_data.Manufacturer, CAR_FACTORY, FACTORY_NAME);
        }
        else
        {
            where += String.Format(" AND {0}.{1} LIKE \'%\'", CAR_FACTORY, FACTORY_NAME);
        }

        // Check color name field
        if (query_data.ColorName != "")
        {
            where += String.Format(" AND {1}.{2} = \'{0}\'", query_data.ColorName, MODEL_DATA, COLOR_NAME);
        }
        else
        {
            where += String.Format(" AND {0}.{1} LIKE \'%\'", MODEL_DATA, COLOR_NAME);
        }

        where += String.Format(" AND {0}.{2} = {1}.{3}", CAR_FACTORY, MODEL_DATA, CAR_ID, CAR_FACTORY_ID);

        where += String.Format(" ORDER BY {0}.{1}", MODEL_DATA, COLOR_ID);

        query += where;

        OleDbCommand command = new OleDbCommand();

        command.Connection = connection;
        command.CommandText = query;

        OleDbDataReader dr = command.ExecuteReader();

        int data_count = 0;

        if (dr.HasRows)
        {
            while (dr.Read())
            {
                data_count++;

                Array.Resize(ref colors_data, data_count);

                colors_data[data_count - 1].ColorCode = dr[COLOR_ID].ToString();
                colors_data[data_count - 1].Manufacturer = dr[FACTORY_NAME].ToString();
                colors_data[data_count - 1].ColorName = dr[COLOR_NAME].ToString();
                colors_data[data_count - 1].modelColorId = dr[MOD_ID].ToString();
            }
        }
    }

    //
    public void get_formulas_data(TColorsData colors_data, ref TFormulasData[] formulas_data)
    {
        string query = "SELECT ";
        string where = " WHERE";
        
        query += MODEL_COLOR_ID + ", " +
                 YEAR + ", " +
                 STOCK_CODE + ", " +
                 FORMULA_CODE + ", " +
                 VARIANT + ", " +
                 BRAND + ", " +
                 COAT + ", " +
                 MODEL + ", " +
                 SOURCE + ", " +
                 DATE + ", " +
                 COLOR_INDEX;

        query += " FROM " + COLOR_SCHEME;

        where += String.Format(" {1} = \'{0}\' ", colors_data.modelColorId, MODEL_COLOR_ID);

        query += where;

        OleDbCommand command = new OleDbCommand();

        command.Connection = connection;
        command.CommandText = query;

        OleDbDataReader dr = command.ExecuteReader();

        int formulas_count = 0;

        if (dr.HasRows)
        {
            while (dr.Read())
            {
                formulas_count++;

                Array.Resize(ref formulas_data, formulas_count);

                formulas_data[formulas_count - 1].ColorCode = colors_data.ColorCode;
                formulas_data[formulas_count - 1].Brand = dr[BRAND].ToString();
                formulas_data[formulas_count - 1].Coat = dr[COAT].ToString();
                formulas_data[formulas_count - 1].Variant = dr[VARIANT].ToString();
                formulas_data[formulas_count - 1].Model = dr[MODEL].ToString();
                formulas_data[formulas_count - 1].Year = dr[YEAR].ToString();
                formulas_data[formulas_count - 1].Source = dr[SOURCE].ToString();
                formulas_data[formulas_count - 1].CreatedDate = dr[DATE].ToString();
                formulas_data[formulas_count - 1].FormulaCode = dr[FORMULA_CODE].ToString();
                formulas_data[formulas_count - 1].StockCode = dr[STOCK_CODE].ToString();
                formulas_data[formulas_count - 1].ColorIndex = dr[COLOR_INDEX].ToString();
            }
        }
    }
}