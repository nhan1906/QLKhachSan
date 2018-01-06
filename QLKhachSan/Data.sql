CREATE DATABASE HotelManagement
GO

USE HotelManagement
GO


CREATE TABLE Tang
(
	tangThu int primary key,
	tenTang nvarchar(10) unique,
	soPhong int default 0
)
GO



--Thêm vào 10 tầng
INSERT INTO Tang
(
	tangThu, tenTang
)
VALUES
(
	1 , N'Tầng 1'
)
INSERT INTO Tang
(
	tangThu, tenTang
)
VALUES
(
	2 , N'Tầng 2'
)
INSERT INTO Tang
(
	tangThu, tenTang
)
VALUES
(
	3 , N'Tầng 3'
)
INSERT INTO Tang
(
	tangThu, tenTang
)
VALUES
(
	4 , N'Tầng 4'
)
INSERT INTO Tang
(
	tangThu, tenTang
)
VALUES
(
	5 , N'Tầng 5'
)
INSERT INTO Tang
(
	tangThu, tenTang
)
VALUES
(
	6 , N'Tầng 6'
)
INSERT INTO Tang
(
	tangThu, tenTang
)
VALUES
(
	7 , N'Tầng 7'
)
INSERT INTO Tang
(
	tangThu, tenTang
)
VALUES
(
	8 , N'Tầng 8'
)
INSERT INTO Tang
(
	tangThu, tenTang
)
VALUES
(
	9 , N'Tầng 9'
)
INSERT INTO Tang
(
	tangThu, tenTang
)
VALUES
(
	10 , N'Tầng 10'
)
GO


CREATE PROC PhanTrangTheo
@page int,
@number int
AS
BEGIN
	DECLARE @selectedrow INT = @number * @page
	DECLARE @exceptedrow INT = @number * (@page - 1)
	SELECT  TOP (@selectedrow) * from Tang
	except
	SELECT  TOP (@exceptedrow) * from Tang
END
GO

CREATE TABLE ChatLuong
(
	tenChatLuong nvarchar(10) primary key,
	ghiChu text
)
GO

INSERT INTO ChatLuong
(
	tenChatLuong , ghiChu
)
VALUES
(
	N'Thường', N'Phòng bình dân'
)
INSERT INTO ChatLuong
(
	tenChatLuong 
)
VALUES
(
	N'VIP'
)
INSERT INTO ChatLuong
(
	tenChatLuong
)
VALUES
(
	N'Superior'
)
INSERT INTO ChatLuong
(
	tenChatLuong 
)
VALUES
(
	N'Deluxe'
)
INSERT INTO ChatLuong
(
	tenChatLuong 
)
VALUES
(
	N'Luxury'
)
GO

CREATE TABLE LoaiGiuong
(
	tenLoaiGiuong nvarchar(10) primary key,
	soNguoi int default 1,
	soGiuong int default 1
)
GO

INSERT INTO LoaiGiuong
(
	tenLoaiGiuong, soNguoi , soGiuong
)
VALUES
(
	N'Single' , 1 , 1
)
INSERT INTO LoaiGiuong
(
	tenLoaiGiuong, soNguoi , soGiuong
)
VALUES
(
	N'King' , 2 , 1
)
INSERT INTO LoaiGiuong
(
	tenLoaiGiuong, soNguoi , soGiuong
)
VALUES
(
	N'Twin' , 2 , 2
)
INSERT INTO LoaiGiuong
(
	tenLoaiGiuong, soNguoi , soGiuong
)
VALUES
(
	N'Triple' , 3 , 3
)
GO

CREATE TABLE LoaiPhong
(
	maLoaiPhong nvarchar(5) primary key,
	tenChatLuong nvarchar(10) not null,
	tenLoaiGiuong nvarchar(10) not null,
	giaNgay float not null,
	soNguoiToiDa int default 0,
	hinhMoTa image
)
GO

CREATE PROC InsertLoaiPhong
@maLoaiPhong nvarchar(5),
@tenChatLuong nvarchar(10),
@tenLoaiGiuong nvarchar(10),
@giaNgay float,
@soNguoiToiDa int,
@hinhMoTa image
AS
BEGIN
	INSERT INTO LoaiPhong
	( maLoaiPhong , tenChatLuong , tenLoaiGiuong , giaNgay , soNguoiToiDa , hinhMoTa)
	VALUES
	( @maLoaiPhong , @tenChatLuong , @tenLoaiGiuong , @giaNgay , @soNguoiToiDa , @hinhMoTa)
