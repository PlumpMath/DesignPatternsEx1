using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp
{
    using FacebookWrapper.ObjectModel;

    public partial class ProfilePage : UserControl
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        public void ShowUser(User i_User)
        {
            InitLeftPanel();
            InitTopPanel(i_User);
        }

        private void InitTopPanel(User i_User)
        {
            topPanel.ShowUser(i_User);
        }

        private void InitLeftPanel()
        {
            
        }

        private void topPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
