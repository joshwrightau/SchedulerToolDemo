create table [Scheduler].[Employee]
(
	[Id] bigint identity(1,1) not null,
	[FirstName] nvarchar(100) not null,
	[LastName] nvarchar(100) not null,
	[Email] varchar(256) not null,
	[IsActive] bit default 1 not null,

	constraint [PK_Employee] primary key ([Id])
)
