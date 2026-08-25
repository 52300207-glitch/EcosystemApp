
-- ======================
--       STATION
-- ======================
CREATE TABLE Station (
    StationID TEXT PRIMARY KEY,
    WarehouseID TEXT NOT NULL,
    StationName TEXT,
    Address TEXT,
    FOREIGN KEY (WarehouseID) REFERENCES Warehouse(WarehouseID)
);

-- ======================
--       WAREHOUSE
-- ======================
CREATE TABLE Warehouse (
    WarehouseID   TEXT PRIMARY KEY,
    WarehouseName TEXT,
    Address       TEXT,
    isCentral     BOOL DEFAULT 0
);


-- ======================
--     INVENTORY
-- ======================
CREATE TABLE Inventory (
    InventoryID   TEXT    PRIMARY KEY,
    ProductID     TEXT    REFERENCES Product (ProductID),
    PackageID     TEXT,
    WarehouseID   TEXT,
    StockQuantity INTEGER,
    isDelete      BOOL    DEFAULT [false],
    FOREIGN KEY (
        PackageID
    )
    REFERENCES Package (SerialCode),
    FOREIGN KEY (
        WarehouseID
    )
    REFERENCES Warehouse (WarehouseID),
    CONSTRAINT OneProductOrPackage CHECK ( (ProductID IS NOT NULL AND
                                            PackageID IS NULL) OR
                                           (ProductID IS NULL AND
                                            PackageID IS NOT NULL) ) 
);


-- ======================
--  IMPORT/EXPORT INVOICE
-- ======================
CREATE TABLE ImportExportInvoice (
    InvoiceID   TEXT PRIMARY KEY,
    InvoiceDate TEXT,
    InvoiceType TEXT CHECK (InvoiceType IN ('IMPORT', 'EXPORT') ),
    WarehouseID TEXT,
    Notes       TEXT,
    TotalBill   REAL DEFAULT (0),
    FOREIGN KEY (
        WarehouseID
    )
    REFERENCES Warehouse (WarehouseID) 
);

-- ======================
--  INVOICE DETAILS
-- ======================
CREATE TABLE InvoiceDetail (
    InvoiceDetailID TEXT    PRIMARY KEY,
    InvoiceID       TEXT,
    ProductID       TEXT,
    Quantity        INTEGER,
    TotalAmount     DECIMAL,
    PackageID       INTEGER REFERENCES Package (PackageID),
    FOREIGN KEY (
        InvoiceID
    )
    REFERENCES ImportExportInvoice (InvoiceID),
    FOREIGN KEY (
        ProductID
    )
    REFERENCES Product (ProductID) 
);



-- ======================
-- 3. PRODUCT
-- ======================
CREATE TABLE Product (
    ProductID    TEXT PRIMARY KEY,
    ProductName  TEXT UNIQUE,
    Category     TEXT,
    Unit         TEXT,
    SellingPrice REAL,
    isDelete     BOOL DEFAULT [false]
);


--===========================
-- PACKAGE TYPE
--=============================
CREATE TABLE PackagingType (
    PackagingTypeID TEXT    PRIMARY KEY,
    TypeName        TEXT,
    Material        TEXT,
    ReuseLimit      INTEGER DEFAULT 10,
    Deposit         REAL
);


-- ======================
-- 4. PACKAGING
-- ======================
CREATE TABLE Package (
    PackageID       INTEGER PRIMARY KEY AUTOINCREMENT,
    PackagingTypeID TEXT,
    SerialCode      TEXT    UNIQUE,
    Status          TEXT    CHECK (Status IN ('Available', 'InUse', 'Returned', 'Broken', 'Cleaning') ) 
                            DEFAULT 'Available',
    ReuseCount      INTEGER DEFAULT 0,
    isDelete        BOOL    DEFAULT 0,
    FOREIGN KEY (
        PackagingTypeID
    )
    REFERENCES PackagingType (PackagingTypeID) 
);

-- ======================
-- 5. CLEANING SCHEDULE
-- ======================
CREATE TABLE CleaningSchedule (
    CleaningID   TEXT PRIMARY KEY,
    CleaningDate TEXT,
    Status       TEXT,
    StartTime    TEXT,
    EndTime      TEXT
);


-- ======================
-- 6. WAREHOUSE CLEANING
-- ======================
CREATE TABLE WarehouseCleaning (
    WarehouseCleaningID TEXT PRIMARY KEY,
    WarehouseID         TEXT,
    CleaningID          TEXT,
    FOREIGN KEY (
        WarehouseID
    )
    REFERENCES Warehouse (WarehouseID),
    FOREIGN KEY (
        CleaningID
    )
    REFERENCES CleaningSchedule (CleaningID) 
);

-- ======================
-- 7. PACKAGING CLEANING
-- ======================
CREATE TABLE PackagingCleaning (
    PackagingCleaningID TEXT,
    PackagingID         INTEGER,
    CleaningID          TEXT,
    PRIMARY KEY (
        PackagingCleaningID
    ),
    FOREIGN KEY (
        CleaningID
    )
    REFERENCES CleaningSchedule (CleaningID),
    FOREIGN KEY (
        PackagingID
    )
    REFERENCES Package (PackageID) 
);

-- ======================
-- 8. EMPLOYEE
-- ======================
CREATE TABLE Employee (
    EmployeeID TEXT         PRIMARY KEY,
    FullName   TEXT,
    BirthDate  TEXT,
    Position   TEXT,
    Phone      VARCHAR (11) UNIQUE,
    Email      TEXT,
    StationID  TEXT,
    isDelete   BOOL         DEFAULT [false],
    FOREIGN KEY (
        StationID
    )
    REFERENCES Station (StationID) 
);