END
GO

CREATE TABLE TinhTrangPhong
(
	tenTinhTrangPhong nvarchar(20) primary key
)
GO

INSERT INTO TinhTrangPhong
(
	tenTinhTrangPhong
)
VALUES
(
	N'Trống'
)
INSERT INTO TinhTrangPhong
(
	tenTinhTrangPhong
)
VALUES
(
	N'Nhận phòng'
)
INSERT INTO TinhTrangPhong
(
	tenTinhTrangPhong
)
VALUES
(
	N'Quá hạn'
)
INSERT INTO TinhTrangPhong
(
	tenTinhTrangPhong
)
VALUES
(
	N'Đã đặt'
)
INSERT INTO TinhTrangPhong
(
	tenTinhTrangPhong
)
VALUES
(
	N'Không đến'
)
INSERT INTO TinhTrangPhong
(
	tenTinhTrangPhong
)
VALUES
(
	N'Đang sửa'
)
GO


CREATE TABLE KhachHang
(
	idKH int identity,
	maKH as 'KH' + Right('000000' + cast(idKH as nvarchar(10)), 6) persisted primary key,
	cmnd nvarchar(15) not null unique,
	hoKH nvarchar(20) not null,
	tenKH nvarchar(50) not null,
	sdt nvarchar(15),
	gioiTinh int default 1, -- 1 nam 0 là nữ 
	diaChi nvarchar(100),
	ngheNghiep nvarchar(20),
	ngayCapCMND date,
	ngaySinh date,
	email nvarchar(50),
	ghiChu nvarchar(100),
	quoctich nvarchar(20),
	soVisa nvarchar(20),
	thoiHanVisa date,
	tamTruTu date,
	tamTruDen date
)
GO

CREATE PROC InsertKhachHang
@cmnd nvarchar(15),
@hoKH nvarchar(20),
@tenKH nvarchar(50),
@sdt nvarchar(15),
@gioiTinh int ,
@diaChi nvarchar(100),
@ngheNghiep nvarchar(20),
@ngayCapCMND date,
@ngaySinh date,
@email nvarchar(50),
@ghiChu nvarchar(100),
@quoctich nvarchar(20),
@soVisa nvarchar(20),
@thoiHanVisa date,
@tamTruTu date,
@tamTruDen date
AS
BEGIN
	INSERT INTO KhachHang
	(
		tenKH , hoKH ,  cmnd , sdt ,gioiTinh ,diaChi , ngheNghiep  , ngayCapCMND , ngaySinh ,
		 email , ghiChu , quoctich , soVisa , thoiHanVisa , tamTruTu ,tamTruDen
	)
	Values
	(
		@tenKH , @hoKH ,  @cmnd , @sdt ,@gioiTinh ,@diaChi , @ngheNghiep  , isNull(@ngayCapCMND, '') , isNull(@ngaySinh, '') ,
		 @email , @ghiChu , @quoctich , @soVisa , isNull(@thoiHanVisa, '') , isNull(@tamTruTu, '') , isNull(@tamTruDen, '')
	)
END
GO


CREATE TABLE Phong
(
	maPhong int primary key,
	phongSo int not null,
	tangThu int foreign key references Tang(tangThu),
	maLoaiPhong nvarchar(5) foreign key references LoaiPhong(maLoaiPhong),
	tenTinhTrangPhong nvarchar(20) foreign key references TinhTrangPhong(tenTinhTrangPhong),
	maHDHienTai nvarchar(20),
	ban int default 0 -- 0 là sạch 1 là bẩn 2 là đang dọn
)
GO


CREATE TABLE PhieuSuaPhong
(
	idSuaPhong int identity,
	maSuaPhong as 'SC' + Right('000000' + cast(idSuaPhong as nvarchar(10)), 6) persisted primary key,
	maPhong int not null,
	ngayBatDau Date not null,
	ngayDuKienKT Date not null,
	ngayKT Date ,
	ghiChu text,
	tongTienSC float
)
GO

CREATE PROC InsertPhieuSuaPhong
@maPhong int,
@ngayBatDau Date,
@ngayDuKienKT Date,
@ghiChu text
AS
BEGIN
	Insert into PhieuSuaPhong
	(maPhong , ngayBatDau , ngayDuKienKT , ghiChu)
	VALUes
	(@maPhong , @ngayBatDau , @ngayDuKienKT , @ghiChu)
