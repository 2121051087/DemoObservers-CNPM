// See https://aka.ms/new-console-template for more information
using DemoObservers;



Console.OutputEncoding = System.Text.Encoding.UTF8;
// Tạo sản phẩm
var product = new Product { ProductID = 1, Name = "iPhone 15", Price = 1000m };

    // Tạo người dùng
    var user1 = new User { UserID = 1, Name = @"Hà", Email = "ha@example.com" };
    var user2 = new User { UserID = 2, Name = @"Vượng", Email = "vuong@example.com" };

    // Người dùng theo dõi sản phẩm
    product.Attach(user1);
    product.Attach(user2);

    // Cập nhật giá sản phẩm
    Console.WriteLine(@"Thay đổi giá sản phẩm:");
    product.Price = 950m; // Giá giảm, thông báo được gửi
    product.Price = 900m; // Giá tiếp tục giảm, thông báo được gửi

    // Người dùng ngừng theo dõi
    product.Detach(user1);

    Console.WriteLine("Thay đổi giá sản phẩm lần nữa:");
    product.Price = 850m; // Chỉ thông báo cho user2
