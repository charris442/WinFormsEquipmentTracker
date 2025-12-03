using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsEquipmentTracker.Data;
using WinFormsEquipmentTracker.Model;

namespace WinFormsEquipmentTracker
{
    public partial class Form1 : Form
    {
        private readonly EquipmentRepository _repo;
        private List<Equipment> _equipmentList;

        public Form1()
        {
            InitializeComponent();
            _repo = new EquipmentRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEquipmentList();
            ClearDetails();
        }

        private void LoadEquipmentList()
        {
            _equipmentList = _repo.GetAllEquipment();

            lst_equipment.DataSource = null;
            lst_equipment.DisplayMember = "Name";
            lst_equipment.ValueMember = "Id";
            lst_equipment.DataSource = _equipmentList;
        }

        private void ClearInputForm()
        {
            txt_eq_name.Text = "";
            txt_eq_location.Text = "";
            txt_eq_status.Text = "";
            txt_eq_notes.Text = "";
            dtp_eq_lastService.Value = DateTime.Today;
        }

        private void ClearDetails()
        {
            lbl_eq_id.Text = "";
            lbl_eq_name.Text = "";
            lbl_eq_location.Text = "";
            lbl_eq_lastService.Text = "";
            lbl_eq_status.Text = "";
            lbl_eq_notes.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string name = txt_eq_name.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required.");
                return;
            }

            var eq = new Equipment
            {
                Name = name,
                Location = txt_eq_location.Text.Trim(),
                LastService = dtp_eq_lastService.Value.Date,
                Status = txt_eq_status.Text.Trim(),
                Notes = txt_eq_notes.Text.Trim()
            };

            _repo.AddEquipment(eq);

            LoadEquipmentList();
            ClearInputForm();

            MessageBox.Show("Equipment saved!");
        }


        private void lst_equipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_equipment.SelectedValue == null)
                return;

            string id = lst_equipment.SelectedValue.ToString();
            var eq = _repo.GetEquipmentById(id);

            if (eq == null) return;

            lbl_eq_id.Text = eq.Id;
            lbl_eq_name.Text = eq.Name;
            lbl_eq_location.Text = eq.Location;
            lbl_eq_status.Text = eq.Status;
            lbl_eq_notes.Text = eq.Notes;

            lbl_eq_lastService.Text = eq.LastService.HasValue
                ? eq.LastService.Value.ToShortDateString()
                : "(none)";
        }
    }
}
