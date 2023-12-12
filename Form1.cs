using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace responsijunpromaul
{
    public partial class Form1 : Form
    {

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsijunpro";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from insert_karyawan(:nama_dep_input,:nama_karyawan_input)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("nama_dep_input", cbDep.Text);
                cmd.Parameters.AddWithValue("nama_karyawan_input", tbNama.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data karyawan berhasil disimpan", "NICE!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbNama.Text = cbDep.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                tbNama.Text = r.Cells["nama"].Value.ToString();
                cbDep.Text = r.Cells["nama_dep"].Value.ToString();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "select * from get_karyawan_data()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diubah", "GOOD!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                conn.Open();
                if (int.TryParse(r.Cells["id_karyawan"].Value.ToString(), out int idKaryawan))
                {
                    sql = @"select update_karyawan(:id_karyawan,:nama,:id_dep)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("id_karyawan", idKaryawan);
                        cmd.Parameters.AddWithValue("nama", tbNama.Text);
                        cmd.Parameters.AddWithValue("id_dep", cbDep.Text);
                        if ((int)cmd.ExecuteScalar() == 1)
                        {
                            MessageBox.Show("Data karyawan berhasil diupdate", "WELL DONE!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conn.Close();
                            btnLoad.PerformClick();
                            tbNama.Text = cbDep.Text = null;
                            r = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan dihapus", "GOOD!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Apakah benar Anda ingin menghapus data " + r.Cells["nama"].Value.ToString() + " ?", "Hapus data terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    if (int.TryParse(r.Cells["id_karyawan"].Value.ToString(), out int idKaryawan))
                    {
                        sql = @"select delete_karyawan(:id_karyawan)";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("id_karyawan", idKaryawan);
                            if ((int)cmd.ExecuteScalar() == 1)
                            {
                                MessageBox.Show("Data karyawan berhasil dihapus", "WELL DONE!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                conn.Close();
                                btnLoad.PerformClick();
                                tbNama.Text = cbDep.Text = null;
                                r = null;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID karyawan tidak valid", "DELETE FAILED!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
        }
    }
}