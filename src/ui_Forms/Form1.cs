using core;

namespace ui_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static HttpClient sharedClient = new()
        {
            BaseAddress = new Uri("https://localhost:7267/api/"),
        };

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<string> SelectedCategorys = new List<string>();
            List<SearchResponse> list = Search.PostSearchRequest(sharedClient ,txtSearch.Text.ToString(), SelectedCategorys).Result;

            lbSearchResults.Items.Clear();
            foreach (SearchResponse Item in list)
            {
                lbSearchResults.Items.Add(Item.Item_Name);
            }
        }
    }
}