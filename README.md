
🛒 ****eShop - Blazor Server Application**
👩‍🎓 Thông tin sinh viên
```text
Thông tin	Nội dung
Họ và tên:	Lê Thị Linh
Mã sinh viên:	23K4080020
Lớp:	K57 Tin học kinh tế
Trường	Đại học Kinh tế Huế
Ngành	Hệ thống thông tin quản lý
Môn học	Lập trình ứng dụng Web
```

📌 Giới thiệu dự án
eShop là ứng dụng website bán hàng được xây dựng bằng Blazor Server trên nền tảng .NET 6 và ngôn ngữ lập trình C#.
Dự án mô phỏng các chức năng cơ bản của một hệ thống thương mại điện tử, cho phép khách hàng tìm kiếm sản phẩm, xem thông tin sản phẩm, quản lý giỏ hàng và thực hiện đặt hàng. Bên cạnh đó, hệ thống còn cung cấp khu vực quản trị để theo dõi và xử lý các đơn hàng của khách hàng.
Ứng dụng được tổ chức thành nhiều project riêng biệt nhằm phân tách phần nghiệp vụ, giao diện và truy xuất dữ liệu, giúp mã nguồn rõ ràng và dễ quản lý hơn.
✨ Chức năng chính
🛍️ Khách hàng
- Xem danh sách sản phẩm.
- Tìm kiếm sản phẩm theo tên.
- Xem thông tin chi tiết sản phẩm.
- Thêm sản phẩm vào giỏ hàng.
- Xem các sản phẩm đã thêm vào giỏ hàng.
- Thay đổi số lượng sản phẩm trong giỏ hàng.
- Xóa sản phẩm khỏi giỏ hàng.
- Thực hiện đặt hàng.
- Xem thông tin xác nhận đơn hàng.
👨‍💼 Quản trị viên
- Đăng nhập vào khu vực quản trị.
- Xem danh sách các đơn hàng cần xử lý.
- Xem thông tin chi tiết của từng đơn hàng.
- Xử lý đơn hàng.
- Theo dõi danh sách các đơn hàng đã được xử lý.
🏗️ Cấu trúc dự án
Dự án được chia thành các thành phần chính như sau:
```text
eShop
│
├── eShop.CoreBusiness
│   ├── Models
│   └── Services
│
├── eShop.Usecases
│   ├── PluginInterfaces
│   ├── SearchProductScreen
│   ├── ViewProductScreen
│   ├── ShoppingCartScreen
│   ├── OrderConfirmationScreen
│   └── AdminPortal
│
├── Plugins
│   ├── eShop.DataStore.HardCode
│   ├── eShop.DataStore.SQL.Dapper
│   ├── eShop.ShoppingCart.Local
│   └── eShop.StateStore.DI
│
├── eShop.Web.Modules
│   ├── eShop.Web.Common
│   ├── eShop.Web.CustomerPotal
│   └── eShop.Web.AdminPortal
│
└── eShop.Web
    ├── Controllers
    ├── Pages
    ├── Shared
    ├── wwwroot
    ├── appsettings.json
    └── Program.cs
```
Vai trò của các thành phần
- eShop.CoreBusiness: chứa các đối tượng và logic nghiệp vụ chính của hệ thống.
- eShop.Usecases: chứa các chức năng và luồng xử lý nghiệp vụ của ứng dụng.
- Plugins: chứa các thành phần liên quan đến lưu trữ dữ liệu, truy xuất cơ sở dữ liệu và quản lý trạng thái.
- eShop.Web.Modules: chứa các thành phần giao diện được tách riêng cho khách hàng và quản trị viên.
- eShop.Web: project Blazor Server chính, chịu trách nhiệm khởi chạy và cấu hình toàn bộ ứng dụng.
🛠️ Công nghệ sử dụng
```text
Công nghệ	            Vai trò
C#	                    Ngôn ngữ lập trình chính
.NET 6	                Nền tảng phát triển ứng dụng
Blazor Server	        Xây dựng ứng dụng web
Razor Components	    Xây dựng các thành phần giao diện
SQL Server	            Lưu trữ dữ liệu
Dapper	                Hỗ trợ truy xuất dữ liệu từ SQL Server
Dependency Injection	Quản lý và cung cấp các service trong ứng dụng
LocalStorage	        Lưu trữ trạng thái giỏ hàng
Bootstrap	            Hỗ trợ xây dựng và định dạng giao diện
HTML/CSS	            Thiết kế giao diện website
```

🔄 Luồng hoạt động
Quy trình mua hàng cơ bản của hệ thống:
```text
Khách hàng
    ↓
Xem / tìm kiếm sản phẩm
    ↓
Xem thông tin sản phẩm
    ↓
Thêm sản phẩm vào giỏ hàng
    ↓
Kiểm tra và cập nhật giỏ hàng
    ↓
Đặt hàng
    ↓
Tạo đơn hàng
    ↓
Quản trị viên tiếp nhận đơn hàng
    ↓
Kiểm tra và xử lý đơn hàng
```

🎯 Mục tiêu thực hiện
Thông qua việc xây dựng dự án eShop, sinh viên có thể vận dụng các kiến thức đã học vào quá trình phát triển một ứng dụng web hoàn chỉnh, bao gồm:
- Thực hành lập trình ứng dụng web bằng Blazor Server.
- Vận dụng ngôn ngữ lập trình C# và nền tảng .NET 6.
- Làm quen với cách tổ chức một solution gồm nhiều project.
- Hiểu cách phân tách phần giao diện, nghiệp vụ và truy xuất dữ liệu.
- Sử dụng Dependency Injection trong ứng dụng .NET.
- Thực hành lưu trữ và truy xuất dữ liệu.
- Xây dựng chức năng giỏ hàng và đặt hàng.
- Xây dựng chức năng quản lý và xử lý đơn hàng cho quản trị viên.
