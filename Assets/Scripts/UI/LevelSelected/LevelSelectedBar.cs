using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelSelectedBar : MonoBehaviour
{
    public GameObject levelTips;

    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = levelTips.GetComponentInChildren<TextMeshProUGUI>();
        levelTips.SetActive(false);
        foreach (Transform child in transform)
        {
            SingleLevelBtn singleLevelBtn = child.gameObject.AddComponent<SingleLevelBtn>();
            if (singleLevelBtn == null)
            {
                Debug.LogError("add singleLevelBtn component failed");
            }

            singleLevelBtn.LevelData = Resources.Load<LevelData>(child.name);

            if (singleLevelBtn.LevelData == null)
            {
                Debug.LogError("add levelData failed");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
