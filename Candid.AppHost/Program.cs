var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Candid_ApiService>("apiservice");

builder.AddProject<Projects.Candid_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
