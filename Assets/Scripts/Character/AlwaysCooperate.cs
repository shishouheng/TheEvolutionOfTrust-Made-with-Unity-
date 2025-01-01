using System;
//小粉帽：永远合作
namespace Character
{
	public class AlwaysCooperate: CharacterBase
	{
		public override bool firstChoice { get; } = true;

		private void Start()
		{
			characterName = "小粉帽";
		}

		public override bool MakeDecision(bool otherLastChoice)
		{
			return true;
		}
	}
}