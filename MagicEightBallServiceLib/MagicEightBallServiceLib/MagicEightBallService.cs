using System;
using System.ServiceModel;

namespace MagicEightBallServiceLib
{
	public class MagicEightBallService : IEightBall
	{
		public MagicEightBallService()
		{
			Console.WriteLine("The 8-ball awaits your question...");
		}

		public string ObtainAnswerToQuestion(string userQuestion)
		{
			var answers = new string[] {"Future uncertain", "Yes", "No", "Hazy", "Ask again later", "Definitely"};
			var random = new Random();
			var answer = answers[random.Next(answers.Length)];
			return answer;
		}
	}
}
