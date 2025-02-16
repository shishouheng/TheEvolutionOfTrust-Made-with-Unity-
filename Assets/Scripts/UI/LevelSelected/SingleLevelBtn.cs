using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class SingleLevelBtn : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
	public LevelData LevelData;
	private GameObject m_SelectedBar;
	private LevelSelectedBar bar;
	

	private void Start()
	{
		m_SelectedBar = GameObject.Find("LevelBar");
		
		if(m_SelectedBar==null)
			Debug.LogError("can't find LevelBar obj");
		
		else
		{
			bar = m_SelectedBar.GetComponent<LevelSelectedBar>();
		}
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		bar.levelTips.SetActive(true);
		bar.levelTips.transform.position = transform.position + Vector3.up*100;
		bar.text.text = LevelData.levelNum + ". " + LevelData.desc;
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		bar.levelTips.SetActive(false);
	}
}