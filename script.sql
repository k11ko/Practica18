USE [master]
GO
/****** Object:  Database [Teams]    Script Date: 21.04.2022 9:21:28 ******/
GO
ALTER DATABASE [Teams] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Teams].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Teams] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Teams] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Teams] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Teams] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Teams] SET ARITHABORT OFF 
GO
ALTER DATABASE [Teams] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Teams] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Teams] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Teams] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Teams] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Teams] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Teams] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Teams] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Teams] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Teams] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Teams] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Teams] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Teams] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Teams] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Teams] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Teams] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Teams] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Teams] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Teams] SET  MULTI_USER 
GO
ALTER DATABASE [Teams] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Teams] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Teams] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Teams] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Teams] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Teams] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Teams] SET QUERY_STORE = OFF
GO
USE [Teams]
GO
/****** Object:  Table [dbo].[FP]    Script Date: 21.04.2022 9:21:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FP](
	[Номер] [int] NOT NULL,
	[Фамилия] [nvarchar](50) NOT NULL,
	[Имя] [nvarchar](50) NOT NULL,
	[Отчество] [nvarchar](50) NULL,
	[Команда] [nvarchar](50) NOT NULL,
	[СыгранныхСезонов] [int] NOT NULL,
	[ЧислоЗаброшенныхШайб] [int] NULL,
	[КолГолевыхПередач] [int] NULL,
	[ШтрафВремя] [int] NULL,
	[КолСыгранныхМатчей] [int] NULL,
 CONSTRAINT [PK_FP] PRIMARY KEY CLUSTERED 
(
	[Номер] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[FP] ([Номер], [Фамилия], [Имя], [Отчество], [Команда], [СыгранныхСезонов], [ЧислоЗаброшенныхШайб], [КолГолевыхПередач], [ШтрафВремя], [КолСыгранныхМатчей]) VALUES (1, N'Цыплаков', N'Максим    ', N'Викторович', N'Спартак   ', 6, 4, 8, 28, 38)
INSERT [dbo].[FP] ([Номер], [Фамилия], [Имя], [Отчество], [Команда], [СыгранныхСезонов], [ЧислоЗаброшенныхШайб], [КолГолевыхПередач], [ШтрафВремя], [КолСыгранныхМатчей]) VALUES (2, N'Баранов', N'Илья      ', N'Григорьевич', N'Спартак   ', 1, 2, 1, 4, 11)
INSERT [dbo].[FP] ([Номер], [Фамилия], [Имя], [Отчество], [Команда], [СыгранныхСезонов], [ЧислоЗаброшенныхШайб], [КолГолевыхПередач], [ШтрафВремя], [КолСыгранныхМатчей]) VALUES (3, N'Солодухин', N'Вячеслав  ', N'Сергеевич', N'Спартак   ', 1, 1, 1, 6, 26)
INSERT [dbo].[FP] ([Номер], [Фамилия], [Имя], [Отчество], [Команда], [СыгранныхСезонов], [ЧислоЗаброшенныхШайб], [КолГолевыхПередач], [ШтрафВремя], [КолСыгранныхМатчей]) VALUES (4, N'Петтерссон', N'Эмиль     ', N'Отсутствует', N'Спартак   ', 1, 13, 11, 16, 42)
INSERT [dbo].[FP] ([Номер], [Фамилия], [Имя], [Отчество], [Команда], [СыгранныхСезонов], [ЧислоЗаброшенныхШайб], [КолГолевыхПередач], [ШтрафВремя], [КолСыгранныхМатчей]) VALUES (5, N'Талалуев', N'Илья      ', N'Викторович', N'Спартак   ', 5, 3, 5, 4, 14)
INSERT [dbo].[FP] ([Номер], [Фамилия], [Имя], [Отчество], [Команда], [СыгранныхСезонов], [ЧислоЗаброшенныхШайб], [КолГолевыхПередач], [ШтрафВремя], [КолСыгранныхМатчей]) VALUES (6, N'Фисенко', N'Михаил    ', N'Александрович', N'Динамо    ', 2, 3, 7, 18, 28)
INSERT [dbo].[FP] ([Номер], [Фамилия], [Имя], [Отчество], [Команда], [СыгранныхСезонов], [ЧислоЗаброшенныхШайб], [КолГолевыхПередач], [ШтрафВремя], [КолСыгранныхМатчей]) VALUES (7, N'Зайцев', N'Олег      ', N'Алексеевич', N'Динамо    ', 2, 1, 0, 1, 14)
INSERT [dbo].[FP] ([Номер], [Фамилия], [Имя], [Отчество], [Команда], [СыгранныхСезонов], [ЧислоЗаброшенныхШайб], [КолГолевыхПередач], [ШтрафВремя], [КолСыгранныхМатчей]) VALUES (8, N'Петунин', N'Александр ', N'Павлович', N'Динамо    ', 5, 3, 1, 5, 23)
INSERT [dbo].[FP] ([Номер], [Фамилия], [Имя], [Отчество], [Команда], [СыгранныхСезонов], [ЧислоЗаброшенныхШайб], [КолГолевыхПередач], [ШтрафВремя], [КолСыгранныхМатчей]) VALUES (9, N'Никонов', N'Андрей', N'Владимирович', N'Динамо', 2, 8, 3, 12, 20)
INSERT [dbo].[FP] ([Номер], [Фамилия], [Имя], [Отчество], [Команда], [СыгранныхСезонов], [ЧислоЗаброшенныхШайб], [КолГолевыхПередач], [ШтрафВремя], [КолСыгранныхМатчей]) VALUES (10, N'Шипачев', N'Вадим', N'Олегович', N'Динамо', 4, 6, 7, 25, 32)
INSERT [dbo].[FP] ([Номер], [Фамилия], [Имя], [Отчество], [Команда], [СыгранныхСезонов], [ЧислоЗаброшенныхШайб], [КолГолевыхПередач], [ШтрафВремя], [КолСыгранныхМатчей]) VALUES (11, N'Константинов', N'Кирилл', N'Александрович', N'Спартак', 4, 9, 3, 2, 15)
GO
USE [master]
GO
ALTER DATABASE [Teams] SET  READ_WRITE 
GO
