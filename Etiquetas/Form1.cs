using System.Text.Json;

namespace Etiquetas
{
    public partial class Form1 : Form
    {
        int posY = 0;
        int posX = 0;
        public Form1()
        {
            InitializeComponent();
            daikinPartN_tbl.Visible = false;
            SetupDataGridView();
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            moveFrm(e);
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            moveFrm(e);
        }

        private void CloseLbl_MouseHover(object sender, EventArgs e)
        {
            CloseLbl.ForeColor = Color.Red;
        }

        private void CloseLbl_MouseLeave(object sender, EventArgs e)
        {
            CloseLbl.ForeColor = Color.White;
        }

        private void CloseLbl_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void txtSupplierP_N_MouseClick(object sender, MouseEventArgs e)
        {
            resetText(txtSupplierP_N, "Supplier Part Number");
        }

        private void txtSupplierP_N_TextChanged(object sender, EventArgs e)
        {
            lblSupplierPartNumber.Visible = true;

            txtSupplierP_N.ForeColor = Color.FromArgb(250, 250, 250);
            txtSupplierP_N.Font = new Font("Arial", 14.25f, FontStyle.Bold);
        }

        private void resetText(TextBox txt1, string text)
        {
            if (txt1.Text == text)
            {
                txt1.Text = "";
                txt1.ForeColor = Color.FromArgb(250, 250, 250);
                txt1.Font = new Font("Arial", 14.25f, FontStyle.Bold);

                lblSupplierPartNumber.Visible = true;
            }
        }

        private void minimizeLbl_MouseHover(object sender, EventArgs e)
        {
            minimizeLbl.ForeColor = Color.Red;
        }

        private void minimizeLbl_MouseLeave(object sender, EventArgs e)
        {
            minimizeLbl.ForeColor = Color.White;
        }

        private void minimizeLbl_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void moveFrm(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + e.X - posX;
                Top = Top + (e.Y - posY);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSupplierP_N.Text) || txtSupplierP_N.Text == "Supplier Part Number")
            {
                MessageBox.Show("Please enter a Supplier Part Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            daikinPartN_tbl.Visible = true;
            await GetDataFromApi();
        }

        private void SetupDataGridView()
        {
            daikinPartN_tbl.Columns.Clear();

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Print";
            btnColumn.Name = "Print";
            btnColumn.Text = "Print";
            btnColumn.UseColumnTextForButtonValue = true;

            daikinPartN_tbl.Columns.Add(btnColumn);
            daikinPartN_tbl.Columns.Add("SupplierPartNumber", "Supplier Part Number");
            daikinPartN_tbl.Columns.Add("DaikinPartNumber", "Daikin Part Number");

            daikinPartN_tbl.CellClick += daikinPartN_tbl_CellClick;
        }

        private async Task GetDataFromApi()
        {
            using (HttpClient client = new HttpClient())
            {
                string supplierPartNumber = txtSupplierP_N.Text.Trim();
                string url = $"https://azuappsrvuat01v.mcquay.com/SupportDashboard/Home/GetReportData?id=2167&parameters={{\"supplier_part_number\":\"{supplierPartNumber}\"}}";

                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    ProcessApiResponse(responseBody);
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Error en la solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ProcessApiResponse(string jsonResponse)
        {
            try
            {
                daikinPartN_tbl.Rows.Clear();

                var results = JsonSerializer.Deserialize<List<Dictionary<string, object>>>(jsonResponse);

                foreach (var result in results)
                {
                    daikinPartN_tbl.Rows.Add(
                        "Print",
                        result["Supplier_Part_number"],
                        result["Daikin_Part_Number"]
                    );
                }
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Error procesando la respuesta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void daikinPartN_tbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                string supplierPartNumber = daikinPartN_tbl.Rows[e.RowIndex].Cells["SupplierPartNumber"].Value.ToString();
                string daikinPartNumber = daikinPartN_tbl.Rows[e.RowIndex].Cells["DaikinPartNumber"].Value.ToString();

                HandlePrint(supplierPartNumber, daikinPartNumber);
            }
        }

        private void HandlePrint(string supplierPartNumber, string daikinPartNumber)
        {
            MessageBox.Show($"Imprimiendo etiqueta para:\nSupplier PN: {supplierPartNumber}\nDaikin PN: {daikinPartNumber}");
        }
    }
}