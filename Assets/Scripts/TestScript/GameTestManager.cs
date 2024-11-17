using UnityEngine;

public class GameTestManager : MonoBehaviour
{
    public CharacterBase characterA;
    public CharacterBase characterB;
    public int rounds = 10;

    void Start()
    {
        SimulateGame();
    }

    void SimulateGame()
    {
        bool lastMoveA = true;
        bool lastMoveB = true;

        for (int i = 0; i < rounds; i++)
        {
            // 每个角色根据对方上次的行为做出决策
            bool decisionA = characterA.MakeDecision(lastMoveB);
            bool decisionB = characterB.MakeDecision(lastMoveA);

            // 输出轮次和行为
            Debug.Log($"Round {i + 1}: {characterA.characterName} -> {decisionA}, {characterB.characterName} -> {decisionB}");

            // 更新上一轮的行为
            lastMoveA = decisionA;
            lastMoveB = decisionB;
        }
    }
}
