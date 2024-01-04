namespace SendingEmails.Services;

public interface IMailService
{
    Task SendEmailAsync(string toEmail, string subject, string content, IList<IFormFile> attachmets = default!);
}
