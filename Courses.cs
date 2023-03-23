using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform
{
    public class Courses
    {
        private string courseId = "", courseName = "", courseTopic = "";
        private int coursePrice = 0;

        /*Courses(string courseId, string courseName, string courseTopic, int coursePrice) {
       
            this.courseId = courseId;
            this.courseName = courseName;
            this.courseTopic = courseTopic;
            this.coursePrice = coursePrice;
        }*/

        public void setcourseID(string courseID) { this.courseId = courseID; }
        public string getcourseID(string courseID) { return courseID; }

        public void setcourseName(string courseName) { this.courseName = courseName; }
        public string getcourseName() { return courseName; }




    }
}
