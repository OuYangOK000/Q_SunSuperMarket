use master;

--���⽨��
if DB_ID('SunSuperMarket') is not null 
 drop database SunSuperMarket
go
create database SunSuperMarket
on(
	name='SunSuperMarket',
	filename='D:\���\���ⳬ�й���ϵͳ\DB\SunSuperMarket.MDF'
)

use SunSupermarket;

if OBJECT_ID('TypeP') is not null
 drop table TypeP
go
create table TypeP
(
	CdTid varchar(20) ,		--���ͱ��
	CdTypeName varchar(20) ,--��Ʒ��������
);


if OBJECT_ID('Users') is not null
 drop table Users
go
create table Users
(
	UserId varchar(20) ,	--�û����
	UserName varchar(20) ,  --�û���
	UserPwd varchar(20) ,	--����
);

if OBJECT_ID('Product') is not null
 drop table Product
go
create table Product
(
	CdId varchar(20) ,		--��Ʒ���
	CdTid varchar(20) ,		--��Ʒ����
	PcName varchar(20) ,	--��Ʒ����
	CdPrice float ,			--��Ʒ�۸�
	CdAmount int ,			--���
	UserName varchar(20),	--������
	Img varchar(50)			--ͼƬ
);

--����������

--1����Ʒ���ͱ�
insert TypeP(CdTid,CdTypeName)
 values('TP1','������')
insert TypeP(CdTid,CdTypeName)
 values('TP2','ˮ����')
insert TypeP(CdTid,CdTypeName)
 values('TP3','�����')
insert TypeP(CdTid,CdTypeName)
 values('TP4','������')
insert TypeP(CdTid,CdTypeName)
 values('TP5','ʳƷ��')

--2���û���
insert Users(UserId,UserName,UserPwd)
 values('U0001','����','123456')
insert Users(UserId,UserName,UserPwd)
 values('U0002','����','123456')
insert Users(UserId,UserName,UserPwd)
 values('U0003','����','123456')
insert Users(UserId,UserName,UserPwd)
 values('U0004','����','123456')

--3����Ʒ��
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0001','TP1','Ь��','159','100','����','D:\���\���ⳬ�й���ϵͳ\image\��ƷͼƬ\Ь��.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0002','TP1','����','5','100','����','D:\���\���ⳬ�й���ϵͳ\image\��ƷͼƬ\����.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0003','TP1','����','20','100','����','D:\���\���ⳬ�й���ϵͳ\image\��ƷͼƬ\����.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0004','TP1','Χ��','15','100','����','D:\���\���ⳬ�й���ϵͳ\image\��ƷͼƬ\Χ��.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0005','TP1','��ɡ','35','100','����','D:\���\���ⳬ�й���ϵͳ\image\��ƷͼƬ\��ɡ.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0006','TP2','��բз','45','100','����','D:\���\���ⳬ�й���ϵͳ\image\��ƷͼƬ\��բз.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0007','TP2','����','20','100','����','D:\���\���ⳬ�й���ϵͳ\image\��ƷͼƬ\����.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0008','TP2','ʯ����','45','100','����','D:\���\���ⳬ�й���ϵͳ\image\��ƷͼƬ\ʯ����.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0009','TP2','����','25','100','����','D:\���\���ⳬ�й���ϵͳ\image\��ƷͼƬ\����.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0010','TP2','����','20','100','����','D:\���\���ⳬ�й���ϵͳ\image\��ƷͼƬ\����.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0011','TP3','�˵�','15','100','����','D:\���\���ⳬ�й���ϵͳ\image\��ƷͼƬ\�˵�.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0012','TP3','����','22','100','����','D:\���\���ⳬ�й���ϵͳ\image\��ƷͼƬ\����.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0013','TP3','��˿','16','100','����','D:\���\���ⳬ�й���ϵͳ\image\��ƷͼƬ\��˿.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0014','TP3','��˿��','26','100','����','D:\���\���ⳬ�й���ϵͳ\image\��ƷͼƬ\��˿��.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0015','TP3','����','1','100','����','D:\���\���ⳬ�й���ϵͳ\image\��ƷͼƬ\����.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0016','TP4','ũҩ','2','100','����','D:\���\���ⳬ�й���ϵͳ\image\��ƷͼƬ\ũҩ.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0017','TP5','����','6.5','100','����','D:\���\���ⳬ�й���ϵͳ\image\��ƷͼƬ\����.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0018','TP5','��֬','5','100','����','D:\���\���ⳬ�й���ϵͳ\image\��ƷͼƬ\��֬.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0019','TP5','���','4','100','����','D:\���\���ⳬ�й���ϵͳ\image\��ƷͼƬ\���.jpg')
insert Product(CdId,CdTid,PcName,CdPrice,CdAmount,UserName,Img)
 values('P0020','TP5','���','12','100','����','D:\���\���ⳬ�й���ϵͳ\image\��ƷͼƬ\���.jpg')








