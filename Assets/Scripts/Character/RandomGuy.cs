//胡乱来:以同样的概率随机选择「欺骗」或者「合作」。

using System;

namespace Character
{
	public class RandomGuy : CharacterBase
	{
		public override bool firstChoice
		{
			get { return random.Next(0, 2) == 1; }
		}

		private Random random;

		private void Start()
		{
			characterName = "胡乱来";
			random = new Random();
		}

		public override bool MakeDecision(bool otherLastChoice)
		{
			int decision = random.Next(0, 2);
			return decision == 1;
		}
	}
}