using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_ActionFucPredicate_Event_Lesson24
{
    internal class MailingSystem
    {

        public void SendMail(object sender, NewStudentRegsiterEventArgs newStd)
        {
            College c = (College)sender;
            Console.WriteLine($"sending mail to {newStd.NewStudent.Mail}... from {c.Name}.");
        }
    }
}
