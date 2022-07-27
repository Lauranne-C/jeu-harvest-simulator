using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{
    public GameObject pauseMenuUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision hit)
    {
        if (hit.transform.gameObject.name == "Vehicle")
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}