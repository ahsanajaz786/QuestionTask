USE [QuestionDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 3/16/2022 6:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 3/16/2022 6:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Type] [nvarchar](max) NULL,
	[CreatedAt] [nvarchar](max) NULL,
 CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionAnswers]    Script Date: 3/16/2022 6:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionAnswers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fk_UserInfo] [int] NOT NULL,
	[FK_QuestionId] [int] NOT NULL,
	[FkQuestionAnswer] [int] NOT NULL,
	[TextAnswer] [nvarchar](max) NULL,
 CONSTRAINT [PK_QuestionAnswers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionOptions]    Script Date: 3/16/2022 6:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionOptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FKQuestionId] [int] NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_QuestionOptions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserInfos]    Script Date: 3/16/2022 6:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserInfos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[GET_QUESTION_ANSWER]    Script Date: 3/16/2022 6:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[GET_QUESTION_ANSWER] @id int=0
as
begin
select FullName,Email,q.Title,qo.Value,qa.TextAnswer,q.Type from  UserInfos u
inner join QuestionAnswers qa on qa.Fk_UserInfo=u.id
inner join Question q on q.id=qa.FK_QuestionId
left join 
[dbo].[QuestionOptions] qo on qo.Id=qa.FkQuestionAnswer where u.Id=@id
end

GO
/****** Object:  StoredProcedure [dbo].[GET_QUESTIONS]    Script Date: 3/16/2022 6:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GET_QUESTIONS]   
  @page int =0 ,@pageSize int=10,@orderColumn varchar(max)='Id',@orderBy varchar(max)='desc',@search varchar(max)=null    
as    
begin    
  declare @total int  
set @total=(select count(id) from Question 
where @search is null or Title like '%'+@search+'%')
select [Title],[Type],[Id] as Id ,[CreatedAt] 
,@total as Total
from [dbo].[Question]
where @search is null or Title like '%'+@search+'%'
order by
case when @orderColumn='Question' and @orderBy='asc'then Title    
when @orderColumn='Type' and @orderBy='asc'    
then Type     
      
    
end asc ,
case     
when @orderColumn='Type' and @orderBy='desc'    
then Type     
   
    
end desc 
OFFSET @page ROWS FETCH NEXT @pageSize ROWS ONLY    
end    
GO
/****** Object:  StoredProcedure [dbo].[GET_USERS]    Script Date: 3/16/2022 6:21:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GET_USERS]     
  @page int =0 ,@pageSize int=10,@orderColumn varchar(max)='Id',@orderBy varchar(max)='desc',@search varchar(max)=null      
as      
begin      
  declare @total int    
set @total=(select count(id) from UserInfos   
where @search is null or FullName like '%'+@search+'%')  
select [Id],Email,FullName   
,@total as Total  
from UserInfos
where @search is null or FullName like '%'+@search+'%'  
order by  
case when @orderColumn='FullName' and @orderBy='asc'then FullName      
when @orderColumn='Email' and @orderBy='asc'      
then Email       
        
      
end asc ,  
case       
when @orderColumn='Email' and @orderBy='desc'      
then Email       
     when @orderColumn='FullName' and @orderBy='desc'      
then FullName       
     
      
end desc   
OFFSET @page ROWS FETCH NEXT @pageSize ROWS ONLY      
end 
GO
