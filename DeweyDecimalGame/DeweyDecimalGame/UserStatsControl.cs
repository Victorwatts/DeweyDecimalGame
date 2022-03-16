using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweyDecimalGame
{
    
    public partial class UserStatsControl : UserControl
    {
        
       
        public string Username;

        public UserStatsControl()
        {
            InitializeComponent();
           

        }

        private void UserStatsControl_Load(object sender, EventArgs e)
        {
            
            SetUserStats();

        }

       

        public void SetUserStats()
        {

            
            UserData userdata = new UserData();
            lbl_Username.Text = UserData.Username;
            lbl_lvl.Text = userdata.GetUserLvl(UserData.UserID).ToString();
            lbl_XPvalue.Text = userdata.GetUserXP(UserData.UserID).ToString();
            int PB_MAX = userdata.GetLvlMax(UserData.UserLevel); ;
            int PB_VALUE = userdata.GetUserXP(UserData.UserID); ;
            PB_XP.Maximum = 100;
            PB_XP.Value = 100 - (PB_MAX - PB_VALUE);

            //Console.WriteLine(PB_MAX);
            //Console.WriteLine(PB_VALUE);
            //Console.WriteLine( 100 - (PB_MAX - PB_VALUE));
            //Console.WriteLine(UserData.Username);
        }
    }
}
