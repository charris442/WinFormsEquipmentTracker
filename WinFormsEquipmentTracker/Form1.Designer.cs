namespace WinFormsEquipmentTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_title = new System.Windows.Forms.Label();
            this.lst_equipment = new System.Windows.Forms.ListBox();
            this.lbl_eq_id = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.lbl_eq_name = new System.Windows.Forms.Label();
            this.label_location = new System.Windows.Forms.Label();
            this.lbl_eq_location = new System.Windows.Forms.Label();
            this.lbl_eq_notes = new System.Windows.Forms.Label();
            this.label_notes = new System.Windows.Forms.Label();
            this.lbl_eq_status = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.lbl_eq_lastService = new System.Windows.Forms.Label();
            this.label_lastService = new System.Windows.Forms.Label();
            this.Label_Id = new System.Windows.Forms.Label();
            this.label_add_name = new System.Windows.Forms.Label();
            this.txt_eq_name = new System.Windows.Forms.TextBox();
            this.txt_eq_location = new System.Windows.Forms.TextBox();
            this.label_add_location = new System.Windows.Forms.Label();
            this.abel_add_lastService = new System.Windows.Forms.Label();
            this.dtp_eq_lastService = new System.Windows.Forms.DateTimePicker();
            this.txt_eq_notes = new System.Windows.Forms.TextBox();
            this.label_add_notes = new System.Windows.Forms.Label();
            this.txt_eq_status = new System.Windows.Forms.TextBox();
            this.label_add_status = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(12, 28);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(76, 13);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Equipment List";
            // 
            // lst_equipment
            // 
            this.lst_equipment.FormattingEnabled = true;
            this.lst_equipment.Location = new System.Drawing.Point(12, 44);
            this.lst_equipment.Name = "lst_equipment";
            this.lst_equipment.Size = new System.Drawing.Size(177, 290);
            this.lst_equipment.TabIndex = 1;
            this.lst_equipment.SelectedIndexChanged += new System.EventHandler(this.lst_equipment_SelectedIndexChanged);
            // 
            // lbl_eq_id
            // 
            this.lbl_eq_id.AutoSize = true;
            this.lbl_eq_id.Location = new System.Drawing.Point(331, 44);
            this.lbl_eq_id.Name = "lbl_eq_id";
            this.lbl_eq_id.Size = new System.Drawing.Size(15, 13);
            this.lbl_eq_id.TabIndex = 3;
            this.lbl_eq_id.Text = "id";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(275, 66);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 13);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "Name:";
            // 
            // lbl_eq_name
            // 
            this.lbl_eq_name.AutoSize = true;
            this.lbl_eq_name.Location = new System.Drawing.Point(331, 66);
            this.lbl_eq_name.Name = "lbl_eq_name";
            this.lbl_eq_name.Size = new System.Drawing.Size(33, 13);
            this.lbl_eq_name.TabIndex = 5;
            this.lbl_eq_name.Text = "name";
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Location = new System.Drawing.Point(262, 88);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(51, 13);
            this.label_location.TabIndex = 6;
            this.label_location.Text = "Location:";
            // 
            // lbl_eq_location
            // 
            this.lbl_eq_location.AutoSize = true;
            this.lbl_eq_location.Location = new System.Drawing.Point(329, 88);
            this.lbl_eq_location.Name = "lbl_eq_location";
            this.lbl_eq_location.Size = new System.Drawing.Size(44, 13);
            this.lbl_eq_location.TabIndex = 7;
            this.lbl_eq_location.Text = "location";
            // 
            // lbl_eq_notes
            // 
            this.lbl_eq_notes.Location = new System.Drawing.Point(329, 158);
            this.lbl_eq_notes.Name = "lbl_eq_notes";
            this.lbl_eq_notes.Size = new System.Drawing.Size(141, 176);
            this.lbl_eq_notes.TabIndex = 13;
            this.lbl_eq_notes.Text = "notes";
            // 
            // label_notes
            // 
            this.label_notes.AutoSize = true;
            this.label_notes.Location = new System.Drawing.Point(273, 158);
            this.label_notes.Name = "label_notes";
            this.label_notes.Size = new System.Drawing.Size(38, 13);
            this.label_notes.TabIndex = 12;
            this.label_notes.Text = "Notes:";
            // 
            // lbl_eq_status
            // 
            this.lbl_eq_status.AutoSize = true;
            this.lbl_eq_status.Location = new System.Drawing.Point(329, 133);
            this.lbl_eq_status.Name = "lbl_eq_status";
            this.lbl_eq_status.Size = new System.Drawing.Size(35, 13);
            this.lbl_eq_status.TabIndex = 11;
            this.lbl_eq_status.Text = "status";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(273, 133);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(40, 13);
            this.label_status.TabIndex = 10;
            this.label_status.Text = "Status:";
            // 
            // lbl_eq_lastService
            // 
            this.lbl_eq_lastService.AutoSize = true;
            this.lbl_eq_lastService.Location = new System.Drawing.Point(331, 111);
            this.lbl_eq_lastService.Name = "lbl_eq_lastService";
            this.lbl_eq_lastService.Size = new System.Drawing.Size(66, 13);
            this.lbl_eq_lastService.TabIndex = 9;
            this.lbl_eq_lastService.Text = "last serviced";
            // 
            // label_lastService
            // 
            this.label_lastService.AutoSize = true;
            this.label_lastService.Location = new System.Drawing.Point(238, 111);
            this.label_lastService.Name = "label_lastService";
            this.label_lastService.Size = new System.Drawing.Size(75, 13);
            this.label_lastService.TabIndex = 8;
            this.label_lastService.Text = "Last Serviced:";
            // 
            // Label_Id
            // 
            this.Label_Id.AutoSize = true;
            this.Label_Id.Location = new System.Drawing.Point(289, 44);
            this.Label_Id.Name = "Label_Id";
            this.Label_Id.Size = new System.Drawing.Size(24, 13);
            this.Label_Id.TabIndex = 2;
            this.Label_Id.Text = "ID: ";
            // 
            // label_add_name
            // 
            this.label_add_name.AutoSize = true;
            this.label_add_name.Location = new System.Drawing.Point(476, 44);
            this.label_add_name.Name = "label_add_name";
            this.label_add_name.Size = new System.Drawing.Size(35, 13);
            this.label_add_name.TabIndex = 14;
            this.label_add_name.Text = "Name";
            // 
            // txt_eq_name
            // 
            this.txt_eq_name.Location = new System.Drawing.Point(479, 60);
            this.txt_eq_name.Name = "txt_eq_name";
            this.txt_eq_name.Size = new System.Drawing.Size(130, 20);
            this.txt_eq_name.TabIndex = 15;
            // 
            // txt_eq_location
            // 
            this.txt_eq_location.Location = new System.Drawing.Point(479, 110);
            this.txt_eq_location.Name = "txt_eq_location";
            this.txt_eq_location.Size = new System.Drawing.Size(130, 20);
            this.txt_eq_location.TabIndex = 17;
            // 
            // label_add_location
            // 
            this.label_add_location.AutoSize = true;
            this.label_add_location.Location = new System.Drawing.Point(476, 94);
            this.label_add_location.Name = "label_add_location";
            this.label_add_location.Size = new System.Drawing.Size(48, 13);
            this.label_add_location.TabIndex = 16;
            this.label_add_location.Text = "Location";
            // 
            // abel_add_lastService
            // 
            this.abel_add_lastService.AutoSize = true;
            this.abel_add_lastService.Location = new System.Drawing.Point(476, 133);
            this.abel_add_lastService.Name = "abel_add_lastService";
            this.abel_add_lastService.Size = new System.Drawing.Size(66, 13);
            this.abel_add_lastService.TabIndex = 18;
            this.abel_add_lastService.Text = "Last Service";
            // 
            // dtp_eq_lastService
            // 
            this.dtp_eq_lastService.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_eq_lastService.Location = new System.Drawing.Point(479, 149);
            this.dtp_eq_lastService.Name = "dtp_eq_lastService";
            this.dtp_eq_lastService.Size = new System.Drawing.Size(130, 20);
            this.dtp_eq_lastService.TabIndex = 19;
            // 
            // txt_eq_notes
            // 
            this.txt_eq_notes.Location = new System.Drawing.Point(480, 239);
            this.txt_eq_notes.Multiline = true;
            this.txt_eq_notes.Name = "txt_eq_notes";
            this.txt_eq_notes.Size = new System.Drawing.Size(168, 95);
            this.txt_eq_notes.TabIndex = 23;
            // 
            // label_add_notes
            // 
            this.label_add_notes.AutoSize = true;
            this.label_add_notes.Location = new System.Drawing.Point(476, 223);
            this.label_add_notes.Name = "label_add_notes";
            this.label_add_notes.Size = new System.Drawing.Size(35, 13);
            this.label_add_notes.TabIndex = 22;
            this.label_add_notes.Text = "Notes";
            // 
            // txt_eq_status
            // 
            this.txt_eq_status.Location = new System.Drawing.Point(479, 200);
            this.txt_eq_status.Name = "txt_eq_status";
            this.txt_eq_status.Size = new System.Drawing.Size(130, 20);
            this.txt_eq_status.TabIndex = 21;
            // 
            // label_add_status
            // 
            this.label_add_status.AutoSize = true;
            this.label_add_status.Location = new System.Drawing.Point(476, 184);
            this.label_add_status.Name = "label_add_status";
            this.label_add_status.Size = new System.Drawing.Size(37, 13);
            this.label_add_status.TabIndex = 20;
            this.label_add_status.Text = "Status";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(687, 311);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 24;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_eq_notes);
            this.Controls.Add(this.label_add_notes);
            this.Controls.Add(this.txt_eq_status);
            this.Controls.Add(this.label_add_status);
            this.Controls.Add(this.dtp_eq_lastService);
            this.Controls.Add(this.abel_add_lastService);
            this.Controls.Add(this.txt_eq_location);
            this.Controls.Add(this.label_add_location);
            this.Controls.Add(this.txt_eq_name);
            this.Controls.Add(this.label_add_name);
            this.Controls.Add(this.lbl_eq_notes);
            this.Controls.Add(this.label_notes);
            this.Controls.Add(this.lbl_eq_status);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.lbl_eq_lastService);
            this.Controls.Add(this.label_lastService);
            this.Controls.Add(this.lbl_eq_location);
            this.Controls.Add(this.label_location);
            this.Controls.Add(this.lbl_eq_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.lbl_eq_id);
            this.Controls.Add(this.Label_Id);
            this.Controls.Add(this.lst_equipment);
            this.Controls.Add(this.label_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.ListBox lst_equipment;
        private System.Windows.Forms.Label lbl_eq_id;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label lbl_eq_name;
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.Label lbl_eq_location;
        private System.Windows.Forms.Label lbl_eq_notes;
        private System.Windows.Forms.Label label_notes;
        private System.Windows.Forms.Label lbl_eq_status;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label lbl_eq_lastService;
        private System.Windows.Forms.Label label_lastService;
        private System.Windows.Forms.Label Label_Id;
        private System.Windows.Forms.Label label_add_name;
        private System.Windows.Forms.TextBox txt_eq_name;
        private System.Windows.Forms.TextBox txt_eq_location;
        private System.Windows.Forms.Label label_add_location;
        private System.Windows.Forms.Label abel_add_lastService;
        private System.Windows.Forms.DateTimePicker dtp_eq_lastService;
        private System.Windows.Forms.TextBox txt_eq_notes;
        private System.Windows.Forms.Label label_add_notes;
        private System.Windows.Forms.TextBox txt_eq_status;
        private System.Windows.Forms.Label label_add_status;
        private System.Windows.Forms.Button btn_save;
    }
}

