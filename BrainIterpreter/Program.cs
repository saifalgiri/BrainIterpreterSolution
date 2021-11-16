using BrainIterpreter;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<InterpreterService>(new InterpreterService());
var app = builder.Build();

app.MapGet("/", (HttpContext context, InterpreterService interpreterService) => 
interpreterService.ProcessInstructions("-[------->+<]>-.-[->+++++<]>++.+++++++..+++"+
".[--->+<]>-----.+[->++<]>.[-->+++<]>++.+++++++++.----.---------.++++++++++++.----.++" +
"+++.[----->++<]>++.++[--->++<]>.++++[->++<]>+.-[->++++<]>.--[->++++<]>-.-----.---------" +
".+++++++++++.+++[->+++<]>.--[--->+<]>-.---[->++++<]>.------------.+.++++++++++.+[---->+<]>" +
"+++.+[----->+<]>.--------.[--->+<]>----..++[->+++<]>++.++++++.--.--[--->+<]>-.---[->++++<]>" +
".-----.[--->+<]>-----.--[->++++<]>-.[->+++<]>.+++++++.---------.++++++++++++.--.--------.--" +
"[--->+<]>-.--[->++++<]>+.----------.++++++.-[-->+++++<]>-.-."));

app.Run();
