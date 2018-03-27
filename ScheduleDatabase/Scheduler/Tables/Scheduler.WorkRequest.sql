create table [Scheduler].[WorkRequest]
(
	[Id] bigint identity(1,1) not null,
	[Name] varchar(100) not null,
	[Description] nvarchar(1000) not null,
	[IsActive] bit default 1 not null,
	[Owner] bigint not null,
	[ExternalLink] nvarchar(200) not null,

	constraint [PK_WorkRequest] primary key ([Id]),
	constraint [FK_WorkRequestEmployee_Owner] foreign key ([Owner]) references [Scheduler].[Employee] ([Id])
)
