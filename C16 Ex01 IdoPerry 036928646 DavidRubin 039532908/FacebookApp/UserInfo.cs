using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FacebookApp.Properties;

using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public partial class UserInfo : UserControl
    {
        private const int k_Margin = 15;

        private List<InfoItem> m_InfoItems;

        private User m_User;

        public UserInfo()
        {
            InitializeComponent();
            m_InfoItems = new List<InfoItem>();
        }

        public void Init(User i_User)
        {
            reset();
            m_User = i_User;
            tryAddInfo(m_User.Bio, null);
            tryAddInfo(m_User.Birthday, Resources.Birthday);
            tryAddInfo(m_User.Religion, Resources.Bolt);
            tryAddInfo(
                m_User.Gender.ToString(), 
                i_User.Gender.Equals(User.eGender.male) ? Resources.Male : Resources.Female);

            // tryAddInfo(m_User.Hometown.ToString(), Resources.Birthday);
            tryAddInfo(m_User.RelationshipStatus.ToString(), Resources.Heart);
        }

        private void tryAddInfo(string i_Info, Image i_Image)
        {
            if (i_Info != null)
            {
                if (!i_Info.Equals(string.Empty))
                {
                    InfoItem infoItem = new InfoItem();
                    infoItem.InfoImage = i_Image;
                    infoItem.InfoText = i_Info;
                    infoItem.Left = pictureBoxTitle.Left;
                    infoItem.Top = pictureBoxTitle.Top + pictureBoxTitle.Height + k_Margin + (m_InfoItems.Count * (infoItem.Height + k_Margin));
                    m_InfoItems.Add(infoItem);
                    Controls.Add(infoItem);
                }
            }
        }

        private void reset()
        {
            foreach (InfoItem infoItem in m_InfoItems)
            {
                Controls.Remove(infoItem);
                infoItem.Dispose();
            }

            m_InfoItems.Clear();
        }
    }
}