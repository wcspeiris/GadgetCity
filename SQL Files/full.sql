create database GadgetCity;

create table SystemUser(
userId int primary key identity not null,
userName varchar(30) not null,
userPassword varchar(200) not null,
authorityLevel int not null,
firstName varchar(50) not null,
lastName  varchar(50) not null,
userAddress varchar(200) not null,
DOB varchar(10) not null,
contactNo varchar(10) not null,
emailAddress varchar(100) not null,
activeStatus varchar(10) not null,
accessedBy int not null,
accessedDateTime varchar(25) not null,
OTP varchar(200),
constraint fkUserAccUserId foreign key (accessedBy) references SystemUser(userId)
);

create table Customer(
customerId int primary key not null,
customerType varchar(20) not null,
constraint fkCustomerTypeId foreign key (customerId) references SystemUser(userId)
);

create table CompanyWeb(
companyName varchar(100) primary key not null,
companyAddress varchar(200) not null,
companyEmail varchar(100) not null,
companyContactNo varchar(12) not null,
sMedia01 varchar(50),
sMedia02 varchar(50),
sMedia03 varchar(50),
sMedia04 varchar(50),
createdBy int not null,
createdDateTime varchar(25) not null,
constraint fkWebAccUserId foreign key (createdBy) references SystemUser(userId)
);

create table VehicleBrand(
brandId int primary key identity not null,
brandName varchar(100) not null,
imgUrl varchar(300) not null,
activeStatus varchar(10) not null
);

create table VehicleModel(
modelId int primary key identity not null,
modelName varchar(100) not null,
vehicleBrandId int not null,
activeStatus varchar(10) not null,
addedBy int not null,
addedDateTime varchar(25) not null,
updatedBy int not null,
updatedDateTime varchar(25) not null,
constraint fkVehicleBrandId foreign key (vehicleBrandId) references VehicleBrand(brandId),
constraint fkVehicleModelAddedBy foreign key (addedBy) references SystemUser(userId),
constraint fkVehicleModelUpdatedBy foreign key (updatedBy) references SystemUser(userId)
);

create table SparePart(
sparePartId int primary key identity not null,
sparePartName varchar(100) not null,
sparePartModalId int not null,
sparePartCategory varchar(100) not null,
manufactureYear varchar(5) not null,
sparePartPrice float not null,
sparePartDescription varchar(200) not null,
availableQuantity int,
activeStatus varchar(10) not null,
addedBy int not null,
addedDateTime varchar(25) not null,
updatedBy int not null,
updatedDateTime varchar(25) not null,
constraint fkSparePartBrandId foreign key (sparePartModalId) references VehicleModel(modelId),
constraint fkSparePartAddedBy foreign key (addedBy) references SystemUser(userId),
constraint fkSparePartUpdatedBy foreign key (updatedBy) references SystemUser(userId)
);

create table Supplier(
supplierId int primary key identity not null,
supplierName varchar(100) not null,
supplierAddress varchar(200) not null,
supplierContactNo varchar(12) not null,
activeStatus varchar(10) not null,
addedBy int not null,
addedDateTime varchar(25) not null,
updateBy int not null,
updateDateTime varchar(25) not null,
constraint fkSupplierAddedBy foreign key (addedBy) references SystemUser(userId),
constraint fkSupplierUpdatedBy foreign key (updateBy) references SystemUser(userId),
);

create table Supply(
supplyInvoiceId int not null,
supplierId int not null,
sparePartId int not null,
receivedQuantity int not null,
receivedDateTime varchar(25) not null,
primary key(supplyInvoiceId, supplierId, sparePartId),
constraint fkSupplierId foreign key (supplierId) references Supplier (supplierId),
constraint fkSupplySparePartId foreign key (sparePartId) references SparePart (sparePartId)
);

create table CustomerOrder(
orderId int primary key identity not null,
customerId int not null,
totalAmount float not null,
orderedDateTime varchar(25) not null,
deliveryRequestStatus varchar(10) not null,
orderStatus varchar(20) not null,
orderPreparedDateTime varchar(25),
accessedBy int not null,
constraint fkOrderCustomerId foreign key (customerId) references SystemUser(userId),
constraint fkOrderAccessedBy foreign key (accessedBy) references SystemUser(userId)
);

create table Payment(
paymentId int primary key identity not null,
paymentOrderId int not null,
paymentMethod varchar(20) not null,
paymentStatus varchar(20) not null,
paymentAcceptedBy int,
paidDateTime varchar(25),
constraint fkPaymentOrderId foreign key (paymentOrderId) references CustomerOrder(orderId),
constraint fkPaymentAcceptedBy foreign key (paymentAcceptedBy) references SystemUser(userId)
);

create table OrderContain(
orderId int not null,
sparePartId int not null,
orderQuantity int not null,
primary key (orderId, sparePartId),
constraint fkOrderId foreign key (orderId) references CustomerOrder (orderId),
constraint fkOrderSparePartId foreign key (sparePartId) references SparePart (sparePartId)
);

CREATE TABLE gcInquery(
	Inquery_id int IDENTITY primary key NOT NULL,
	Inquery_userName varchar(50) NULL,
	Inquery_email varchar(200) NULL,
	inquery_message varchar(1000) NULL,
	inquery_status varchar(50) NULL,
	inquery_date datetime NULL
)