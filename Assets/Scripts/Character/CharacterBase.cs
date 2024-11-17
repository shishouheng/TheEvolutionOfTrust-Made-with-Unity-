using UnityEngine;

public abstract class CharacterBase : MonoBehaviour
{
    public string characterName;

    public abstract bool MakeDecision(bool opponentLastMove);
}
