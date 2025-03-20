using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITEC_Event_Management_System.DL;
using ITEC_Event_Management_System.BL;
using System.Management.Instrumentation;

namespace ITEC_Event_Management_System
{
	public partial class Events : Form
	{
		bool isOtherTable = false;
		public Events()
		{
			InitializeComponent();
		}

		private void Events_Load(object sender, EventArgs e)
		{
			UpdateButtons();
			LoadComboBoxes();
		}

		private void LoadComboBoxes()
		{
			List<ITECEdition> editions = ITECEditionsDL.GetAllEditions();
			ITECIDComboBox.Items.Add("None");
			foreach (ITECEdition edition in editions)
			{
				ITECIDComboBox.Items.Add(edition.ID);
			}
			ITECIDComboBox.SelectedIndex = 0;

			List<EventCategory> categories = EventCategoryDL.GetAllCategories();
			CategoryIDComboBox.Items.Add("None");
			foreach (EventCategory category in categories)
			{
				CategoryIDComboBox.Items.Add(category.ID);
			}
			CategoryIDComboBox.SelectedIndex = 0;

			List<Venue> venues = VenueDL.GetAllVenues();
			VenueIDComboBox.Items.Add("None");
			foreach (Venue venue in venues)
			{
				VenueIDComboBox.Items.Add(venue.ID);
			}
			VenueIDComboBox.SelectedIndex = 0;

			List<Committee> committees = CommitteeDL.GetAllCommittees();
			CommitteeIDComboBox.Items.Add("None");
			foreach (Committee committee in committees)
			{
				CommitteeIDComboBox.Items.Add(committee.ID);
			}
			CommitteeIDComboBox.SelectedIndex = 0;
		}

		private bool IsNumeric(string input)
		{
			return int.TryParse(input, out _);
		}

		private void UpdateButtons()
		{
			SuccessLabel.Text = "None";
			SuccessLabel.ForeColor = Color.Green;
			if ((IDTextBox.Text == "auto increment" || IDTextBox.Text == "") && NameTextBox.Text != "")
			{
				AddButton.Enabled = true;
				AddButton.ForeColor = Color.White;
				AddButton.BackColor = Color.ForestGreen;
			}
			else
			{

				AddButton.Enabled = false;
				AddButton.BackColor = Color.Gray;
			}

			if (IDTextBox.Text != "" && IDTextBox.Text != "auto increment" && IsNumeric(IDTextBox.Text))
			{
				DeleteButton.Enabled = true;
				DeleteButton.ForeColor = Color.White;
				DeleteButton.BackColor = Color.Brown;

				RetrieveButton.Enabled = true;
				RetrieveButton.BackColor = Color.Peru;
			}
			else
			{
				DeleteButton.Enabled = false;
				DeleteButton.BackColor = Color.Gray;

				RetrieveButton.Enabled = false;
				RetrieveButton.BackColor = Color.Gray;
			}

			if (IDTextBox.Text != "" && IDTextBox.Text != "auto increment" && IsNumeric(IDTextBox.Text))
			{
				UpdateButton.Enabled = true;
				UpdateButton.BackColor = Color.RoyalBlue;
			}
			else
			{
				UpdateButton.Enabled = false;
				UpdateButton.BackColor = Color.Gray;
			}
		}

		public string CapitalizeEachWord(string input)
		{
			if (string.IsNullOrWhiteSpace(input))
				return input;

			return string.Join(" ", input.Split(' ')
				.Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));
		}

		private void IDTextBox_Click(object sender, EventArgs e)
		{
			if (IDTextBox.Text == "auto increment")
				IDTextBox.Text = "";
			IDTextBox.ForeColor = Color.Black;
			IDTextBox.Font = new Font(IDTextBox.Font, FontStyle.Regular);
		}

		private void IDTextBox_Leave(object sender, EventArgs e)
		{
			if (IDTextBox.Text == "")
			{
				IDTextBox.Text = "auto increment";
				IDTextBox.Font = new Font(IDTextBox.Font, FontStyle.Italic);
				IDTextBox.ForeColor = Color.Gray;
				IDErrorLabel.Hide();
			}
			UpdateButtons();
		}

