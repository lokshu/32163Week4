using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    // Start is called before the first frame update
    [SerializeField]
    private GameObject blueObj;

    void Start()
    {
        Application.targetFrameRate = 60;
        Vector3 redPos = new Vector3(2, 0, 0);
        Vector3 bluePos = new Vector3(-2, 0, 0);
        Quaternion rotation = Quaternion.Euler(0, 0, 0);
        Instantiate(redObj, redPos, rotation);
        Instantiate(blueObj, bluePos, rotation);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

