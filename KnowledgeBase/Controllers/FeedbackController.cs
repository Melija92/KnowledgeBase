using KnowledgeBase.Models;
using RazorEngine;
using RazorEngine.Templating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace KnowledgeBase.Controllers
{
    public class FeedbackController : Controller
    {
        public ActionResult Index()
        {
            return View("Comments");
        }

        // GET: Feedback
        public ActionResult Comments()
        {
            TempData["FeedbackPost"] = string.Empty;
            return View(new Feedback());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> PostFeedback(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                string template = "<html> " +
                                    "<head>" +
                                      "  <meta name='viewport' content='width=device-width' />" +
                                      "  <title></title>" +
                                    "</head>" +
                                    "<body>" +
                                     "   <div style='margin:0 auto; border: 1px solid lightgray;'>" +
                                     "<div style='height:30px; background-color: darkgray;  top: 0;  left: 0;   width: 100%;'> " +
                                     "</div>" +
                                     "<div style='padding:20px;' >" +
                                      "      <div>" +
                                       "     <b> Name : </b> @Model.Name " +
                                        "    </div>" +
                                         "   <br />" +
                                          "  <div>" +
                                           " <b> Feedback Type : </b>   @Model.Type " +
                                           " </div>" +
                                           " <br />" +
                                           " <div>" +
                                           " <b> Comment: </b>  @Model.Comment " +
                                           " </div>" +
                                       " </div>" +
                                       "</div> " +
                                     "</body>" +
                                    "</html>";
                var result = Engine.Razor.RunCompile(new LoadedTemplateSource(template), "templateKey", null, new { Name = feedback.FullName, Type = feedback.FeedbackType, Comment = feedback.Comment }, null);
                MailMessage mail = new MailMessage();
                
#if DEBUG
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new NetworkCredential("freelancerxamarin@gmail.com", "Bangaru23@");
#else
                SmtpClient SmtpServer = new SmtpClient("relay-hosting.secureserver.net");
                SmtpServer.Port = 25;
                SmtpServer.UseDefaultCredentials = false;
#endif

                mail.From = new MailAddress("freelancerxamarin@gmail.com", "Knowledge Base");
                mail.To.Add("guntidheerajkumar@gmail.com");
                mail.IsBodyHtml = true;
                mail.Subject = "Knowledge Base";
                mail.Body = result;
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                SmtpServer.SendCompleted += SmtpServer_SendCompleted;
                try
                {
                   await SmtpServer.SendMailAsync(mail);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                TempData["FeedbackPost"] = "Success";
                return RedirectToAction("ThankYou");
            }
            return View("Comments");
        }

        private void SmtpServer_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            MailMessage mail = e.UserState as MailMessage;
            if (!e.Cancelled && e.Error != null)
            {
                Console.WriteLine("Mail sent successfully");
            }
        }

        public ActionResult ThankYou()
        {
            if (string.IsNullOrWhiteSpace(Convert.ToString(TempData["FeedbackPost"])))
            {
                return RedirectToAction("Comments");
            }
            ViewBag.FeedbackPost = string.Empty;
            return View();
        }
    }
}