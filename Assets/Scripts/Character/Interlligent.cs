//福尔摩星人:每一局开始时的四轮会依次「合作」「欺骗」「合作」
//「合作」。之后，如果玩家反过来「欺骗」一次（包括前四轮中玩家的「欺骗」），
//就会像复读机那样跟着玩家出牌；
//如果玩家一直不「欺骗」，就会像千年老油条那样榨干玩家。

using System;

namespace Character
{
	public class Interlligent: CharacterBase
	{
		public override bool firstChoice { get; } = true;

		protected enum InterllignetState
		{
			FixedPattern,//前四局固定策略
			TitForTat,//复读机策略
			AlwaysCheat//永远欺骗策略
		}

		private InterllignetState mCurrentState=InterllignetState.FixedPattern;
		
		//当前游戏轮数
		//初始值设置为1是因为第一轮的策略使用的是firstChoice
		private int mCurrentRount=1;
		//玩家是否欺骗过
		private bool mHasPlayerCheat = false;
		//玩家上一次的行为
		private bool mLastOpponentMove = true;
		
		protected InterllignetState MCurrentState
		{
			get { return mCurrentState; }
		}
		private void Start()
		{
			characterName = "福尔摩星人";
		}

		public override bool MakeDecision(bool otherLastChoice)
		{
			mCurrentRount++;
			mLastOpponentMove = otherLastChoice;

			if (!otherLastChoice)
				mHasPlayerCheat = true;
			
			//根据当前状态做出决策
			switch (mCurrentState)
			{
				case InterllignetState.FixedPattern:
					return HandleFixedPattern();
				
				case InterllignetState.TitForTat:
					return HandleTitFotTat();

				case InterllignetState.AlwaysCheat:
					return HandleAlwaysCheat();
				
				default:
					throw new InvalidOperationException("未知状态");
			}
		}

		private bool HandleFixedPattern()
		{
			switch (mCurrentRount)
			{
				case 1: return true;
				case 2: return false;
				case 3: return true;
				case 4: return true;
				default:
					mCurrentState = mHasPlayerCheat ? InterllignetState.TitForTat : InterllignetState.AlwaysCheat;
					return MakeDecision(mLastOpponentMove);
			}
		}

		private bool HandleTitFotTat()
		{
			return mLastOpponentMove;
		}

		private bool HandleAlwaysCheat()
		{
			return false;
		}
	}
}