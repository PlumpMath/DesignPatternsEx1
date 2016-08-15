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
        private User m_CurrentUser;
        public ProfilePage()
        {
            InitializeComponent();
        }

        public void ShowUser(User i_User)
        {
            m_CurrentUser = i_User;
            InitLeftPanel();
            InitTopPanel();
        }

        private void InitTopPanel()
        {
            
        }

        private void InitLeftPanel()
        {
            leftPanel.init(m_CurrentUser);
        }
    }
}
