using Services;

namespace Dependencies
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(IPreferencesRepo preferencesRepo)
        {
            InitializeComponent();
            PreferencesRepo = preferencesRepo;
        }

        public IPreferencesRepo PreferencesRepo { get; }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var preference = PreferencesRepo.GetSetting("counter");

            if (string.IsNullOrEmpty(preference))
            {
                preference = "New preference";
                PreferencesRepo.SetSetting("counter", preference);
            }

            CounterBtn.Text = preference;


        }
    }

}
