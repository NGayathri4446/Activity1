using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1LB
{
    public class Instructor
    {
        float avgFeedback;
        int experience;
        string instructorName;
        string [] instructorSkill;
        public Instructor(string instructorName, float avgFeedback, int experience,string[] instructorSkill)
        {
            this.instructorName = instructorName;
            this.avgFeedback = avgFeedback;
            this.experience = experience;
            this.instructorSkill = instructorSkill;
        }

        public bool ValidateEligibility()
        {
             
                if (experience > 3 && avgFeedback >= 4.5)
                    return true;
                else if (experience <= 3 && avgFeedback >= 4 && avgFeedback>0)
                    return true;
                else
                    return false; 
                
        }
        public bool CheckSkill(string technology)
        {
            bool check = false;
            foreach(var item in instructorSkill)
            {
                if(item==technology && ValidateEligibility())
                
                    check=true;                
            }
            return check;

        }
    }
}
