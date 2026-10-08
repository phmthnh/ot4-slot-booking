namespace SlotBooking
{
    public partial class MainForm : Form
    {
        // Danh sách button vị trí (20 nút)
        private readonly List<Button> _seatButtons = new();
        // Tập chứa index các ghế đã bị khóa (đỏ)
        private readonly HashSet<int> _lockedSeats = new() { 2, 7, 13 }; // 3 ghế mẫu bị khóa

        // Giá theo khung giờ
        private readonly Dictionary<string, decimal> _prices = new()
        {
            { "Sáng (100.000đ)",  100_000m },
            { "Tối (150.000đ)",   150_000m }
        };

        public MainForm()
        {
            InitializeComponent();
            InitSeats();
            cboTimeSlot.SelectedIndex = 0;
        }

        // Khởi tạo 20 button ghế bằng vòng lặp
        private void InitSeats()
        {
            int cols = 5;
            int rows = 4;
            int btnW = 70;
            int btnH = 55;
            int padX = 10;
            int padY = 10;

            for (int i = 0; i < rows * cols; i++)
            {
                int row = i / cols;
                int col = i % cols;

                var btn = new Button
                {
                    Name = $"btnSeat{i}",
                    Text = $"A{i + 1}",
                    Tag  = i,
                    Size = new System.Drawing.Size(btnW, btnH),
                    Location = new System.Drawing.Point(padX + col * (btnW + 6), padY + row * (btnH + 6)),
                    FlatStyle = FlatStyle.Flat,
                    Font = new System.Drawing.Font("Segoe UI", 8F)
                };

                if (_lockedSeats.Contains(i))
                {
                    // Đỏ = đã có người đặt
                    btn.BackColor = System.Drawing.Color.IndianRed;
                    btn.ForeColor = System.Drawing.Color.White;
                    btn.Enabled = false;
                }
                else
                {
                    // Trắng/xám nhạt = trống
                    btn.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
                    btn.ForeColor = System.Drawing.Color.Black;
                    btn.Click += Seat_Click;
                }

                pnlSeats.Controls.Add(btn);
                _seatButtons.Add(btn);
            }
        }

        // Xử lý click chọn/bỏ chọn ghế
        private void Seat_Click(object? sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            if (btn.BackColor == System.Drawing.Color.MediumSeaGreen)
            {
                // Bỏ chọn → về trắng
                btn.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
                btn.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                // Chọn → xanh lá
                btn.BackColor = System.Drawing.Color.MediumSeaGreen;
                btn.ForeColor = System.Drawing.Color.White;
            }

            UpdateStats();
        }

        // Cập nhật thống kê realtime
        private void UpdateStats()
        {
            int count = _seatButtons.Count(b => b.BackColor == System.Drawing.Color.MediumSeaGreen);
            decimal unitPrice = _prices.ContainsKey(cboTimeSlot.Text) ? _prices[cboTimeSlot.Text] : 100_000m;
            decimal total = count * unitPrice;

            lblSelectedCount.Text = $"Số vị trí đang chọn: {count}";
            lblTotalPrice.Text    = $"Tạm tính tiền: {total:N0} VNĐ";
        }

        // Thay đổi khung giờ → cập nhật tạm tính
        private void cboTimeSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStats();
        }

        // Xác nhận đặt
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var chosen = _seatButtons
                .Where(b => b.BackColor == System.Drawing.Color.MediumSeaGreen)
                .Select(b => b.Text)
                .ToList();

            if (chosen.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn vị trí nào.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal unitPrice = _prices.ContainsKey(cboTimeSlot.Text) ? _prices[cboTimeSlot.Text] : 100_000m;
            decimal total = chosen.Count * unitPrice;

            MessageBox.Show(
                $"✅ Đặt thành công!\n\n" +
                $"Khung giờ  : {cboTimeSlot.Text}\n" +
                $"Vị trí đã chọn: {string.Join(", ", chosen)}\n" +
                $"Số lượng   : {chosen.Count}\n" +
                $"Tổng tiền  : {total:N0} VNĐ",
                "Xác nhận đặt chỗ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Đánh dấu ghế đã đặt → đỏ, khóa
            foreach (var btn in _seatButtons.Where(b => b.BackColor == System.Drawing.Color.MediumSeaGreen))
            {
                btn.BackColor = System.Drawing.Color.IndianRed;
                btn.ForeColor = System.Drawing.Color.White;
                btn.Enabled = false;
            }
            UpdateStats();
        }

        // Hủy chọn tất cả
        private void btnCancelAll_Click(object sender, EventArgs e)
        {
            foreach (var btn in _seatButtons.Where(b => b.Enabled && b.BackColor == System.Drawing.Color.MediumSeaGreen))
            {
                btn.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
                btn.ForeColor = System.Drawing.Color.Black;
            }
            UpdateStats();
        }
    }
}