-- ======================
-- 9. WORK SHIFT
-- ======================
CREATE TABLE WorkShift (
    ShiftID   INTEGER PRIMARY KEY,
    StartTime TEXT,
    EndTime   TEXT
);

-- ======================
-- 10. SHIFT ASSIGNMENT
-- ======================
CREATE TABLE ShiftAssignment (
    AssignmentID INTEGER PRIMARY KEY,
    EmployeeID   TEXT,
    ShiftID      INTEGER,
    WorkDate     TEXT,
    Status       TEXT,
    Notes        TEXT,
    FOREIGN KEY (
        EmployeeID
    )
    REFERENCES Employee (EmployeeID),
    FOREIGN KEY (
        ShiftID
    )
    REFERENCES WorkShift (ShiftID) 
);

CREATE TABLE PrepareAssignment(
    PrepareID INTEGER PRIMARY KEY AUTOINCREMENT,
    EmployeeID,
    OrderID,
    Notes,
    FOREIGN KEY(EmployeeID) References Employee(EmployeeID),
    Foreign key (OrderID) References Orders(OrderID)
);

-- ======================
-- 11. CUSTOMER
-- ======================
CREATE TABLE Customer (
    CustomerID TEXT PRIMARY KEY,
    FullName   TEXT,
    Phone      TEXT,
    Address    TEXT,
    Email      TEXT,
    isDelete   BOOL
);

-- ======================
-- 15. ORDER
-- ======================
CREATE TABLE Orders (
    OrderID            TEXT PRIMARY KEY,
    OrderDate          TEXT DEFAULT (datetime('Now') ),
    TotalAmount        REAL,
    TransactionType    TEXT CHECK (TransactionType IN ('CASH', 'BANKING') ) 
                            DEFAULT 'CASH',
    CustomerID         TEXT,
    EmployeeID         TEXT,
    DeliveryEmployeeID TEXT,
    Status             TEXT CHECK (Status IN ('New', 'Prepare', 'Shipping', 'Complete', 'Recall Package') ) 
                            DEFAULT 'New',
    isDelete           BOOL DEFAULT 0,
    DeliveryAddress    TEXT,
    OrderAddress       TEXT,
    FOREIGN KEY (
        CustomerID
    )
    REFERENCES Customer (CustomerID),
    FOREIGN KEY (
        EmployeeID
    )
    REFERENCES Employee (EmployeeID),
    FOREIGN KEY (
        DeliveryEmployeeID
    )
    REFERENCES Employee (EmployeeID) 
);


-- ======================
-- 16. ORDER DETAILS
-- ======================
CREATE TABLE OrderDetail (
    OrderDetailID   TEXT    PRIMARY KEY,
    ProductID       TEXT,
    OrderID         TEXT,
    ProductQuantity INTEGER,
    TotalPrice      REAL,
    FOREIGN KEY (
        ProductID
    )
    REFERENCES Product (ProductID),
    FOREIGN KEY (
        OrderID
    )
    REFERENCES Orders (OrderID) 
);



CREATE TABLE OrderPackaging (
    OrderPackagingID TEXT    PRIMARY KEY,
    OrderID          TEXT,
    PackageID        INTEGER,
    ActionType       TEXT    CHECK (ActionType IN ('ISSUE', 'RETURN') ),
    ActionDate       TEXT    DEFAULT (datetime('now') ),
    TotalBill        REAL,
    FOREIGN KEY (
        OrderID
    )
    REFERENCES Orders (OrderID),
    FOREIGN KEY (
        PackageID
    )
    REFERENCES Package (PackageID) 
);



-- ======================
-- 18. KPI
-- ======================
CREATE TABLE EmployeeKPI (
    KPIID      INTEGER PRIMARY KEY,
    EmployeeID TEXT,
    Notes      TEXT,
    Score      INTEGER,
    FOREIGN KEY (
        EmployeeID
    )
    REFERENCES Employee (EmployeeID) 
);

CREATE TABLE User (
    Id       INTEGER      PRIMARY KEY AUTOINCREMENT,
    EmpPhone VARCHAR (11),
    Username TEXT         UNIQUE
                          NOT NULL,
    Password TEXT         NOT NULL,
    Role     TEXT         CHECK (Role IN ('Seller', 'Delivery', 'Manager') ),
    FOREIGN KEY (
        EmpPhone
    )
    REFERENCES Employee (Phone) 
);


CREATE TABLE Admin(
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Username TEXT UNIQUE NOT NULL,
    Password TEXT NOT NULL
);-- Chior dùng chỉnh sửa tài khoản

CREATE TABLE DeliveryAssignment(
    ID INTEGER PRIMARY KEY AUTOINCREMENT,
    EmployeeID TEXT,
    OrderID TEXT UNIQUE,
    Status TEXT,
    Note,
    FOREIGN KEY (EMPLOYEEID) REFERENCES Employee(EmployeeID),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);


SELECT da.EmployeeID AS EmployeeID,
       e.FullName    AS EmployeeName,
       da.OrderID    AS OrderID,
       o.DeliveryAddress AS DeliveryAddress,
       o.OrderAddress AS OrderAddress,
       da.Status     AS Status
