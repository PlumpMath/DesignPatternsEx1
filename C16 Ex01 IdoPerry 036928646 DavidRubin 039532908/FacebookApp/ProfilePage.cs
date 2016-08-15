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
            InitTopPanel();
        }

        private void InitTopPanel()
        {
            
        }

        private void InitLeftPanel()
        {
            
        }
    }
}
