using System.Net;
using System.Net.Mail;
using UnityEngine;
using UnityEngine.UI;

public class EmailSender : MonoBehaviour
{
    public InputField recipientEmailInput; // This input field will hold the recipient's email entered in the app

    private string senderEmail = "workdesigntae@gmail.com";
    private string senderPassword = "itnd qdxt wamn jhjw";

    public void SendEmail()
    {
        string recipientEmail = recipientEmailInput.text.Trim();

        if (string.IsNullOrEmpty(recipientEmail))
        {
            Debug.LogError("Recipient email is empty!");
            return;
        }

        MailMessage mail = new MailMessage();
        mail.From = new MailAddress(senderEmail);
        mail.To.Add(recipientEmail); // Dynamically adds the email address input by the user
        mail.Subject = "Welcome To SPTMWORLD App";
        mail.Body = "Nice! Your officially an SPTM exclusive member, check out your email for the special offers and discounts!.";

        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
        smtpServer.Port = 587;
        smtpServer.Credentials = new NetworkCredential(senderEmail, senderPassword) as ICredentialsByHost;
        smtpServer.EnableSsl = true;

        try
        {
            smtpServer.Send(mail);
            Debug.Log("Email sent to: " + recipientEmail);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Failed to send email: " + e.Message);
        }
    }
}