FROM DeliveryAssignment da
JOIN Employee e ON da.EmployeeID = e.EmployeeID
JOIN Orders o ON da.OrderID = o.OrderID;

--==========================
--TRIGGER
--==========================

-- Cập nhật tồn kho sau khi thêm đơn hàng 

CREATE TRIGGER trg_UpdateOrderShipping
AFTER INSERT ON DeliveryAssignment
FOR EACH ROW
BEGIN
    UPDATE Orders
    SET Status = 'Shipping'
    WHERE OrderID = NEW.OrderID;
END;

CREATE TRIGGER trg_UpdateOrderStatusAfterComplete
AFTER UPDATE OF Status ON DeliveryAssignment
FOR EACH ROW
WHEN NEW.Status = 'Complete'
BEGIN
    UPDATE Orders
    SET Status = 'Complete'
    WHERE OrderID = NEW.OrderID;
END;



-- Trigger cập nhật trạng thái đơn hàng khi thêm PrepareAssignment
CREATE TRIGGER trg_UpdateOrderStatusAfterPrepare
AFTER INSERT ON PrepareAssignment
FOR EACH ROW
BEGIN
    UPDATE Orders
    SET Status = 'Prepare'
    WHERE OrderID = NEW.OrderID;
END;


CREATE TRIGGER trg_Inventory_Export_Product
AFTER INSERT ON InvoiceDetail
FOR EACH ROW
WHEN (SELECT InvoiceType 
      FROM ImportExportInvoice 
      WHERE InvoiceID = NEW.InvoiceID) = 'EXPORT'
  AND NEW.ProductID IS NOT NULL
BEGIN
    -- Trừ tồn kho theo số lượng
    UPDATE Inventory
    SET StockQuantity = StockQuantity - NEW.Quantity
    WHERE ProductID = NEW.ProductID
      AND WarehouseID = (SELECT WarehouseID 
                         FROM ImportExportInvoice 
                         WHERE InvoiceID = NEW.InvoiceID);

    -- Nếu tồn kho âm → báo lỗi
    SELECT CASE 
        WHEN EXISTS (
            SELECT 1 FROM Inventory
            WHERE ProductID = NEW.ProductID
              AND WarehouseID = (SELECT WarehouseID 
                                 FROM ImportExportInvoice 
                                 WHERE InvoiceID = NEW.InvoiceID)
              AND StockQuantity < 0
        ) THEN
            RAISE(ABORT, 'Lỗi: Sản phẩm không tồn tại đủ số lượng trong kho')
    END;
END;

CREATE TRIGGER trg_Inventory_Import_Product
AFTER INSERT ON InvoiceDetail
FOR EACH ROW
WHEN EXISTS (
    SELECT 1
    FROM ImportExportInvoice
    WHERE InvoiceID = NEW.InvoiceID
      AND InvoiceType = 'IMPORT'
	AND NEW.ProductID IS NOT NULL
)
BEGIN
    -- Lấy WarehouseID từ Invoice
    -- UPDATE nếu tồn tại product trong kho
    UPDATE Inventory
    SET StockQuantity = StockQuantity + NEW.Quantity
    WHERE WarehouseID = (SELECT WarehouseID 
                         FROM ImportExportInvoice 
                         WHERE InvoiceID = NEW.InvoiceID
                         LIMIT 1)
      AND (
          (ProductID IS NOT NULL AND ProductID = NEW.ProductID AND PackageID IS NULL) OR
          (PackageID IS NOT NULL AND PackageID = NEW.PackageID AND ProductID IS NULL)
      );

    -- INSERT nếu UPDATE không thay đổi dòng nào
    INSERT INTO Inventory (ProductID, PackageID, WarehouseID, StockQuantity)
    SELECT NEW.ProductID,
           NEW.PackageID,
           (SELECT WarehouseID 
            FROM ImportExportInvoice 
            WHERE InvoiceID = NEW.InvoiceID
            LIMIT 1),
           NEW.Quantity
    WHERE (SELECT changes()) = 0;
END;






DROP TRIGGER IF EXISTS trg_upsert_customer;
--UPSERT
CREATE TRIGGER trg_upsert_customer
BEFORE INSERT ON Customer
FOR EACH ROW
WHEN EXISTS (SELECT 1 FROM Customer WHERE Phone = New.Phone)
BEGIN
    UPDATE Customer
    SET 
        FullName = NEW.FullName,
        Address = NEW.Address,
        Email = NEW.Email,
        isDelete = NEW.isDelete
    WHERE Phone = New.Phone;

    -- Hủy thao tác INSERT gốc
    SELECT RAISE(IGNORE);
END;


--====================================
-- INSERT DỮ LIỆU
--==================================
INSERT INTO Admin(Username, Password) Values(
'testad','123'
);

PRAGMA foreign_keys = ON;



--========================
--Xóa Dữ liệu
--========================
PRAGMA foreign_keys = OFF;

DELETE FROM WarehouseCleaning;
DELETE FROM PackagingCleaning;
DELETE FROM CleaningSchedule;
DELETE FROM Inventory;
DELETE FROM InvoiceDetail;
DELETE FROM ImportExportInvoice;
DELETE FROM OrderDetail;
DELETE FROM Orders;
DELETE FROM Product;
DELETE FROM EmployeeKPI;
DELETE FROM ShiftAssignment;
DELETE FROM WorkShift;
DELETE FROM Customer;
DELETE FROM Station;
DELETE FROM Warehouse;
DELETE FROM Employee;
DELETE FROM User;
DELETE FROM Admin;

