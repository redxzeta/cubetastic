using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour {

    public Transform player;
    public Text Score;
	// Update is called once per frame
	void Update () {
        Score.text = player.position.z.ToString("0");
	}
}
