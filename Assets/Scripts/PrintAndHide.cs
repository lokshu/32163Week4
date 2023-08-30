using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    public int rand; //random number
    // Start is called before the first frame update
    public Renderer rend;

    void Start()
    {
        rand = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        if (i == 100 && gameObject.CompareTag("Red"))
        {
            gameObject.SetActive(false); // Deactivate the GameObject
        }
        if (i == rand && gameObject.CompareTag("Blue"))
        {
            GetComponent<Renderer>().enabled = false;
        }

    }
}