PRAGMA foreign_keys = ON;

--===============
--
--===============
-- Tắt kiểm tra khóa ngoại tạm thời để tránh lỗi khi xóa
PRAGMA foreign_keys = OFF;

-- Xóa bảng phụ thuộc trước (bảng có khóa ngoại tham chiếu)

DROP TABLE IF EXISTS OrderDetail;
DROP TABLE IF EXISTS Orders;
DROP TABLE IF EXISTS InvoiceDetail;
DROP TABLE IF EXISTS ImportExportInvoice;
DROP TABLE IF EXISTS Station;
DROP TABLE IF EXISTS Customer;
DROP TABLE IF EXISTS ShiftAssignment;
DROP TABLE IF EXISTS WorkShift;
DROP TABLE IF EXISTS EmployeeKPI;
DROP TABLE IF EXISTS PackagingCleaning;
DROP TABLE IF EXISTS WarehouseCleaning;
DROP TABLE IF EXISTS CleaningSchedule;
DROP TABLE IF EXISTS Inventory;
DROP TABLE IF EXISTS Product;
DROP TABLE IF EXISTS Employee;
DROP TABLE IF EXISTS Warehouse;
DROP TABLE IF EXISTS OrderPackaging;
DROP TABLE IF EXISTS Package;
DROP TABLE IF EXISTS PackagingType;
DROP TABLE IF EXISTS Admin;
DROP TABLE IF EXISTS User;

-- Bật lại kiểm tra khóa ngoại
PRAGMA foreign_keys = ON;





PRAGMA foreign_keys = ON;

-- ===============================
-- 1. WAREHOUSE (KHO) -- STATION
-- ===============================
INSERT INTO Warehouse (WarehouseID, WarehouseName, Address, isCentral)
VALUES
('WH001', 'Kho Trung Tâm', '123 Nguyễn Văn Linh', 1),

('WH003', 'Kho Quận 7', '22 Nguyễn Hữu Thọ', 0),
('WH004', 'Kho Quận Bình Thạnh', '98 Xô Viết Nghệ Tĩnh', 0),
('WH005', 'Kho Quận Tân Bình', '77 Cộng Hòa', 0),
('WH006', 'Kho Củ Chi', '12 Tỉnh Lộ 8', 0),
('WH007', 'Kho Long An', 'KCN Long Hậu', 0),
('WH008', 'Kho Bình Dương', 'KCN Sóng Thần', 0),
('WH009', 'Kho Đồng Nai', 'Biên Hòa', 0),
('WH010', 'Kho Gò Vấp', '60 Quang Trung', 0),
('WH011', 'Kho Hóc Môn', '40 Lê Thị Hà', 0),
('WH012', 'Kho Nhà Bè', '15 Huỳnh Tấn Phát', 0),
('WH013', 'Kho Thủ Đức', '200 Võ Văn Ngân', 0),
('WH014', 'Kho Quận 10', '50 Lý Thường Kiệt', 0),
('WH015', 'Kho Quận 12', '8 Tô Ký', 0);

--('WH002', 'Kho Quận 1', '45 Lê Lợi', 0),
INSERT INTO Station (StationID, WarehouseID, StationName, Address)
VALUES
--('ST001', 'WH002', 'Trạm Quận 1', '45 Lê Lợi'),
('ST002', 'WH003', 'Trạm Quận 7', '22 Nguyễn Hữu Thọ'),
('ST003', 'WH004', 'Trạm Bình Thạnh', '98 Xô Viết Nghệ Tĩnh'),
('ST004', 'WH005', 'Trạm Tân Bình', '77 Cộng Hòa'),
('ST005', 'WH010', 'Trạm Gò Vấp', '60 Quang Trung'),
('ST006', 'WH011', 'Trạm Hóc Môn', '40 Lê Thị Hà'),
('ST007', 'WH012', 'Trạm Nhà Bè', '15 Huỳnh Tấn Phát'),
('ST008', 'WH013', 'Trạm Thủ Đức', '200 Võ Văn Ngân'),
('ST009', 'WH014', 'Trạm Quận 10', '50 Lý Thường Kiệt'),
('ST010', 'WH015', 'Trạm Quận 12', '8 Tô Ký'),
('ST011', 'WH006', 'Trạm Củ Chi', '12 Tỉnh Lộ 8'),
('ST012', 'WH007', 'Trạm Long An', 'KCN Long Hậu'),
('ST013', 'WH008', 'Trạm Bình Dương', 'KCN Sóng Thần'),
('ST014', 'WH009', 'Trạm Đồng Nai', 'Biên Hòa'),
('ST015', 'WH001', 'Trạm Trung Tâm', '123 Nguyễn Văn Linh');

-- ===============================
-- 2. PACKAGING TYPE (LOẠI BAO BÌ)
-- ===============================
INSERT INTO PackagingType (PackagingTypeID, TypeName, Material, ReuseLimit)
VALUES
('PKT001', 'Chai nhựa 500ml', 'Nhựa PET', 10),
('PKT002', 'Chai nhựa 1L', 'Nhựa HDPE', 12),
('PKT003', 'Can 2L', 'Nhựa PP',  8),
('PKT004', 'Túi 3kg', 'PE', 5),
('PKT005', 'Tuýp 200ml', 'Nhựa mềm',15),
('PKT006', 'Chai thủy tinh 500ml', 'Thủy tinh',20),
('PKT007', 'Gói 300g', 'Giấy', 5),
('PKT008', 'Chai 250ml', 'Nhựa PET', 10),
('PKT009', 'Chai 1L nắp bật', 'Nhựa HDPE', 10),
('PKT010', 'Bình 2L', 'Thủy tinh',  15),
('PKT011', 'Chai 750ml', 'Nhựa',10),
('PKT012', 'Can 5L', 'Nhựa', 8),
('PKT013', 'Chai 100ml', 'Nhựa',  15),
('PKT014', 'Túi 500g', 'PE', 5),
('PKT015', 'Bình thủy tinh 1L', 'Thủy tinh', 15);


