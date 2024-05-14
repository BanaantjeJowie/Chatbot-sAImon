using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryChatbot
{
    public class Subjects
    {
        public Dictionary<string, List<string>> subjectQuestions;
        public Dictionary<string, Dictionary<string, List<string>>> subjectResponses;

        public Subjects()
        {
            subjectQuestions = new Dictionary<string, List<string>>();
            subjectResponses = new Dictionary<string, Dictionary<string, List<string>>>();

            // Add conversation subjects, questions, and responses
            AddSubject("Politics",
                new List<string> 
                {
                "What are the current political issues in your country?",
                "How do you think political systems can be improved?",
                "What role should the government play in addressing social issues?",
                "How do you feel about the political climate today?",
                "What are the major political parties in your country and their ideologies?",
                "Do you think everyone should vote? Why or why not?",
                "Who are you voting for in the next election?"
                },
                new Dictionary<string, List<string>> {
                { "Agree", new List<string> { "I like that.", "Absolutely, political reform is necessary." } },
                { "Disagree", new List<string> { "I'm not sure if I agree with that perspective.", "I can see where you're coming from, but I don't entirely agree." } }
                });

            AddSubject("Climate Change",
                new List<string> 
                {
                "What are the primary causes of climate change?",
                "How can individuals contribute to combating climate change?",
                "What are the potential consequences of failing to address climate change?",
                "What role should governments and corporations play in addressing climate change?",
                "How can renewable energy sources be promoted?",
                "How can we adapt to the effects of climate change?"
                },
                new Dictionary<string, List<string>> {
                { "Agree", new List<string> { "That's a valid point, individual actions do matter.", "Absolutely, we all need to do our part to combat climate change." } },
                { "Disagree", new List<string> { "I'm not sure if individual actions alone can solve the problem.", "I think the issue is more complex than just individual efforts." } }
                });


            AddSubject("Artificial Intelligence",
                new List<string>
                {
                "What are the benefits of artificial intelligence?",
                "What are the potential risks of artificial intelligence?",
                "How can we ensure that artificial intelligence is used ethically?",
                "What are the implications of artificial intelligence on the job market?",
                "How can artificial intelligence be used to address societal challenges?",
                "What are the limitations of artificial intelligence?"
                },
                new Dictionary<string, List<string>> {
                { "Agree", new List<string> { "I agree, AI has the potential to revolutionize many industries.", "Absolutely, AI can be a powerful tool for innovation." } },
                { "Disagree", new List<string> { "I'm not sure if I agree with that perspective.", "I think there are valid concerns about the impact of AI." } }
                });

            AddSubject("Space Exploration",
                new List<string>
                {
                "What are the benefits of space exploration?",
                "What are the challenges of space exploration?",
                "How can space exploration contribute to scientific knowledge?",
                "What are the potential risks of space exploration?",
                "How can space exploration inspire future generations?",
                "What are the ethical considerations of space exploration?"
                },
                new Dictionary<string, List<string>>{
                { "Agree", new List<string> { "I agree, space exploration has led to many technological advancements.", "Absolutely, the pursuit of knowledge is important." } },
                { "Disagree", new List<string> { "I'm not sure if I agree with that perspective.", "I think there are valid concerns about the cost and risks of space exploration." } }
                });

            AddSubject("Globalization",
                new List<string>
                {
                "What are the benefits of globalization?",
                "What are the drawbacks of globalization?",
                "How has globalization impacted different cultures?",
                "What are the implications of globalization on the economy?",
                "How can we address the negative effects of globalization?",
                "What role should governments play in regulating globalization?"
                },
                new Dictionary<string, List<string>> {
                { "Agree", new List<string> { "I agree, globalization has led to increased connectivity and economic growth.", "Absolutely, globalization has the potential to benefit many people." } },
                { "Disagree", new List<string> { "I'm not sure if I agree with that perspective.", "I think there are valid concerns about the impact of globalization on local economies." } }
                }); 

            AddSubject("Education",
                new List<string>
                {
                "What are the challenges facing the education system?",
                "How can we improve access to quality education?",
                "What role should technology play in education?",
                "How can we address educational inequality?",
                "What are the benefits of lifelong learning?",
                "How can we prepare students for the future job market?"
                },
                new Dictionary<string, List<string>>{
                { "Agree", new List<string> { "I agree, education is essential for personal and societal development.", "Absolutely, investing in education is crucial for the future." } },
                { "Disagree", new List<string> { "I'm not sure if I agree with that perspective.", "I think there are valid concerns about the current education system." } }
                });

            AddSubject("Healthcare",
             new List<string>{
                "What are the challenges facing the healthcare system?",
                "How can we improve access to healthcare services?",
                "What role should governments play in healthcare?",
                "How can we address healthcare inequality?",
                "What are the benefits of preventative healthcare?",
                "How can we promote mental health awareness?"
                },
                new Dictionary<string, List<string>>{
                { "Agree", new List<string> { "I agree, access to healthcare is a fundamental human right.", "Absolutely, investing in healthcare is essential for public well-being." } },
                { "Disagree", new List<string> { "I'm not sure if I agree with that perspective.", "I think there are valid concerns about the current healthcare system." } }
                });

            AddSubject("Technology",
                new List<string>{
                    "What are the benefits of technological advancements?",
                    "What are the drawbacks of technological advancements?",
                    "How can we ensure that technology is used ethically?",
                    "What are the implications of automation on the job market?",
                    "How can technology be used to address environmental challenges?",
                    "What are the limitations of current technology?",
                    "What is better, IOS or Android?",
                    "What is the best programming language?",
                    "What is the best computer brand?",
                    "What is the best phone brand?",
                    "What is the best game console?",
                    "What is the best game?",
                    "What is the best social media platform?",
                    "What is the best streaming service?",
                    "What is the best search engine?",
                    "What is the best web browser?",
                    "What is the best email provider?",
                    "What is the best messaging app?",
                },
                new Dictionary<string, List<string>>{
                { "Agree", new List<string> { "I agree, technology has the potential to improve our lives in many ways.", "Absolutely, technological innovation drives progress and efficiency." } },
                { "Disagree", new List<string> { "I'm not sure if I agree with that perspective.", "I think there are valid concerns about the impact of technology on society." } }
                });

            AddSubject("Social Media",
                new List<string>
                {
                    "What are the benefits of social media?",
                    "What are the drawbacks of social media?",
                    "How can we promote positive interactions on social media?",
                    "What are the implications of social media on mental health?",
                    "How can we address cyberbullying and online harassment?",
                    "What role should social media companies play in regulating content?",
                    "What is the best social media platform?",
                    "Who is your favorite social media influencer?",
                },
                new Dictionary<string, List<string>>
                {
                { "Agree", new List<string> { "I agree, social media has revolutionized communication and connectivity.", "Absolutely, social media can be a powerful tool for sharing information and building communities." } },
                { "Disagree", new List<string> { "I'm not sure if I agree with that perspective.", "I think there are valid concerns about the impact of social media on mental health and privacy." } }
                });

            AddSubject("Music",
                new List<string>
                {
                    "What is your favorite music genre?",
                    "Who is your favorite musician or band?",
                    "What is the best music streaming service?",
                    "How does music influence your mood?",
                    "What role does music play in your life?",
                    "What is the best music festival?",
                    "What is the best music video?",
                    "What is the best music award show?",
                    "What is the best music documentary?",
                    "What is the best music biopic?",
                    "What is the best music genre?",
                    "What is the best music album?",
                    "What is the best music artist?",
                    "What is the best music band?",
                    "What is the best music song?",
                    "What is the best music video?",
                    "What is the best music streaming service?",
                    "What is the best music festival?",
                    "What is the best music award show?",
                    "What is the best music documentary?",
                    "What is the best music biopic?",
                    "What is the best music genre?",
                    "What is the best music album?",
                    "What is the best music artist?",
                    "What is the best music band?",
                    "What is the best music song?",
                    "What is the best music video?",
                    "What is the best music streaming service?",
                    "What is the best music festival?",
                    "What is the best music award show?",
                    "What is the best music documentary?",
                    "What is the best music biopic?",
                    "What is the best music genre?",
                    "What is the best music album?",
                    "What is the best music artist?",
                    "What is the best music band?",
                    "What is the best music song?",
                    "What is the best music video?",
                    "What is the best music streaming service?",
                    "What is the best music festival?",
                    "What is the best music award show?",
                    "What is the best music documentary?",
                    "What is the best music biopic?",
                    "What is the best music genre?",
                    "What is the best music album?",
                    "What is the best music artist?",
                    "What is the best music band?",
                    "What is the best music song?",
                    "What is the best music video?",
                    "What is the best music streaming service?",
                    "What is the best music festival?",
                    "What is the best music award show?",
                    "What is the best music"
                },
                new Dictionary<string, List<string>>
                {
                { "Agree", new List<string> { "I agree, I really like that too.", "OMG YAAASSS!!!!" } },
                { "Disagree", new List<string> { "I'm not sure if I agree with that.", "NU-UH, stop the CAP" } }
                }) ;
                








        }

        private void AddSubject(string subject, List<string> questions, Dictionary<string, List<string>> responses)
        {
            subjectQuestions.Add(subject, questions);
            subjectResponses.Add(subject, responses);
        }

        public List<string> GetQuestionsForSubject(string subject)
        {
            if (subjectQuestions.ContainsKey(subject))
            {
                return subjectQuestions[subject];
            }
            else
            {
                Console.WriteLine("Subject not found.");
                return null;
            }
        }

        public Dictionary<string, List<string>> GetResponsesForSubject(string subject)
        {
            if (subjectResponses.ContainsKey(subject))
            {
                return subjectResponses[subject];
            }
            else
            {
                Console.WriteLine("Subject not found.");
                return null;
            }
        }

        public string GetRandomSubject()
        {
            Random rand = new Random();
            int index = rand.Next(subjectQuestions.Count);
            return subjectQuestions.Keys.ToArray()[index];
        }

        public static void Main(string[] args)
        {
            Subjects conversationSubjects = new Subjects();
            string randomSubject = conversationSubjects.GetRandomSubject();
            Console.WriteLine("Random Conversation Subject: " + randomSubject);
            List<string> questions = conversationSubjects.GetQuestionsForSubject(randomSubject);
            if (questions != null)
            {
                Console.WriteLine("Questions about " + randomSubject + ":");
                foreach (string question in questions)
                {
                    Console.WriteLine("- " + question);
                }

                Dictionary<string, List<string>> responses = conversationSubjects.GetResponsesForSubject(randomSubject);
                if (responses != null)
                {
                    Console.WriteLine("Enter your response:");
                    string userResponse = Console.ReadLine();

                    // Randomly select agreement or disagreement response
                    Random rand = new Random();
                    List<string> agreementResponses = responses["Agree"];
                    List<string> disagreementResponses = responses["Disagree"];
                    string selectedResponse;
                    if (rand.Next(2) == 0)
                        selectedResponse = agreementResponses[rand.Next(agreementResponses.Count)];
                    else
                        selectedResponse = disagreementResponses[rand.Next(disagreementResponses.Count)];

                    Console.WriteLine(selectedResponse);
                }
            }
        }
    }
}