		private void IDTextBox_TextChanged(object sender, EventArgs e)
		{
			UpdateButtons();

			if (!IsNumeric(IDTextBox.Text) && IDTextBox.Text != "")
				IDErrorLabel.Show();
			else
				IDErrorLabel.Hide();
		}

		private void NameTextBox_TextChanged(object sender, EventArgs e)
		{
			UpdateButtons();
		}

		private void ShowAllButton_Click(object sender, EventArgs e)
		{
			List<Event> events = EventDL.GetAllEvents();

			DataTable dt = new DataTable();

			dt.Columns.Add("ID");
			dt.Columns.Add("Name");
			dt.Columns.Add("Date");
			dt.Columns.Add("Description");
			dt.Columns.Add("ITEC ID");
			dt.Columns.Add("Category ID");
			dt.Columns.Add("Venue ID");
			dt.Columns.Add("Committee ID");

			foreach (Event evn in events)
			{
				string ITECIDValue = evn.ITECID == -1 ? "NULL" : evn.ITECID.ToString();
				string categoryIDValue = evn.categoryID == -1 ? "NULL" : evn.categoryID.ToString();
				string venueIDValue = evn.venueID == -1 ? "NULL" : evn.venueID.ToString();
				string committeeIDValue = evn.committeeID == -1 ? "NULL" : evn.committeeID.ToString();
				dt.Rows.Add(evn.ID, evn.name, evn.date.ToShortDateString(), evn.description, ITECIDValue, categoryIDValue, venueIDValue, committeeIDValue);
			}

			DataGrid.DataSource = dt;
			DataGrid.Refresh();
			isOtherTable = false;
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			string descriptionValue = string.IsNullOrWhiteSpace(DescriptionTextBox.Text) ? null : DescriptionTextBox.Text;
			int ITECIDValue = ITECIDComboBox.Text == "None" ? -1 : int.Parse(ITECIDComboBox.Text);
			int categoryIDValue = CategoryIDComboBox.Text == "None" ? -1 : int.Parse(CategoryIDComboBox.Text);
			int venueIDValue = VenueIDComboBox.Text == "None" ? -1 : int.Parse(VenueIDComboBox.Text);
			int committeeIDValue = CommitteeIDComboBox.Text == "None" ? -1 : int.Parse(CommitteeIDComboBox.Text);
			Event evn = new Event(-1, NameTextBox.Text, DateTime.Parse(DatePicker.Value.ToString("yyyy-MM-dd")), descriptionValue, ITECIDValue, categoryIDValue, venueIDValue, committeeIDValue);
			int result = EventDL.StoreEvent(evn);
			if (result == 1)
			{
				SuccessLabel.Text = "Event added successfully!";
				SuccessLabel.ForeColor = Color.Green;
				ShowAllButton.PerformClick();
            }
			else
			{
				SuccessLabel.Text = "Failed to add event!";
				SuccessLabel.ForeColor = Color.Red;
			}
		}