END
GO

-----------------------------------------------------------------------------------
-- Bản nhân viên tài khoản
-----------------------------------------------------------------------------------
CREATE TABLE TrinhDo
(
	tenTrinhDo nvarchar(30) primary key
)
GO

INSERT INTO TrinhDo
(
	tenTrinhDo
)
VALUES
(
	N'Tiểu học'
)
INSERT INTO TrinhDo
(
	tenTrinhDo
)
VALUES
(
	N'Trung học'
)
INSERT INTO TrinhDo
(
	tenTrinhDo
)
VALUES
(
	N'Cấp 3'
)
INSERT INTO TrinhDo
(
	tenTrinhDo
)
VALUES
(
	N'Trung cấp nghề'
)
INSERT INTO TrinhDo
(
	tenTrinhDo
)
VALUES
(
	N'Cao đẳng'
)
INSERT INTO TrinhDo
(
	tenTrinhDo
)
VALUES
(
	N'Đại học'
)
GO

CREATE TABLE SoYeuLiLich
(
	idLL int identity,
	maLL as 'LL' + Right('000000' + cast(idLL as nvarchar(10)), 6) persisted primary key,
	cmnd nvarchar(15) not null unique,
	ho nvarchar(20) not null,
	ten nvarchar(50) not null,
	sdt nvarchar(15),
	gioiTinh int default 1, -- 1 nam 0 là nữ 
	diaChiTamTru nvarchar(100),
	queQuan nvarchar(100),
	trinhDo nvarchar(30) foreign key references TrinhDo(tenTrinhDo),
	ngayCapCMND date,
	ngaySinh date,
	email nvarchar(50),
	ghiChu nvarchar(100),
	quoctich nvarchar(20),
)
GO

CREATE PROC InsertSoYeuLiLich
@cmnd nvarchar(15),
@ho nvarchar(20),
@ten nvarchar(50),
@sdt nvarchar(15),
@gioiTinh int ,
@diaChiTamTru nvarchar(100),
@queQuan nvarchar(100),
@trinhDo nvarchar(30),
@ngayCapCMND date,
@ngaySinh date,
@email nvarchar(50),
@ghiChu nvarchar(100),
@quoctich nvarchar(20)
AS
BEGIN
	INSERT INTO SoYeuLiLich
	(
		cmnd , ho , ten , sdt , gioiTinh , diaChiTamTru , queQuan , trinhDo  , ngayCapCMND , ngaySinh ,
		 email , ghiChu , quoctich
	)
	Values
	(
		@cmnd , @ho ,  @ten , @sdt ,@gioiTinh ,@diaChiTamTru , @queQuan , @trinhDo , isNull(@ngayCapCMND, '') , isNull(@ngaySinh, '') ,
		 @email , @ghiChu , @quoctich
	)
END
GO

InsertSoYeuLiLich N'215290607' , N'Dương' , N'Ngọc Nhẫn' , N'01654018013' , 1 , N'Đông Hòa , Dĩ An , Bình Dương' , N'Bình Định' ,
N'Đại học' , '05-24-2013' , '06-19-1995' , N'nhantx.1906@gmail.com' , N'' , N'Việt Nam'
GO

CREATE TABLE PhongBan
(
	tenPhongBan nvarchar(30) primary key
)
GO

INSERT INTO PhongBan
(
	tenPhongBan
)
VALUES
(
	N'Kế toán'
)
INSERT INTO PhongBan
(
	tenPhongBan
)
VALUES
(
	N'Lễ tân'
)
GO

CREATE TABLE NhanVien
(
	idNV int identity,
	maNV as 'NV' + Right('000000' + cast(idNV as nvarchar(10)), 6) persisted primary key,
	maLL nvarchar(8) foreign key references SoYeuLiLich(maLL),
	thuocPhongBan nvarchar(30) foreign key references PhongBan(tenPhongBan) default N'Lễ tân'
)
GO

CREATE PROC InsertNhanVien
@maLL nvarchar(8),
@thuocPhongBan nvarchar(30)
AS
BEGIN
	INSERT iNTo NhanVien
	(
		maLL , thuocPhongBan
	)
	Values
	(
		@maLL , @thuocPhongBan
	)
END
GO

InsertNhanVien N'LL000001' , N'Lễ tân'
GO

