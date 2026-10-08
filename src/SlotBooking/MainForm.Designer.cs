namespace SlotBooking
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpSeats        = new System.Windows.Forms.GroupBox();
            this.pnlSeats        = new System.Windows.Forms.TableLayoutPanel();
            this.grpStats        = new System.Windows.Forms.GroupBox();
            this.lblTimeSlot     = new System.Windows.Forms.Label();
            this.cboTimeSlot     = new System.Windows.Forms.ComboBox();
            this.lblSelectedCount = new System.Windows.Forms.Label();
            this.lblTotalPrice   = new System.Windows.Forms.Label();
            this.lblLegend       = new System.Windows.Forms.Label();
            this.btnConfirm      = new System.Windows.Forms.Button();
            this.btnCancelAll    = new System.Windows.Forms.Button();
            this.grpSeats.SuspendLayout();
            this.grpStats.SuspendLayout();
            this.SuspendLayout();

            // grpSeats
            this.grpSeats.Controls.Add(this.pnlSeats);
            this.grpSeats.Location = new System.Drawing.Point(12, 12);
            this.grpSeats.Name = "grpSeats";
            this.grpSeats.Size = new System.Drawing.Size(420, 340);
            this.grpSeats.TabIndex = 0;
            this.grpSeats.TabStop = false;
            this.grpSeats.Text = "Sơ đồ vị trí (4 × 5)";

            // pnlSeats — ma trận 4 hàng, 5 cột; các nút sinh trong Form_Load.
            this.pnlSeats.ColumnCount = 5;
            this.pnlSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlSeats.RowCount = 4;
            this.pnlSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlSeats.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.pnlSeats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSeats.Location = new System.Drawing.Point(3, 19);
            this.pnlSeats.Name = "pnlSeats";
            this.pnlSeats.Size = new System.Drawing.Size(414, 318);
            this.pnlSeats.TabIndex = 0;

            // grpStats
            this.grpStats.Controls.Add(this.lblTimeSlot);
            this.grpStats.Controls.Add(this.cboTimeSlot);
            this.grpStats.Controls.Add(this.lblSelectedCount);
            this.grpStats.Controls.Add(this.lblTotalPrice);
            this.grpStats.Controls.Add(this.lblLegend);
            this.grpStats.Controls.Add(this.btnConfirm);
            this.grpStats.Controls.Add(this.btnCancelAll);
            this.grpStats.Location = new System.Drawing.Point(445, 12);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(280, 340);
            this.grpStats.TabIndex = 1;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Thống kê & Đặt chỗ";

            // lblTimeSlot
            this.lblTimeSlot.AutoSize = true;
            this.lblTimeSlot.Location = new System.Drawing.Point(12, 30);
            this.lblTimeSlot.Name = "lblTimeSlot";
            this.lblTimeSlot.TabIndex = 0;
            this.lblTimeSlot.Text = "Khung giờ:";

            // cboTimeSlot
            this.cboTimeSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeSlot.Items.AddRange(new object[] { "Sáng (100.000đ)", "Tối (150.000đ)" });
            this.cboTimeSlot.Location = new System.Drawing.Point(12, 52);
            this.cboTimeSlot.Name = "cboTimeSlot";
            this.cboTimeSlot.Size = new System.Drawing.Size(250, 23);
            this.cboTimeSlot.TabIndex = 1;
            this.cboTimeSlot.SelectedIndexChanged += new System.EventHandler(this.cboTimeSlot_SelectedIndexChanged);

            // lblSelectedCount
            this.lblSelectedCount.AutoSize = false;
            this.lblSelectedCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectedCount.Location = new System.Drawing.Point(12, 100);
            this.lblSelectedCount.Name = "lblSelectedCount";
            this.lblSelectedCount.Size = new System.Drawing.Size(250, 30);
            this.lblSelectedCount.TabIndex = 2;
            this.lblSelectedCount.Text = "Số vị trí đang chọn: 0";

            // lblTotalPrice
            this.lblTotalPrice.AutoSize = false;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalPrice.Location = new System.Drawing.Point(12, 138);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(250, 30);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Tạm tính tiền: 0 VNĐ";

            // lblLegend
            this.lblLegend.AutoSize = false;
            this.lblLegend.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLegend.ForeColor = System.Drawing.Color.Gray;
            this.lblLegend.Location = new System.Drawing.Point(12, 180);
            this.lblLegend.Name = "lblLegend";
            this.lblLegend.Size = new System.Drawing.Size(250, 60);
            this.lblLegend.TabIndex = 4;
            this.lblLegend.Text = "⬜ Trắng/Xám = Trống\n🟩 Xanh lá = Đang chọn\n🟥 Đỏ = Đã đặt / Khóa";

            // btnConfirm
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(0, 150, 100);
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(12, 265);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(120, 40);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Xác nhận đặt";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);

            // btnCancelAll
            this.btnCancelAll.BackColor = System.Drawing.Color.FromArgb(120, 100, 120);
            this.btnCancelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAll.ForeColor = System.Drawing.Color.White;
            this.btnCancelAll.Location = new System.Drawing.Point(145, 265);
            this.btnCancelAll.Name = "btnCancelAll";
            this.btnCancelAll.Size = new System.Drawing.Size(120, 40);
            this.btnCancelAll.TabIndex = 6;
            this.btnCancelAll.Text = "Hủy chọn tất cả";
            this.btnCancelAll.UseVisualStyleBackColor = false;
            this.btnCancelAll.Click += new System.EventHandler(this.btnCancelAll_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 370);
            this.Controls.Add(this.grpSeats);
            this.Controls.Add(this.grpStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BT4 - Sơ đồ chọn vị trí chỗ ngồi / Đặt bàn";
            this.Load += new System.EventHandler(this.MainForm_Load);

            this.grpSeats.ResumeLayout(false);
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpSeats;
        private System.Windows.Forms.TableLayoutPanel pnlSeats;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblTimeSlot;
        private System.Windows.Forms.ComboBox cboTimeSlot;
        private System.Windows.Forms.Label lblSelectedCount;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblLegend;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancelAll;
    }
}
