using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_ActionFucPredicate_Event_Lesson24
{
    internal class College
    {
        public string Name { get; set; }
        private List<Student> Students { get; set; }
        public event EventHandler<NewStudentRegsiterEventArgs> newStudentRegsitered;
        
        public College(string name)
        {
            Name = name;
            Students = new List<Student>();
            //newStudentRegsitered = null;
            //newStudentRegsitered.Invoke(null, null);
        }

        public void RegisterNewStudent(Student newStd)
        {
            if(newStd != null)
            {
                Students.Add(newStd);
                OnNewStudentRegsitered(newStd);
            }
        }

        private void OnNewStudentRegsitered(Student newStd)
        {
            NewStudentRegsiterEventArgs newStdEvntArgs = new NewStudentRegsiterEventArgs(newStd);
            newStudentRegsitered?.Invoke(this, newStdEvntArgs);
        }
    }
}
