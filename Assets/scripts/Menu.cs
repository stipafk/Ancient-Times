using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	public GameObject MenuCanvas;

	// Use this for initialization
	void Start () {
		// Создаём канвас для меню
		MenuCanvas = new GameObject();
		MenuCanvas.name = "MenuCanvas";
		MenuCanvas.AddComponent<Canvas>();
		Canvas myCanvas = MenuCanvas.GetComponent<Canvas> ();
		myCanvas.renderMode = RenderMode.ScreenSpaceOverlay;
		
		// Создаём панель и задаём ей фон
		GameObject Panel = new GameObject("Panel");
	    Panel.AddComponent<CanvasRenderer>();
	    Image i = Panel.AddComponent<Image>();
	    Panel.transform.SetParent(MenuCanvas.transform, false);
		i.sprite = Resources.Load(PlayerPrefs.GetString("MenuBackground"), typeof(Sprite)) as Sprite;
		Debug.Log (PlayerPrefs.GetString("MenuBackground"));
	    
	    // Делаем по центру и на весь экран
	    Panel.GetComponent< RectTransform >().anchorMin = new Vector2(0, 0);
        Panel.GetComponent< RectTransform >().anchorMax = new Vector2(1, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
