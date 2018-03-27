create table [Scheduler].[PriorityLevel]
(
	[Id] int not null,
	[Name] varchar(50) not null,
	[Description] nvarchar(1000),
	[IsActive] bit default 1 not null,
	[BackgroundColour] varchar(6) not null,
	[ForegroundColour] varchar(6) not null,

	constraint [PK_PriorityLevel] primary key ([Id])
)
