
namespace SE1617_Win.GUI
{
    partial class ShowAddEditGUI
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
            this.lbRoom = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbSlot = new System.Windows.Forms.Label();
            this.lbFilm = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.cboSlot = new System.Windows.Forms.ComboBox();
            this.cboFilm = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Location = new System.Drawing.Point(101, 32);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(52, 20);
            this.lbRoom.TabIndex = 0;
            this.lbRoom.Text = "Room:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(101, 89);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(44, 20);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Date:";
            // 
            // lbSlot
            // 
            this.lbSlot.AutoSize = true;
            this.lbSlot.Location = new System.Drawing.Point(101, 153);
            this.lbSlot.Name = "lbSlot";
            this.lbSlot.Size = new System.Drawing.Size(38, 20);
            this.lbSlot.TabIndex = 2;
            this.lbSlot.Text = "Slot:";
            // 
            // lbFilm
            // 
            this.lbFilm.AutoSize = true;
            this.lbFilm.Location = new System.Drawing.Point(101, 222);
            this.lbFilm.Name = "lbFilm";
            this.lbFilm.Size = new System.Drawing.Size(40, 20);
            this.lbFilm.TabIndex = 3;
            this.lbFilm.Text = "Film:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(101, 296);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(44, 20);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "Price:";
            // 
            // cboRoom
            // 
            this.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(228, 32);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(236, 28);
            this.cboRoom.TabIndex = 6;
            // 
            // cboSlot
            // 
            this.cboSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSlot.FormattingEnabled = true;
            this.cboSlot.Location = new System.Drawing.Point(228, 153);
            this.cboSlot.Name = "cboSlot";
            this.cboSlot.Size = new System.Drawing.Size(236, 28);
            this.cboSlot.TabIndex = 7;
            // 
            // cboFilm
            // 
            this.cboFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilm.FormattingEnabled = true;
            this.cboFilm.Location = new System.Drawing.Point(228, 222);
            this.cboFilm.Name = "cboFilm";
            this.cboFilm.Size = new System.Drawing.Size(236, 28);
            this.cboFilm.TabIndex = 8;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(228, 89);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(236, 27);
            this.dtpDate.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(228, 296);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(236, 27);
            this.txtPrice.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(152, 377);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(370, 377);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ShowAddEditGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cboFilm);
            this.Controls.Add(this.cboSlot);
            this.Controls.Add(this.cboRoom);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbFilm);
            this.Controls.Add(this.lbSlot);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ShowAddEditGUI";
            this.ShowInTaskbar = false;
            this.Text = "ShowAddEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbSlot;
        private System.Windows.Forms.Label lbFilm;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.ComboBox cboSlot;
        private System.Windows.Forms.ComboBox cboFilm;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}