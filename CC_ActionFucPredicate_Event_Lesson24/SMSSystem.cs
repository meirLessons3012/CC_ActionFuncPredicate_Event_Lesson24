using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_ActionFucPredicate_Event_Lesson24
{
    internal class SMSSystem
    {
        public void SendSMS(object sender, NewStudentRegsiterEventArgs newStd)
        {
            Console.WriteLine($"sending sms to {newStd.NewStudent.Phone}...");
        }
    }
}