-- ===============================
-- 3. PRODUCT (SẢN PHẨM)
-- ===============================
INSERT INTO Product (ProductID, ProductName, Category, Unit, SellingPrice)
VALUES
('P001', 'Dầu gội 500ml', '500ml', 'Chai', 55000),
('P002', 'Nước rửa chén 500ml', '500ml', 'Chai', 30000),
('P003', 'Sữa tắm 1L', '1000ml', 'Chai', 85000),
('P004', 'Bột giặt 3kg', '3kg', 'Túi', 125000),
('P005', 'Nước lau sàn 1L', '1L', 'Chai', 60000),
('P006', 'Nước giặt 2L', '2L', 'Can', 98000),
('P007', 'Dầu xả 500ml', '500ml', 'Chai', 50000),
('P008', 'Kem rửa tay 250ml', '250ml', 'Chai', 40000),
('P009', 'Chất tẩy rửa bếp', '500ml', 'Chai', 45000),
('P010', 'Nước xịt kính', '500ml', 'Chai', 35000),
('P011', 'Nước xả vải 1L', '1L', 'Chai', 70000),
('P012', 'Sữa rửa mặt 200ml', '200ml', 'Tuýp', 65000),
('P013', 'Bột tẩy lồng giặt', '300g', 'Gói', 25000),
('P014', 'Dầu gội trẻ em 250ml', '250ml', 'Chai', 45000),
('P015', 'Dầu gội thiên nhiên 500ml', '500ml', 'Chai', 75000);


-- ===============================
-- 4. CUSTOMER (KHÁCH HÀNG) -- EMPLOYEE
-- ===============================
INSERT INTO Customer (CustomerID, FullName, Phone, Address)
VALUES
('C001','Nguyễn Văn A','0901111111','TP.HCM'),
('C002','Trần Thị B','0902222222','Hà Nội'),
('C003','Lê Văn C','0903333333','Đà Nẵng'),
('C004','Phạm Thị D','0904444444','Huế'),
('C005','Võ Văn E','0905555555','Bình Dương'),
('C006','Hoàng Thị F','0906666666','Long An'),
('C007','Đỗ Văn G','0907777777','Hải Phòng'),
('C008','Nguyễn Thị H','0908888888','Cần Thơ'),
('C009','Phan Văn I','0909999999','Quảng Ninh'),
('C010','Lê Thị J','0910000000','Bạc Liêu'),
('C011','Nguyễn Văn K','0911111111','Nha Trang'),
('C012','Trần Thị L','0912222222','Tây Ninh'),
('C013','Lê Văn M','0913333333','Đồng Nai'),
('C014','Phạm Thị N','0914444444','Sóc Trăng'),
('C015','Võ Văn O','0915555555','Vũng Tàu');


INSERT INTO Employee (EmployeeID, FullName, BirthDate, Position, Phone, Email, StationID)
VALUES
('EMP01', 'Nguyễn Văn An', '1990-03-05', 'Bán hàng', '0901111111', 'an@sapo.vn', 'ST001'),
('EMP02', 'Trần Thị Bình', '1992-05-10', 'Bán hàng', '0902222222', 'binh@sapo.vn', 'ST002'),
('EMP03', 'Phạm Văn Cường', '1988-07-12', 'Giao hàng', '0903333333', 'cuong@sapo.vn', 'ST003'),
('EMP04', 'Lê Thị Dung', '1995-02-08', 'Thu ngân', '0904444444', 'dung@sapo.vn', 'ST004'),
('EMP05', 'Đỗ Văn Em', '1991-06-20', 'Bán hàng', '0905555555', 'em@sapo.vn', 'ST005'),
('EMP06', 'Nguyễn Thị Hạnh', '1993-09-15', 'Bán hàng', '0906666666', 'hanh@sapo.vn', 'ST006'),
('EMP07', 'Trần Quốc Huy', '1990-12-01', 'Quản lý', '0907777777', 'huy@sapo.vn', 'ST007'),
('EMP08', 'Phạm Anh Khoa', '1992-08-25', 'Giao hàng', '0908888888', 'khoa@sapo.vn', 'ST008'),
('EMP09', 'Nguyễn Thị Lan', '1996-11-18', 'Bán hàng', '0909999999', 'lan@sapo.vn', 'ST009'),
('EMP10', 'Trần Văn Minh', '1985-04-22', 'Giao hàng', '0910000000', 'minh@sapo.vn', 'ST010'),
('EMP11', 'Lê Hồng Ngọc', '1997-02-11', 'Bán hàng', '0911111111', 'ngoc@sapo.vn', 'ST011'),
('EMP12', 'Nguyễn Tuấn Kiệt', '1989-07-09', 'Quản lý', '0912222222', 'kiet@sapo.vn', 'ST012'),
('EMP13', 'Đoàn Thị Oanh', '1994-10-03', 'Bán hàng', '0913333333', 'oanh@sapo.vn', 'ST013'),
('EMP14', 'Phạm Văn Phúc', '1991-11-29', 'Bán hàng', '0914444444', 'phuc@sapo.vn', 'ST014'),
('EMP15', 'Trần Thị Quyên', '1998-01-18', 'Giao hàng', '0915555555', 'quyen@sapo.vn', 'ST015');

