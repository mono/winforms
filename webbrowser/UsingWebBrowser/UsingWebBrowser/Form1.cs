using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace UsingWebBrowser
{
    // Enable Interop to support communication between this class and the WebBrowser control
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            setupBrowser1();
            setupBrowser2();
            setupBrowser3();
        }


#region WebBrowser1: Simple Browser

        private void setupBrowser1()
        {
            // Configure 1st WebBrowser control
            // Allow navigation to other pages
            webBrowser1.AllowNavigation = true;
            // Enable the IE context menu in the browser control
            webBrowser1.IsWebBrowserContextMenuEnabled = true;
            // Enable keyboard shortcutes in the browser control
            webBrowser1.WebBrowserShortcutsEnabled = true;

        }
        // Provide an accessor for the browserAddressTextBox control
        private string browserUrl
        {
            get { return browserAddressTextBox.Text.Trim(); }
            set { browserAddressTextBox.Text = value; }
        }

        // Update status strip with status message
        private void updateBrowserStatus(string message)
        {
            if (message.Trim() == String.Empty)
                message = "Ready";
            browserStatusLabel.Text = message;
        }

        private void browserGoButton_Click(object sender, EventArgs e)
        {
			Navigate();
        }

		private void Navigate()
		{
			if (!browserUrl.StartsWith("http://"))
			{
				browserUrl = "http://" + browserUrl;
			}

			try
			{
				webBrowser1.Navigate(new Uri(browserUrl));
			}
			catch
			{
				MessageBox.Show("Invalid Url.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void browserBackButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void browserForwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            // Refresh Address after navigation, in case redirects occurred
            browserUrl = e.Url.ToString();
            updateBrowserStatus(String.Empty);
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            // Provide feedback to user that the browser is busy
            updateBrowserStatus("Navigating...");
        }

		void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Navigate if the ENTER key is pressed
			if (e.KeyChar == '\r')
				Navigate();
		}

		private void browserRefreshButton_Click(object sender, EventArgs e)
		{
			webBrowser1.Refresh();
		}

		private void browserStopButton_Click(object sender, EventArgs e)
		{
			webBrowser1.Stop();
		}

#endregion

#region WebBrowser2: HTML Document Viewer

        private void setupBrowser2()
        {
			// This prevents the Web browser from opening files that are dropped onto it.
			webBrowser2.AllowWebBrowserDrop = false;

			// Load up the browser with the sample's ReadMe
			FileInfo fi = new FileInfo(@"..\..\ReadMe.htm");
			DisplayHTMLDoc(fi.FullName);
        }

        private void DisplayHTMLDoc(string path)
        {
            if (path != String.Empty)
            {
                try
                {
					if (File.Exists(path))
					{
						// Any of the following will work.
						//webBrowser2.Navigate(new Uri(path));
						//webBrowser2.DocumentStream = File.OpenRead(path);
						webBrowser2.Url = new Uri(path);
					}
					else
					{
						MessageBox.Show("The browser could not navigate to " + 
							path + ".", this.Text);
					}
                }
                catch (ApplicationException ex)
                {
					MessageBox.Show("The following error occurred:" + ex.Message);
                }
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Default directory is project root
            openFileDialog.InitialDirectory = @"..\..\";
            openFileDialog.Filter = "HTML files (*.html)|*.html|HTM files (*.htm)|*.htm|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileNameTextBox.Text = openFileDialog.FileName;
                // Display the HTML Doc as well.
                DisplayHTMLDoc(fileNameTextBox.Text.Trim());
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            DisplayHTMLDoc(fileNameTextBox.Text.Trim());
        }

#endregion

#region WebBrowser3: 2-way Interaction 
        
		private Sales sales;
		private BindingSource salesHeaderBindingSource;
		private BindingSource salesDetailBindingSource;


        private void setupBrowser3()
        {
			// Bind the Form to the Sales data
			BindOrderForm();

			// Load the browser with the Sales Order printing template
			webBrowser3.DocumentStream = File.OpenRead(Path.GetDirectoryName(Application.ExecutablePath) + "\\..\\..\\SalesOrderForm.html");

			// Specify host form as the scripting object
			webBrowser3.ObjectForScripting = this;

		}

		private void BindOrderForm()
		{
			string projectPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\..\\..\\";
			sales = new Sales();
			sales.ReadXml(projectPath + "Sales.xml");

            salesHeaderBindingSource = new BindingSource();
			salesHeaderBindingSource.DataSource = sales.SalesHeader;
            salesHeaderBindingSource.Position = 0;
			// Handle event to refresh the HTML Form when change the current Order
			salesHeaderBindingSource.CurrentChanged += new EventHandler(salesHeaderBindingSource_CurrentChanged);

			salesDetailBindingSource = new BindingSource(salesHeaderBindingSource, "SalesHeader_SalesDetail");

            BindingNavigator salesHeaderBindingNavigator = new BindingNavigator(true);
            salesHeaderBindingNavigator.BindingSource = salesHeaderBindingSource;

            this.splitContainer2.Panel1.Controls.Add(salesHeaderBindingNavigator);
            salesHeaderBindingNavigator.Dock = DockStyle.Top;

            // Bind the controls to the BindingSource
            this.headerIDTextBox.DataBindings.Add(
                new Binding("Text", salesHeaderBindingSource, "HeaderID", true));
            this.salesPersonIDTextBox.DataBindings.Add(
                new Binding("Text", salesHeaderBindingSource, "SalesPersonID", true));
            this.salesPersonNameTextBox.DataBindings.Add(
                new Binding("Text", salesHeaderBindingSource, "SalesPersonName", true));
            this.customerIDTextBox.DataBindings.Add(
                new Binding("Text", salesHeaderBindingSource, "CustomerID", true));
            this.customerNameTextBox.DataBindings.Add(
                new Binding("Text", salesHeaderBindingSource, "CustomerName", true));
            this.salesDateDateTimePicker.DataBindings.Add(
                new Binding("Value", salesHeaderBindingSource, "SalesDate", true)); 
            this.salesTotalTextBox.DataBindings.Add(
                new Binding("Text", salesHeaderBindingSource, "SalesTotal", true));
			
			salesDetailsRowDataGridView.DataSource = salesDetailBindingSource;
		}

		public void RefreshHTMLForm()
		{
			// Inject the data from the current OrderForm into the HTML template

			// Grab the current order
			Sales.SalesHeaderRow salesHeader = (Sales.SalesHeaderRow)((DataRowView)salesHeaderBindingSource.Current).Row;

			// Refresh the SalesHeader information
			HtmlDocument htmlDoc = webBrowser3.Document;
			if (htmlDoc.All["SalesPersonID"] != null)
				htmlDoc.All["SalesPersonID"].InnerText = salesHeader.SalesPersonID.ToString();
			if (htmlDoc.All["SalesPersonName"] != null)
				htmlDoc.All["SalesPersonName"].InnerText = salesHeader.SalesPersonName;
			if (htmlDoc.All["CustomerID"] != null)
				htmlDoc.All["CustomerID"].InnerText = salesHeader.CustomerID.ToString();
			if (htmlDoc.All["CustomerName"] != null)
				htmlDoc.All["CustomerName"].InnerText = salesHeader.CustomerName;
			if (htmlDoc.All["SalesDate"] != null)
				htmlDoc.All["SalesDate"].InnerText = salesHeader.SalesDate.ToShortDateString();
			if (htmlDoc.All["SalesTotal"] != null)
				htmlDoc.All["SalesTotal"].InnerText = salesHeader.SalesTotal.ToString();

			// Build SalesDetails table
			// The SalesDetailTable element contains the template for each SalesDetail item
			HtmlElement detailsTemplate = htmlDoc.GetElementById("SalesDetailsTemplate");
			// Populated sales data is injected into SalesData element
			HtmlElement detailsData = htmlDoc.GetElementById("SalesData");
			
			// Build up the HTML row for each SalesDetail record based upon the template
			// Replace the element HTML with the row values
			// and append add each row's resulting HTML to a string
			string detailsText = String.Empty;
			foreach (Sales.SalesDetailRow saleDetail in salesHeader.GetSalesDetailRows())
			{
				if (detailsTemplate.All["ItemID"] != null)
					detailsTemplate.All["ItemID"].InnerHtml = saleDetail["ItemID"].ToString();
				if (detailsTemplate.All["ItemName"] != null)
					detailsTemplate.All["ItemName"].InnerHtml = saleDetail["ItemName"].ToString();
				if (detailsTemplate.All["Quantity"] != null)
					detailsTemplate.All["Quantity"].InnerHtml = saleDetail["Quantity"].ToString();
				if (detailsTemplate.All["UnitPrice"] != null)
					detailsTemplate.All["UnitPrice"].InnerHtml = saleDetail["UnitPrice"].ToString();
				if (detailsTemplate.All["SubTotal"] != null)
					detailsTemplate.All["SubTotal"].InnerHtml = saleDetail["SubTotal"].ToString();
				
				detailsText += detailsTemplate.InnerHtml;
			}

 			// Restore the template
			if (detailsTemplate.All["ItemID"] != null)
				detailsTemplate.All["ItemID"].InnerHtml = String.Empty;
			if (detailsTemplate.All["ItemName"] != null)
				detailsTemplate.All["ItemName"].InnerHtml = String.Empty;
			if (detailsTemplate.All["Quantity"] != null)
				detailsTemplate.All["Quantity"].InnerHtml = String.Empty;
			if (detailsTemplate.All["UnitPrice"] != null)
				detailsTemplate.All["UnitPrice"].InnerHtml = String.Empty;
			if (detailsTemplate.All["SubTotal"] != null)
				detailsTemplate.All["SubTotal"].InnerHtml = String.Empty;

			// Inject populated HTML into data element
			detailsData.InnerHtml = detailsText;

		}

		private void salesHeaderBindingSource_CurrentChanged(object sender, EventArgs e)
		{
			RefreshHTMLForm();
		}

		// When selecting the 2-way interaction tab, 
		// refresh the HTML Form
		private void tabControl1_Selected(object sender, TabControlEventArgs e)
		{
			if (tabControl1.SelectedTab == tabPage3)
				RefreshHTMLForm();
		}

#endregion

	}
}