using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV.DataAccessLayer.Settings
{
    public enum LoggingEvents
    {
        LIST_SKILLS = 0,
        GET_SKILL = 1,
        DB_ERROR = 2,
        LIST_PROJECTS = 3,
        LIST_PROJECT_SKILLS = 4,
        GET_PROJECT = 5,
        LIST_PROJECT_IMAGES = 6,
        GET_EXPERIENCE = 7,
        LIST_EXPERIENCES = 8,
        LIST_EXPERIENCE_SKILLS = 9,
        GET_PERSON = 10,
        LIST_QUALIFICATIONS = 11,
        LIST_TRAININGS = 12,
        LIST_CARDS = 13
    }
}