-- ===============================
-- 5. ORDER (ĐƠN HÀNG)
-- ===============================
INSERT INTO Employee (EmployeeID, FullName, BirthDate, Position, Phone, Email, StationID)
VALUES
('EMP011', 'Nguyễn Văn An', '1990-03-05', 'Bán hàng', '0901111111', 'an@sapo.vn', 'ST001');

INSERT INTO User(empPhone,username, password, Role)
Values('0901111111', 'test', '123','Seller');
-- ===============================
-- 7. PACKAGE (BAO BÌ)
-- ===============================
INSERT INTO Package (PackagingTypeID, SerialCode, Status, CurrentWarehouseID, ReuseCount)
VALUES
('PKT001', 'PK001', 'Available', 'WH002', 0),
('PKT001', 'PK002', 'Available', 'WH002', 0),
('PKT001', 'PK003', 'Available', 'WH003', 0),
('PKT002', 'PK004', 'Available', 'WH004', 0),
('PKT002', 'PK005', 'Available', 'WH004', 0),
('PKT003', 'PK006', 'Available', 'WH005', 0),
('PKT004', 'PK007', 'Available', 'WH005', 0),
('PKT005', 'PK008', 'Available', 'WH006', 0),
('PKT006', 'PK009', 'Available', 'WH006', 0),
('PKT007', 'PK010', 'Available', 'WH007', 0),
('PKT008', 'PK011', 'Available', 'WH008', 0),
('PKT009', 'PK012', 'Available', 'WH009', 0),
('PKT010', 'PK013', 'Available', 'WH010', 0),
('PKT011', 'PK014', 'Available', 'WH011', 0),
('PKT012', 'PK015', 'Available', 'WH012', 0);

INSERT INTO Inventory (ProductID, WarehouseID, StockQuantity)
VALUES ('P001', 'WH003', 100),
('P002', 'WH002', 100),
('P003', 'WH002', 100),
('P004', 'WH002', 100),
('P005', 'WH002', 100),
('P001', 'WH004', 100),
('P002', 'WH007', 100),
('P001', 'WH006', 100),
('P009', 'WH009', 100),
('P010', 'WH003', 100),
('P007', 'WH002', 100);



WITH RECURSIVE
cnt(x) AS (
  SELECT 1
  UNION ALL
  SELECT x + 1 FROM cnt WHERE x < 100
)
INSERT INTO Package (PackagingTypeID, SerialCode, Status, ReuseCount, isDelete)
SELECT
  CASE
    WHEN (x % 5) = 1 THEN 'PKT001'
    WHEN (x % 5) = 2 THEN 'PKT002'
    WHEN (x % 5) = 3 THEN 'PKT003'
    WHEN (x % 5) = 4 THEN 'PKT004'
    ELSE 'PKT005'
  END AS Packaging,
  printf('PK%03d', x + 16) AS SerialCode, -- tạo mã PK017, PK018,...
  CASE
    WHEN (x % 6) <= 2 THEN 'InUse'
    ELSE 'Available'
  END AS Status,
  (ABS(RANDOM()) % 300) AS ReuseCount,  -- số ngẫu nhiên 0–299
  0 AS isDelete
FROM cnt;

INSERT INTO Inventory (ProductID, PackageID, WarehouseID, StockQuantity)
VALUES
-- WH001
('P001', NULL, 'WH001', 10000),
('P002', NULL, 'WH001', 10000),
('P003', NULL, 'WH001', 10000),
('P004', NULL, 'WH001', 10000),
('P005', NULL, 'WH001', 10000),
('P006', NULL, 'WH001', 10000),
('P007', NULL, 'WH001', 10000),
('P008', NULL, 'WH001', 10000),
('P009', NULL, 'WH001', 10000),
('P010', NULL, 'WH001', 10000),
('P011', NULL, 'WH001', 10000),
('P012', NULL, 'WH001', 10000),
('P013', NULL, 'WH001', 10000),
('P014', NULL, 'WH001', 10000),
('P015', NULL, 'WH001', 10000),
('P016', NULL, 'WH001', 10000),

-- WH002
('P001', NULL, 'WH002', 10000),
('P002', NULL, 'WH002', 10000),
('P003', NULL, 'WH002', 10000),
('P004', NULL, 'WH002', 10000),
('P005', NULL, 'WH002', 10000),
('P006', NULL, 'WH002', 10000),
('P007', NULL, 'WH002', 10000),
('P008', NULL, 'WH002', 10000),
('P009', NULL, 'WH002', 10000),
('P010', NULL, 'WH002', 10000),
('P011', NULL, 'WH002', 10000),
('P012', NULL, 'WH002', 10000),
('P013', NULL, 'WH002', 10000),
('P014', NULL, 'WH002', 10000),
('P015', NULL, 'WH002', 10000),
('P016', NULL, 'WH002', 10000),

