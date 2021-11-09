using Replikit.Abstractions.Messages.Models;
using Replikit.Core.Controllers;
using Replikit.Core.Controllers.Patterns;

namespace Replipg.Bot.Controllers;

public class HelloController : Controller
{
    [Pattern("hi")]
    public OutMessage Hello() => "Чё звал, сларк";
}
