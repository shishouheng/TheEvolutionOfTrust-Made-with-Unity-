using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
   private Transform m_LevelRoot;
   private LevelBase m_CurrentLevel;

   public TextMeshPro testShow;
   public List<GameObject> allLevels;

   public LevelBase CurrentLevel
   {
      get => m_CurrentLevel;
      set => m_CurrentLevel = value;
   }


   private void Awake()
   {
      allLevels = new List<GameObject>();
      //m_LevelRoot = GameObject.Find("LevelObj").transform;
   }

   private void Start()
   {
      AddLevelComponent();
   }


   private void AddLevelComponent()
   {
      if (m_LevelRoot == null)
      {
         Debug.Log("miss level root");
         return;
      }

      foreach (Transform child in m_LevelRoot)
      {
         string className = child.name;
         Type type = Type.GetType(className);

         if (type != null && child.gameObject.GetComponent(type)==null)
         {
            child.gameObject.AddComponent(type);
            Debug.Log($"Added {className} to {child.name}");
            allLevels.Add(child.gameObject);
         }
      }

      if (allLevels.Count == 0)
      {
         Debug.Log("no member be added");
      }
   }

   private void SetCurrentLevel(int levelNum)
   {
      
   }
}
