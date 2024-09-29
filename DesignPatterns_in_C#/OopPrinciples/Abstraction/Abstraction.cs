using System;

namespace DesignPatterns_in_C_.OopPrinciples.Abstraction
{
    class Abstraction
    {
        static void Main(string[] args)
        {
            EmailService emailService = new EmailService();
            emailService.SendEmail();
        }
    }
}