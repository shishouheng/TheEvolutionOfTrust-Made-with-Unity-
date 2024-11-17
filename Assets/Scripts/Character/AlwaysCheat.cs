using System;
//千年老油条：用不合作,一直欺骗
namespace Character
{
	public class AlwaysCheat: CharacterBase
	{
		private void Start()
		{
			characterName = "千年老油条";
		}

		public override bool MakeDecision(bool opponentLastMove)
		{
			return false;
		}
	}
}