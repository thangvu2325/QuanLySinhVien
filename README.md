# QuanLySinhVien
HI THIS IS THE PROJECT THAT ME AND THANG VU HAVE CREATE TO MANAGE STUDENT POINTS 

THE REQUIRE OF THIS PROJECT BELLOW:

Quản lý điểm sinh viên :
Ta tổ chức các danh sách sau:
- Danh sách môn học: cây nhị phân tìm kiếm (MAMH (C10) , TENMH, STCLT (số tín
chỉ lý thuyết), STCTH (số tín chỉ thực hành))
- Danh sách Lop : danh sách tuyến tính là 1 mảng con trỏ(MALOP (C15), TENLOP,
Năm nhập học, con trỏ dssv): con trỏ dssv sẻ trỏ đến danh sách sinh viên thuộc lớp đó.
- Danh sách sinh viên : danh sách liên kết đơn (MASV, HO, TEN, PHAI, SODT, con
trỏ): con trỏ sẻ trỏ đến danh sách điểm các môn của sinh viên đó
- Danh sách Điểm (danh sách liên kết đơn): ( MAMH, LAN, DIEM)
Chương trình có các chức năng sau :

a. NhapLop : cho phép cập nhật (thêm / xóa / hiệu chỉnh ) thông tin của lớp

b. In danh saùch Lôùp cuûa tröôøng theo 1 nieân khoùa naøo ñoù

c. NhapSV : Cập nhập sinh viên của 1 lớp: nhập vào mã lớp trước, sau đó nhập các sinh
viên vào lớp đó.

Lưu ý : Khi nhập liệu phải đủ 3 chức năng Thêm / Xóa / Hiệu chỉnh
Quá trình nhập SV mới sẽ dừng khi ta nhập vào mã sv là chuỗi rỗng.
d. In DSSV của 1 lớp (dựa vào mã lớp) theo thứ tự alphabet tăng dần của tên+họ ,

e. Nhập môn học: cho phép cập nhật (thêm / xóa / hiệu chỉnh ) thông tin của môn học

f. In DS môn học : tăng dần theo tên môn học.

g. Nhập điểm: User nhập vào mã lớp, mã môn học, lần thi. Căn cứ vào 3 giá trị này,
chương trình sẽ tự động lọc ra danh sách sv sẽ thi, và in ra màn hình danh sách theo dạng
sau :
STT MASV HO TEN DIEM
99 XXXX XXXXXXXXXXX XXXXX 5
99 XXXX XXXXXXXXXXX XXXXX 6
Bốn cột đầu đã có sẵn dữ liệu, lúc này user chỉ việc nhập điểm hoặc hiệu chỉnh điểm trực
tiếp vào khung.

h. In bảng điểm môn học của 1 lớp theo lần thi: User nhập vào mã lớp, mã môn học, lần
thi, chương trình sẽ in ra bảng điểm đã thi . Kết quả trên màn hình:
BẢNG ĐIỂM MÔN HỌC
Lớp : <tenlop> Lần thi : 99
Môn học: <tenmon>
STT MASV HO TEN DIEM
99 XXXX XXXXXXXXXXX XXXXX 99
99 XXXX XXXXXXXXXXX XXXXX 99i. In điểm trung bình kết thúc khóa học của 1 lớp theo số tín chỉ. Kết xuất:
BẢNG THỐNG KÊ ĐIỂM TRUNG BÌNH KHÓA HỌC
Lớp : <tenlop> Năm nhập học: 9999
STT MASV HO TEN Điểm TB
99 XXXX XXXXXXXXXXX XXXXX 99.9
99 XXXX XXXXXXXXXXX XXXXX 99.9
  
THANK FOR THE SUPPORT OF CHAT GPT AND OUR EFFORT
