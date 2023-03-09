if not exists (select 1 from dbo.Customer)
begin
	insert into dbo.[Customer](customerId, emailAddress, firstName, lastName, phoneNo, passwordHash, passwordSalt)
	values ('10001', 'example100-1@pocztex.com', 'John', 'Smith', '12345678', 'password10001', 'psalt10001'),
	('10002', 'example100-2@pocztex.com', '2John', '2Smith', '22345678', 'password10002', 'psalt10002'),
	('10003', 'example100-3@pocztex.com', '3John', '3Smith', '32345678', 'password10003', 'psalt10003'),
	('10004', 'example100-4@pocztex.com', '4John', '4Smith', '42345678', 'password10004', 'psalt10004'),
	('10005', 'example100-5@pocztex.com', '5John', '5Smith', '52345678', 'password10005', 'psalt10005'),
	('10006', 'example100-6@pocztex.com', '6John', '6Smith', '62345678', 'password10006', 'psalt10006'),
	('10007', 'example100-7@pocztex.com', '7John', '7Smith', '72345678', 'password10007', 'psalt10007');

		insert into dbo.[Reservation] (Id, starting, ending, title, total,primaryColor,secondaryColor,customerId)
	values (20001,'20120618 10:34:09 AM','20120618 10:54:09 AM','Basic1','12.31','red1', 'black1', 10001),
	(20002,'20120618 10:35:09 AM','20120618 10:55:09 AM','Basic1','12.32','red2', 'black2', 10001),
	(20003,'20120618 10:36:09 AM','20120618 10:56:09 AM','Basic1','12.33','red3', 'black3', 10001),
	(20004,'20120618 10:37:09 AM','20120618 10:57:09 AM','Basic1','12.34','red4', 'black4', 10002),
	(20005,'20120618 10:38:09 AM','20120618 10:58:09 AM','Basic1','12.35','red5', 'black5', 10002),
	(20006,'20120618 10:39:09 AM','20120618 10:59:09 AM','Basic1','12.36','red6', 'black6', 10003),
	(20007,'20120618 10:40:09 AM','20120618 11:00:09 AM','Basic1','12.37','red7', 'black7', 10003),
	(20008,'20120618 10:41:09 AM','20120618 10:01:09 AM','Basic1','12.38','red8', 'black8', 10004),
	(20009,'20120618 10:42:09 AM','20120618 10:02:09 AM','Basic1','12.39','red9', 'black9', 10005);



			insert into dbo.[Payment] ([paymentId],
	  [id],
	  [totalAmount],
	  [paymentDate])
	values (30001,20001,'12.32','20120618 10:34:09 AM'),
	(30002,20002,'12.33','20120618 10:35:09 AM'),
	(30003,20002,'12.31','20120618 10:36:09 AM'),
	(30004,20003,'12.30','20120618 10:37:09 AM');


				insert into dbo.[Roles] (Id, Name, NormalizedName, ConcurrencyStamp)
	values 
	 (1, 'admin','ADMIN', null),
	 (2, 'basic','BASIC', null),
	 (3, 'doctor','DOCTOR', null);



	 	 			insert into dbo.Users ([Id]
      ,[FirstName]
      ,[LastName]
      ,[UserName]
      ,[NormalizedUserName]
      ,[Email]
      ,[NormalizedEmail]
      ,[EmailConfirmed]
      ,[PasswordHash]
      ,[SecurityStamp]
      ,[ConcurrencyStamp]
      ,[PhoneNumber]
      ,[PhoneNumberConfirmed]
      ,[TwoFactorEnabled]
      ,[LockoutEnd]
      ,[LockoutEnabled]
      ,[AccessFailedCount])
	values  ('ec8e27d4-bfa7-485f-bd0d-2eb421c4568c', 'Administrator','ADMIN','adminsa','ADMINSA','sa@wms1.com','SA@WMS1.COM',1, 'AQAAAAIAAYagAAAAEPltPF42vz7sGoKoO4TCmRLxkdgWJPilVtXeUGjsBSE9rdXJ5olNamSivcv5RVHmIA==','JZMRVA2OZBKGNJKHC3NNSO2ILF7BOYGB','9317ad09-e005-4c83-8155-b9b05de0bab8',null,1,0,null,1,0),
			('ec8e27d4-bfa7-485f-bd0d-2eb421c4568d', 'Administrator','ADMIN','adminsb','ADMINSB','sa@wms2.com','SA@WMS2.COM',1, 'AQAAAAIAAYagAAAAEPltPF42vz7sGoKoO4TCmRLxkdgWJPilVtXeUGjsBSE9rdXJ5olNamSivcv5RVHmIA==','JZMRVA2OZBKGNJKHC3NNSO2ILF7BOYGB','9317ad09-e005-4c83-8155-b9b05de0bab8',null,1,0,null,1,0),
			('ec8e27d4-bfa7-485f-bd0d-2eb421c4568e', 'Administrator','ADMIN','adminsc','ADMINSC','sa@wms3.com','SA@WMS3.COM',1, 'AQAAAAIAAYagAAAAEPltPF42vz7sGoKoO4TCmRLxkdgWJPilVtXeUGjsBSE9rdXJ5olNamSivcv5RVHmIA==','JZMRVA2OZBKGNJKHC3NNSO2ILF7BOYGB','9317ad09-e005-4c83-8155-b9b05de0bab8',null,1,0,null,1,0);



			insert into dbo.[UserRoles] ([UserId],[RoleId])
	values ('ec8e27d4-bfa7-485f-bd0d-2eb421c4568c', 2),
	 ('ec8e27d4-bfa7-485f-bd0d-2eb421c4568d', 1),
	 ('ec8e27d4-bfa7-485f-bd0d-2eb421c4568e', 3);

end


