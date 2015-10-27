using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace TableTennisRanking
{
    public class FilesAccess
    {
        private static FilesAccess _db;
        public static FilesAccess db
        {
            get
            {
                if (_db == null)
                {
                    _db = new FilesAccess();
                }
                return _db;
            }
        }

        public DataSet1.calculationsDataTable calculations = new DataSet1.calculationsDataTable();
        public DataSet1.championshipsDataTable championships = new DataSet1.championshipsDataTable();
        public DataSet1.clubsDataTable clubs = new DataSet1.clubsDataTable();
        public DataSet1.gamesDataTable games = new DataSet1.gamesDataTable();
        public DataSet1.playerchampsDataTable playerChamps = new DataSet1.playerchampsDataTable();
        public DataSet1.playerclubsDataTable playerClubs = new DataSet1.playerclubsDataTable();
        public DataSet1.playerDataTable player = new DataSet1.playerDataTable();
        public DataSet1.pointsbreakdownDataTable pointsBreakDown = new DataSet1.pointsbreakdownDataTable();
        public DataSet1.ratingchartDataTable ratingChart = new DataSet1.ratingchartDataTable();

        public void UpdatePlayer()
        {
            try
            {
            //    for (int i = 0; i < player.Count; i++)
            //    {
            //        if (player[i].RowState != DataRowState.Unchanged)
            //        {
                        new DataSet1TableAdapters.playerTableAdapter().Update(player);
                        player = new DataSet1TableAdapters.playerTableAdapter().GetData();
                //    }
                //    else
                //    {
                //        Console.WriteLine("test");
                //    }
                //}
            }
            catch(Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void UpdateClub()
        {
            new DataSet1TableAdapters.clubsTableAdapter().Update(clubs);
            clubs = new DataSet1TableAdapters.clubsTableAdapter().GetData();
        }

        public void UpdateChamp()
        {
            new DataSet1TableAdapters.championshipsTableAdapter().Update(championships);
            championships = new DataSet1TableAdapters.championshipsTableAdapter().GetData();
        }

        public void UpdateGames()
        {
            new DataSet1TableAdapters.gamesTableAdapter().Update(games);
            games = new DataSet1TableAdapters.gamesTableAdapter().GetData();
        }
    }

    public class MySqlDatabase
    {
        ///Localhost
        //string server = "localhost";
        //string databaseName = "tabletennisranking";
        //string username = "root";
        //string password = "";

        string server = "d1f2b143-b798-4c94-9bc7-a53e0150a1b8.sqlserver.sequelizer.com";
        string databaseName = "tabletennisranking";
        string username = "lciozrwerypsifda";
        string password = "5DbmjHctCnZQGEQshu7V8RJnPE45oMbjMsrfknwYdbdQWkKjqrJ8nubm3VDLNgeY";

        MySqlConnection conn = null;
        
        private static MySqlDatabase instance;
        public static MySqlDatabase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MySqlDatabase();
                    instance.PushData();
                    instance.Initalization();
                }
                return instance;
            }
        }

        private bool PushData()
        {
            string cs = @"server="+server+";userid=" + username + ";password=" + password + ";database=" + databaseName + "";
            conn = new MySqlConnection("Server=d1f2b143-b798-4c94-9bc7-a53e0150a1b8.sqlserver.sequelizer.com;Database=tabletennisranking;User ID=lciozrwerypsifda;Password=5DbmjHctCnZQGEQshu7V8RJnPE45oMbjMsrfknwYdbdQWkKjqrJ8nubm3VDLNgeY;");
            conn.Open();
            Console.WriteLine("MySQL version : {0}", conn.ServerVersion);
            return true;
        }

        private void Initalization()
        {
            string cs = @"server=localhost;userid="+username+";password="+password+";database="+databaseName+"";
            
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                Console.WriteLine("MySQL version : {0}", conn.ServerVersion);

                string query = "SELECT * FROM calculations";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(query, conn);
                returnVal.Fill(FilesAccess.db.calculations);

                query = "SELECT * FROM championships";
                cmd = new MySqlCommand(query, conn);
                returnVal = new MySqlDataAdapter(query, conn);
                returnVal.Fill(FilesAccess.db.championships);

                query = "SELECT * FROM clubs";
                cmd = new MySqlCommand(query, conn);
                returnVal = new MySqlDataAdapter(query, conn);
                returnVal.Fill(FilesAccess.db.clubs);

                query = "SELECT * FROM player";
                cmd = new MySqlCommand(query, conn);
                returnVal = new MySqlDataAdapter(query, conn);
                returnVal.Fill(FilesAccess.db.player);

                query = "SELECT * FROM playerclubs";
                cmd = new MySqlCommand(query, conn);
                returnVal = new MySqlDataAdapter(query, conn);
                returnVal.Fill(FilesAccess.db.playerClubs);

                query = "SELECT * FROM playerchamps";
                cmd = new MySqlCommand(query, conn);
                returnVal = new MySqlDataAdapter(query, conn);
                returnVal.Fill(FilesAccess.db.playerChamps);

                query = "SELECT * FROM games";
                cmd = new MySqlCommand(query, conn);
                returnVal = new MySqlDataAdapter(query, conn);
                returnVal.Fill(FilesAccess.db.games);

                query = "SELECT * FROM pointsbreakdown";
                cmd = new MySqlCommand(query, conn);
                returnVal = new MySqlDataAdapter(query, conn);
                returnVal.Fill(FilesAccess.db.pointsBreakDown);

                query = "SELECT * FROM ratingchart";
                cmd = new MySqlCommand(query, conn);
                returnVal = new MySqlDataAdapter(query, conn);
                returnVal.Fill(FilesAccess.db.ratingChart);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