CREATE TABLE Account 
(
	username nvarchar(30) primary key,
	password nvarchar(1000) not null,
	displayname nvarchar(30) not null,
	maNV nvarchar(8) foreign key references NhanVien(maNV),
	phanquyen int default 0 -- 0 là nhân viên 1 là quản lý
)
GO



CREATE PROC InsertAccount
@username nvarchar(30),
@password nvarchar(1000),
@displayname nvarchar(30),
@maNV nvarchar(8),
@phanquyen int
AS
BEGIN
	Insert into Account
	(
		username , password , displayname , maNV , phanquyen
	)
	Values
	(
		@username , @password , @displayname , @maNV , @phanquyen
	)
END
GO


InsertAccount N'nhan' , N'246217623212531124222177229148153147175114244', N'Ngọc Nhẫn' , N'NV000001' , 1
GO

CREATE PROC CheckLogin
@username nvarchar(30),
@password nvarchar(1000)
AS
BEGIN
	Select * from Account where username = @username and password = @password
END
GO


--------------------------------------------------------------------------------------
--Kết thúc bản Nhân viên và Tài khoản
--------------------------------------------------------------------------------------

--------------------------------------------------------------------------------------
--Bản dịch vụ
--------------------------------------------------------------------------------------

CREATE TABLE NhomDichVu
(
	tenLoaiDV nvarchar(30) primary key
)
GO

INSERT INTO NhomDichVu
(
	tenLoaiDV
)
VALUES
(
	N'Khác'
)
INSERT INTO NhomDichVu
(
	tenLoaiDV
)
VALUES
(
	N'Nước giải khát'
)
INSERT INTO NhomDichVu
(
	tenLoaiDV
)
VALUES
(
	N'Đồ uống'
)
INSERT INTO NhomDichVu
(
	tenLoaiDV
)
VALUES
(
	N'Snack'
)
INSERT INTO NhomDichVu
(
	tenLoaiDV
)
VALUES
(
	N'Thức ăn'
)
INSERT INTO NhomDichVu
(
	tenLoaiDV
)
VALUES
(
	N'Giặt là'
)

GO

CREATE TABLE DonVi
(
	tenDonVi nvarchar(10) primary key
)
GO

INSERT INTO DonVi
(
	tenDonVi
)
VALUES
(
	N'Chai'
)
INSERT INTO DonVi
(
	tenDonVi
)
VALUES
(
	N'Lon'
)
INSERT INTO DonVi
(
	tenDonVi
)
VALUES
(
	N'Đĩa'
)
INSERT INTO DonVi
(
	tenDonVi
)
VALUES
(
	N'Phần'
)
INSERT INTO DonVi
(
	tenDonVi
)
VALUES
(
	N'Bịch'
)
INSERT INTO DonVi
(
	tenDonVi
)
VALUES
(
	N'Chiếc'
)
INSERT INTO DonVi
(
	tenDonVi
)
VALUES
(
	N'Bộ'
)
INSERT INTO DonVi
(
	tenDonVi
)
VALUES
(
	N'Cái'
)
GO

CREATE TABLE DichVu
(
	idDV int identity,
	maDV as 'DV' + Right('000000' + cast(idDV as nvarchar(10)), 6) persisted primary key,
	tenDV nvarchar(20) not null,
	tenLoaiDV nvarchar(30) foreign key references NhomDichVu(tenLoaiDV),
	tenDonVi nvarchar(10) foreign key references DonVi(tenDonVi),
	hangHoa int default 0, -- 0 là không phải 1 là hàng hóa
	donGiaDonVi float -- Đơn giá cho 1 đơn vị
)
GO
--Thức uống
INSERT INTO DichVu
(
	tenDV , tenLoaiDV ,tenDonVi ,donGiaDonVi , hangHoa
)
VALUES
(
	N'Nước suối' , N'Nước giải khát' , N'Chai' , 12000 , 1
)
INSERT INTO DichVu
(
	tenDV , tenLoaiDV ,tenDonVi ,donGiaDonVi , hangHoa
)
VALUES
(
	N'C2' , N'Nước giải khát' , N'Chai' , 8000 , 1
)
INSERT INTO DichVu
(
	tenDV , tenLoaiDV ,tenDonVi ,donGiaDonVi , hangHoa
)
VALUES
(
	N'Trà xanh 0 độ' , N'Nước giải khát' , N'Chai' , 10000 , 1
)
INSERT INTO DichVu
(
	tenDV , tenLoaiDV ,tenDonVi ,donGiaDonVi , hangHoa
)
VALUES
(
	N'Trà Olong' , N'Nước giải khát' , N'Chai' , 10000 , 1
)
INSERT INTO DichVu
(
	tenDV , tenLoaiDV ,tenDonVi ,donGiaDonVi , hangHoa
)
VALUES
(
	N'Nước tăng lực' , N'Nước giải khát' , N'Chai' , 12000 , 1
)
GO
--Snack
INSERT INTO DichVu
(
	tenDV , tenLoaiDV ,tenDonVi ,donGiaDonVi , hangHoa
)
VALUES
(
	N'Khô bò' , N'Snack' , N'Bịch' , 15000 , 1
)
INSERT INTO DichVu
(
	tenDV , tenLoaiDV ,tenDonVi ,donGiaDonVi , hangHoa
)
VALUES
(
	N'Khô mực' , N'Snack' , N'Bịch' , 15000 , 1
)
INSERT INTO DichVu
(
	tenDV , tenLoaiDV ,tenDonVi ,donGiaDonVi , hangHoa
)
VALUES
(
	N'Poca nhỏ' , N'Snack' , N'Bịch' , 10000 , 1
)
GO

