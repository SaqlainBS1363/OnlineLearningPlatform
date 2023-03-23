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

        public void setcourseID(string courseId) { this.courseId = courseId; }
        public string getcourseID() { return courseId; }

        public void setcourseName(string courseName) { this.courseName = courseName; }
        public string getcourseName() { return courseName; }

        public void setcourseTopic(string courseTopic) { this.courseTopic = courseTopic; }
        public string getcourseTopic() { return courseTopic; }

        public void setcoursePrice(int coursePrice) { this.coursePrice = coursePrice; }
        public int getcoursePrice() {  return coursePrice; }
    }
}
