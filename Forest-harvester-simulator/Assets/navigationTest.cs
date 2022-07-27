using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class navigationTest : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> listUi = new List<GameObject>();

    private int currentItem = 0;

    private void OnEnable()
    {
        EventSystem.current.SetSelectedGameObject(null);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentItem++;
            if (currentItem >= listUi.Count) {
                currentItem = 0;
            }
            EventSystem.current.SetSelectedGameObject(listUi[currentItem]);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentItem--;
            if (currentItem < 0)
            {
                currentItem = listUi.Count - 1;
            }
            EventSystem.current.SetSelectedGameObject(listUi[currentItem]);
        }
    }
}
