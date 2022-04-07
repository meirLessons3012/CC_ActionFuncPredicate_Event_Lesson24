using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_ActionFucPredicate_Event_Lesson24
{
    internal class NewStudentRegsiterEventArgs : EventArgs
    {
        public Student NewStudent { get; set; }

        public NewStudentRegsiterEventArgs(Student newStudent)
        {
            NewStudent = newStudent;
        }
    }
}
