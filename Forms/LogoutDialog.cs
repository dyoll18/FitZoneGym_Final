namespace FitZoneGym.Forms
{
    /// <summary>Screen 16 - Logout confirmation.</summary>
    public partial class LogoutDialog : Form
    {
        public LogoutDialog()
        {
            InitializeComponent();
            if (!Ui.IsDesignTime) Theme.Apply(this);
        }
    }
}