-- WH003
('P001', NULL, 'WH003', 10000),
('P002', NULL, 'WH003', 10000),
('P003', NULL, 'WH003', 10000),
('P004', NULL, 'WH003', 10000),
('P005', NULL, 'WH003', 10000),
('P006', NULL, 'WH003', 10000),
('P007', NULL, 'WH003', 10000),
('P008', NULL, 'WH003', 10000),
('P009', NULL, 'WH003', 10000),
('P010', NULL, 'WH003', 10000),
('P011', NULL, 'WH003', 10000),
('P012', NULL, 'WH003', 10000),
('P013', NULL, 'WH003', 10000),
('P014', NULL, 'WH003', 10000),
('P015', NULL, 'WH003', 10000),
('P016', NULL, 'WH003', 10000),

-- WH004
('P001', NULL, 'WH004', 10000),
('P002', NULL, 'WH004', 10000),
('P003', NULL, 'WH004', 10000),
('P004', NULL, 'WH004', 10000),
('P005', NULL, 'WH004', 10000),
('P006', NULL, 'WH004', 10000),
('P007', NULL, 'WH004', 10000),
('P008', NULL, 'WH004', 10000),
('P009', NULL, 'WH004', 10000),
('P010', NULL, 'WH004', 10000),
('P011', NULL, 'WH004', 10000),
('P012', NULL, 'WH004', 10000),
('P013', NULL, 'WH004', 10000),
('P014', NULL, 'WH004', 10000),
('P015', NULL, 'WH004', 10000),
('P016', NULL, 'WH004', 10000),

-- WH005
('P001', NULL, 'WH005', 10000),
('P002', NULL, 'WH005', 10000),
('P003', NULL, 'WH005', 10000),
('P004', NULL, 'WH005', 10000),
('P005', NULL, 'WH005', 10000),
('P006', NULL, 'WH005', 10000),
('P007', NULL, 'WH005', 10000),
('P008', NULL, 'WH005', 10000),
('P009', NULL, 'WH005', 10000),
('P010', NULL, 'WH005', 10000),
('P011', NULL, 'WH005', 10000),
('P012', NULL, 'WH005', 10000),
('P013', NULL, 'WH005', 10000),
('P014', NULL, 'WH005', 10000),
('P015', NULL, 'WH005', 10000),
('P016', NULL, 'WH005', 10000),

-- WH006
('P001', NULL, 'WH006', 10000),
('P002', NULL, 'WH006', 10000),
('P003', NULL, 'WH006', 10000),
('P004', NULL, 'WH006', 10000),
('P005', NULL, 'WH006', 10000),
('P006', NULL, 'WH006', 10000),
('P007', NULL, 'WH006', 10000),
('P008', NULL, 'WH006', 10000),
('P009', NULL, 'WH006', 10000),
('P010', NULL, 'WH006', 10000),
('P011', NULL, 'WH006', 10000),
('P012', NULL, 'WH006', 10000),
('P013', NULL, 'WH006', 10000),
('P014', NULL, 'WH006', 10000),
('P015', NULL, 'WH006', 10000),
('P016', NULL, 'WH006', 10000),

-- WH007
('P001', NULL, 'WH007', 10000),
('P002', NULL, 'WH007', 10000),
('P003', NULL, 'WH007', 10000),
('P004', NULL, 'WH007', 10000),
('P005', NULL, 'WH007', 10000),
('P006', NULL, 'WH007', 10000),
('P007', NULL, 'WH007', 10000),
('P008', NULL, 'WH007', 10000),
('P009', NULL, 'WH007', 10000),
('P010', NULL, 'WH007', 10000),
('P011', NULL, 'WH007', 10000),
('P012', NULL, 'WH007', 10000),
('P013', NULL, 'WH007', 10000),
('P014', NULL, 'WH007', 10000),
('P015', NULL, 'WH007', 10000),
('P016', NULL, 'WH007', 10000),

-- WH008
('P001', NULL, 'WH008', 10000),
('P002', NULL, 'WH008', 10000),
('P003', NULL, 'WH008', 10000),
('P004', NULL, 'WH008', 10000),
('P005', NULL, 'WH008', 10000),
('P006', NULL, 'WH008', 10000),
('P007', NULL, 'WH008', 10000),
('P008', NULL, 'WH008', 10000),
('P009', NULL, 'WH008', 10000),
('P010', NULL, 'WH008', 10000),
('P011', NULL, 'WH008', 10000),
('P012', NULL, 'WH008', 10000),
('P013', NULL, 'WH008', 10000),
('P014', NULL, 'WH008', 10000),
('P015', NULL, 'WH008', 10000),
('P016', NULL, 'WH008', 10000),

-- WH009
('P001', NULL, 'WH009', 10000),
('P002', NULL, 'WH009', 10000),
('P003', NULL, 'WH009', 10000),
('P004', NULL, 'WH009', 10000),
('P005', NULL, 'WH009', 10000),
('P006', NULL, 'WH009', 10000),
('P007', NULL, 'WH009', 10000),
('P008', NULL, 'WH009', 10000),
('P009', NULL, 'WH009', 10000),
('P010', NULL, 'WH009', 10000),
('P011', NULL, 'WH009', 10000),
('P012', NULL, 'WH009', 10000),
('P013', NULL, 'WH009', 10000),
('P014', NULL, 'WH009', 10000),
('P015', NULL, 'WH009', 10000),
('P016', NULL, 'WH009', 10000),

