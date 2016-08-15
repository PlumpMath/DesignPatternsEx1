using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookApp.Properties;

namespace FacebookApp
{


    public partial class UserInfo : UserControl
    {

        private List<InfoItem> m_InfoItems;

        public UserInfo()
        {
            InitializeComponent();
            m_InfoItems= new List<InfoItem>();
        }


        public void init(User i_User)
        {
           
            tryAddInfo(i_User.Birthday, Resources.Birthday);
            tryAddInfo(i_User.Religion, Resources.Birthday);
            tryAddInfo(i_User.Gender.ToString(), Resources.Birthday);
            //tryAddInfo(i_User.Hometown.ToString(), Resources.Birthday);
            tryAddInfo(i_User.RelationshipStatus.ToString(), Resources.Birthday);

        }

        private void tryAddInfo(string i_Info, Image i_Image)
        {
            if (i_Info != null || !i_Info.Equals(string.Empty))
            {
                InfoItem infoItem = new InfoItem();
                infoItem.InfoImage = i_Image;
                infoItem.InfoText = i_Info;
                infoItem.Left = 20;
                infoItem.Top = 100 + m_InfoItems.Count * (infoItem.Height + 15);
                m_InfoItems.Add(infoItem);
                this.Controls.Add(infoItem);
                
            }
        }

    }
}