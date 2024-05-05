namespace VehicleRentalServices
{
    public partial class DisplayMain : Form
    {
        public DisplayMain()
        {
            InitializeComponent();
        }
        private void ClickAboutVRS(object sender, EventArgs e)
        {
            DisplayAboutVRS tutorial = new DisplayAboutVRS();
            tutorial.Show();
        }
        private void ClickOwner(object sender, EventArgs e)
        {
            DisplayOwner owner = new DisplayOwner();
            owner.Show();
        }
        private void ClickDriver(object sender, EventArgs e)
        {
            DisplayDriver driver = new DisplayDriver();
            driver.Show();
        }
        private void ClickAssistant(object sender, EventArgs e)
        {
            DisplayAssistant assistant = new DisplayAssistant();
            assistant.Show();
        }
        private void ClickRenter(object sender, EventArgs e)
        {
            DisplayRenter rental = new DisplayRenter();
            rental.Show();
        }
        private void ClickAdmin(object sender, EventArgs e)
        {
            DisplayAdmin admin = new DisplayAdmin();
            admin.Show();
        }
        private void ClickBusinessInfo(object sender, EventArgs e)
        {
            DisplayBusinessInfo displayBusinessInfo = new DisplayBusinessInfo();
            displayBusinessInfo.Show();
        }
    }
}