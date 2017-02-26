using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosterCreator : MonoBehaviour {

	private string sample_json = "[ {    \"museum_id\": 1,    \"poster_id\": 1,    \"title_text\": \"Youtube 360\",    \"image_name\": \"poster_image_001\",    \"description_text\": \"360 degree video ads let you engage your audience in an entirely new way. Available today in Chrome and the YouTube app on Android and iOS, viewers can explore every angle of your videos by dragging their mouse or moving their phone to shift their POV 360 degrees – up, down, left or right. Thanks to the ability simply to move your phone to see different parts of the video, 360 video ads are a truly mobile-first video ad product.\"  },  {    \"museum_id\": 1,    \"poster_id\": 2,    \"title_text\": \"Immersv\",    \"image_name\": \"poster_image_002\",    \"description_text\": \"Immersv is a VR advertising platform that wants to help gamemakers and app designers with discovery while also providing them with a way to generate revenue. The idea is to enable studios to insert video commercials into their VR experiences. The startup already launched its ad exchange in a closed beta for a few clients in December with support for mobile headsets like Samsung’s Gear VR and Google Cardboard.\"  },  {    \"museum_id\": 1,    \"poster_id\": 3,    \"title_text\": \"Vertebrae\",    \"image_name\": \"poster_image_003\",    \"description_text\": \"Vertebrae is a technology company building the future of Virtual Reality (VR) and Augmented Reality (AR) advertising.\\nOur mission is to make VR accessible to publishers, advertisers and consumers alike through our next generation monetization platform. Our headset-agnostic VR ad tech is currently in private beta and is being used by entertainment studios, gaming companies, brands and creative agencies to tell stories in dynamic virtual environments. Out technology enables native 3D and 360° video ad insertion within a range of fully immersive and interactive ad formats.\\n\\nThe Vertebrae team is comprised of creative professionals from new media, gaming, and advertising from companies like Oculus, Google, Activision. and Twitter. We are passionately innovating the future of VR and AR advertising.\\n\\nRaised $10M in Sept 2016.\"  },  {    \"museum_id\": 2,    \"poster_id\": 4,    \"title_text\": \"CognitiveVR\",    \"image_name\": \"poster_image_004\",    \"description_text\": \"CognitiveVR is a brand new analytics solution that overcomes the complexity of virtual reality (VR) to bring you deep insights into how your users are interacting with your products. Our technology is hardware agnostic, developer friendly, and easy to configure. Open APIs mean less time onboarding and more time building your VR products.\"  },  {    \"museum_id\": 2,    \"poster_id\": 5,    \"title_text\": \"Retinad\",    \"image_name\": \"poster_image_005\",    \"description_text\": \"The World's First Ads and Analytics Platform made exclusively for Virtual Reality Developers\\n\\nRaised a $500k Angel round in May 2015. In River 2\"  },  {    \"museum_id\": 3,    \"poster_id\": 6,    \"title_text\": \"IKEA\",    \"image_name\": \"poster_image_006\",    \"description_text\": \"IKEA today announced the release of a pilot virtual reality app, the IKEA VR Experience, on Valve’s world leading game platform Steam. The test app, featuring a virtual kitchen experience, is the first foray from IKEA into VR technology. The launch of the app is intended to solicit consumer feedback as IKEA continues to explore the possible implications of the technology for the home. In recent years, IKEA has explored new technology as a way to improve its offer and empower customers. The launch of IKEA VR Experience is one of the steps taken in this effort.\"  },  {    \"museum_id\": 3,    \"poster_id\": 7,    \"title_text\": \"VisualCommerce\",    \"image_name\": \"poster_image_007\",    \"description_text\": \"VisualCommerce™ is the award-winning virtual products platform that powers top Augmented Reality and Virtual Reality apps for leading retailers and manufacturers, including the Lowe’s Holoroom.\\nMarxent offers market-leading expertise in the latest Augmented Reality and mobile app development technologies for Android and iOS. A Qualcomm Preferred Vendor, our team is experienced with AR and ready to work with you.\"  },  {    \"museum_id\": 3,    \"poster_id\": 8,    \"title_text\": \"ZeroLight\",    \"image_name\": \"poster_image_008\",    \"description_text\": \"ZeroLight is the world’s most advanced car configurator solution. We create engaging configurators using real-time 3D visualisation to drive a live, interactive scene of the car.\"  },  {    \"museum_id\": 3,    \"poster_id\": 9,    \"title_text\": \"Innoactive VR Showroom\",    \"image_name\": \"poster_image_009\",    \"description_text\": \"The Future of Retail\\nPresent your Products, better than you ever could in reality. For Example: present beautiful furniture in an amazing apartment, including multi-million-dollar-views. At the flip of a virtual switch, change the environment to a cozy mountain chalet.\"  },  {    \"museum_id\": 4,    \"poster_id\": 10,    \"title_text\": \"Matterport\",    \"image_name\": \"poster_image_010\",    \"description_text\": \"Quick 3D Scanning for interior spaces. Primarily targeting the Real Estate market, they use a combination of 360 photo capture and 3D reconstruction.\\n\\n$4000 for the 3D scanning camera + additional fees for their service\\n\\nRaised $56M from Qualcomm Ventures, DCM, Lux\"  },  {    \"museum_id\": 4,    \"poster_id\": 11,    \"title_text\": \"Studio216\",    \"image_name\": \"poster_image_011\",    \"description_text\": \"Studio 216 is a digital production agency that empowers our clients to see the future and experience virtual environments. Our award-winning VR, MR, visualization and mobile applications bring projects to life by crafting the story of place.\"  },  {    \"museum_id\": 4,    \"poster_id\": 12,    \"title_text\": \"Vint\",    \"image_name\": \"poster_image_012\",    \"description_text\": \"Virt's patent-pending technology allows us to create low-cost virtual reality copies of real-world spaces, using 360-degree videos.\\n\\nFor Sellers:\\nThis means we can create a virtual tour of that home you're trying to sell for the same cost as photographing it; or if you're a brick & mortar retailer, we can bring your business into virtual reality with a great ROI.\\nFor Shoppers:\\nSome things just weren't mean to be flat, like your favorite establishment or that home you're looking to buy. Shopping online can feel like running into a wall, but now you'll be able to virtually step inside the store and browse naturally. Looking at a home online and then seeing it in person can be quite a different experience, but now it doesn't have to be.\\n\\n\"  },  {    \"museum_id\": 5,    \"poster_id\": 13,    \"title_text\": \"NextVR\",    \"image_name\": \"poster_image_013\",    \"description_text\": \"NextVR is a pioneer in capturing and delivering immersive, high-definition, live and recorded virtual reality experiences, specializing in sports and live events. They are creating a content platform for sharing video VR experiences and already support GearVR\"  },  {    \"museum_id\": 5,    \"poster_id\": 14,    \"title_text\": \"Immersive Media\",    \"image_name\": \"poster_image_014\",    \"description_text\": \"The Immersive Media Content Platform\\n\\nImmersive Media has a full compliment of technology to capture, produce, distribute and view interactive immersive experiences. Our patented capabilities extend beyond simple hardware cameras or stitching algorithms. We provide a unique end-to-end platform that allows our customers and partners to take advantage of not only our capture and production technology but our industry leading content management and distribution platform.\\n\\nThey can do live 360 streaming.\"  },  {    \"museum_id\": 5,    \"poster_id\": 15,    \"title_text\": \"Vantage.TV\",    \"image_name\": \"poster_image_015\",    \"description_text\": \"vantage.tv is a new social virtual reality events platform that lets you experience concerts, sports and other types of shows in 360, from multiple angles, with your friends enjoying right along side you.\"  }]";
	int museum_id;
	string museum_name;

	public Text museumTitle;
	public GameObject posterObject;
	public Image Fadein;
	public float fadeVelocity = 0.2f;
	public GameObject FadeinCanvas;

	void Awake () {
		sample_json = "{\"Items\":" + sample_json + "}";
		museum_id = EnterMuseum.getMuseumId ();
		museum_name = EnterMuseum.getMuseumName ();
	}

	void Start () {
		Poster[] posters = JsonHelper.FromJson<Poster>(sample_json);
		museumTitle.text = museum_name;

		foreach (Poster p in posters) {
			if (p.museum_id == museum_id) {
				CreatePoster (p.title_text, p.description_text, p.image_name);
			}
		}
	}

	void Update () {
		if (Fadein.color.a > 0.0f) {
			Color newColor = new Color (Fadein.color.r, Fadein.color.g, Fadein.color.b, Fadein.color.a - fadeVelocity * Time.deltaTime);
			Fadein.color = newColor;
		} else {
			FadeinCanvas.SetActive (false);
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
