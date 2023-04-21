use master;

--建库建表
if DB_ID('SunSuperMarket') is not null 
 drop database SunSuperMarket
go
create database SunSuperMarket
on(
	name='SunSuperMarket',
	filename='D:\编程\阳光超市管理系统\DB\SunSuperMarket.MDF'
)

use SunSupermarket;

if OBJECT_ID('TypeP') is not null
 drop table TypeP
go
create table TypeP
(
	CdTid varchar(20) ,		--类型编号
	CdTypeName varchar(20) ,--商品类型名称
);


if OBJECT_ID('Users') is not null
 drop table Users
go
create table Users
(
	UserId varchar(20) ,	--用户编号
	UserName varchar(20) ,  --用户名
	UserPwd varchar(20) ,	--密码
);

if OBJECT_ID('Product') is not null
 drop table Product
go
create table Product
(
	CdId varchar(20) ,		--商品编号
	CdTid varchar(20) ,		--商品类型
	PcName varchar(20) ,	--商品名称
	CdPrice float ,			--商品价格
	CdAmount int ,			--库存
	UserName varchar(20),	--购买人
	Img varchar(50)			--图片
);

--创建表数据

--1：商品类型表
insert TypeP(CdTid,CdTypeName)
 values('TP1','服饰类')
insert TypeP(CdTid,CdTypeName)
 values('TP2','水产类')
insert TypeP(CdTid,CdTypeName)
 values('TP3','五金类')
insert TypeP(CdTid,CdTypeName)
 values('TP4','化工类')
insert TypeP(CdTid,CdTypeName)
 values('TP5','食品类')

--2：用户表
insert Users(UserId,UserName,UserPwd)
 values('U0001','张三','123456')
insert Users(UserId,UserName,UserPwd)
 values('U0002','李四','123456')
insert Users(UserId,UserName,UserPwd)
 values('U0003','王五','123456')
insert Users(UserId,UserName,UserPwd)
 values('U0004','渣六','123456')

--3：商品表
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0001','TP1','鞋子','159','100','张三','D:\编程\阳光超市管理系统\image\商品图片\鞋子.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0002','TP1','袜子','5','100','张三','D:\编程\阳光超市管理系统\image\商品图片\袜子.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0003','TP1','手套','20','100','张三','D:\编程\阳光超市管理系统\image\商品图片\手套.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0004','TP1','围巾','15','100','张三','D:\编程\阳光超市管理系统\image\商品图片\围巾.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0005','TP1','雨伞','35','100','张三','D:\编程\阳光超市管理系统\image\商品图片\雨伞.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0006','TP2','大闸蟹','45','100','李四','D:\编程\阳光超市管理系统\image\商品图片\大闸蟹.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0007','TP2','海带','20','100','李四','D:\编程\阳光超市管理系统\image\商品图片\海带.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0008','TP2','石花菜','45','100','李四','D:\编程\阳光超市管理系统\image\商品图片\石花菜.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0009','TP2','鲤鱼','25','100','李四','D:\编程\阳光超市管理系统\image\商品图片\鲤鱼.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0010','TP2','鲫鱼','20','100','李四','D:\编程\阳光超市管理系统\image\商品图片\鲫鱼.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0011','TP3','菜刀','15','100','王五','D:\编程\阳光超市管理系统\image\商品图片\菜刀.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0012','TP3','钢铁','22','100','王五','D:\编程\阳光超市管理系统\image\商品图片\钢铁.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0013','TP3','铁丝','16','100','王五','D:\编程\阳光超市管理系统\image\商品图片\铁丝.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0014','TP3','钢丝网','26','100','王五','D:\编程\阳光超市管理系统\image\商品图片\钢丝网.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0015','TP3','扁铁','1','100','王五','D:\编程\阳光超市管理系统\image\商品图片\扁铁.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0016','TP4','农药','2','100','渣六','D:\编程\阳光超市管理系统\image\商品图片\农药.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0017','TP5','鸡蛋','6.5','100','渣六','D:\编程\阳光超市管理系统\image\商品图片\鸡蛋.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0018','TP5','油脂','5','100','渣六','D:\编程\阳光超市管理系统\image\商品图片\油脂.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0019','TP5','淀粉','4','100','渣六','D:\编程\阳光超市管理系统\image\商品图片\淀粉.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0020','TP5','糕点','12','100','渣六','D:\编程\阳光超市管理系统\image\商品图片\糕点.jpg')








