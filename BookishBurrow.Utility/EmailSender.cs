﻿using Microsoft.AspNetCore.Identity.UI.Services;

namespace BookishBurrow.Utility;

public class EmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        // TODO : Implement Email Sender Logic Here
        return Task.CompletedTask;
    }
}