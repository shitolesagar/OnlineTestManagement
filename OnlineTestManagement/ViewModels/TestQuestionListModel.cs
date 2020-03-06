using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTestManagement.ViewModels
{
    public class TestQuestionListModel
    {
        public List<Question> QuestionList { get; set; }
    }

    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
