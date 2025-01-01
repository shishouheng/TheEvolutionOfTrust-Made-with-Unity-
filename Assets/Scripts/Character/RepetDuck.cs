using UnityEngine;

//跟复读机几乎一样，但只会在玩家连着「欺骗」两次的情况下才选择反击回去。
namespace Character
{
	public class RepetDuck: CharacterBase
	{
		public override bool firstChoice { get; } = true;
		private bool shouldMimic;
		private int consecutiveCheatCount = 0;
		
		private void Start()
		{
			characterName = "复读鸭";
		}

		public override bool MakeDecision(bool otherLastChoice)
		{
			// 如果已经进入模仿模式，直接模仿对方的上一次行为
			if (shouldMimic)
			{
				Debug.Log("[模仿触发] 复读对方行为: "+otherLastChoice);
				return otherLastChoice; // 模仿对方的当前行为
			}

			// 检查对方是否欺骗
			if (!otherLastChoice)
			{
				consecutiveCheatCount++;
				Debug.Log($"对方欺骗，当前被欺骗次数: {consecutiveCheatCount}");

				if (consecutiveCheatCount >= 2)
					Debug.Log("1");
				
				if (consecutiveCheatCount >= 2)
				{
					shouldMimic = true; // 进入模仿模式
					Debug.Log("[模仿模式开启] 连续被欺骗两次，开始复读");
					return false;
				}
			}
			else
			{
				consecutiveCheatCount = 0; // 对方未欺骗，重置计数
				Debug.Log("[计数重置] 对方合作，连续欺骗次数清零");
			}

			Debug.Log($"[复读鸭] 当前状态 - shouldMimic: {shouldMimic}, 连续欺骗次数: {consecutiveCheatCount}, 对方此次行为: {otherLastChoice}");
			return true;
		}
	}
}