using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    internal class QuestionCollection
    {
        List<Question> questions = null;
        public void AddQuestion(Question question)
        {
            questions.Add(question);
        }
        public void CleanAll()
        {
            questions.Clear();
        }



        
        
    }
}
