using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTWeb02_Bai2.Models;

namespace LTWeb02_Bai2.Controllers
{
    public class BookController : Controller
    {
        //
        // GET: /Book/


        public List<Models.Book> lstBook = new List<Book>(){
                new Book {imageURL = "/Content/Img/lenaoemkhongbiet.jpg", maSach = "S01", tenSach = "Lẽ Nào Em Không Biết", gia = 64200, tenTG = "Lan Rùa", moTa = "Bạn có còn nhớ về mối tình đầu của mình không? Về lần đầu tiên nắm tay ai đó rụt rè, lần đầu tiên ngại ngùng khi nhận được những món quà be bé trong giờ ra chơi, lần đầu tiên ngóng trông từng con hạc giấy, lần đầu tiên hờn giận, lần đầu tiên vỡ òa… tất cả bỗng ùa về và khiến bạn \"bé\" lại, con tim chợt hẫng đi một nhịp, và mắt bạn chẳng hiểu sao cứ thế nhòe đi."},
                new Book {imageURL = "/Content/Img/em-la-nha-6.jpg", maSach = "S02", tenSach = "Em là nhà", gia = 58800, tenTG = "Lan Rùa", moTa = "Chỉ bằng một giọng văn nhẹ nhàng với một câu chuyện rất thực trong cuộc sống,cuốn sách đã diễn tả thành công mối tình đầy ngọt ngào nhưng cũng không kém phần đắng cay của 2 nhân vật chính:Kiều Như Nguyệt và Hà Quốc Trung."},
                new Book {imageURL = "/Content/Img/khuvuonNgonTu.jpg", maSach = "S03", tenSach = "Khu vườn ngôn từ", gia = 71250, tenTG = "Shinkai Makoto", moTa = "Cuốn sách Khu Vườn Ngôn Từ của tác giả Shinkai Makoto chính là một kiệt tác như thế - một bản tình ca nhẹ nhàng, lãng mạn nhưng cũng đầy day dứt, nơi những cơn mưa không chỉ là biểu tượng mà còn là cầu nối cho những tâm hồn cô đơn tìm thấy nhau."},
                new Book {imageURL = "/Content/Img/nguoitruyenkyuc.jpg", maSach = "S04", tenSach = "Người truyền ký ức", gia = 642000, tenTG = "Lois Lowry", moTa = "\"Người truyền ký ức\" là cuốn tiểu thuyết khoa học viễn tưởng của Lois Lowry mô tả một xã hội tương lai nơi mọi cảm xúc và ký ức được loại bỏ để đạt được sự bình đẳng và ổn định tuyệt đối. Nhân vật chính Jonas được chọn làm Người Tiếp nhận Ký ức và được ông Người Truyền Ký Ức (người đã từng giữ vai trò này) trao cho toàn bộ ký ức của loài người, bao gồm cả niềm vui và nỗi đau, từ đó Jonas nhận ra sự trống rỗng của xã hội mình sống và bắt đầu lên kế hoạch trốn thoát cùng bé Gabriel. "},
                new Book {imageURL = "/Content/Img/daotinh_.jpg", maSach = "S05", tenSach = "Đạo Tình", gia = 77000, tenTG = "Chu Ngọc", moTa = "Cuốn sách audio “Đạo Tình” của tác giả Chu Ngọc đem đến một câu chuyện hấp dẫn với thể loại Ngôn tình, Hắc bang, và Văn học phương Đông. Với những tình tiết đầy kịch tính, cuốn sách chiếm được cảm tình của độc giả trên các diễn đàn với những nhận xét tích cực như “đọc đi đọc lại không chán”, “tiểu thuyết hắc bang kinh điển”. Hãy cùng khám phá và tận hưởng chuyến phiêu lưu trong thế giới bí ẩn của “Đạo Tình”. Mời bạn đọc thưởng thức công trình đặc sắc này của tác giả Chu Ngọc."},
                new Book {imageURL = "/Content/Img/yeu.jpg", maSach = "S06", tenSach = "Yêu", gia = 52200, tenTG = "Duana Welch", moTa = "“Yêu” (tựa gốc “Love Factually”) là quyển sách được viết bởi Duana Welch – một tiến sĩ khoa học xã hội, ứng dụng những nghiên cứu về các mối quan hệ để giải đáp những câu hỏi của mọi người về đời sống riêng tư. Những ý kiến của bà được dựa trên những luận giải cho những nghiên cứu về các mối quan hệ, và sự trải nghiệm cá nhân của bà. “Yêu” là một cuốn sách viết về tình yêu dựa trên nền tảng khoa học vững chắc, mang lại những phương pháp tối ưu cho cuộc sống lứa đôi với những câu chuyện tình yêu đầy thu hút. "},
                new Book {imageURL = "/Content/Img/KyAnAnhTrang.jpg", maSach = "S07", tenSach = "Kỳ Án ánh Trăng", gia = 115500, tenTG = "Trần Hữu Nung", moTa = "Kỳ Án Ánh Trăng (Phiên Bản Mới) Đêm 16 tháng Sáu Luôn có người nhảy lầu… Đã mười sáu năm rồi, cứ vào nửa đêm 16 tháng Sáu là có người tới số, mụ mẫm trèo lên bậu cửa phòng 405, lao đầu xuống sân và chết. Dù được di tản ra ngoài để tránh nạn thì vào thời khắc định mệnh đó, người tới số vẫn mò về, trèo lên bậu cửa phòng 405, lao đầu xuống sân và chết. Dù được canh gác ngăn chặn thì vào thời khắc định mệnh đó, người tới số vẫn tìm cách lọt vào, trèo lên bậu cửa phòng 405, lao đầu xuống sân và chết. Người tới số năm nay là Diệp Hinh."},
                new Book {imageURL = "/Content/Img/CuocsongKoGH.jpg", maSach = "S08", tenSach = "Cuộc sống không giới hạn", gia = 77000, tenTG = "Nick Vujicic", moTa = "\"Cuộc Sống Không Giới Hạn\" là tên một cuốn sách và cũng là triết lý sống của Nick Vujicic, một người sinh ra không có tay chân do hội chứng Tetra-amelia, nhưng đã vượt qua nghịch cảnh để trở thành diễn giả truyền cảm hứng toàn cầu. Cuốn sách mô tả hành trình cá nhân của ông, nhấn mạnh vào sức mạnh tinh thần, sự kiên trì và niềm tin vào bản thân, rằng hoàn cảnh không định đoạt số phận mà chính thái độ sống mới tạo nên sự khác biệt để sống một cuộc đời ý nghĩa và truyền cảm hứng cho người khác. "},
        };

        public ActionResult Index()
        {
            
            return View(lstBook);
        }

        public ActionResult Detail(string id)
        {
            Models.Book info = lstBook.Find(x => x.maSach == id);
            return View(info);
        }

    }
}
