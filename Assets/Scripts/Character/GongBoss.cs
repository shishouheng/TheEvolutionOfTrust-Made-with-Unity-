using System;
//黑帮老铁：先合作，如果玩家欺骗了一次，就用不合作
namespace Character
{
	public class GongBoss: CharacterBase
	{
		public override bool firstChoice { get; } = true;
		private bool mHasLostTrust = false;
		private void Start()
		{
			characterName = "黑帮老铁";
		}

		public override bool MakeDecision(bool otherLastChoice)
		{
			if (!otherLastChoice)
				mHasLostTrust = true;
			
			if (mHasLostTrust)
				return false;

			return true;
		}
	}
}