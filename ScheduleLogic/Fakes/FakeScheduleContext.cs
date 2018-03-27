using System;
using System.Data.Entity;
using ScheduleLogic.Models;

namespace ScheduleLogic.Fakes
{
    public class FakeScheduleContext : IEntities
    {
        public FakeScheduleContext()
        {
            EmployeeToTeamMaps = new FakeEmployeeToTeamMapSet();
            Employees          = new FakeEmployeeSet();
            PriorityLevels     = new FakePriorityLevelSet();
            TaskTypes          = new FakeTaskTypeSet();
            Tasks              = new FakeTaskSet();
            Teams              = new FakeTeamSet();
            TaskStatus         = new FakeTaskStatusSet();
            Utilizations       = new FakeUtilizationSet();
            WorkRequests       = new FakeWorkRequestSet();

            Employees.Add(new Employee {Id = 0, FirstName  = "John", LastName     = "Smith"});
            Employees.Add(new Employee {Id = 1, FirstName  = "Arie", LastName     = "Bailon"});
            Employees.Add(new Employee {Id = 2, FirstName  = "Marti", LastName    = "Folkes"});
            Employees.Add(new Employee {Id = 3, FirstName  = "Clark", LastName    = "Buzard"});
            Employees.Add(new Employee {Id = 4, FirstName  = "Violette", LastName = "Sierra"});
            Employees.Add(new Employee {Id = 5, FirstName  = "Lai", LastName      = "Jinkins"});
            Employees.Add(new Employee {Id = 6, FirstName  = "Esteban", LastName  = "Dahlstrom"});
            Employees.Add(new Employee {Id = 7, FirstName  = "Luana", LastName    = "Screws"});
            Employees.Add(new Employee {Id = 8, FirstName  = "Collene", LastName  = "Fike"});
            Employees.Add(new Employee {Id = 9, FirstName  = "Mari", LastName     = "Carnes"});
            Employees.Add(new Employee {Id = 10, FirstName = "Gonzalo", LastName  = "Schepis"});

            TaskStatus.Add(new TaskStatus
                           {
                               Id               = 0,
                               IsActive         = true,
                               Name             = "Pending",
                               ForegroundColour = "E74C3C"
                           });
            TaskStatus.Add(new TaskStatus
                           {
                               Id               = 1,
                               IsActive         = true,
                               Name             = "In Progress",
                               ForegroundColour = "85C1E9"
                           });
            TaskStatus.Add(new TaskStatus
                           {
                               Id               = 2,
                               IsActive         = true,
                               Name             = "Complete",
                               ForegroundColour = "1E8449"
                           });

            TaskTypes.Add(new TaskType
                          {
                              Id               = 0,
                              IsActive         = true,
                              Name             = "Programming",
                              ForegroundColour = "E74C3C"
                          });
            TaskTypes.Add(new TaskType
                          {
                              Id               = 1,
                              IsActive         = true,
                              Name             = "Testing",
                              ForegroundColour = "85C1E9"
                          });
            TaskTypes.Add(new TaskType
                          {
                              Id               = 2,
                              IsActive         = true,
                              Name             = "Analysis",
                              ForegroundColour = "1E8449"
                          });

            WorkRequests.Add(new WorkRequest
                             {
                                 Id           = 1000000,
                                 Client       = "Demo Client",
                                 Name         = "Fake Work Request 01",
                                 IsActive     = true,
                                 Owner        = 0,
                                 ExternalLink = "https://www.google.com.au"
                             });

            Tasks.Add(new Task
                      {
                          Id             = 0,
                          IsActive       = true,
                          ScheduledUtc   = DateTime.UtcNow,
                          HoursEstimated = 10m,
                          PriorityId     = 0,
                          Resource       = 3,
                          HoursScheduled = 25m,
                          StatusId       = 1,
                          TypeId         = 1,
                          WorkRequestId  = 1000000
                      });
            Tasks.Add(new Task
                      {
                          Id             = 0,
                          IsActive       = true,
                          ScheduledUtc   = DateTime.UtcNow,
                          HoursEstimated = 10m,
                          PriorityId     = 0,
                          Resource       = 2,
                          HoursScheduled = 25m,
                          StatusId       = 0,
                          TypeId         = 0,
                          WorkRequestId  = 1000000
                      });
            Tasks.Add(new Task
                      {
                          Id             = 0,
                          IsActive       = true,
                          ScheduledUtc   = DateTime.UtcNow,
                          HoursEstimated = 10m,
                          PriorityId     = 0,
                          Resource       = 0,
                          HoursScheduled = 25m,
                          StatusId       = 0,
                          TypeId         = 0,
                          WorkRequestId  = 1000000
                      });

            WorkRequests.Add(new WorkRequest
                             {
                                 Id           = 1000001,
                                 Client       = "Demo Client",
                                 Name         = "Fake Work Request 02",
                                 IsActive     = true,
                                 Owner        = 0,
                                 ExternalLink = "https://www.google.com.au"
                             });

            Tasks.Add(new Task
                      {
                          Id             = 0,
                          IsActive       = true,
                          ScheduledUtc   = DateTime.UtcNow,
                          HoursEstimated = 10m,
                          PriorityId     = 0,
                          Resource       = 3,
                          HoursScheduled = 25m,
                          StatusId       = 1,
                          TypeId         = 1,
                          WorkRequestId  = 1000001
                      });
            Tasks.Add(new Task
                      {
                          Id             = 0,
                          IsActive       = true,
                          ScheduledUtc   = DateTime.UtcNow,
                          HoursEstimated = 10m,
                          PriorityId     = 0,
                          Resource       = 2,
                          HoursScheduled = 25m,
                          StatusId       = 0,
                          TypeId         = 0,
                          WorkRequestId  = 1000001
                      });
            Tasks.Add(new Task
                      {
                          Id             = 0,
                          IsActive       = true,
                          ScheduledUtc   = DateTime.UtcNow,
                          HoursEstimated = 10m,
                          PriorityId     = 0,
                          Resource       = 0,
                          HoursScheduled = 25m,
                          StatusId       = 0,
                          TypeId         = 0,
                          WorkRequestId  = 1000001
                      });

            WorkRequests.Add(new WorkRequest
                             {
                                 Id           = 1000002,
                                 Client       = "Demo Client",
                                 Name         = "Fake Work Request 03",
                                 IsActive     = true,
                                 Owner        = 0,
                                 ExternalLink = "https://www.google.com.au"
                             });

            Tasks.Add(new Task
                      {
                          Id             = 0,
                          IsActive       = true,
                          ScheduledUtc   = DateTime.UtcNow,
                          HoursEstimated = 10m,
                          PriorityId     = 0,
                          Resource       = 3,
                          HoursScheduled = 25m,
                          StatusId       = 1,
                          TypeId         = 1,
                          WorkRequestId  = 1000002
                      });
            Tasks.Add(new Task
                      {
                          Id             = 0,
                          IsActive       = true,
                          ScheduledUtc   = DateTime.UtcNow,
                          HoursEstimated = 10m,
                          PriorityId     = 0,
                          Resource       = 2,
                          HoursScheduled = 25m,
                          StatusId       = 0,
                          TypeId         = 0,
                          WorkRequestId  = 1000002
                      });
            Tasks.Add(new Task
                      {
                          Id             = 0,
                          IsActive       = true,
                          ScheduledUtc   = DateTime.UtcNow,
                          HoursEstimated = 10m,
                          PriorityId     = 0,
                          Resource       = 0,
                          HoursScheduled = 25m,
                          StatusId       = 0,
                          TypeId         = 0,
                          WorkRequestId  = 1000002
                      });

            WorkRequests.Add(new WorkRequest
                             {
                                 Id           = 1000003,
                                 Client       = "Demo Client",
                                 Name         = "Fake Work Request 04",
                                 IsActive     = true,
                                 Owner        = 0,
                                 ExternalLink = "https://www.google.com.au"
                             });

            Tasks.Add(new Task
                      {
                          Id             = 0,
                          IsActive       = true,
                          ScheduledUtc   = DateTime.UtcNow,
                          HoursEstimated = 10m,
                          PriorityId     = 0,
                          Resource       = 3,
                          HoursScheduled = 25m,
                          StatusId       = 1,
                          TypeId         = 1,
                          WorkRequestId  = 1000003
                      });
            Tasks.Add(new Task
                      {
                          Id             = 0,
                          IsActive       = true,
                          ScheduledUtc   = DateTime.UtcNow,
                          HoursEstimated = 10m,
                          PriorityId     = 0,
                          Resource       = 2,
                          HoursScheduled = 25m,
                          StatusId       = 0,
                          TypeId         = 0,
                          WorkRequestId  = 1000003
                      });
            Tasks.Add(new Task
                      {
                          Id             = 0,
                          IsActive       = true,
                          ScheduledUtc   = DateTime.UtcNow,
                          HoursEstimated = 10m,
                          PriorityId     = 0,
                          Resource       = 0,
                          HoursScheduled = 25m,
                          StatusId       = 0,
                          TypeId         = 0,
                          WorkRequestId  = 1000003
                      });

            WorkRequests.Add(new WorkRequest
                             {
                                 Id           = 1000004,
                                 Client       = "Demo Client",
                                 Name         = "Fake Work Request 05",
                                 IsActive     = true,
                                 Owner        = 0,
                                 ExternalLink = "https://www.google.com.au"
                             });

            Tasks.Add(new Task
            {
                Id = 0,
                IsActive = true,
                ScheduledUtc = DateTime.UtcNow,
                HoursEstimated = 10m,
                PriorityId = 0,
                Resource = 0,
                HoursScheduled = 25m,
                StatusId = 0,
                TypeId = 0,
                WorkRequestId = 1000004
            });

            PriorityLevels.Add(new PriorityLevel {Id = 0, IsActive = true, Name = "Standard"});
        }

        public IDbSet<Employee>          Employees          { get; set; }
        public IDbSet<EmployeeToTeamMap> EmployeeToTeamMaps { get; set; }
        public IDbSet<PriorityLevel>     PriorityLevels     { get; set; }
        public IDbSet<Task>              Tasks              { get; set; }
        public IDbSet<TaskStatus>        TaskStatus         { get; set; }
        public IDbSet<TaskType>          TaskTypes          { get; set; }
        public IDbSet<Team>              Teams              { get; set; }
        public IDbSet<Utilization>       Utilizations       { get; set; }
        public IDbSet<WorkRequest>       WorkRequests       { get; set; }

        public int SaveChanges() => 0;
    }
}