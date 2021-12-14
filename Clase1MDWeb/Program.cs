var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/api/users",()=>{

    var user1= new User("Nicolas", "Ochoa", 2002);
    var user2= new User("Name","Surname",0000);

    var users= new List<User>();

    users.Add(user1);
    users.Add(user2);
    return users;
});

app.Run();




