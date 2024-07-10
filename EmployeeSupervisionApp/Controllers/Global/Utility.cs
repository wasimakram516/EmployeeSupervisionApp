using System;
using System.Data;
using System.Text;
using System.Security.Cryptography;

namespace EmployeeSupervisionApp.Controllers.Global
{
    public static class Utility
    {
        // Method to Hash the Password
        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        // Method for showing messages
        public static DialogResult ShowMsg(string msg, string heading, string type)
        {
            MessageBoxIcon icon;
            switch (type)
            {
                case "Success":
                    icon = MessageBoxIcon.Information;
                    break;
                case "Warning":
                    icon = MessageBoxIcon.Warning;
                    break;
                case "Error":
                    icon = MessageBoxIcon.Error;
                    break;
                case "Question":
                    icon = MessageBoxIcon.Question;
                    break;
                default:
                    icon = MessageBoxIcon.None;
                    break;
            }
            return MessageBox.Show(msg, heading, MessageBoxButtons.OK, icon);
        }

        // Method for showing a confirmation dialog
        public static DialogResult ShowConfirmation(string msg, string heading)
        {
            return MessageBox.Show(msg, heading, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        // Method for numbering rows in DataGridView
        public static void SNO(DataGridView gv, string columnName)
        {
            int count = 0;
            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[columnName].Value = count;
            }
        }

        // Method for showing a window
        public static void ShowWindow(Form openWin, Form closeWin)
        {
            closeWin.Close();
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = Form.ActiveForm;
            openWin.Show();
        }

        // Methods for enabling/disabling controls in a panel
        public static void EnableReset(Control container)
        {
            foreach (Control ctr in container.Controls)
            {
                if (ctr is TextBox txt)
                {
                    txt.Enabled = true;
                    txt.Text = "";
                }
                else if (ctr is ComboBox cb)
                {
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                else if (ctr is RadioButton rb)
                {
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                else if (ctr is CheckBox chk)
                {
                    chk.Enabled = true;
                    chk.Checked = false;
                }
                else if (ctr is DateTimePicker dtp)
                {
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
                else if (ctr is Button btn)
                {
                    btn.Enabled = true;
                }
                else if (ctr is PictureBox pic)
                {
                    pic.Image = null;
                }
                else if (ctr is ListBox lb)
                {
                    lb.Enabled = true;
                    lb.ClearSelected();
                }
            }
        }

        public static void Enable(Control container)
        {
            foreach (Control ctr in container.Controls)
            {
                ctr.Enabled = true;
            }
        }

        public static void DisableReset(Control container)
        {
            foreach (Control ctr in container.Controls)
            {
                if (ctr is TextBox txt)
                {
                    txt.Enabled = false;
                    txt.Text = "";
                }
                else if (ctr is ComboBox cb)
                {
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;
                }
                else if (ctr is RadioButton rb)
                {
                    rb.Enabled = false;
                    rb.Checked = false;
                }
                else if (ctr is CheckBox chk)
                {
                    chk.Enabled = false;
                    chk.Checked = false;
                }
                else if (ctr is DateTimePicker dtp)
                {
                    dtp.Enabled = false;
                    dtp.Value = DateTime.Now;
                }
                else if (ctr is Button btn)
                {
                    btn.Enabled = false;
                }
                else if (ctr is PictureBox pic)
                {
                    pic.Image = null;
                }
                else if (ctr is ListBox lb)
                {
                    lb.Enabled = false;
                    lb.ClearSelected();
                }
            }
        }

        public static void Disable(Control container)
        {
            foreach (Control ctr in container.Controls)
            {
                ctr.Enabled = false;
            }
        }

        // Method for fetching dropdown list data with parameters
        public static void GetDropdownListWithParameters(string procedure, ComboBox cb, string displayMember, string valueMember, params (string, object)[] parameters)
        {
            try
            {
                // Implement database connection and fetching logic here
                // This is just a placeholder to show structure
                cb.DataSource = null;
                // SqlCommand com = new SqlCommand(procedure, con)
                // {
                //     CommandType = CommandType.StoredProcedure
                // };
                // foreach (var param in parameters)
                // {
                //     com.Parameters.AddWithValue(param.Item1, param.Item2);
                // }
                // SqlDataAdapter da = new SqlDataAdapter(com);
                // DataTable dt = new DataTable();
                // da.Fill(dt);
                DataTable dt = new DataTable(); // Placeholder for actual data fetching
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "~~~Select~~~" };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                cb.DataSource = dt;
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message, "Error", "Error");
            }
        }
    }
}
