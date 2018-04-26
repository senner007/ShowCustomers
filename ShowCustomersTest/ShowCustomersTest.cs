using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShowCustomers.Models;
using ShowCustomers.View;
using ShowCustomers.Presenter;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace ShowCustomersTest
{
    [TestClass]
    public class ShowCustomersTest // TODO : TIlføj manglende tests
    {
        /*
        * 
        * 
        * MODEL TESTS
        * 
        * 
        */
        private ManageAccounts _manage;
        private MockView _view;
        private CustomerPresenter _present;
        [TestInitialize()]
        public void TestInitialize() // executes once before each test run https://stackoverflow.com/questions/13943078/c-sharp-unit-test-with-common-code-repeated
        {
            _manage = new ManageAccounts();
            _view = new MockView();
            _present = new InitPresenter(_view);
        }
        [TestCleanup()]
        public void Cleanup() // Clear static class for hver test https://colinmackay.scot/2007/06/16/unit-testing-a-static-class/
        {
            Type staticType = typeof(Bank);
            ConstructorInfo ci = staticType.TypeInitializer;
            object[] parameters = new object[0];
            ci.Invoke(null, parameters);
        }

        [TestMethod]
        public void ModelUpdateCustomerNameSuccess()
        {
            long cpr = 1111111111;
            Customer customer = _manage.UpdateCustomer(cpr, "Smart0001", "Road 1, SomeWhere");

            string name_expected = "Smart0001";

            Assert.AreEqual(name_expected, _manage.FindCustomer(cpr).Name);


        }
        [TestMethod]
        public void ModelUpdateCustomerNameFail()
        {
            long cpr = 1111111111;
            Customer customer = _manage.UpdateCustomer(cpr, "Smart002", "Road 1, SomeWhere");

            string name_expected = "Smart001";

            Assert.AreEqual(name_expected, _manage.FindCustomer(cpr).Name);

        }
        [TestMethod]
        public void ModelCreateCustomer()
        {
            //Arrange

            long cpr = 3333333333;
            Customer customer = _manage.CreateCustomer(cpr, "Smart003", "Road 1, SomeWhere");

            Customer customer_actual = _manage.FindCustomer(cpr);

            long cpr_expected = cpr;
            string name_expected = "Smart003";
            string address_expected = "Road 1, SomeWhere";

            //Act
            long cpr_actual = customer_actual.CPR;
            string name_actual = customer_actual.Name;
            string address_actual = customer_actual.Address;

            //Assert
            Assert.AreEqual(cpr_expected, cpr_actual);
            Assert.AreEqual(name_expected, name_actual);
            Assert.AreEqual(address_expected, address_actual);
        }
        /*
         * 
         * 
         * VIEW TESTS
         * 
         * 
         */

        [TestMethod]
        public void CreateCustomerWithView()
        {
            // 1. Opret bruger
            _view.NameText = "Smart004";
            _view.CPRText = "4444444444";
            _view.AddressText = "Somwewhere 1";
            _present.CreateUpdateCustomer();

            // model test
            long expected = 4444444444;
            long actual = _manage.FindCustomer(4444444444).CPR;

            Assert.AreEqual(expected, actual);

            // view test
            string expected_feedback = "444444Bruger er oprettet. Bruger indlæst";
            Assert.AreEqual(expected_feedback, _view.DisplayUser);

        }
        [TestMethod]
        public void CreateDisplayUserView()
        {

            _view.NameText = "Smart005";
            _view.CPRText = "5555555555";
            _view.AddressText = "Somwewhere 1";

            _present.CreateUpdateCustomer();

            string expected = "555555Bruger er oprettet. Bruger indlæst";
            string actual = _view.DisplayUser;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAccountsView()
        {
            _view.NameText = "";
            _view.CPRText = "2222222222";
            _view.AddressText = "";
            _present.GetCustomer();

            _view.CurrentCreateRadio = true;
            _present.CreateAccount(); // create curtrent account

            _view.CurrentCreateRadio = false;
            _view.BudgetCreateRadio = true;
            _present.CreateAccount(); // create budget account

            string expected_CurrentNumber = "123";
            string expected_CurrentTotal = ".00";
            string expected_BudgetNumber = "456";
            string expected_BudgetTotal = ".00";

            string actual_CurrentNumber = _view.CurrentAccount;
            string actual_CurrentTotal = _view.CurrentTotal;
            string actual_BudgetNumber = _view.BudgetAccount;
            string actual_BudgetTotal = _view.BudgetTotal;

            Assert.AreEqual(expected_CurrentNumber, actual_CurrentNumber);
            Assert.AreEqual(expected_CurrentTotal, actual_CurrentTotal);

            Assert.AreEqual(expected_BudgetNumber, actual_BudgetNumber);
            Assert.AreEqual(expected_BudgetTotal, actual_BudgetTotal);

        }
        [TestMethod]
        public void AddAccountsIfExistsView()
        {
            _view.NameText = "";
            _view.CPRText = "1111111111";
            _view.AddressText = "";
            _present.GetCustomer();

            _view.CurrentCreateRadio = true;
            _present.CreateAccount(); // create current account

            _view.CurrentCreateRadio = false;
            _view.BudgetCreateRadio = true;
            _present.CreateAccount(); // create budget account

            string expected_CurrentNumber = "123";
            string expected_CurrentTotal = "100.00";
            string expected_BudgetNumber = "456";
            string expected_BudgetTotal = "200.00";

            string actual_CurrentNumber = _view.CurrentAccount;
            string actual_CurrentTotal = _view.CurrentTotal;
            string actual_BudgetNumber = _view.BudgetAccount;
            string actual_BudgetTotal = _view.BudgetTotal;

            Assert.AreEqual(expected_CurrentNumber, actual_CurrentNumber);
            Assert.AreEqual(expected_CurrentTotal, actual_CurrentTotal);

            Assert.AreEqual(expected_BudgetNumber, actual_BudgetNumber);
            Assert.AreEqual(expected_BudgetTotal, actual_BudgetTotal);

        }
        [TestMethod]
        public void InsertBudgetTransaction()
        {
            _view.NameText = "";
            _view.CPRText = "1111111111";
            _view.AddressText = "";
            _present.GetCustomer();

            _view.BudgetModifyRadio = true;
            _view.AmountText = "50";
            _view.DatePick = DateTime.Today.ToString();
            _present.InsertTransaction();


            string dateExpected = "27-04-2018 00:00:00";
            string dateActual = _view.BudgetList.FirstOrDefault()[0];

            string amountExpected = "50.00";
            string amountActual = _view.BudgetList.FirstOrDefault()[1];

            string totalExpected = "250.00";
            string totalActual = _view.BudgetList.FirstOrDefault()[2];

            Assert.AreEqual(dateExpected, dateActual);
            Assert.AreEqual(amountExpected, amountActual);
            Assert.AreEqual(totalExpected, totalActual);

        }
        [TestMethod]
        public void LogIn_InsertMultipleBudgetTransactions_LogOut_LogIn_Verify_Sequence()
        {
            _view.NameText = "";
            _view.CPRText = "1111111111";
            _view.AddressText = "";
            _present.GetCustomer();

            _view.BudgetModifyRadio = true;
            _view.AmountText = "50";  // 1. Transact
            _view.DatePick = DateTime.Today.ToString();
            _present.InsertTransaction();

            _view.AmountText = "-100"; // 2. Transact
            _present.InsertTransaction();

            _present.LogOut(); // log out

            _view.CPRText = "1111111111";
            _present.GetCustomer(); // log in

            string dateExpected = "27-04-2018 00:00:00"; // Verify Transactions
            string dateActual = _view.BudgetList.Skip(1).FirstOrDefault()[0];

            string amountExpected = "-100.00";
            string amountActual = _view.BudgetList.Skip(1).FirstOrDefault()[1];

            string totalExpected = "150.00";
            string totalActual = _view.BudgetList.Skip(1).FirstOrDefault()[2];

            Assert.AreEqual(dateExpected, dateActual);
            Assert.AreEqual(amountExpected, amountActual);
            Assert.AreEqual(totalExpected, totalActual);

        }

    }
 }

