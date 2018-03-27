create table [Scheduler].[Task]
(
	[Id] bigint identity(1,1) not null,
	[WorkRequestId] bigint not null,
	[HoursEstimated] decimal(10,2) not null,
	[HoursScheduled] decimal(10,2) default 0.00 not null,
	[ScheduledUTC] date not null,
	[IsActive] bit default 1 not null,
	[TypeId] int not null,
	[StatusId] int not null,
	[PriorityId] int not null,
	[Resource] bigint not null,

	constraint [PK_Task] primary key ([Id]),
	constraint [FK_TaskWorkRequest_WorkRequestId] foreign key ([WorkRequestId]) references [Scheduler].[WorkRequest] ([Id]),
	constraint [FK_TaskTaskStatus_StatusId] foreign key ([StatusId]) references [Scheduler].[TaskStatus] ([Id]),
	constraint [FK_TaskTaskType_TypeId] foreign key ([TypeId]) references [Scheduler].[TaskType] ([Id]),
	constraint [FK_TaskPriorityLevel_PriorityId] foreign key ([PriorityId]) references [Scheduler].[PriorityLevel] ([Id]),
	constraint [FK_TaskEmployee_Resource] foreign key ([Resource]) references [Scheduler].[Employee] ([Id])
)
