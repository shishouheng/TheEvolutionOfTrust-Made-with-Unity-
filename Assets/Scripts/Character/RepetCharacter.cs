using System;
//复读机：先合作，然后模仿对方的上一次行为
namespace Character
{
	public class TitForTat: CharacterBase
	{
		private bool lastOpponentMove = true;

		private void Start()
		{
			characterName = "复读机";
		}

		public override bool MakeDecision(bool opponentLastMove)
		{
			lastOpponentMove = opponentLastMove;
			return lastOpponentMove;
		}
	}
}