using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObservers
{
    public class User : IObserver
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public void Update(Product product)
        {
            Console.WriteLine($"[Email gửi đến {Name}] Sản phẩm '{product.Name}' hiện có giá mới: {product.Price:C}");
            // Thực tế có thể sử dụng EmailService hoặc SMSService tại đây
        }
    }

}
