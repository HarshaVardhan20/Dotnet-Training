using ExamSchedular.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamSchedular.Data
{
    public static class DataSession
    {
        static List<Session> sections = new List<Session>();    

        static DataSession()
        {
            sections.Add(new Session { Id = "CSE2024Batch1" });
            sections.Add(new Session { Id = "CSE2024Batch2" });
            sections.Add(new Session { Id = "CSE2024Batch3" });
        }
        

        public static List<Session> GetSessionsData() { 
            return sections;
        }
    }
}
