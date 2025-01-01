using System;
//千年老油条：永不合作,一直欺骗
namespace Character
{
	public class AlwaysCheat: CharacterBase
	{
		public override bool firstChoice { get; } = true;

		private void Start()
		{
			characterName = "千年老油条";
		}

		public override bool MakeDecision(bool otherLastChoice)
		{
			return false;
		}
	}
}