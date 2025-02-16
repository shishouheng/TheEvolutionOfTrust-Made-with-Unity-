using UnityEngine;
using UnityEngine.UI;

public class GameTestManager : MonoBehaviour
{
	public CharacterBase characterA;
	private bool aCurrentChoice;
	public CharacterBase characterB; 
	private bool bCurrentChoice;
	public int rounds = 10;

	public Button newRoundBtn;

	void Start()
	{
		newRoundBtn.onClick.AddListener(SimulateGame);
	}

	void Rest()
	{
	}

	void SimulateGame()
	{
		// 初始化首轮行为
		aCurrentChoice = characterA.firstChoice;
		bCurrentChoice = characterB.firstChoice;

		for (int i = 0; i < rounds; i++)
		{
			// 输出轮次和行为
			Debug.Log(
				$"Round {i + 1}: {characterA.characterName} -> {aCurrentChoice}, {characterB.characterName} -> {bCurrentChoice}");

			// 每个角色根据对方上次的行为做出决策
			bool aNextChoice = characterA.MakeDecision(bCurrentChoice);
			bool bNextChoice = characterB.MakeDecision(aCurrentChoice);

			// 更新下回合的行为
			UpdateNextRountChoice(aNextChoice,bNextChoice);
		}
	}

	private void UpdateNextRountChoice(bool decisionA,bool decisionB)
	{
		aCurrentChoice = decisionA;
		bCurrentChoice = decisionB;
	}
}