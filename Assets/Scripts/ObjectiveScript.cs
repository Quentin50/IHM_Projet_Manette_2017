using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectiveScript : MonoBehaviour {

    public int nextScene;
    public float DistanceDeRamassage;


    private GUIStyle guiStyle = new GUIStyle();

    

    // Display scores
    public void OnGUI()
    {
        string toDisplay = "YOUR SCORE: " + PlayerPrefs.GetInt("Score");
        GUI.Label(new Rect(20, 10, 1000, 200), toDisplay);
    }

    // change scene
    void goToScene()
    {
        string sceneName = "scene" + nextScene;
        SceneManager.LoadScene(sceneName);
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 1);
    }
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        // check for distance between player and the star
      float playerDist = Mathf.Sqrt(Mathf.Pow(GameObject.Find("character").transform.position.x - this.gameObject.transform.position.x, 2)
                                    + Mathf.Pow(GameObject.Find("character").transform.position.y - this.gameObject.transform.position.y, 2));
      if(playerDist < DistanceDeRamassage) goToScene();
    }
}