-- WH010
('P001', NULL, 'WH010', 10000),
('P002', NULL, 'WH010', 10000),
('P003', NULL, 'WH010', 10000),
('P004', NULL, 'WH010', 10000),
('P005', NULL, 'WH010', 10000),
('P006', NULL, 'WH010', 10000),
('P007', NULL, 'WH010', 10000),
('P008', NULL, 'WH010', 10000),
('P009', NULL, 'WH010', 10000),
('P010', NULL, 'WH010', 10000),
('P011', NULL, 'WH010', 10000),
('P012', NULL, 'WH010', 10000),
('P013', NULL, 'WH010', 10000),
('P014', NULL, 'WH010', 10000),
('P015', NULL, 'WH010', 10000),
('P016', NULL, 'WH010', 10000),

-- WH011
('P001', NULL, 'WH011', 10000),
('P002', NULL, 'WH011', 10000),
('P003', NULL, 'WH011', 10000),
('P004', NULL, 'WH011', 10000),
('P005', NULL, 'WH011', 10000),
('P006', NULL, 'WH011', 10000),
('P007', NULL, 'WH011', 10000),
('P008', NULL, 'WH011', 10000),
('P009', NULL, 'WH011', 10000),
('P010', NULL, 'WH011', 10000),
('P011', NULL, 'WH011', 10000),
('P012', NULL, 'WH011', 10000),
('P013', NULL, 'WH011', 10000),
('P014', NULL, 'WH011', 10000),
('P015', NULL, 'WH011', 10000),
('P016', NULL, 'WH011', 10000),

-- WH012
('P001', NULL, 'WH012', 10000),
('P002', NULL, 'WH012', 10000),
('P003', NULL, 'WH012', 10000),
('P004', NULL, 'WH012', 10000),
('P005', NULL, 'WH012', 10000),
('P006', NULL, 'WH012', 10000),
('P007', NULL, 'WH012', 10000),
('P008', NULL, 'WH012', 10000),
('P009', NULL, 'WH012', 10000),
('P010', NULL, 'WH012', 10000),
('P011', NULL, 'WH012', 10000),
('P012', NULL, 'WH012', 10000),
('P013', NULL, 'WH012', 10000),
('P014', NULL, 'WH012', 10000),
('P015', NULL, 'WH012', 10000),
('P016', NULL, 'WH012', 10000),

-- WH013
('P001', NULL, 'WH013', 10000),
('P002', NULL, 'WH013', 10000),
('P003', NULL, 'WH013', 10000),
('P004', NULL, 'WH013', 10000),
('P005', NULL, 'WH013', 10000),
('P006', NULL, 'WH013', 10000),
('P007', NULL, 'WH013', 10000),
('P008', NULL, 'WH013', 10000),
('P009', NULL, 'WH013', 10000),
('P010', NULL, 'WH013', 10000),
('P011', NULL, 'WH013', 10000),
('P012', NULL, 'WH013', 10000),
('P013', NULL, 'WH013', 10000),
('P014', NULL, 'WH013', 10000),
('P015', NULL, 'WH013', 10000),
('P016', NULL, 'WH013', 10000),

-- WH014
('P001', NULL, 'WH014', 10000),
('P002', NULL, 'WH014', 10000),
('P003', NULL, 'WH014', 10000),
('P004', NULL, 'WH014', 10000),
('P005', NULL, 'WH014', 10000),
('P006', NULL, 'WH014', 10000),
('P007', NULL, 'WH014', 10000),
('P008', NULL, 'WH014', 10000),
('P009', NULL, 'WH014', 10000),
('P010', NULL, 'WH014', 10000),
('P011', NULL, 'WH014', 10000),
('P012', NULL, 'WH014', 10000),
('P013', NULL, 'WH014', 10000),
('P014', NULL, 'WH014', 10000),
('P015', NULL, 'WH014', 10000),
('P016', NULL, 'WH014', 10000),

-- WH015
('P001', NULL, 'WH015', 10000),
('P002', NULL, 'WH015', 10000),
('P003', NULL, 'WH015', 10000),
('P004', NULL, 'WH015', 10000),
('P005', NULL, 'WH015', 10000),
('P006', NULL, 'WH015', 10000),
('P007', NULL, 'WH015', 10000),
('P008', NULL, 'WH015', 10000),
('P009', NULL, 'WH015', 10000),
('P010', NULL, 'WH015', 10000),
('P011', NULL, 'WH015', 10000),
('P012', NULL, 'WH015', 10000),
('P013', NULL, 'WH015', 10000),
('P014', NULL, 'WH015', 10000),
('P015', NULL, 'WH015', 10000),
('P016', NULL, 'WH015', 10000);

--VIOEW
CREATE VIEW DeliveryRouteView AS
SELECT 
    da.EmployeeID AS EmployeeID,
    c.Address AS ReceivingAddress,
    s.Address AS DeliveryAddress,
    o.OrderDate AS Time,
    o.OrderID AS OrderID
FROM DeliveryAssignment da
JOIN Orders o ON da.OrderID = o.OrderID
JOIN Customer c ON o.CustomerID = c.CustomerID
LEFT JOIN Employee e ON da.EmployeeID = e.EmployeeID
LEFT JOIN Station s ON e.StationID = s.StationID;

SELECT sa.EmployeeID, sa.ShiftID, sa.WorkDate, sa.Status, sa.Notes, 
       e.FullName, e.BirthDate, e.Position, e.Phone, e.Email,e.StationID,
       ws.ShiftName, ws.StartTime, ws.EndTime
FROM ShiftAssignment sa
LEFT JOIN Employee e ON sa.EmployeeID = e.EmployeeID
LEFT JOIN WorkShift ws ON sa.ShiftID = ws.ShiftID;







