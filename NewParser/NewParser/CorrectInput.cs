using Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace NewParser
{
    public class CorrectInput
    {
        private List<Question> previous;
        private List<QuestionModel> current;
        public CorrectInput(List<Question> pr)
        {
            previous = pr;
            current = new List<QuestionModel>();
        }
        public void FillAll()
        {
            int i = 1;
            foreach (var item in previous)
            {
                QuestionModel model = new QuestionModel();
                model.Id = i;
                model.Task = AphostrofInput( item.QuestionText);
                model.ImageData = item.ImageName;

                foreach (var answ in item.Answers)
                {
                    switch (answ[0])
                    {
                        case 'А':
                            model.b1 = DeletaFirstSymbol(AphostrofInput(answ));
                            break;
                        case 'Б':
                            model.b2 = DeletaFirstSymbol(AphostrofInput(answ));
                            break;
                        case 'В':
                            model.b3 = DeletaFirstSymbol(AphostrofInput(answ));
                            break;
                        case 'Г':
                            model.b4 = DeletaFirstSymbol(AphostrofInput(answ));
                            break;
                        case 'Д':
                            model.b5 = DeletaFirstSymbol(AphostrofInput(answ));
                            break;

                        case '1':
                            model.a1 = DeletaFirstSymbol(AphostrofInput(answ));
                            break;
                        case '2':
                            model.a2 = DeletaFirstSymbol(AphostrofInput(answ));
                            break;
                        case '3':
                            model.a3 = DeletaFirstSymbol(AphostrofInput(answ));
                            break;
                        case '4':
                            model.a4 = DeletaFirstSymbol(AphostrofInput(answ));
                            break;
                        case '5':
                            model.a5 = DeletaFirstSymbol(AphostrofInput(answ));
                            break;
                        case '6':
                            model.a6 = DeletaFirstSymbol(AphostrofInput(answ));
                            break;
                        case '7':
                            model.a7 = DeletaFirstSymbol(AphostrofInput(answ));
                            break;
                        case '8':
                            model.a8 = DeletaFirstSymbol(AphostrofInput(answ));
                            break;

                        default:
                            break;
                    }

                }

                model.CorrectAnswer = item.CorrectAnswer;
                model.Comment =AphostrofInput( item.Comment);
                model.CommentImage = item.CommentImage;
                current.Add(model);
                i++;
            }
        }

        public List<QuestionModel> GetRezult()
        {
            return current;
        }

        public string DeletaFirstSymbol(string text)
        {
            var t = text.ToCharArray();
            t[0] = ' ';
            return new string(t);
        }

        public string AphostrofInput(string a)
        {
            var temp = a.ToCharArray();
            string rezult = "";
            foreach (var item in temp)
            {
                if (item == '\"')
                {
                    rezult += "\'";
                }
                else
                {
                    rezult += item;
                }

            }
            return rezult;

        }
    }
}
