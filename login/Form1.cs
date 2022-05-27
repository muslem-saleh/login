using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class fomLogin : Form
    {
        List<User> lst_user = new List<User>();
        public static string str_name { get; set; }
        public fomLogin()
        {
            InitializeComponent();

            lst_user.Add(new User { ID = 1, Name = "Muslim", UserName = "MS", Password = "123" });
            lst_user.Add(new User { ID = 2, Name = "Ali", UserName = "Al", Password = "123" });
        }

        private void fomLogin_Load(object sender, EventArgs e)
        {

        }

        private void bonLogin_Click(object sender, EventArgs e)
        {
            if (lst_user.Count > 0)
            {
                bool isUserNameValid = false;

                foreach (var names in lst_user)
                {
                    if (names.UserName == tb_Uuser.Text)
                    {
                        isUserNameValid = true;
                        break;
                    }
                }

                if (isUserNameValid)
                {
                    foreach (var user in lst_user)
                    {
                        if (user.UserName == tb_Uuser.Text)
                            if (user.Password != txtPass.Text)
                            {
                                MessageBox.Show("password is invalid");
                                return;
                            }


                        if (user.UserName == tb_Uuser.Text && user.Password == txtPass.Text)
                        {
                            str_name = user.Name;
                            Form02 form02 = new Form02();
                            form02.Show();
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("username is invalid");
                }
            }
        }
    }
}
