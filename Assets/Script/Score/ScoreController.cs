using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text skorP1;
    public Text skorP2;
    public Text skorP3;
    public Text skorP4;
    public ScoreManager manager;

    // Update is called once per frame
    void Update()
    {
        skorP1.text = manager.scoreP1.ToString();
        skorP2.text = manager.scoreP2.ToString();
        skorP3.text = manager.scoreP3.ToString();
        skorP4.text = manager.scoreP4.ToString();
    }
}
