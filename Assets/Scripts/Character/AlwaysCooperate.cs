using System;
//小粉帽：永远合作
namespace Character
{
	public class AlwaysCooperate: CharacterBase
	{
		private void Start()
		{
			characterName = "小粉帽";
		}

		public override bool MakeDecision(bool opponentLastMove)
		{
			return true;
		}
	}
}