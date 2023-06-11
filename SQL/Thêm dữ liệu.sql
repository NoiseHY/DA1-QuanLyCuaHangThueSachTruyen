--use quanlisach
--go
use master 
go 
use quanlisach
-- The loai
insert into theloai (theloaiID, tenTheloai, motaTheloai)
values 
('TL01', N'Văn học', N'Các tác phẩm văn học'),
('TL02', N'Khoa học', N'Các tác phẩm khoa học'),
('TL03', N'Lịch sử', N'Các tác phẩm về lịch sử');
INSERT INTO theloai (theloaiID, tenTheloai, motaTheloai)
VALUES 
('TL04', N'Tâm lý', N'Các tác phẩm về tâm lý'),
('TL05', N'Truyện ngắn', N'Các truyện ngắn'),
('TL06', N'Trinh thám', N'Các tác phẩm trinh thám'),
('TL07', N'Tự truyện', N'Các tác phẩm tự truyện'),
('TL08', N'Thể thao', N'Các tác phẩm về thể thao');


-- Docgia
insert into docgia (docgiaID, tenDaydu, diachi, email, sodienthoai, ngaysinh, daCanhCao, biCamMuon)
values 
('DG01', N'Nguyễn Văn A', N'123 Nguyễn Du, Q1, TP.HCM', 'nguyenvana@gmail.com', '0123456789', '1990-01-01', '0', '0'),
('DG02', N'Trần Thị B', N'456 Trần Hưng Đạo, Q5, TP.HCM', 'tranthib@gmail.com', '0987654321', '1995-05-05', '1', '0'),
('DG03', N'Lê Văn C', N'789 Lê Lợi, Q3, TP.HCM', 'levanc@gmail.com', '0162874923', '2000-10-10', '1', '1'),
('DG04', N'Nguyễn Thị Thanh Thảo', N'Hàm Tử', 'Thao@gmail.com', '0162845343', '2000-10-10','','');
-- Docgia
INSERT INTO docgia (docgiaID, tenDaydu, diachi, email, sodienthoai, ngaysinh, daCanhCao, biCamMuon)
VALUES 
('DG06', N'Nguyễn Thị Hương', N'789 Trần Phú, Q10, TP.HCM', 'huongnguyen@gmail.com', '0123456789', '1992-03-15', '0', '1'),
('DG07', N'Trần Văn Đức', N'456 Lê Lợi, Q2, TP.HCM', 'ductran@gmail.com', '0987654321', '1998-07-20', '1', '0'),
('DG08', N'Phạm Thị An', N'123 Đinh Tiên Hoàng, Q3, TP.HCM', 'anpham@gmail.com', '0162874923', '2001-11-05', '0', '0'),
('DG09', N'Lê Minh Đức', N'369 Lý Thường Kiệt, Q5, TP.HCM', 'ducle@gmail.com', '0162845343', '1995-09-12', '1', '1'),
('DG010', N'Nguyễn Thị Lan', N'789 Lê Duẩn, Q1, TP.HCM', 'lannguyen@gmail.com', '0123456789', '2000-02-25', '0', '0');


-- Nha xuat ban
insert into nhaxuatban (nhaxuatbanID, tenNhaxuatban, diachi, sodienthoai, email)
values 
('NXB01', N'Kim Đồng', N'12 Nguyễn Du, Q1, TP.HCM', '0123456789', 'info@kimdong.com.vn'),
('NXB02', N'Nhã Nam', N'24 Trần Hưng Đạo, Q5, TP.HCM', '0987654321', 'info@nhanam.com.vn'),
('NXB03', N'Trẻ', N'36 Lê Lợi, Q3, TP.HCM', '0162874923', 'info@tre.com.vn');
insert into nhaxuatban (nhaxuatbanID, tenNhaxuatban, diachi, sodienthoai, email)
values 
('NXB04', N'Kim Thành', N'8 Trần Phú, Q1, TP.HCM', '0123456780', 'info@kimthanh.com.vn');
insert into nhaxuatban (nhaxuatbanID, tenNhaxuatban, diachi, sodienthoai, email)
values 
('NXB05', N'Văn Học', N'45 Hà Nội, Q2, TP.HCM', '0909090909', 'info@vanhoc.com.vn');
insert into nhaxuatban (nhaxuatbanID, tenNhaxuatban, diachi, sodienthoai, email)
values 
('NXB06', N'Tổng Hợp', N'78 Lý Thường Kiệt, Q3, TP.HCM', '0777777777', 'info@tonghop.com.vn');
insert into nhaxuatban (nhaxuatbanID, tenNhaxuatban, diachi, sodienthoai, email)
values 
('NXB07', N'Hà Nội', N'2 Đinh Tiên Hoàng, Q4, TP.HCM', '0888888888', 'info@hanoi.com.vn');
insert into nhaxuatban (nhaxuatbanID, tenNhaxuatban, diachi, sodienthoai, email)
values 
('NXB08', N'Phụ Nữ', N'15 Hai Bà Trưng, Q5, TP.HCM', '0999999999', 'info@phunu.com.vn');


