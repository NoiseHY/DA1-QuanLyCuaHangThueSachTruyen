use master
go
--drop database quanlisach
create database quanlisach
go
use quanlisach
go
create table theloai
(
	theloaiID nvarchar(20) primary key,
	tenTheloai nvarchar(50) not null ,
	motaTheloai nvarchar(500) not null
)
CREATE TABLE docgia
(
    docgiaID nvarchar(20) PRIMARY KEY,
    tenDaydu nvarchar(50) NOT NULL,
    diachi nvarchar(50) NOT NULL,
    email varchar(50) NOT NULL,
    sodienthoai char(10) NOT NULL,
    ngaysinh date NOT NULL,
    daCanhCao bit DEFAULT 0, -- Cột để xác định xem độc giả đã bị cảnh cáo hay chưa
    biCamMuon bit DEFAULT 0 -- Cột để xác định xem độc giả đã bị cấm mượn sách hay chưa
);

create table nhaxuatban
(
	nhaxuatbanID nvarchar(20) primary key,
	tenNhaxuatban nvarchar(50) not null,
	diachi nvarchar(50) not null,
	sodienthoai char(10) not null,
	email varchar(50) not null
)
create table tacgia
(
	tacgiaID nvarchar(20) primary key,
	tenDaydu nvarchar(50) not null,
	quoctich nvarchar(50) not null,
	namSinh int not null
)
create table sach
(
	sachID nvarchar(20) primary key,
	tenSach nvarchar(50) not null ,
	sotrang int not null ,
	giatien float not null,
	ngayxuatban date not null,
	soluong int not null,
	theloaiID nvarchar(20) not null,
	tacgiaID nvarchar(20) not null,
	nhaxuatbanID nvarchar(20),
	ngonngu nvarchar(20) not null,
	foreign key (tacgiaID) references tacgia(tacgiaID) on delete cascade on update cascade,
	foreign key (theloaiID) references theloai(theloaiID) on delete cascade on update cascade,
	foreign key (nhaxuatbanID) references nhaxuatban(nhaxuatbanID) on delete cascade on update cascade
)
create table nhacungcap
(
	nhacungcapID nvarchar(20) primary key,
	tenNhacungcap nvarchar(50) not null,
	diachi nvarchar(50) not null,
	sodienthoai char(10) not null,
	email varchar(50) not null
)
create table phieunhap
(
	phieunhapID nvarchar(20) primary key not null,
	nhacungcapID nvarchar(20) not null,
	ngayNhaphoadon date not null,
	tongsotien float not null,
	foreign key (nhacungcapID) references nhacungcap(nhacungcapID) on delete cascade on update cascade
)
create table ctPhieunhap
(
	ctPhieunhapID nvarchar(20) primary key,
	phieunhapID nvarchar(20) not null,
	sachID nvarchar(20) not null,
	soluong int not null,
	giabanle float not null,
	foreign key (phieunhapID) references phieunhap(phieunhapID) on delete cascade,
	foreign key (sachID) references sach(sachID) on delete cascade
)
create table muontra
(
	muontraID nvarchar(20) primary key,
	docgiaID nvarchar(20) not null,
	ngayMuonsach date not null,
	ngayTrasach date not null,
	foreign key (docgiaID) references docgia(docgiaID) on delete cascade on update cascade
)
create table ctMuontra
(
	ctMuontraID nvarchar(20) primary key,
	muontraID nvarchar(20) not null,
	sachID nvarchar(20) not null,
	soluongSachMuon int not null,
	soluongSachTra int ,
	foreign key (muontraID) references muontra(muontraID) on delete cascade on update cascade,
	foreign key (sachID) references sach(sachID) on delete cascade on update cascade
)
create table phanQuyen
(
	phanQuyenID nvarchar(20) primary key,
	tenphanQuyen nvarchar(50) not null,
	mota nvarchar(500) not null
)
create table nguoidung
(
	nguoidungID nvarchar(20) primary key,
	tenNguoidung nvarchar(50) unique not null,
	matkhau nvarchar(50) not null,
	email varchar(50) not null,
	tenDaydu nvarchar(50) not null,
	sodienthoai char(10) not null,
	diachi nvarchar(50) not null,
	phanQuyenID nvarchar(20),
	foreign key (phanQuyenID) references phanQuyen(phanQuyenID) on delete cascade on update cascade
)
