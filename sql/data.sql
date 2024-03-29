USE [host_computer]
GO
INSERT [dbo].[devices] ([d_id], [d_name], [d_sn], [comm_type]) VALUES (N'1001', N'#1 Master device info', N'8937-45845735', 2)
INSERT [dbo].[devices] ([d_id], [d_name], [d_sn], [comm_type]) VALUES (N'1002', N'#2 Master device info', N'8937-24363456', 2)
INSERT [dbo].[devices] ([d_id], [d_name], [d_sn], [comm_type]) VALUES (N'1003', N'#3 Master device info', N'8937-57568456', 2)
INSERT [dbo].[devices] ([d_id], [d_name], [d_sn], [comm_type]) VALUES (N'1004', N'#4 Master device info', N'8937-57568568', 2)
GO
INSERT [dbo].[monitor_values] ([d_id], [v_id], [tag_name], [address], [data_type], [unit]) VALUES (N'1001', 1001001, N'电压', N'VW100', N'ushort', N'kv')
INSERT [dbo].[monitor_values] ([d_id], [v_id], [tag_name], [address], [data_type], [unit]) VALUES (N'1001', 1001002, N'电流', N'VW102', N'ushort', N'A')
GO
INSERT [dbo].[P_Modbus] ([p_id], [d_id], [d_ip], [d_port], [baudrate], [data_bit], [stop], [parity], [slave_id], [comm_mode]) VALUES (N'1', N'1001', N'127.0.0.1', 502, 9600, 8, 1, 0, N'1         ', 1)
GO
INSERT [dbo].[P_S7] ([p_id], [d_id], [d_ip], [d_port], [d_rock], [d_slot]) VALUES (N'1', N'1001', N'192.168.2.1', 102, 0, 1)
GO
INSERT [dbo].[users] ([user_id], [user_name], [real_name], [password], [is_validation], [is_can_login], [is_teacher], [avatar], [gender]) VALUES (N'1001', N'admin', N'Administrator', N'51A70A1E25F9E6A8954F54D6DF935B0D', 1, 1, 0, N'../Assets/Images/avatar.png', 1)
INSERT [dbo].[users] ([user_id], [user_name], [real_name], [password], [is_validation], [is_can_login], [is_teacher], [avatar], [gender]) VALUES (N'1002', N'guest', N'Guest', N'2D64CDF22D0B162AC64F5F7A883DC964', 1, 0, 0, N'../Assets/Images/avatar.png', 1)
INSERT [dbo].[users] ([user_id], [user_name], [real_name], [password], [is_validation], [is_can_login], [is_teacher], [avatar], [gender]) VALUES (N'1003', N'eleven', N'Eleven', N'C95C977F4EFC60E2717BB730A69470F2', 1, 1, 1, N'../Assets/Images/avatar.png', 1)
INSERT [dbo].[users] ([user_id], [user_name], [real_name], [password], [is_validation], [is_can_login], [is_teacher], [avatar], [gender]) VALUES (N'1004', N'richard', N'Richard', N'EF60F453E23F1B9B3C45C97C5E1C316E', 1, 1, 1, N'../Assets/Images/avatar.png', 1)
INSERT [dbo].[users] ([user_id], [user_name], [real_name], [password], [is_validation], [is_can_login], [is_teacher], [avatar], [gender]) VALUES (N'1005', N'clay', N'Clay', N'0E6AE0856E2CDD1E94344562EFF41A23', 1, 1, 1, N'../Assets/Images/avatar.png', 1)
INSERT [dbo].[users] ([user_id], [user_name], [real_name], [password], [is_validation], [is_can_login], [is_teacher], [avatar], [gender]) VALUES (N'1006', N'garry', N'Garry', N'1FF74A56AE38F179E201BC91F754CBA1', 1, 1, 1, N'../Assets/Images/avatar.png', 1)
INSERT [dbo].[users] ([user_id], [user_name], [real_name], [password], [is_validation], [is_can_login], [is_teacher], [avatar], [gender]) VALUES (N'1007', N'ace', N'Ace', N'1D4C08127C768A77A1E39CCA5E208F91', 1, 1, 1, N'../Assets/Images/avatar.png', 1)
INSERT [dbo].[users] ([user_id], [user_name], [real_name], [password], [is_validation], [is_can_login], [is_teacher], [avatar], [gender]) VALUES (N'1008', N'leah', N'Leah', N'50A1CDDA6D8D09C9021FC490016240B4', 1, 1, 1, N'../Assets/Images/avatar.png', 2)
INSERT [dbo].[users] ([user_id], [user_name], [real_name], [password], [is_validation], [is_can_login], [is_teacher], [avatar], [gender]) VALUES (N'1009', N'jovan', N'Jovan', N'3B9D859D7EF2C8EA60B890FEEFF20912', 1, 1, 1, N'../Assets/Images/avatar.png', 1)
GO
