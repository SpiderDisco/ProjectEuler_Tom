using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ProjectEuler
{
    class DataRead
    {
        public static void Start()
        {
            ReadData();
            Timer _CollectKeywordsTimer = new Timer();
            _CollectKeywordsTimer.Interval = TimeSpan.FromMinutes(1).TotalMilliseconds;
            _CollectKeywordsTimer.Elapsed += (sender, e) =>
                {
                    //_CollectKeywordsTimer.Stop();
                    ReadData();
                    //_CollectKeywordsTimer.Start();
                };
            _CollectKeywordsTimer.Start();
        }
        public static void ReadData()
        {
            string connectionString = "Data Source=tcp:dcqzpy2j51.database.windows.net,1433;Initial Catalog=PII_SocialMediaData_Dev;Integrated Security=False;User ID=maestro;Password=Stravinsky1;Connect Timeout=30;Encrypt=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandTimeout = 60 * 3;
                    command.CommandText = "select count(*) as [count] from Social_Media_Data where DateCreated < getdate()-90";
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        Console.WriteLine(DateTime.Now.ToShortTimeString() + " - " + string.Format("{0:n0}", int.Parse(reader["count"].ToString())));
                    }
                }

            }
        }
    }
}
