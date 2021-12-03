using DLMS.Forms;
using DLMS.CustomClasses;

namespace DLMS
{
    class Singleton
    {
        // Fields
        private static FormMainSignIn s_frmMainSignIn;
        private static FormMainMenu s_frmMainMenu;
        private static FormHome s_frmHome;
        private static FormLibrary s_frmLibrary;
        private static FormViewProfile s_frmViewProfile;

        private static DBHandler s_dBHandler;

        // Properties
        public static FormMainSignIn FrmMainSignIn
        {
            get 
            {
                if (s_frmMainSignIn == null)
                    s_frmMainSignIn = new FormMainSignIn();
                return s_frmMainSignIn;
            }
            set => s_frmMainSignIn = value;
        }

        public static FormMainMenu FrmMainMenu
        {
            get
            {
                if (s_frmMainMenu == null)
                    s_frmMainMenu = new FormMainMenu();
                return s_frmMainMenu;
            }
            set => s_frmMainMenu = value;
        }

        public static FormHome FrmHome
        {
            get
            {
                if (s_frmHome == null)
                    s_frmHome = new FormHome();
                return s_frmHome;
            }
            set => s_frmHome = value;
        }

        public static FormLibrary FrmLibrary
        {
            get
            {
                if (s_frmLibrary == null)
                    s_frmLibrary = new FormLibrary();
                return s_frmLibrary;
            }
            set => s_frmLibrary = value;
        }

        public static FormViewProfile FrmViewProfile
        {
            get
            {
                if (s_frmViewProfile == null)
                    s_frmViewProfile = new FormViewProfile();
                return s_frmViewProfile;
            }
            set => s_frmViewProfile = value;
        }

        public static DBHandler DBHandler
        {
            get
            {
                if (s_dBHandler == null)
                    s_dBHandler = new DBHandler();
                return s_dBHandler;
            }
        }
    }
}