-- TacGia
insert into tacgia (tacgiaID, tenDaydu, quoctich, namSinh)
values 
('TG01', N'Nguyễn Du', N'Việt Nam', 1766),
('TG02', N'Victor Hugo', N'Pháp', 1802),
('TG03', N'Shakespeare', N'Anh', 1564);
insert into tacgia (tacgiaID, tenDaydu, quoctich, namSinh)
values 
('TG04', N'Nguyễn Nhật Ánh', N'Việt Nam', 1955);
insert into tacgia (tacgiaID, tenDaydu, quoctich, namSinh)
values 
('TG05', N'J.K. Rowling', N'Anh', 1965);
insert into tacgia (tacgiaID, tenDaydu, quoctich, namSinh)
values 
('TG06', N'Haruki Murakami', N'Nhật Bản', 1949);
insert into tacgia (tacgiaID, tenDaydu, quoctich, namSinh)
values 
('TG07', N'Toni Morrison', N'Hoa Kỳ', 1931);
insert into tacgia (tacgiaID, tenDaydu, quoctich, namSinh)
values 
('TG08', N'Gabriel Garcia Marquez', N'Colombia', 1927);



-- Sach 
INSERT INTO sach (sachID, tenSach, sotrang, giatien, ngayxuatban, soluong, theloaiID, tacgiaID, nhaxuatbanID, ngonngu) VALUES 
('S001', 'To Kill a Mockingbird', 281, 9.99, '1960-07-11', 50, 'TL01', 'TG01', 'NXB01', 'English'),
('S002', 'The Great Gatsby', 218, 10.99, '1925-04-10', 30, 'TL01', 'TG02', 'NXB02', 'English'),
('S003', 'Pride and Prejudice', 279, 7.99, '1813-01-28', 20, 'TL01', 'TG03', 'NXB01', 'English'),
('S004', 'Crime and Punishment', 430, 12.99, '1866-01-01', 10, 'TL02', 'TG03', 'NXB02', 'Russian'),
('S005', 'One Hundred Years of Solitude', 417, 15.99, '1967-05-30', 15, 'TL02', 'TG03', 'NXB03', 'Spanish'),
('S006', 'The Catcher in the Rye', 234, 8.99, '1951-07-16', 25, 'TL01', 'TG01', 'NXB03', 'English');
INSERT INTO sach (sachID, tenSach, sotrang, giatien, ngayxuatban, soluong, theloaiID, tacgiaID, nhaxuatbanID, ngonngu) VALUES 
('S007', '1984', 328, 110000, '1949-06-08', 40, 'TL03', 'TG04', 'NXB08', 'English');
INSERT INTO sach (sachID, tenSach, sotrang, giatien, ngayxuatban, soluong, theloaiID, tacgiaID, nhaxuatbanID, ngonngu) VALUES 
('S008', 'The Hobbit', 310, 139999, '1937-09-21', 30, 'TL03', 'TG05', 'NXB06', 'English');
INSERT INTO sach (sachID, tenSach, sotrang, giatien, ngayxuatban, soluong, theloaiID, tacgiaID, nhaxuatbanID, ngonngu) VALUES 
('S009', 'Norwegian Wood', 389000, 9.99, '1987-08-04', 20, 'TL04', 'TG06', 'NXB05', 'Japanese');
INSERT INTO sach (sachID, tenSach, sotrang, giatien, ngayxuatban, soluong, theloaiID, tacgiaID, nhaxuatbanID, ngonngu) VALUES 
('S010', 'Beloved', 324, 149900, '1987-09-02', 15, 'TL05', 'TG07', 'NXB05', 'English');
INSERT INTO sach (sachID, tenSach, sotrang, giatien, ngayxuatban, soluong, theloaiID, tacgiaID, nhaxuatbanID, ngonngu) VALUES 
('S011', 'One Hundred Years of Solitude', 417, 159990, '1967-05-30', 12, 'TL02', 'TG08', 'NXB07', 'Spanish');



