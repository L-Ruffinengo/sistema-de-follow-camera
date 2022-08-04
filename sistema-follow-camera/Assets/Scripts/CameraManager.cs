using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject[] cameras;
    private int opcion = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            opcion++;
            if (opcion > cameras.Length)
            {
                opcion = 1;
            }
            
            switch (opcion)
            {
                case 1:
                    cameras[0].SetActive(true);
                    cameras[1].SetActive(false);
                    cameras[2].SetActive(false);
                    break;
                case 2:
                    cameras[0].SetActive(false);
                    cameras[1].SetActive(true);
                    cameras[2].SetActive(false);
                    break;
                case 3:
                    cameras[0].SetActive(false);
                    cameras[1].SetActive(false);
                    cameras[2].SetActive(true);
                    break;
            }

        }



    }
}
