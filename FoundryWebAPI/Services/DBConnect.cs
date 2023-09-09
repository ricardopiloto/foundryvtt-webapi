using System.Text;
using LevelDB;

namespace FoundryWebAPI.Services.DBConnect
{
    public class DBConnect
    {
        public static string SetConnection(string world, string dbtype)
        {
            string result = "";
            string dbPath = @"/home/ricardosobral/Data_Jiban/FoundryVTT-Code/Mock_server/forgotten-realms/data/actors/";
            // Open a connection to a new DB and create if not found
            var options = new Options { CreateIfMissing = true };

            // Open or create the LevelDB database
            using (var db = new DB(options, dbPath))
            {
                // Writing data to the database
                var key1 = "items";
                // Reading data from the database
                result = db.Get(key1);
            }
            if(string.IsNullOrEmpty(result)){
                return ("vazio");
            }else{
                return (result);
            }
        }
    }
}