-- Nha cung cap
INSERT INTO nhacungcap (nhacungcapID, tenNhacungcap, diachi, sodienthoai, email) VALUES 
('NCC001', N'Nhà cung cấp sách ABC', N'123 Đường A, Quận 1, TP.HCM', '0123456789', 'abc@gmail.com'),
('NCC002', N'Nhà cung cấp sách XYZ', N'456 Đường B, Quận 2, TP.HCM', '0987654321', 'xyz@gmail.com'),
('NCC003', N'Nhà cung cấp sách HIK', N'789 Đường C, Quận 3, TP.HCM', '0123456789', 'hik@gmail.com');
INSERT INTO nhacungcap (nhacungcapID, tenNhacungcap, diachi, sodienthoai, email) VALUES 
('NCC004', N'Nhà cung cấp sách DEF', N'111 Đường D, Quận 4, TP.HCM', '0123456780', 'def@gmail.com');
INSERT INTO nhacungcap (nhacungcapID, tenNhacungcap, diachi, sodienthoai, email) VALUES 
('NCC005', N'Nhà cung cấp sách GHI', N'222 Đường E, Quận 5, TP.HCM', '0909090909', 'ghi@gmail.com');
INSERT INTO nhacungcap (nhacungcapID, tenNhacungcap, diachi, sodienthoai, email) VALUES 
('NCC006', N'Nhà cung cấp sách JKL', N'333 Đường F, Quận 6, TP.HCM', '0777777777', 'jkl@gmail.com');
INSERT INTO nhacungcap (nhacungcapID, tenNhacungcap, diachi, sodienthoai, email) VALUES 
('NCC007', N'Nhà cung cấp sách MNO', N'444 Đường G, Quận 7, TP.HCM', '0888888888', 'mno@gmail.com');
INSERT INTO nhacungcap (nhacungcapID, tenNhacungcap, diachi, sodienthoai, email) VALUES 
('NCC008', N'Nhà cung cấp sách PQR', N'555 Đường H, Quận 8, TP.HCM', '0999999999', 'pqr@gmail.com');



--PhieuNhap
INSERT INTO phieunhap (phieunhapID, nhacungcapID, ngayNhaphoadon, tongsotien) VALUES
('PN001', 'NCC001', '2023-04-28', 15000000.0),
('PN002', 'NCC002', '2023-05-05', 20000000.0);
INSERT INTO phieunhap (phieunhapID, nhacungcapID, ngayNhaphoadon, tongsotien) VALUES
('PN003', 'NCC001', '2023-06-10', 18000000.0);
INSERT INTO phieunhap (phieunhapID, nhacungcapID, ngayNhaphoadon, tongsotien) VALUES
('PN004', 'NCC002', '2023-06-15', 25000000.0);



--CtPhieuNhap
INSERT INTO ctPhieunhap (ctPhieunhapID, phieunhapID, sachID, soluong, giabanle) VALUES
('CT001', 'PN001', 'S001', 100, 150000.0),
('CT002', 'PN001', 'S002', 200, 200000.0),
('CT003', 'PN002', 'S003', 150, 300000.0),
('CT004', 'PN002', 'S004', 300, 250000.0);
INSERT INTO ctPhieunhap (ctPhieunhapID, phieunhapID, sachID, soluong, giabanle) VALUES
('CT005', 'PN003', 'S005', 120, 180000.0);
INSERT INTO ctPhieunhap (ctPhieunhapID, phieunhapID, sachID, soluong, giabanle) VALUES
('CT006', 'PN003', 'S006', 80, 150000.0);
INSERT INTO ctPhieunhap (ctPhieunhapID, phieunhapID, sachID, soluong, giabanle) VALUES
('CT007', 'PN004', 'S002', 250, 220000.0);



-- Thêm dữ liệu vào bảng muontra
INSERT INTO muontra (muontraID, docgiaID, ngayMuonsach, ngayTrasach)
VALUES ('MT001', 'DG01', '2023-05-01', '2023-05-08');
INSERT INTO muontra (muontraID, docgiaID, ngayMuonsach, ngayTrasach)
VALUES ('MT002', 'DG01', '2023-05-10', '2023-05-30'),
('MT003', 'DG03', '2023-05-12', '2023-05-30'),
('MT004', 'DG03', '2023-05-13', '2023-05-30'),
('MT005', 'DG02', '2023-05-14', '2023-05-30'),
('MT006', 'DG01', '2023-05-15', '2023-05-30');

