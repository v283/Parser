using System;
using AngleSharp;
using System.Threading.Tasks;
using System.Threading;
using AngleSharp.Dom;
using System.ComponentModel;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;
using AngleSharp.Text;
using AngleSharp.Css;
using AngleSharp.Common;
using System.Dynamic;
using System.Text.Json;
using System.Net;
using System.Reflection;
using System.IO;
using NewParser;
using Microsoft.Data.Sqlite;

namespace Parser
{
    public class Program
    {
        // код страницы відрізняється від подивитися код
        static async Task Main(string[] args)
        {
            string hist4withcomm = ""; 
            string hist4withoutcomm = "";

            try
            {
                using (StreamReader sr = new StreamReader("C:\\Новая папка\\with.txt"))
                {
                    hist4withcomm = sr.ReadToEnd();
                }
                using (StreamReader sr = new StreamReader("C:\\Новая папка\\without.txt"))
                {
                    hist4withoutcomm = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
            }










            string con = "C:\\C#\\NMT_tests\\NMT_tests\\mydb.db";
            string TableName = "Math4";

            





            // 4 хіст дуже великий
            string qId = "q1";
            string moduleName = "Hist1";
            string filePath = "C:\\zno-tests\\1.1";
            int CoutOfQuestions = 0;
            

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            using var context = BrowsingContext.New(Configuration.Default);

            using var doc = await context.OpenAsync(req => req.Content(hist4withcomm)); //with comment
            using var doc2 = await context.OpenAsync(req => req.Content(hist4withoutcomm)); // with answer

            var elements = doc.GetElementsByClassName("task-card");
            var elements2 = doc2.GetElementsByClassName("task-card");

            GetTitle(doc);
            Console.WriteLine(GetCorrectAnswer(elements2, qId));
            List<string> someting = GetAnswers(elements2, qId);
            CoutOfQuestions = GetNumbOfQustions(doc);

            GetAnswers(elements, qId);

            List<Question> questions = new List<Question>();


            //Question q = new Question();
            //q.QuestionText = GetQuestion(elements, qId);
            //q.Answers = GetAnswers(elements, qId);
            //q.CorrectAnswer = GetCorrectAnswer(elements2, qId);
            //q.Comment = GetComment(elements, qId, q.CorrectAnswer);
            //q.ImageName = GetBase64Image(elements, qId, filePath, moduleName).Result;
            //q.CommentImage = GetCommentImage(elements, qId, q.CorrectAnswer).Result;
            //questions.Add(q);


            for (int i = 1; i < CoutOfQuestions + 1; i++)
            {
                try
                {
                    qId = "q" + i;
                    Question q = new Question();
                    q.QuestionText = GetQuestion(elements, qId);
                    q.Answers = GetAnswers(elements, qId);
                    q.CorrectAnswer = GetCorrectAnswer(elements2, qId);
                    q.Comment = GetComment(elements, qId, q.CorrectAnswer);
                    q.ImageName = GetBase64Image(elements, qId, filePath, moduleName).Result;
                    q.CommentImage = GetCommentImage(elements, qId, q.CorrectAnswer).Result;

                    questions.Add(q);
                }
                catch (Exception)
                {

                    Console.WriteLine("Error qId = {0}", qId);
                }

            }

            List<QuestionModel> all = new List<QuestionModel>();
            CorrectInput correctInput = new CorrectInput(questions);
            correctInput.FillAll();
            all = correctInput.GetRezult();

            using (var connection = new SqliteConnection($"Data Source={con}"))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"CREATE TABLE {TableName}(Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, ImageData TEXT, Task TEXT, a1 TEXT, a2 TEXT, a3 TEXT, a4 TEXT, a5 TEXT, a6 TEXT, a7 TEXT, a8 TEXT, b1 TEXT, b2 TEXT, b3 TEXT, b4 TEXT, b5 TEXT, CorrectAnswer TEXT, Comment TEXT, CommentImage TEXT)";
                command.ExecuteNonQuery();
                Console.WriteLine($"Таблица {TableName} создана");
                foreach (var item in all)
                {


                    try
                    {
                        command.CommandText = $"""INSERT INTO {TableName}(ImageData, Task, a1, a2, a3, a4, a5, a6, a7, a8, b1, b2, b3, b4, b5, CorrectAnswer, Comment, CommentImage) VALUES ("{item.ImageData}", "{item.Task}", "{item.a1}", "{item.a2}", "{item.a3}", "{item.a4}", "{item.a5}", "{item.a6}", "{item.a7}", "{item.a8}", "{item.b1}", "{item.b2}", "{item.b3}", "{item.b4}", "{item.b5}", "{item.CorrectAnswer}", "{item.Comment}", "{item.CommentImage}")""";
                        command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Was an error at q {0}", item.Id);
                        Console.WriteLine(item.Task);
                    }

                }


            }


            //{
            //    string js = JsonSerializer.Serialize(questions);
            //    List<Question> ques1 = new List<Question>();
            //    ques1 = JsonSerializer.Deserialize<List<Question>>(js);
            //    string jsonPath = filePath + $"\\{moduleName}.json";
            //    File.WriteAllText(jsonPath, js);
            //}

        }

