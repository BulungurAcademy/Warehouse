var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Wh_Api>("wh-api");

builder.Build().Run();
