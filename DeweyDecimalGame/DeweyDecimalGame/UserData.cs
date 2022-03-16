using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalGame
{
    public class UserData
    {
        public static string Username { get; set; }
        public static string GameMode { get; set; }
        public static int UserID { get; set; }
        public static int UserXP { get; set; }
        public static int UserLevel { get; set; }
        public static int MaxLevel { get; set; }

        public string UserLogin(string username, string password)
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conn))
            {
                SqlCommand cmdLogin = new SqlCommand("SELECT ID FROM UserAccount WHERE Username= @username AND Password = @password ", con);
                cmdLogin.CommandType = CommandType.Text;
                cmdLogin.Parameters.Add("@username     ", SqlDbType.VarChar).Value = username;
                cmdLogin.Parameters.Add("@password     ", SqlDbType.VarChar).Value = password;
                try
                {
                    con.Open();
                    UserID = (int)cmdLogin.ExecuteScalar();
                    con.Close();
                    GetUserName();


                }
                catch (Exception)
                {

                }
            }
            return Username;

        }

        public int GetUserXP(int id)
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conn))
            {
                SqlCommand cmdXp = new SqlCommand("SELECT CharacterXp FROM UserAccount WHERE ID= @ID", con);
                cmdXp.CommandType = CommandType.Text;
                cmdXp.Parameters.Add("@ID     ", SqlDbType.Int).Value = id;
                try
                {
                    con.Open();
                    UserXP = (int)cmdXp.ExecuteScalar();
                    con.Close();

                }
                catch (Exception)
                {

                }
            }
            return UserXP;
        }

        public int GetUserLvl(int id)
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conn))
            {
                SqlCommand cmdLvl = new SqlCommand("SELECT CharacterLvl FROM UserAccount WHERE ID= @ID", con);
                cmdLvl.CommandType = CommandType.Text;
                cmdLvl.Parameters.Add("@ID     ", SqlDbType.Int).Value = id;
                try
                {
                    con.Open();
                    UserLevel = (int)cmdLvl.ExecuteScalar();
                    con.Close();

                }
                catch (Exception)
                {

                }
            }
            return UserLevel;
        }

        public int GetLvlMax(int id)
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conn))
            {
                SqlCommand cmdLvlMax = new SqlCommand("SELECT LVL FROM TB_Levels WHERE ID= @ID", con);
                cmdLvlMax.CommandType = CommandType.Text;
                cmdLvlMax.Parameters.Add("@ID     ", SqlDbType.Int).Value = id;
                try
                {
                    con.Open();
                    MaxLevel = (int)cmdLvlMax.ExecuteScalar();
                    con.Close();

                }
                catch (Exception)
                {

                }
            }
            return MaxLevel;
        }

        public int SetUserXP(int id, int xp)
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conn))
            {
                SqlCommand cmdAddXP = new SqlCommand("UPDATE UserAccount Set CharacterXp = @XP WHERE ID= @ID ", con);
                cmdAddXP.CommandType = CommandType.Text;
                cmdAddXP.Parameters.Add("@ID     ", SqlDbType.Int).Value = id;
                cmdAddXP.Parameters.Add("@XP     ", SqlDbType.Int).Value = xp;
                try
                {
                    con.Open();
                    cmdAddXP.ExecuteScalar();
                    con.Close();
                    
                }
                catch (Exception)
                {

                }
            }
            return UserXP;
        }

        public void GetUserName()
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conn))
            {
                SqlCommand cmdLogin = new SqlCommand("SELECT Username FROM UserAccount WHERE ID= @ID", con);
                cmdLogin.CommandType = CommandType.Text;
                cmdLogin.Parameters.Add("@ID     ", SqlDbType.Int).Value = UserID;
                try
                {
                    con.Open();
                    Username = (string)cmdLogin.ExecuteScalar();
                    con.Close();

                }
                catch (Exception)
                {

                }
            }
        }

        private void UserRegister() 
        { 

        }

    }
}
