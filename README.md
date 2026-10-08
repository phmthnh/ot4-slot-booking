# BÁO CÁO BÀI TẬP / ĐỒ ÁN

## THÔNG TIN SINH VIÊN
- **Họ và tên:** Phạm Tuấn Thành
- **Mã số sinh viên:** 24810320264
- **Tên môn học:** Lập trình C# / Windows Forms
- **Tên bài tập:** BT4 - Sơ đồ chọn vị trí chỗ ngồi / Đặt bàn

---

## MÔ TẢ BÀI TẬP
Ứng dụng chọn vị trí chỗ ngồi tương tác với sơ đồ ma trận 4×5 (20 vị trí).

**Tính năng:**
- Tự động sinh 20 Button vị trí bằng vòng lặp `for` tại `Form_Load`
- Quản lý màu trạng thái: Xám (Trống) → Xanh lá (Đang chọn) → Đỏ (Đã đặt)
- Thống kê realtime: số vị trí đang chọn + tạm tính tiền theo khung giờ
- Chọn khung giờ: Sáng 100.000đ / Tối 150.000đ
- Xác nhận đặt → khóa ghế đỏ
- Hủy chọn tất cả

---

## KẾT QUẢ THỰC HÀNH

### 1. Ảnh màn hình Giao diện chính
![Giao diện chính](./screenshots/main_ui.png)

### 2. Ảnh màn hình Chức năng thực thi / Kết quả
![Thực thi chức năng](./screenshots/execution_result.png)

### 3. Ảnh màn hình Kiểm tra lỗi (Validation)
![Kiểm tra lỗi](./screenshots/validation_error.png)

---

## CÁCH CHẠY
- Yêu cầu: .NET 10.0 SDK + Windows
- Mở file `SlotBooking.sln` bằng Visual Studio 2022/2026
- Nhấn **F5** để chạy