        public static async Task<string> GetBase64Image(IHtmlCollection<IElement> elements, string qId, string filePath, string module)
        {
            IElement url = null;
            string imgUrl = "";
            try
            {
                url = elements.GetElementById<IElement>(qId).ChildNodes.GetElementsByTagName("img")[0];
            }
            catch (Exception)
            {

            }

            if (url != null)
            {
                string part2 = "";
                string part1 = url.BaseUri;
                string[] t = url.OuterHtml.Split(" ");

                foreach (var item in t)
                {
                    if (item.Contains("src"))
                    {
                        part2 = item.ReplaceFirst("src=", "");
                        part2 = part2.Trim('"');

                    }
                }
                imgUrl = part1 + part2;
                if (imgUrl.EndsWith("\">"))
                {
                    imgUrl = imgUrl.Replace("\">", "");
                }
            }
            try
            {
                using (var client = new HttpClient())
                {
                    var bytes = await client.GetByteArrayAsync(imgUrl);
                    return Convert.ToBase64String(bytes);
                }
            }
            catch (Exception)
            {
               
                
            }
            return "";


     
        }

        public static string GetImage(IHtmlCollection<IElement> elements, string qId, string filePath, string module)
        {
            IElement url = null;
            try
            {
                url = elements.GetElementById<IElement>(qId).ChildNodes.GetElementsByTagName("img")[0];
            }
            catch (Exception)
            {
                
            }
            
            if (url != null)
            {
                string part2 = "";
                string part1 = url.BaseUri;
                string[] t = url.OuterHtml.Split(" ");

                foreach (var item in t)
                {
                    if (item.Contains("src"))
                    {
                        part2 = item.ReplaceFirst("src=", "");
                        part2 = part2.Trim('"');

                    }
                }
                string imgUrl = part1 + part2;

                string imagePath = filePath + "\\" + module + ".img_" + qId + ".png";
                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(imgUrl, imagePath);
                    }

                    return module + ".img_" + qId + ".png";
                }
                catch (Exception)
                {
                    return null;                    
                }
                
            }
            else
            {
                return null;
            }
            
        }

        public static string GetSpecialAnswer(IHtmlCollection<IElement> elements, string qId)
        {
            var answer = elements.GetElementById<IElement>(qId).ChildNodes.GetElementsByTagName("table");
            var temp = answer[1].InnerHtml;
            string rezult = "";
            for (int i = 0; i < temp.Length; i++)
            {
                if (Char.IsDigit(temp[i]))
                    rezult += temp[i];
            }
            return rezult;
        }
        public static string GetCorrectAnswer(IHtmlCollection<IElement> elements, string qId)
        {
            string result = default; //1А2Б3В4Г

            var answer = elements.GetElementById<IElement>(qId).ChildNodes.GetElementsByClassName("select-answers-variants");
            if (answer.Length == 0)
            {
                try
                {
                    return GetSpecialAnswer(elements, qId);
                }
                catch (Exception)
                {
                    answer = elements.GetElementById<IElement>(qId).ChildNodes.GetElementsByClassName("q-info");
                    string str = answer[1].TextContent;
                    result = str.Replace("Правильна відповідь: ", "");
                    return result;
                }
               
            }
            else
            {
                var correctAnsw = answer[0].GetElementsByTagName("tr");
                List<IElement> tableList = correctAnsw.ToList<IElement>();

                for (int i = 1; i < tableList.Count; i++)
                {
                    List<IElement> answerList = tableList[i].GetElementsByTagName("td").ToList<IElement>();
                    for (int t = 0; t < answerList.Count; t++)
                    {
                        if (answerList[t].InnerHtml.ToString().Contains("marker ok"))
                        {
                            string let = "";
                            if ((t + 1) == 1)
                            {
                                let = "А";
                            }
                            else if ((t + 1) == 2)
                            {
                                let = "Б";
                            }
                            else if ((t + 1) == 3)
                            {
                                let = "В";
                            }
                            else if ((t + 1) == 4)
                            {
                                let = "Г";
                            }
                            else if ((t + 1) == 5)
                            {
                                let = "Д";
                            }
                            else
                            {
                                break;
                            }


                            result += let;
                        }
                    }
                }
                return result;
            }
            
        }

        public static string GetComment(IHtmlCollection<IElement> elements, string qId, string answ)
        {           
            string t = "";
            var comment = elements.GetElementById<IElement>(qId).ChildNodes.GetElementsByClassName("explanation");
            if (comment.Length != 0)
            {


                var temp = comment[0].TextContent.Replace("\t", "");
                temp.Replace("\n\n", "\n");
                t = temp;
            }
            else
            {
                t = $"Відповіть: {answ}.";
            }
            return t;

        }

        public static async Task<string> GetCommentImage(IHtmlCollection<IElement> elements, string qId, string answ)
        {
            try
            {
                var comment = elements.GetElementById<IElement>(qId).ChildNodes.GetElementsByClassName("explanation");
                var url = comment[0].ChildNodes.GetElementsByTagName("img")[0];

                string part2 = "";
                string part1 = url.BaseUri;
                string[] d = url.OuterHtml.Split(" ");

                foreach (var item in d)
                {
                    if (item.Contains("src"))
                    {
                        part2 = item.ReplaceFirst("src=", "");
                        part2 = part2.Trim('"');
                    }
                }
                string imgUrl = part1 + part2;
                try
                {
                    using (var client = new HttpClient())
                    {
                        var bytes = await client.GetByteArrayAsync(imgUrl);
                        return Convert.ToBase64String(bytes);
                    }
                }
                catch (Exception)
                {
                }
                
            }
            catch(Exception ex)
            {

            }

            return "";
        }


        public static List<string> GetAnswers(IHtmlCollection<IElement> elements, string qId)
        {
            
            List<string> listOfString = new List<string>(); // list of answers
            try
            {
                var answers = elements.GetElementById<IElement>(qId).ChildNodes.GetElementsByClassName("answers")[0].ChildNodes;
                var answer = answers.GetElementsByClassName("answer");
                foreach (var item in answer)
                {

                    listOfString.Add(MakeCorrecHTML.ChangeHTML(item.InnerHtml));
                }
                if (elements.GetElementById<IElement>(qId).ChildNodes.GetElementsByClassName("answers").Count<INode>() == 2)
                {
                    var answers2 = elements.GetElementById<IElement>(qId).ChildNodes.GetElementsByClassName("answers")[1].ChildNodes;
                    var answer2 = answers2.GetElementsByClassName("answer");
                    foreach (var item in answer2)
                    {
                        listOfString.Add(MakeCorrecHTML.ChangeHTML(item.InnerHtml));
                    }
                }

            }
            catch (Exception)
            {

                Console.WriteLine("GetAnswers exp qid = {0}", qId);
            }
            

            return listOfString;

        }

        public static string GetQuestion(IHtmlCollection<IElement> elements, string qId)
        {
            var question = elements.GetElementById<IElement>(qId).ChildNodes.GetElementsByClassName("question");
            string str = MakeCorrecHTML.ChangeHTML(question[0].InnerHtml);

            if (str.Contains("img"))
            {
                str = "";
            }
            return str;
        }

        public static void GetTitle(IDocument doc)
        {
            var title = doc.GetElementsByClassName("test-title");
            Console.WriteLine(title[0].TextContent.Trim());
        }

        public static int GetNumbOfQustions(IDocument doc)
        {
            var temp = doc.GetElementsByClassName("row");
            int count = Convert.ToInt32(temp[3].TextContent);
            return count;
        }

    }
}