INSERT INTO muontra (muontraID, docgiaID, ngayMuonsach, ngayTrasach)
VALUES ('MT007', 'DG01', '2023-05-10', '2023-05-30'),
('MT008', 'DG03', '2023-05-12', '2023-05-30'),
('MT009', 'DG03', '2023-05-13', '2023-05-30'),
('MT0010', 'DG02', '2023-05-14', '2023-05-30'),
('MT0011', 'DG01', '2023-05-15', '2023-05-30');
-- Thêm dữ liệu vào bảng ctMuontra
INSERT INTO ctMuontra (ctMuontraID, muontraID, sachID, soluongSachMuon, soluongSachTra)
VALUES ('CTMT001', 'MT001', 'S001', 2, 0);

INSERT INTO ctMuontra (ctMuontraID, muontraID, sachID, soluongSachMuon, soluongSachTra)
VALUES ('CTMT002', 'MT001', 'S001', 2, 0),
('CTMT003', 'MT002', 'S002', 2, 0),
('CTMT004', 'MT003', 'S003', 2, 0),
('CTMT005', 'MT005', 'S005', 2, 0),
('CTMT006', 'MT006', 'S003', 2, 0),
('CTMT007', 'MT002', 'S006', 2, 0);

INSERT INTO ctMuontra (ctMuontraID, muontraID, sachID, soluongSachMuon, soluongSachTra)
VALUES ('CTMT008', 'MT001', 'S001', 8, 8),
('CTMT009', 'MT003', 'S002', 7, 3),
('CTMT0010', 'MT0010', 'S003', 4, 2),
('CTMT0011', 'MT0011', 'S005', 10, 10),
('CTMT0012', 'MT007', 'S003', 8, 3),
('CTMT0013', 'MT008', 'S006', 2, 1);
-- Phan quyen
insert into phanQuyen
values 
('00',N'Admin',N'Quản trị'),
('01',N'Thủ thư',N'Quản lí sách, Quản lí mượn trả sách, Quản lí độc giả'),
('02',N'Quản lí ',N'Phụ trách quản lí việc nhập sách')
--Nguoi dung
INSERT INTO nguoidung (nguoidungID, tenNguoidung, matkhau, email, tenDaydu, sodienthoai, diachi, phanQuyenID)
VALUES
('ND001', 'Nam', '123', 'Nam@gmail.com', N'Nguyễn Công Nam', '0987654321', N'Hà Nội', '00'),
('ND002', 'user2', '123', 'user2@gmail.com', N'Trần Thị B', '0123456789', N'Hồ Chí Minh', '01'),
('ND003', 'user3', '123', 'user3@gmail.com', N'Lê Văn C', '0912345678', N'Đà Nẵng', '02'),
('ND004', 'user4', '123', 'user4@gmail.com', N'Phạm Thị D', '0965432198', N'Nha Trang', '01');
--
SELECT * FROM sach

SELECT * FROM tacgia

SELECT * FROM theloai

SELECT * FROM nhaxuatban

SELECT * FROM nhacungcap

SELECT * FROM docgia

SELECT * FROM phieunhap

SELECT * FROM ctPhieunhap

SELECT * FROM muontra

SELECT * FROM ctMuontra;

