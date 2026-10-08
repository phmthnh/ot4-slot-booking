namespace SlotBooking
{
    public partial class MainForm : Form
    {
        private readonly List<Button> _seatButtons = new();
        private readonly HashSet<int> _lockedSeats = new() { 2, 7, 13 };
        private readonly HashSet<int> _selectedSeats = new();
        private decimal UnitPrice => cboTimeSlot.SelectedIndex == 1 ? 150_000m : 100_000m;

        public MainForm() { InitializeComponent(); }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            InitSeats();
            cboTimeSlot.SelectedIndex = 0;
            UpdateStats();
        }

        private void InitSeats()
        {
            if (_seatButtons.Count > 0) return;
            for (int i = 0; i < 20; i++)
            {
                var button = new Button
                {
                    Name = $"btnSeat{i}", Text = $"A{i + 1}", Tag = i,
                    Dock = DockStyle.Fill, Margin = new Padding(6),
                    FlatStyle = FlatStyle.Flat, TabIndex = i,
                    UseVisualStyleBackColor = false
                };
                // Cả 20 nút dùng chung handler, kể cả nút đã khóa.
                button.Click += Seat_Click;
                _seatButtons.Add(button);
                pnlSeats.Controls.Add(button, i % 5, i / 5);
                RenderSeat(button);
            }
        }

        private void RenderSeat(Button button)
        {
            int id = (int)button.Tag!;
            bool locked = _lockedSeats.Contains(id);
            button.Enabled = !locked;
            button.BackColor = locked ? Color.IndianRed
                : _selectedSeats.Contains(id) ? Color.MediumSeaGreen : Color.FromArgb(240, 240, 240);
            button.ForeColor = locked || _selectedSeats.Contains(id) ? Color.White : Color.Black;
        }

        private void Seat_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button || button.Tag is not int id || _lockedSeats.Contains(id)) return;
            if (!_selectedSeats.Add(id)) _selectedSeats.Remove(id);
            RenderSeat(button);
            UpdateStats();
        }

        private void UpdateStats()
        {
            lblSelectedCount.Text = $"Số vị trí đang chọn: {_selectedSeats.Count}";
            lblTotalPrice.Text = $"Tạm tính tiền: {_selectedSeats.Count * UnitPrice:N0} VNĐ";
        }

        private void cboTimeSlot_SelectedIndexChanged(object? sender, EventArgs e) => UpdateStats();

        private void btnConfirm_Click(object? sender, EventArgs e)
        {
            if (_selectedSeats.Count == 0)
            {
                MessageBox.Show(this, "Bạn chưa chọn vị trí nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string seats = string.Join(", ", _selectedSeats.OrderBy(id => id).Select(id => $"A{id + 1}"));
            MessageBox.Show(this, $"Đặt thành công!\n\nKhung giờ: {cboTimeSlot.Text}\nVị trí: {seats}\n"
                + $"Số lượng: {_selectedSeats.Count}\nTổng tiền: {_selectedSeats.Count * UnitPrice:N0} VNĐ",
                "Xác nhận đặt chỗ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _lockedSeats.UnionWith(_selectedSeats);
            _selectedSeats.Clear();
            foreach (var button in _seatButtons) RenderSeat(button);
            UpdateStats();
        }

        private void btnCancelAll_Click(object? sender, EventArgs e)
        {
            _selectedSeats.Clear();
            foreach (var button in _seatButtons) RenderSeat(button);
            UpdateStats();
        }
    }
}
