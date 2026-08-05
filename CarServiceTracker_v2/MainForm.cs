using CarServiceTracker_v2.Components;

namespace CarServiceTracker_v2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShowControl(new WorkflowView());
        }

        private void btnWorkflow_Click(object sender, EventArgs e)
        {
            ShowControl(new WorkflowView());
        }
        private void ShowControl(Control newControl)
        {
            mainDisplayPanel.Controls.Clear();
            newControl.Dock = DockStyle.Fill;
            mainDisplayPanel.Controls.Add(newControl);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ShowControl(new CustomersView());
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            ShowControl(new ServicesView());
        }
        private void btnInvoices_Click(object sender, EventArgs e)
        {
            ShowControl(new InvoicesView());
        }
    }
}
