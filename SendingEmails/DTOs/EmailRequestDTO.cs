using System.ComponentModel.DataAnnotations;

namespace SendingEmails.DTOs;

public class EmailRequestDTO
{
    [Required]
    public string ToEmail { get; set; }

    [Required]
    public string Subject { get; set; }

    [Required]
    public string Body { get; set; }
    public IList<IFormFile>? Attachments { get; set; } = [];
}