--
SELECT muontra.muontraID, docgiaID, ngayMuonsach, ngayTrasach, sachID, soluongSachMuon, soluongSachTra FROM muontra INNER JOIN ctMuontra ON muontra.muontraID = ctMuontra.muontraID WHERE muontra.muontraID = 'MT001' ORDER BY muontra.muontraID, ctMuontra.ctMuontraID
--
SELECT p.phieunhapID, p.nhacungcapID, p.ngayNhaphoadon, p.tongsotien, c.sachID, c.soluong, c.giabanle, c.ctPhieunhapID
FROM phieunhap p JOIN ctPhieunhap c ON p.phieunhapID = c.phieunhapID 
WHERE p.phieunhapID = 'PN001'
GROUP BY p.phieunhapID, p.nhacungcapID, p.ngayNhaphoadon, p.tongsotien, c.sachID, c.soluong, c.giabanle, c.ctPhieunhapID
ORDER BY p.phieunhapID, c.ctPhieunhapID
--
SELECT muontra.ngayMuonsach, muontra.ngayTrasach, sach.tenSach, ctMuontra.soluongSachMuon, ctMuontra.soluongSachTra
FROM muontra
INNER JOIN ctMuontra ON muontra.muontraID = ctMuontra.muontraID
INNER JOIN sach ON ctMuontra.sachID = sach.sachID
--
SELECT soluongSachTra
FROM ctMuontra
WHERE muontraID IN (
SELECT muontraID
FROM muontra
WHERE ngayMuonsach = '2023-05-01')
--
SELECT phieunhap.phieunhapID, phieunhap.nhacungcapID, phieunhap.ngayNhaphoadon, phieunhap.tongsotien, ctPhieunhap.soluong, ctPhieunhap.giabanle
FROM phieunhap
INNER JOIN ctPhieunhap ON phieunhap.phieunhapID = ctPhieunhap.phieunhapID
ORDER BY phieunhap.phieunhapID, ctPhieunhap.sachID
--
SELECT SUM(soluongSachTra) FROM ctMuontra
WHERE muontraID IN (
    SELECT muontraID FROM muontra WHERE YEAR(ngayMuonsach) = '2023'	
)
--
SELECT ctMuontra.sachID, SUM(ctMuontra.soluongSachMuon) as total_soluongSachMuon
FROM muontra 
JOIN ctMuontra ON muontra.muontraID = ctMuontra.muontraID 
WHERE ngayMuonsach BETWEEN DATEADD(month, -1, GETDATE()) AND GETDATE()
GROUP BY ctMuontra.sachID
--
SELECT ctMuontra.sachID, SUM(ctMuontra.soluongSachMuon) AS total_soluongSachMuon
FROM muontra 
JOIN ctMuontra ON muontra.muontraID = ctMuontra.muontraID 
WHERE YEAR(ngayMuonsach) = 2023 AND MONTH(ngayMuonsach) = 5 
  AND ngayMuonsach BETWEEN DATEADD(month, -1, GETDATE()) AND GETDATE()
GROUP BY ctMuontra.sachID
--
SELECT sum(soluongSachMuon) FROM ctMuontra WHERE muontraID IN (SELECT muontraID FROM muontra WHERE MONTH(ngayMuonsach) = '05' AND YEAR(ngayMuonsach) = '2023')
--
--
select tenNguoidung, tenDaydu, email, sodienthoai, diachi from nguoidung where tenNguoidung = N'Nam'
--
update nguoidung set tenDaydu = N'Nguyễn Duy Khang',email= 'Khang@gmail.com',sodienthoai= '0123456789', diachi = N'Hồ Chí Minh' where tenNguoidung = 'user2'
--
SELECT *
FROM ctMuontra
JOIN muontra ON ctMuontra.muontraID = muontra.muontraID
WHERE muontra.docgiaID = 'DG01';
--
select sachID, tenSach, soluong, ngonngu from sach where soluong <= 10
--
update sach set soluong = 2 where sachID = 'S004'
--
SELECT * FROM ctMuontra WHERE muontraID = N'đâsdasd'
--
update sach set soluong = soluong - 2 where sachID = 'S003'
--
SELECT soluong FROM sach WHERE [sachID] = N'S001'
--
SELECT s.sachID, s.tenSach, c.soluong AS soluongSachMuon
FROM sach s
INNER JOIN ctPhieunhap c ON s.sachID = c.sachID;

SELECT s.sachID, s.tenSach, c.soluong AS soluongSachMuon
FROM sach s
INNER JOIN ctPhieunhap c ON s.sachID = c.sachID
WHERE c.ctPhieunhapID = 'PN001';
--
SELECT muontra.muontraID, muontra.docgiaID, docgia.tenDaydu, muontra.ngayMuonsach, muontra.ngayTrasach, ctMuontra.sachID, sach.tenSach, ctMuontra.soluongSachMuon
FROM muontra
JOIN docgia ON muontra.docgiaID = docgia.docgiaID
JOIN ctMuontra ON muontra.muontraID = ctMuontra.muontraID
JOIN sach ON ctMuontra.sachID = sach.sachID
WHERE muontra.muontraID = 'MT005';
---
SELECT s.sachID, s.tenSach, ct.soluongSachMuon
FROM ctMuontra ct
JOIN sach s ON ct.sachID = s.sachID
WHERE ct.muontraID = 'MT005';
SELECT s.sachID, s.tenSach, ct.soluongSachMuon FROM ctMuontra ct JOIN sach s ON ct.sachID = s.sachID WHERE ct.muontraID = N'đâsdasd'
--
select * from ctMuontra where muontraID = N'MT001'
select * from sach where tenSach like N'One Hundred Years of Solitude'
select * from tacgia where tenDaydu = N'Nguyễn Du'
select * from phieunhap where ngayNhaphoadon = '2023-04-28'
