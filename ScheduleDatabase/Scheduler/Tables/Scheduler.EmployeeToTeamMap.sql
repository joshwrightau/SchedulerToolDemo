create table [Scheduler].[EmployeeToTeamMap]
(
	[Employee] bigint not null,
	[Team] int not null,
	[IsActive] bit default 1 not null,

	constraint [PK_EmployeeToTeamMap] primary key ([Employee], [Team]),
	constraint [FK_EmployeeToTeamMapEmployee_Employee] foreign key ([Employee]) references [Scheduler].[Employee] ([Id]),
	constraint [FK_EmployeeToTeamMapTeam_Team] foreign key ([Team]) references [Scheduler].[Team] ([Id])
)
