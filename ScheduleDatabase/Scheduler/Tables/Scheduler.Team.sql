create table [Scheduler].[Team]
(
	[Id] int identity(1,1) not null,
	[Name] varchar(100) not null,
	[TeamLeader] bigint not null,
	[IsActive] bit default 1 not null,

	constraint [PK_Team] primary key ([Id]),
	constraint [FK_TeamEmployee_TeamLeader] foreign key ([TeamLeader]) references [Scheduler].[Employee] ([Id])
)
