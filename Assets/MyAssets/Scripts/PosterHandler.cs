using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosterHandler : MonoBehaviour{

	public Text title;
	public Text description;
	public Image image;

	public string title_text;
	public string description_text;
	public string image_name;

	void Start () {
		title.text = title_text;
		description.text = description_text;
		Texture2D texture = Resources.Load("Images/PosterImages/" + image_name) as Texture2D;
		image.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
	}
}
