using System;
using System.Windows.Forms;

namespace FacebookApp
{

    public partial class SettingsForm : Form
    {
        private UserSettings m_settings;
        public delegate void SettingChangesDelagate(UserSettings i_changdSettings);
        public event SettingChangesDelagate OnChangesSubmitted;

        public SettingsForm(UserSettings i_userSettings)
        {
            InitializeComponent();
            checkBoxRememberMe.Checked = i_userSettings.RememberMe;
            checkBoxRememberMe.CheckedChanged += checkBox1_CheckedChanged;
            m_settings = i_userSettings;
        }

        protected override void OnShown(EventArgs e)
        {
            LoadUserSettingsFile();
            base.OnShown(e);
        }

        private void LoadUserSettingsFile()
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            m_settings.RememberMe = checkBoxRememberMe.Checked;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (OnChangesSubmitted != null)
            {
                OnChangesSubmitted(m_settings);   
            }
            Close();
        }
    }
}
