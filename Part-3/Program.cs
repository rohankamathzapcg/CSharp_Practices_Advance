// Anonymous types
var obj=new
{
    firstName="King",
    lastName="Kochhar",
    salary=12000,

    address=new {streetName="Civil lines",city="Delhi"},
    projects=new[]
    {
        new {projectName="Ecommerce",projectDuration="40 Hours"},
        new {projectName="Admin Portal",projectDuration="40 Hours"},
    }
};

Console.WriteLine(obj.firstName);
Console.WriteLine(obj.address.streetName);

foreach(var project in obj.projects)
{
    Console.WriteLine(project.projectName + " : " +project.projectDuration);
    
}