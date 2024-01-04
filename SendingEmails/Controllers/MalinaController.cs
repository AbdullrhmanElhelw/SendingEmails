using Microsoft.AspNetCore.Mvc;
using SendingEmails.DTOs;
using SendingEmails.Services;

namespace SendingEmails.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MalinaController : ControllerBase
{
    private readonly IMailService _mailService;

    public MalinaController(IMailService mailService)
    {
        _mailService = mailService ?? throw new ArgumentNullException(nameof(mailService));
    }

    [HttpPost]
    public async Task<IActionResult> SendEmail([FromForm] EmailRequestDTO request)
    {
        await _mailService.SendEmailAsync(request.ToEmail, request.Subject, request.Body, request.Attachments);
        return Ok();
    }
}
