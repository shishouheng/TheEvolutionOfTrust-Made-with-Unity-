using UnityEngine;

public abstract class CharacterBase : MonoBehaviour
{
	public string characterName;
	public abstract bool firstChoice { get; }

	public abstract bool MakeDecision(bool otherLastChoice);
}