		private void RetrieveAt(int ID)
		{
			Event evn = EventDL.GetEventByID(ID);
			if (evn != null)
			{
				DataTable dataTable = new DataTable();
				dataTable.Columns.Add("ID");
				dataTable.Columns.Add("Name");
				dataTable.Columns.Add("Date");
				dataTable.Columns.Add("Description");
				dataTable.Columns.Add("ITEC ID");
				dataTable.Columns.Add("Category ID");
				dataTable.Columns.Add("Venue ID");
				dataTable.Columns.Add("Committee ID");

				string ITECIDValue = evn.ITECID == -1 ? "NULL" : evn.ITECID.ToString();
				string categoryIDValue = evn.categoryID == -1 ? "NULL" : evn.categoryID.ToString();
				string venueIDValue = evn.venueID == -1 ? "NULL" : evn.venueID.ToString();
				string committeeIDValue = evn.committeeID == -1 ? "NULL" : evn.committeeID.ToString();
				dataTable.Rows.Add(evn.ID, evn.name, evn.date.ToShortDateString(), evn.description, ITECIDValue, categoryIDValue, venueIDValue, committeeIDValue);

				DataGrid.DataSource = dataTable;
				DataGrid.Refresh();
				isOtherTable = false;
			}
			else
			{
				SuccessLabel.Text = "Event not found!";
				SuccessLabel.ForeColor = Color.Red;
			}

		}

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
			RetrieveAt(int.Parse(IDTextBox.Text));
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
			string descriptionValue = string.IsNullOrWhiteSpace(DescriptionTextBox.Text) ? null : DescriptionTextBox.Text;
            int ITECIDValue = ITECIDComboBox.Text == "None" ? -1 : int.Parse(ITECIDComboBox.Text);
            int categoryIDValue = CategoryIDComboBox.Text == "None" ? -1 : int.Parse(CategoryIDComboBox.Text);
            int venueIDValue = VenueIDComboBox.Text == "None" ? -1 : int.Parse(VenueIDComboBox.Text);
            int committeeIDValue = CommitteeIDComboBox.Text == "None" ? -1 : int.Parse(CommitteeIDComboBox.Text);

            Event evn = new Event(int.Parse(IDTextBox.Text), NameTextBox.Text, DateTime.Parse(DatePicker.Value.ToString("yyyy-MM-dd")), descriptionValue, ITECIDValue, categoryIDValue, venueIDValue, committeeIDValue);
            int result = EventDL.UpdateEvent(evn);

