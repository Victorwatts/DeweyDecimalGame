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
   

    public partial class UserLoggedBannerControl : UserControl
    {
        string Username;
        public UserLoggedBannerControl()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            UserData userdata = new UserData();
            Username = userdata.UserLogin(txt_UserName.Text.ToString(), txt_Password.Text.ToString());
            if (Username == null)
            {

            }
            else
            {
                Panel panel = this.Parent as Panel;
                if (panel != null)
                {
                    panel.Controls.RemoveByKey("UserLoggedBannerControl");
                    UserStatsControl userStatsControl = new UserStatsControl();
                    panel.Controls.Add(userStatsControl);
                   
                }
            }
           
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {

        }
    }
}
