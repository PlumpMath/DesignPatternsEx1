using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{


    public partial class UserInfo : UserControl
    {

        private List<InfoItem> m_InfoItems;

        public UserInfo()
        {
            InitializeComponent();
        }


        public void init(User i_User)
        {
            
        }

    }
}