--Giặt là

INSERT INTO DichVu
(
	tenDV , tenLoaiDV ,tenDonVi ,donGiaDonVi
)
VALUES
(
	N'Áo dài' , N'Giặt là' , N'Bộ' , 10000
)
INSERT INTO DichVu
(
	tenDV , tenLoaiDV ,tenDonVi ,donGiaDonVi
)
VALUES
(
	N'Veston' , N'Giặt là' , N'Bộ' , 10000
)
INSERT INTO DichVu
(
	tenDV , tenLoaiDV ,tenDonVi ,donGiaDonVi
)
VALUES
(
	N'Áo sơ mi' , N'Giặt là' , N'Cái' , 5000
)
INSERT INTO DichVu
(
	tenDV , tenLoaiDV ,tenDonVi ,donGiaDonVi
)
VALUES
(
	N'Áo thun' , N'Giặt là' , N'Cái' , 5000
)
INSERT INTO DichVu
(
	tenDV , tenLoaiDV ,tenDonVi ,donGiaDonVi
)
VALUES
(
	N'Áo đầm' , N'Giặt là' , N'Cái' , 5000
)
INSERT INTO DichVu
(
	tenDV , tenLoaiDV ,tenDonVi ,donGiaDonVi
)
VALUES
(
	N'Com lê' , N'Giặt là' , N'Bộ' , 10000
)
INSERT INTO DichVu
(
	tenDV , tenLoaiDV ,tenDonVi ,donGiaDonVi
)
VALUES
(
	N'Áo len' , N'Giặt là' , N'Cái' , 5000
)
INSERT INTO DichVu
(
	tenDV , tenLoaiDV ,tenDonVi ,donGiaDonVi
)
VALUES
(
	N'Bộ đồ ngủ' , N'Giặt là' , N'Bộ' , 10000
)
INSERT INTO DichVu
(
	tenDV , tenLoaiDV ,tenDonVi ,donGiaDonVi
)
VALUES
(
	N'Quần tây' , N'Giặt là' , N'Cái' , 5000
)
INSERT INTO DichVu
(
	tenDV , tenLoaiDV ,tenDonVi ,donGiaDonVi
)
VALUES
(
	N'Quần sọt' , N'Giặt là' , N'Cái' , 5000
)
INSERT INTO DichVu
(
	tenDV , tenLoaiDV ,tenDonVi ,donGiaDonVi
)
VALUES
(
	N'Váy' , N'Giặt là' , N'Cái' , 5000
)
INSERT INTO DichVu
(
	tenDV , tenLoaiDV ,tenDonVi ,donGiaDonVi
)
VALUES
(
	N'Quần jean' , N'Giặt là' , N'Cái' , 5000
)
GO


--------------------------------------------------------------------------------------
--Kết thúc bản Dịch vụ
--------------------------------------------------------------------------------------
--------------------------------------------------------------------------------



-----------------------------------------------------------------------------------
------------------------------------------------------------------------------------

CREATE TABLE PhieuNhanPhong
(
	maNhanPhong nvarchar(20),
	maPhong int,
	checkIn DateTime not null,
	checkOut DateTime not null,
	checkOutReal DAteTime,
	soNguoi int,
	soTreEm int,
	maHD nvarchar(20),
	lyDoTraPhong nvarchar(20)
	CONSTRAINT PK_PhieuNhanPhong PRIMARY KEY (maNhanPhong,maPhong)
)
GO

