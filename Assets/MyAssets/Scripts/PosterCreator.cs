using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosterCreator : MonoBehaviour {

	private string sample_json = "{\"Items\":[\n  {\n    \"museum_id\": 1,\n    \"poster_id\": 1,\n    \"title_text\": \"Youtube 360\",\n    \"image_name\": \"poster_image_001\",\n    \"poster_url\": \"https://adwords.googleblog.com/2015/07/see-future-of-video-by-looking-behind.html\",\n    \"description_text\": \"360 degree video ads let you engage your audience in an entirely new way. Available today in Chrome and the YouTube app on Android and iOS, viewers can explore every angle of your videos by dragging their mouse or moving their phone to shift their POV 360 degrees – up, down, left or right. Thanks to the ability simply to move your phone to see different parts of the video, 360 video ads are a truly mobile-first video ad product.\"\n  },\n  {\n    \"museum_id\": 1,\n    \"poster_id\": 2,\n    \"title_text\": \"Immersv\",\n    \"image_name\": \"poster_image_002\",\n    \"poster_url\": \"http://venturebeat.com/2016/03/10/immersv-enables-virtual-reality-developers-to-advertise-their-games-in-other-vr-apps/\",\n    \"description_text\": \"Immersv is a VR advertising platform that wants to help gamemakers and app designers with discovery while also providing them with a way to generate revenue. The idea is to enable studios to insert video commercials into their VR experiences. The startup already launched its ad exchange in a closed beta for a few clients in December with support for mobile headsets like Samsung’s Gear VR and Google Cardboard.\"\n  },\n  {\n    \"museum_id\": 1,\n    \"poster_id\": 3,\n    \"title_text\": \"Vertebrae\",\n    \"image_name\": \"poster_image_003\",\n    \"poster_url\": \"http://www.vertebrae.io\",\n    \"description_text\": \"Vertebrae is a technology company building the future of Virtual Reality (VR) and Augmented Reality (AR) advertising.\\nOur mission is to make VR accessible to publishers, advertisers and consumers alike through our next generation monetization platform. Our headset-agnostic VR ad tech is currently in private beta and is being used by entertainment studios, gaming companies, brands and creative agencies to tell stories in dynamic virtual environments. Out technology enables native 3D and 360° video ad insertion within a range of fully immersive and interactive ad formats.\\n\\nThe Vertebrae team is comprised of creative professionals from new media, gaming, and advertising from companies like Oculus, Google, Activision. and Twitter. We are passionately innovating the future of VR and AR advertising.\\n\\nRaised $10M in Sept 2016.\"\n  },\n  {\n    \"museum_id\": 2,\n    \"poster_id\": 4,\n    \"title_text\": \"CognitiveVR\",\n    \"image_name\": \"poster_image_004\",\n    \"poster_url\": \"http://cognitivevr.co\",\n    \"description_text\": \"CognitiveVR is a brand new analytics solution that overcomes the complexity of virtual reality (VR) to bring you deep insights into how your users are interacting with your products. Our technology is hardware agnostic, developer friendly, and easy to configure. Open APIs mean less time onboarding and more time building your VR products.\"\n  },\n  {\n    \"museum_id\": 2,\n    \"poster_id\": 5,\n    \"title_text\": \"Retinad\",\n    \"image_name\": \"poster_image_005\",\n    \"poster_url\": \"http://retinadvr.com\",\n    \"description_text\": \"The World's First Ads and Analytics Platform made exclusively for Virtual Reality Developers\\n\\nRaised a $500k Angel round in May 2015. In River 2\"\n  }\n]}";
	int museum_id;
	string museum_name;

	public Text museumTitle;
	public GameObject posterObject;
	public Image Fadein;
	public float fadeVelocity = 0.5f;

	void Awake () {
		museum_id = EnterMuseum.getMuseumId ();
		museum_name = EnterMuseum.getMuseumName () + " Museum";
		Debug.Log (museum_id);
	}

	void Start () {
		Poster[] posters = JsonHelper.FromJson<Poster>(sample_json);
		museumTitle.text = museum_name;

		foreach (Poster p in posters) {
			if (p.museum_id == museum_id) {
				Debug.Log (p.title_text);
				CreatePoster (p.title_text, p.description_text, p.image_name);
			}
		}
	}

	void Update () {
		if (Fadein.color.a > 0.0f) {
			Color newColor = new Color (Fadein.color.r, Fadein.color.g, Fadein.color.b, Fadein.color.a - fadeVelocity * Time.deltaTime);
			Fadein.color = newColor;
		}
	}

	void CreatePoster (string title, string description, string image_name) {
		GameObject newPoster = Instantiate (posterObject);
		newPoster.GetComponent<PosterHandler> ().title_text = title;
		newPoster.GetComponent<PosterHandler> ().description_text = description;
		newPoster.GetComponent<PosterHandler> ().image_name = image_name;

		newPoster.transform.parent = transform;
		newPoster.transform.localScale = new Vector3 (1, 1, 1);

		Vector3 pos = newPoster.transform.localPosition;
		pos.z = 0;
		newPoster.transform.localPosition = pos;
		
	}
}
