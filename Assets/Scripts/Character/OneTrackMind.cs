//先「合作」。如果玩家「合作」，就会做出跟自己上一轮一样的选择，即使上一轮犯错了也一样；如果玩家「欺骗」，就会做出跟自己上一轮相反的选择，犯错了也一样。

namespace Character
{
	public class OneTrackMind : CharacterBase
	{
		public override bool firstChoice { get; } = true;
		private bool lastSelfMove = true;

		private void Start()
		{
			characterName = "一根筋";
		}

		public override bool MakeDecision(bool otherLastChoice)
		{
			if (otherLastChoice)
				return lastSelfMove;

			lastSelfMove = !lastSelfMove;
			return lastSelfMove;
		}
	}
}