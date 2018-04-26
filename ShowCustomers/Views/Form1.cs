using System;
using ShowCustomers.View;
using ShowCustomers.Presenter;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;

namespace ShowCustomers
{
    public partial class Form1 : Form, IBank
    {
        BankPresenter presenter; // presenter field

        public Form1()
        {
            InitializeComponent();
            AllocConsole();  // Console output
            presenter = new InitPresenter(this); // instantiate presenter
        }

        [DllImport("kernel32.dll", SetLastError = true)] // Console output
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public string NameText { get => txtName.Text; set => txtName.Text = value; }
        public string CPRText { get => txtCPR.Text; set => txtCPR.Text = value; }
        public string AddressText { get => txtAddress.Text; set => txtAddress.Text = value; }

        public string DisplayUser { set => labelNameOrCPR.Text = value; }

        public bool BudgetModifyRadio => radioBudgetAccountModify.Checked; 
        public bool CurrentModifyRadio => radioCurrentAccountModify.Checked;

        public bool BudgetCreateRadio  => radioBudgetAccount.Checked;
        public bool CurrentCreateRadio => radioCurrentAccount.Checked;

        public string AccountStatusText { get => labelAccountSatus.Text; set => labelAccountSatus.Text = value; }

        public string DatePick => dateTimePicker.Value.ToShortDateString(); 

        public IEnumerable<string[]> BudgetList
        {
            set
            {
                value?.ToList().ForEach(v => listBudget.Items.Insert(0, new ListViewItem(v)));
                listBudget.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }
        public IEnumerable<string[]> CurrentList
        {
            set

            {
                value?.ToList().ForEach(v => listCurrent.Items.Insert(0, new ListViewItem(v)));
                listCurrent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        public string AmountText { get => txtAmount.Text; set => txtAmount.Text = value; }

        public string error_NameText { set => error_Name.Text = value; }
        public string error_CPRText { set => error_CPR.Text = value; }
        public string error_AddressText { set => error_Address.Text = value; }

        public string CurrentAccount { set => txtCurrentAccount.Text = value; }
        public string BudgetAccount { set => txtBudgetAccount.Text = value; }

        public string BudgetTotal { set => labelBudgetAccountTotal.Text = value; }
        public string CurrentTotal { set => labelCurrentAccountTotal.Text = value; }
       
       
        public event Action OnAddCustomer; // EVENT   
        public event Action OnTextChange;
        public event Action OnGetCustomer; 
        public event Action OnCreateAccount;
        public event Action OnLogOut; 
        public event Action OnInsert;


        public void ClearTransactions()
        {
            listBudget.Items.Clear();
            listCurrent.Items.Clear();

        }

        private void buttonUpdateCustomer_Click(object sender, EventArgs e) => OnAddCustomer();

        private void buttonGetCustomer_Click(object sender, EventArgs e)  => OnGetCustomer(); // Invoke event
        
        private void OnTextChange_TextChanged(object sender, EventArgs e)  => OnTextChange();
        
        private void buttonCreateAccount_Click(object sender, EventArgs e)  => OnCreateAccount();           
        
        private void buttonLogOut_Click(object sender, EventArgs e)  => OnLogOut();       

        private void buttonInsert_Click(object sender, EventArgs e)  => OnInsert();


    }
}
