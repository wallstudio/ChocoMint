using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Spown : MonoBehaviour {

    [SerializeField]
    GameObject Fab;
    [SerializeField]
    Text ScoreBoerd;

    public static int Score = 10;

    bool IsEnd = false;

	// Use this for initialization
	void Start () {
        Score = 10;
        StartCoroutine(SpownMint());
	}

    IEnumerator SpownMint()
    {
        for (int i = 0; !IsEnd; i++)
        {
            Instantiate(Fab, new Vector3(Random.Range(-4.0f, 4.0f), 7.5f, 0), Quaternion.identity);
            yield return new WaitForSeconds(0.3f);
        }
    }
	
	// Update is called once per frame
	void Update () {
        ScoreBoerd.text = string.Format("HP {0} / 10", Score);

        if(Score <= 0 && !IsEnd)
        {
            IsEnd = true;
            SceneManager.LoadScene("Gameover");
        }
	}
}