CREATE PROC InsertPhieuNhanPhong
@maNhanPhong nvarchar(20),
@maPhong int,
@checkIn datetime,
@checkOut datetime,
@soNguoi int,
@soTreEm int,
@maHD nvarchar(20)
AS
BEGIN
	INSERT INTO PhieuNhanPhong
	(
		maNhanPhong , maPhong , checkIn , checkOut , soNguoi ,soTreEm , maHD
	)
	VALUES
	(
		@maNhanPhong , @maPhong , @checkIn , @checkOut , @soNguoi , @soTreEm , @maHD
	)
END
GO

CREATE TABLE KhachHangOPhong
(
	maNhanPhong nvarchar(20),
	maPhong int ,
	maKH nvarchar(8) foreign key references KhachHang(maKH),
	FOREIGN KEY (maNhanPhong, maPhong) REFERENCES PhieuNhanPhong(maNhanPhong, maPhong)
)
GO

CREATE TABLE LoaiHoatDong
(
	idLoaiHoatDong int primary key identity,
	tenLoaiHoatDong nvarchar(30), -- 0 là nhận phòng , 1 là chuyển phòng , 2 là trả phòng , 3 là gia hạn phòng ,4 sử dụng dịch vụ , 5 đặt cọc
)
GO

INSERT INTO LoaiHoatDong
(	tenLoaiHoatDong	)
VALUES
(	N'Nhận phòng'	)
INSERT INTO LoaiHoatDong
(	tenLoaiHoatDong	)
VALUES
(	N'Chuyển phòng'	)
INSERT INTO LoaiHoatDong
(	tenLoaiHoatDong	)
VALUES
(	N'Trả phòng'	)
INSERT INTO LoaiHoatDong
(	tenLoaiHoatDong	)
VALUES
(	N'Gia hạn phòng'	)
INSERT INTO LoaiHoatDong
(	tenLoaiHoatDong	)
VALUES
(	N'SD dịch vụ'	)
INSERT INTO LoaiHoatDong
(	tenLoaiHoatDong	)
VALUES
(	N'Đặt cọc'	)
GO

CREATE TABLE ChiTietHoatDong
(
	maHD nvarchar(20),
	idLoaiHoatDong int foreign key references LoaiHoatDong(idLoaiHoatDong),
	maLQ nvarchar(30),
	thoiGian Datetime
)
GO

CREATE PROC InsertChiTietHoatDong
@maHD nvarchar(20),
@idLoaiHoatDong int,
@maLQ nvarchar(30)
AS
BEGIN
	INSERT INTO ChiTietHoatDong
	(
		maHD , idLoaiHoatDong , maLQ , thoiGian
	)
	VALUES
	(
		@maHD , @idLoaiHoatDong , @maLQ , getDate()
	)
END
GO

--------------------------------------------
-- Đặt cọc tiền
--------------------------------------------
CREATE TABLE PhieuDatCocTienPhong
(
	idDC int identity,
	maDC as 'DC' + Right('000000' + cast(idDC as nvarchar(10)), 6) persisted primary key,
	soTien float ,
	maPhong int,
	maNV nvarchar(8) foreign key references NhanVien(maNV),
	thoiGianNhan Datetime default getDate()
)
GO

CREATE PROC InsertPhieuDatCocTienPhong
@soTien float,
@maPhong int,
@maNV nvarchar(8),
@thoiGianNhan DateTime
AS
BEGIN
	INSERT INTO PhieuDatCocTienPhong
	(
		soTien , maPhong , maNV , thoiGianNhan
	)
	VALUES
	(
		@soTien , @maPhong , @maNV , @thoiGianNhan
	)
END
GO

--------------------------------------------
-- Phiếu Sử dụng dịch vụ
--------------------------------------------
CREATE TABLE PhieuSuDungDichVu
(
	idSDDV int identity,
	maSDDV as 'SDDV' + Right('000000' + cast(idSDDV as nvarchar(10)), 6) persisted primary key,
	maDV nvarchar(8) foreign key references DichVu(maDV),
	soLuong int,
	thoiGianNhan Datetime default getDate()
)
GO

