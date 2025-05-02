using AspireStorage.WorkerService;

var builder = Host.CreateApplicationBuilder(args);

builder.AddAzureQueueClient("QueueConnection");

// builder.AddServiceDefaults();
builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
