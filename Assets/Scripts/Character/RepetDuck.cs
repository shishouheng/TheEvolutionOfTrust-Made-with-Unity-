using System;
using Unity.VisualScripting;

namespace Character
{
	public class RepetDuck: CharacterBase
	{
		private bool lastOpponentMove = true;
		private bool shouldMimic = false;
		private int consecutiveCheatCount = 0;
		
		private void Start()
		{
			characterName = "复读鸭";
		}

		public override bool MakeDecision(bool opponentLastMove)
		{
			// 检测连续欺骗两次
			if (!opponentLastMove)
			{
				consecutiveCheatCount++;
				if (consecutiveCheatCount >= 2)
					shouldMimic = true; // 进入模仿模式
			}
			else
			{
				consecutiveCheatCount = 0; // 重置计数
			}

			// 根据状态做出决策
			if (shouldMimic)
			{
				// 模仿玩家的上一次行为
				return lastOpponentMove;
			}

			// 默认合作
			lastOpponentMove = opponentLastMove; // 更新玩家行为记录
			return true;
		}
	}
}