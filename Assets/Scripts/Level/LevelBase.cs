using UnityEngine;

public abstract class LevelBase : MonoBehaviour
{
    //关卡编号
    private int levelNum;
    private string desc;

    public LevelBase(int levelNum, string desc)
    {
        this.levelNum = levelNum;
        this.desc = desc;
    }
    
    public int LevelNum
    {
        get { return levelNum; }
    }

    public string Desc
    {
        get { return desc; }
    }

    private void Awake()
    {
        
    }

    private void Start()
    {
        Init();
    }

    public virtual void Init()
    {
        
    }
}