CREATE PROC InsertPhieuSuDungDichVu
@maDV nvarchar(8),
@soLuong int,
@thoiGianNhan DateTime
AS
BEGIN
	INSERT INTO PhieuSuDungDichVu
	(
		maDV , soLuong  , thoiGianNhan
	)
	VALUES
	(
		@maDV , @soLuong  , @thoiGianNhan
	)
END
GO

-------------------------------------------------------------------------------------------------------------
-- Hóa đơn
-------------------------------------------------------------------------------------------------------------

CREATE TABLE PhieuPhuThu
(
	idPT int identity,
	maPT as 'PT' + Right('000000' + cast(idPT as nvarchar(10)), 6) persisted primary key,
	tienPhuThu float,
	nguyenNhan nvarchar(1000)
)
GO

select * from PhieuNhanPhong inner join ChiTietHoatDong on PhieuNhanPhong.maHD = ChiTietHoatDong.maHD where idLoaiHoatDong = 1
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------


-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------

CREATE TABLE PhieuDatPhong
(
	maDatPhong nvarchar(20) primary key,
	tenNguoiDat nvarchar(50) not null,
	sdtNguoiDat nvarchar(15),
	emailNguoiDat nvarchar(100),
	ngayDen Date not null,
	ngayDi Date not null,
	yeuCauKhac text,
	tinhTrang int default 0 -- 0 đang chờ, -1 là đã hủy , 1 là đã nhận
)
GO

CREATE PROC InsertPhieuDatPhong
@maDatPhong nvarchar(20),
@tenNguoiDat nvarchar(50),
@sdtNguoiDat nvarchar(15),
@emailNguoiDat nvarchar(100),
@ngayDen Date,
@ngayDi Date,
@yeuCauKhac text
AS
BEGIN
	INSERT INTO PhieuDatPhong
	(
		maDatPhong , tenNguoiDat , sdtNguoiDat , emailNguoiDat , ngayDen , ngayDi , yeuCauKhac
	)
	VALUES
	(
		@maDatPhong , @tenNguoiDat , @sdtNguoiDat , @emailNguoiDat , @ngayDen , @ngayDi  , @yeuCauKhac
	)
END
GO

CREATE TABLE ChiTietDatPhong
(
	maDatPhong nvarchar(20) foreign key references PhieuDatPhong(maDatPhong),
	maPhong int not null foreign key references Phong(maPhong),
	maLoaiPhong nvarchar(5) foreign key references LoaiPhong(maLoaiPhong)
	CONSTRAINT PK_ChiTietDatPhong PRIMARY KEY (maDatPhong,maPhong)
)
GO

CREATE PROC InsertChiTietDatPhong
@maDatPhong nvarchar(20),
@maPhong int,
@maLoaiPhong nvarchar(5)
AS
BEGIN
	INSERT INTO ChiTietDatPhong
	(
		maDatPhong , maPhong , maLoaiPhong
	)
	VALUES
	(
		@maDatPhong , @maPhong , @maLoaiPhong
	)
END
GO

--Phòng đã đặt , đang ở, đang sửa trong khoảng thời gian đặt


CREATE PROC BangHienTrangPhongDat
@checkIn Date,
@checkOut Date
AS
BEGIN
	SELECT  Y.hinhMoTa , Y.maLoaiPhong  , Y.tenChatLuong + ' ' +  Y.tenLoaiGiuong as TenLoai, Y.giaNgay, Z.tong , Z.dat , Z.con  FROM (Select maLoaiPhong , ChatLuong.tenChatLuong ,LoaiGiuong.tenLoaiGiuong  , giaNgay , hinhMota  from LoaiPhong INNER JOIN ChatLuong ON LoaiPhong.tenChatLuong = ChatLuong.tenChatLuong INNER JOIN LoaiGiuong ON LoaiPhong.tenLoaiGiuong = LoaiGiuong.tenLoaiGiuong) Y
	 INNER JOIN
	(SELECT t1.maLoaiPhong, t1.tong, coalesce(t2.dat, 0) as 'dat' , (t1.tong - coalesce(t2.dat,0)) AS 'con'
	FROM 
		(SELECT maLoaiPhong, COUNT(maPhong) AS 'tong' FROM Phong GROUP BY maLoaiPhong ) t1
	left join
		(select maLoaiPhong , Count(D.maPhong) as 'dat' from 
			(SELECT Phong.maPhong from Phong right join (select maPhong from PhieuDatPhong INNER JOIN ChiTietDatPhong ON PhieuDatPhong.maDatPhong = ChiTietDatPhong.maDatPhong
						WHERE NOT(ngayDen >= @checkOut or ngayDi <= @checkIn) and tinhTrang = 0 ) Z on Phong.maPhong = Z.maPhong
			union
			select Phong.maPhong from Phong inner join PhieuNhanPhong on Phong.maPhong = PhieuNhanPhong.maPhong where checkOut > @checkIn
			union
			select Phong.maPhong from Phong inner join PhieuSuaPhong on Phong.maPhong = PhieuSuaPhong.maPhong where ngayDuKienKT > @checkIn and ngayDuKienKT = null) D  left join Phong
			on Phong.maPhong = D.maPhong group by maLoaiPhong) t2
	ON
		t1.maLoaiPhong = t2.maLoaiPhong) Z
		ON Y.maLoaiPhong = Z.maLoaiPhong