            if (result == 1)
            {
                SuccessLabel.Text = "Event updated successfully!";
                SuccessLabel.ForeColor = Color.Green;
                ShowAllButton.PerformClick();
            }
            else
            {
                SuccessLabel.Text = "Failed to update event!";
                SuccessLabel.ForeColor = Color.Red;
            }
        }

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			int result = EventDL.DeleteEvent(int.Parse(IDTextBox.Text));
			if (result == 1)
			{
				SuccessLabel.Text = "Event deleted successfully!";
				SuccessLabel.ForeColor = Color.Green;
				ShowAllButton.PerformClick();
			}
			else
			{
				SuccessLabel.Text = "Failed to delete event!";
				SuccessLabel.ForeColor = Color.Red;
			}
		}

        private void ShowEditionsButton_Click(object sender, EventArgs e)
        {
            List<ITECEdition> editions = ITECEditionsDL.GetAllEditions();
			DataTable dt =
                new DataTable();
            dt.Columns.Add("ITEC ID");
            dt.Columns.Add("Year");
            dt.Columns.Add("Theme");
            dt.Columns.Add("Description");
            foreach (ITECEdition edition in editions)
            {
				string themeValue = string.IsNullOrEmpty(edition.theme) ? "NULL" : edition.theme;
                string descriptionValue = string.IsNullOrEmpty(edition.description) ? "NULL" : edition.description;
                dt.Rows.Add(edition.ID, edition.year, themeValue, descriptionValue);
            }
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = true;
        }

        private void ShowCategoriesButton_Click(object sender, EventArgs e)
        {
            List<EventCategory> categories = EventCategoryDL.GetAllCategories();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            foreach (EventCategory category in categories)
            {
                dt.Rows.Add(category.ID, category.name);
            }
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = true;
        }

        private void ShowVenuesButton_Click(object sender, EventArgs e)
        {
            List<Venue> venues = VenueDL.GetAllVenues();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Capacity");
            dt.Columns.Add("Location");
            foreach (Venue venue in venues)
            {
                string locationValue = string.IsNullOrEmpty(venue.location) ? "NULL" : venue.location;
                dt.Rows.Add(venue.ID, venue.name, venue.capacity, locationValue);
            }
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = true;
        }

        private void ShowCommitteesButton_Click(object sender, EventArgs e)
        {
            List<Committee> committees = CommitteeDL.GetAllCommittees();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("ITEC ID");
			dt.Columns.Add("Name");
            foreach (Committee committee in committees)
            {
                string ITECIDValue = committee.ITECID == -1 ? "NULL" : committee.ITECID.ToString();
                dt.Rows.Add(committee.ID, ITECIDValue, committee.Name);
            }
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = true;
        }

		private void DataGrid_DoubleClick(object sender, EventArgs e)
		{
			if (!isOtherTable)
			{
                IDTextBox.Text = DataGrid.CurrentRow.Cells[0].Value.ToString();
                NameTextBox.Text = DataGrid.CurrentRow.Cells[1].Value.ToString();
                DatePicker.Value = DateTime.Parse(DataGrid.CurrentRow.Cells[2].Value.ToString());
                DescriptionTextBox.Text = DataGrid.CurrentRow.Cells[3].Value.ToString() == "NULL" ? "" : DataGrid.CurrentRow.Cells[3].Value.ToString();
                ITECIDComboBox.Text = DataGrid.CurrentRow.Cells[4].Value.ToString() == "NULL" ? "None" : DataGrid.CurrentRow.Cells[4].Value.ToString();
                CategoryIDComboBox.Text = DataGrid.CurrentRow.Cells[5].Value.ToString() == "NULL" ? "None" : DataGrid.CurrentRow.Cells[5].Value.ToString();
                VenueIDComboBox.Text = DataGrid.CurrentRow.Cells[6].Value.ToString() == "NULL" ? "None" : DataGrid.CurrentRow.Cells[6].Value.ToString();
                CommitteeIDComboBox.Text = DataGrid.CurrentRow.Cells[7].Value.ToString() == "NULL" ? "None" : DataGrid.CurrentRow.Cells[7].Value.ToString();
            }
		}

		private void SearchName_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(NameTextBox.Text))
			{
				MessageBox.Show("Please enter a name to search for.");
			}
			else
			{
				List<Event> events = EventDL.GetEventsByNameLike(NameTextBox.Text);
				DataTable dt = new DataTable();
				dt.Columns.Add("ID");
				dt.Columns.Add("Name");
				dt.Columns.Add("Date");
				dt.Columns.Add("Description");
				dt.Columns.Add("ITEC ID");
				dt.Columns.Add("Category ID");
				dt.Columns.Add("Venue ID");
				dt.Columns.Add("Committee ID");

				foreach (Event evn in events)
				{
					string description = string.IsNullOrEmpty(evn.description) ? "NULL" : evn.description;
                    string ITECIDValue = evn.ITECID == -1 ? "NULL" : evn.ITECID.ToString();
					string categoryIDValue = evn.categoryID == -1 ? "NULL" : evn.categoryID.ToString();
					string venueIDValue = evn.venueID == -1 ? "NULL" : evn.venueID.ToString();
					string committeeIDValue = evn.committeeID == -1 ? "NULL" : evn.committeeID.ToString();
					dt.Rows.Add(evn.ID, evn.name, evn.date.ToShortDateString(), description, ITECIDValue, categoryIDValue, venueIDValue, committeeIDValue);
				}

				DataGrid.DataSource = dt;
				DataGrid.Refresh();
				isOtherTable = false;
			}
		}

		private void SearchDescription_Click(object sender, EventArgs e)
		{
			List<Event> events = new List<Event>();
			DataTable dt = new DataTable();
			dt.Columns.Add("ID");
			dt.Columns.Add("Name");
			dt.Columns.Add("Date");
			dt.Columns.Add("Description");
			dt.Columns.Add("ITEC ID");
			dt.Columns.Add("Category ID");
			dt.Columns.Add("Venue ID");
			dt.Columns.Add("Committee ID");

			if (string.IsNullOrWhiteSpace(DescriptionTextBox.Text))
			{
				events = EventDL.GetEventsByNullDescription();
				foreach (Event evn in events)
                {
                    string description = string.IsNullOrEmpty(evn.description) ? "NULL" : evn.description;
                    string ITECIDValue = evn.ITECID == -1 ? "NULL" : evn.ITECID.ToString();
					string categoryIDValue = evn.categoryID == -1 ? "NULL" : evn.categoryID.ToString();
					string venueIDValue = evn.venueID == -1 ? "NULL" : evn.venueID.ToString();
					string committeeIDValue = evn.committeeID == -1 ? "NULL" : evn.committeeID.ToString();
					dt.Rows.Add(evn.ID, evn.name, evn.date.ToShortDateString(), description, ITECIDValue, categoryIDValue, venueIDValue, committeeIDValue);
				}
				DataGrid.DataSource = dt;
				DataGrid.Refresh();
				isOtherTable = false;
			}
			else
			{
				events = EventDL.GetEventsByDescriptionLike(DescriptionTextBox.Text);
				foreach (Event evn in events)
                {
                    string description = string.IsNullOrEmpty(evn.description) ? "NULL" : evn.description;
                    string ITECIDValue = evn.ITECID == -1 ? "NULL" : evn.ITECID.ToString();
					string categoryIDValue = evn.categoryID == -1 ? "NULL" : evn.categoryID.ToString();
					string venueIDValue = evn.venueID == -1 ? "NULL" : evn.venueID.ToString();
					string committeeIDValue = evn.committeeID == -1 ? "NULL" : evn.committeeID.ToString();
					dt.Rows.Add(evn.ID, evn.name, evn.date.ToShortDateString(), description, ITECIDValue, categoryIDValue, venueIDValue, committeeIDValue);
				}
				DataGrid.DataSource = dt;
				DataGrid.Refresh();
				isOtherTable = false;
			}
		}

        private void SearchDate_Click(object sender, EventArgs e)
        {
			List <Event> events = EventDL.GetEventsByDate(DateTime.Parse(DatePicker.Value.ToString("yyyy-MM-dd")));
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Date");
            dt.Columns.Add("Description");
            dt.Columns.Add("ITEC ID");
            dt.Columns.Add("Category ID");
            dt.Columns.Add("Venue ID");
            dt.Columns.Add("Committee ID");

            foreach (Event evn in events)
            {
                string description = string.IsNullOrEmpty(evn.description) ? "NULL" : evn.description;
                string ITECIDValue = evn.ITECID == -1 ? "NULL" : evn.ITECID.ToString();
                string categoryIDValue = evn.categoryID == -1 ? "NULL" : evn.categoryID.ToString();
                string venueIDValue = evn.venueID == -1 ? "NULL" : evn.venueID.ToString();
                string committeeIDValue = evn.committeeID == -1 ? "NULL" : evn.committeeID.ToString();
                dt.Rows.Add(evn.ID, evn.name, evn.date.ToShortDateString(), description, ITECIDValue, categoryIDValue, venueIDValue, committeeIDValue);
            }

            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = false;
        }

        private void SearchITECID_Click(object sender, EventArgs e)
        {
            List<Event> events = new List<Event>();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Date");
            dt.Columns.Add("Description");
            dt.Columns.Add("ITEC ID");
            dt.Columns.Add("Category ID");
            dt.Columns.Add("Venue ID");
            dt.Columns.Add("Committee ID");

			if(ITECIDComboBox.Text == "None")
			{
				events = EventDL.GetEventsByNullITECID();
            }
            else
            {
                events = EventDL.GetEventsByITECID(int.Parse(ITECIDComboBox.Text));
            }
            foreach (Event evn in events)
            {
                string description = string.IsNullOrEmpty(evn.description) ? "NULL" : evn.description;
                string ITECIDValue = evn.ITECID == -1 ? "NULL" : evn.ITECID.ToString();
                string categoryIDValue = evn.categoryID == -1 ? "NULL" : evn.categoryID.ToString();
                string venueIDValue = evn.venueID == -1 ? "NULL" : evn.venueID.ToString();
                string committeeIDValue = evn.committeeID == -1 ? "NULL" : evn.committeeID.ToString();
                dt.Rows.Add(evn.ID, evn.name, evn.date.ToShortDateString(), description, ITECIDValue, categoryIDValue, venueIDValue, committeeIDValue);
            }

            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = false;
        }

        private void SearchCategoryID_Click(object sender, EventArgs e)
        {
            List<Event> events = new List<Event>();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Date");
            dt.Columns.Add("Description");
            dt.Columns.Add("ITEC ID");
            dt.Columns.Add("Category ID");
            dt.Columns.Add("Venue ID");
            dt.Columns.Add("Committee ID");

            if (CategoryIDComboBox.Text == "None")
            {
                events = EventDL.GetEventsByNullCategoryID();
            }
            else
            {
                events = EventDL.GetEventsByCategoryID(int.Parse(CategoryIDComboBox.Text));
            }
            foreach (Event evn in events)
            {
                string description = string.IsNullOrEmpty(evn.description) ? "NULL" : evn.description;
                string ITECIDValue = evn.ITECID == -1 ? "NULL" : evn.ITECID.ToString();
                string categoryIDValue = evn.categoryID == -1 ? "NULL" : evn.categoryID.ToString();
                string venueIDValue = evn.venueID == -1 ? "NULL" : evn.venueID.ToString();
                string committeeIDValue = evn.committeeID == -1 ? "NULL" : evn.committeeID.ToString();
                dt.Rows.Add(evn.ID, evn.name, evn.date.ToShortDateString(), description, ITECIDValue, categoryIDValue, venueIDValue, committeeIDValue);
            }

            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = false;
        }

        private void SearchVenueID_Click(object sender, EventArgs e)
        {
            List<Event> events = new List<Event>();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Date");
            dt.Columns.Add("Description");
            dt.Columns.Add("ITEC ID");
            dt.Columns.Add("Category ID");
            dt.Columns.Add("Venue ID");
            dt.Columns.Add("Committee ID");

            if (VenueIDComboBox.Text == "None")
            {
                events = EventDL.GetEventsByNullVenueID();
            }
            else
            {
                events = EventDL.GetEventsByVenueID(int.Parse(VenueIDComboBox.Text));
            }
            foreach (Event evn in events)
            {
                string description = string.IsNullOrEmpty(evn.description) ? "NULL" : evn.description;
                string ITECIDValue = evn.ITECID == -1 ? "NULL" : evn.ITECID.ToString();
                string categoryIDValue = evn.categoryID == -1 ? "NULL" : evn.categoryID.ToString();
                string venueIDValue = evn.venueID == -1 ? "NULL" : evn.venueID.ToString();
                string committeeIDValue = evn.committeeID == -1 ? "NULL" : evn.committeeID.ToString();
                dt.Rows.Add(evn.ID, evn.name, evn.date.ToShortDateString(), description, ITECIDValue, categoryIDValue, venueIDValue, committeeIDValue);
            }

            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = false;
        }

        private void SearchCommitteeID_Click(object sender, EventArgs e)
        {
            List<Event> events = new List<Event>();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Date");
            dt.Columns.Add("Description");
            dt.Columns.Add("ITEC ID");
            dt.Columns.Add("Category ID");
            dt.Columns.Add("Venue ID");
            dt.Columns.Add("Committee ID");

            if (CommitteeIDComboBox.Text == "None")
            {
                events = EventDL.GetEventsByNullCommitteeID();
            }
            else
            {
                events = EventDL.GetEventsByCommitteeID(int.Parse(CommitteeIDComboBox.Text));
            }
            foreach (Event evn in events)
            {
                string description = string.IsNullOrEmpty(evn.description) ? "NULL" : evn.description;
                string ITECIDValue = evn.ITECID == -1 ? "NULL" : evn.ITECID.ToString();
                string categoryIDValue = evn.categoryID == -1 ? "NULL" : evn.categoryID.ToString();
                string venueIDValue = evn.venueID == -1 ? "NULL" : evn.venueID.ToString();
                string committeeIDValue = evn.committeeID == -1 ? "NULL" : evn.committeeID.ToString();
                dt.Rows.Add(evn.ID, evn.name, evn.date.ToShortDateString(), description, ITECIDValue, categoryIDValue, venueIDValue, committeeIDValue);
            }

            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            isOtherTable = false;
        }
    }
}
