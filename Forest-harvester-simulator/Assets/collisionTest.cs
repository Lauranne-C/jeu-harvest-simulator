using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisionTest : MonoBehaviour
{
    private int nbLog = 0;
    private int frame = 0;
    public Text LogText;
    // Start is called before the first frame update
    void Start()
    {
        LogText.text = nbLog + " / 5";
    }

    // Update is called once per frame
    void Update()
    {
        frame++;
        if (frame > 60)
        {
            frame = 0;
            Debug.Log(nbLog);
        }
    }

    void OnCollisionEnter(Collision hit)
    {
        if (hit.transform.gameObject.name == "Log")
        {
            nbLog++;
            LogText.text = nbLog + " / 5";
        }
    }
}