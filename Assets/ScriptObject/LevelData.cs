using UnityEngine;

[CreateAssetMenu(fileName = "LevelData",menuName = "ScriptObject/关卡数据",order = 0)]
public class LevelData : ScriptableObject
{
    public int levelNum;
    public string desc;
}
