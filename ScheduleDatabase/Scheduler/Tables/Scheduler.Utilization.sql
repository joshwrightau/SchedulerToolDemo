create table [Scheduler].[Utilization]
(
	[Id] bigint identity(1,1) not null,
	[WorkRequestId] bigint not null,
	[TaskId] bigint,
	[TaskTypeId] int not null,
	[Hours] decimal (10,2) not null,

	constraint [PK_Utilization] primary key ([Id]),
	constraint [FK_UtilizationWorkRequest_WorkRequestId] foreign key ([WorkRequestId]) references [Scheduler].[WorkRequest] ([Id]),
	constraint [FK_UtilizationTask_TaskId] foreign key ([TaskId]) references [Scheduler].[Task] ([Id]),
	constraint [FK_UtilizationTaskType_TaskTypeId] foreign key ([TaskTypeId]) references [Scheduler].[TaskType] ([Id])
)
