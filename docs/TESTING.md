# Kiểm thử — Bài 4 — Sơ đồ chọn vị trí chỗ ngồi / Đặt bàn

Ngày chạy: 08/10/2026. Môi trường: Windows, .NET SDK 10.0.401.

Đã chạy 12/12 kiểm tra đạt với vi-VN.

Các kiểm tra chạy trên form thật: hiển thị control, gọi handler, nhập/sửa dữ liệu và xử lý MessageBox. Hộp thoại xác nhận được chương trình kiểm tra trả lời Yes/No tự động. Bộ kiểm tra được chạy ngoài repo để không trộn công cụ audit vào bài nộp.

| Kiểm tra đã chạy | Kết quả |
|---|---|
| `no_dynamic_buttons_before_load` | PASS |
| `20_buttons` | PASS |
| `grid_4x5` | PASS |
| `load_idempotent` | PASS |
| `locked_seat_ignored` | PASS |
| `no_seats_warning` | PASS |
| `morning_two` | PASS |
| `evening_two` | PASS |
| `cancel_all` | PASS |
| `confirm_booking` | PASS |
| `confirmed_locked` | PASS |
| `confirmed_seat_ignored` | PASS |

Kết quả chi tiết: [test-results.json](./test-results.json).

## Kiểm tra thêm trước khi nộp

- [ ] Mở solution bằng Visual Studio 2026, chọn MainForm.cs → Shift+F7 và kiểm tra kéo thả trong Toolbox.
- [ ] Chạy F5, đi qua các bước ở README bằng bàn phím/chuột.
- [ ] Kiểm tra giao diện ở DPI/cỡ màn hình đang dùng.
- [x] Đối chiếu đủ 3 ảnh screenshot với kết quả chạy thực tế ngày 08/10/2026.
