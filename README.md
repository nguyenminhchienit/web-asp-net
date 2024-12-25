# Web ASP.NET Project

## Giới thiệu
Đây là một dự án phát triển ứng dụng web sử dụng công nghệ ASP.NET, được lưu trữ tại [Github Repository](https://github.com/nguyenminhchienit/web-asp-net). Dự án tập trung vào việc xây dựng một ứng dụng web cơ bản với các tính năng chính để quản lý và hiển thị nội dung.

## Các tính năng chính
- **Xây dựng giao diện người dùng**:
  - Thiết kế giao diện với các thành phần hiện đại và thân thiện.
  - Sử dụng các công nghệ hỗ trợ như Bootstrap hoặc CSS để tối ưu hóa trải nghiệm người dùng.

- **Quản lý dữ liệu**:
  - Tích hợp cơ sở dữ liệu SQL Server để lưu trữ và xử lý dữ liệu.
  - Các chức năng CRUD (Create, Read, Update, Delete) cơ bản.

- **Chức năng người dùng**:
  - Hệ thống đăng nhập/đăng ký.
  - Quản lý phiên làm việc của người dùng.

## Yêu cầu hệ thống
### Phần mềm:
- **Hệ điều hành**: Windows 10 trở lên.
- **Công cụ phát triển**: Visual Studio 2022 hoặc mới hơn.
- **Framework**: .NET Framework 6.0 hoặc mới hơn.
- **Cơ sở dữ liệu**: SQL Server 2019 hoặc mới hơn.

### Phần cứng:
- CPU: Intel Core i3 hoặc tương đương.
- RAM: 4GB hoặc cao hơn.
- Dung lượng ổ đĩa: Ít nhất 2GB dung lượng trống.

## Cách cài đặt
1. Clone repository về máy tính:
   ```bash
   git clone https://github.com/nguyenminhchienit/web-asp-net.git
   ```

2. Mở dự án trong Visual Studio.

3. Cấu hình chuỗi kết nối cơ sở dữ liệu trong file `appsettings.json`:
   ```json
   {
       "ConnectionStrings": {
           "DefaultConnection": "Server=your_server_name;Database=your_database_name;User Id=your_username;Password=your_password;"
       }
   }
   ```

4. Khởi tạo cơ sở dữ liệu:
   - Sử dụng Entity Framework để thực hiện migrations:
     ```bash
     dotnet ef database update
     ```

5. Chạy ứng dụng:
   - Nhấn **F5** trong Visual Studio để khởi chạy ứng dụng.

## Cách sử dụng
1. Mở trình duyệt và truy cập vào đường dẫn mặc định: `http://localhost:5000`.
2. Đăng nhập hoặc đăng ký tài khoản để sử dụng các chức năng.
3. Thực hiện các thao tác quản lý dữ liệu hoặc tương tác với các tính năng của ứng dụng.

## Đóng góp
Nếu bạn muốn đóng góp vào dự án, vui lòng làm theo các bước sau:
1. Fork repository.
2. Tạo branch mới cho tính năng hoặc sửa lỗi: `git checkout -b feature-name`.
3. Commit thay đổi của bạn: `git commit -m "Mô tả thay đổi"`.
4. Push branch lên repository của bạn: `git push origin feature-name`.
5. Tạo pull request về repository chính.

## Liên hệ
- **Tác giả**: Nguyễn Minh Chiến
- **Email**: [nguyenminhchienit@example.com](mailto:nguyenminhchienit@example.com)
- **Github**: [nguyenminhchienit](https://github.com/nguyenminhchienit)

## Giấy phép
Dự án này được phát hành dưới giấy phép MIT. Xem thêm thông tin trong file [LICENSE](./LICENSE).
