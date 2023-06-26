using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class Question
    {

        public string QuestionText { get; set; }
        public List<string> Answers { get; set; }
        public string CorrectAnswer { get; set; }

        public string ImageName { get; set; }
        public string Comment { get; set; }
        public string? CommentImage { get; set; }


    }
}