END
GO



Create proc DanhSachPhongConTrong
@soPhong int,
@checkIn date, 
@checkOut date,
@maLoaiPhong nvarchar(20)
As
Begin

	Select TOP (@soPhong) * from Phong 
	INNER JOIN
	(Select maPhong from Phong where maLoaiPhong = @maLoaiPhong
	except
	select D.maPhong from 
		(SELECT Phong.maPhong from Phong right join (select maPhong from PhieuDatPhong INNER JOIN ChiTietDatPhong ON PhieuDatPhong.maDatPhong = ChiTietDatPhong.maDatPhong
				WHERE NOT(ngayDen >= @checkOut or ngayDi <= @checkIn) and tinhTrang = 0 ) Z on Phong.maPhong = Z.maPhong
		union
		select Phong.maPhong from Phong inner join PhieuNhanPhong on Phong.maPhong = PhieuNhanPhong.maPhong where checkOut > @checkIn
		union
		select Phong.maPhong from Phong inner join PhieuSuaPhong on Phong.maPhong = PhieuSuaPhong.maPhong where ngayDuKienKT > @checkIn and ngayDuKienKT = null) D  left join Phong
		on Phong.maPhong = D.maPhong where maLoaiPhong = @maLoaiPhong) H
			ON phong.maPhong = H.maPhong
End
Go



Create proc DanhSachPhongConTrongTatCa
@checkIn date, 
@checkOut date,
@maLoaiPhong nvarchar(20)
As
Begin

	Select * from Phong 
	INNER JOIN
	(Select maPhong from Phong where maLoaiPhong = @maLoaiPhong
	except
	select D.maPhong from 
		(SELECT Phong.maPhong from Phong right join (select maPhong from PhieuDatPhong INNER JOIN ChiTietDatPhong ON PhieuDatPhong.maDatPhong = ChiTietDatPhong.maDatPhong
				WHERE NOT(ngayDen >= @checkOut or ngayDi <= @checkIn) and tinhTrang = 0 ) Z on Phong.maPhong = Z.maPhong
		union
		select Phong.maPhong from Phong inner join PhieuNhanPhong on Phong.maPhong = PhieuNhanPhong.maPhong where checkOut > @checkIn
		union
		select Phong.maPhong from Phong inner join PhieuSuaPhong on Phong.maPhong = PhieuSuaPhong.maPhong where ngayDuKienKT > @checkIn and ngayDuKienKT = null) D  left join Phong
		on Phong.maPhong = D.maPhong where maLoaiPhong = @maLoaiPhong) H
			ON phong.maPhong = H.maPhong
End
Go


CREATE PROC LayDanhSachPhongDaDangKy
@maDatPhong nvarchar(20)
AS
BEGIN
	SELECT
		 maLoaiPhong ,
		 STUFF(
			 (SELECT DISTINCT ', ' + CAST(maPhong as nvarchar(3))
			  FROM ChiTietDatPhong
			  WHERE maLoaiPhong = a.maLoaiPhong and maDatPhong = @maDatPhong
			  FOR XML PATH (''))
			  , 1, 1, '')  AS dsPhong
	FROM ChiTietDatPhong AS a
	GROUP BY maLoaiPhong
END
GO

CREATE PROC KiemTraDaCoDatPhongChua
@maPhong int, 
@checkIn Date,
@checkOut Date
As
Begin
	select * from PhieuDatPhong inner join ChiTietDatPhong 
	on PhieuDatPhong.maDatPhong = ChiTietDatPhong.maDatPhong
	where maPhong = @maPhong and NOT(ngayDen >= @checkOut or ngayDi <= @checkIn)
	order by ngayDen 
End
GO
