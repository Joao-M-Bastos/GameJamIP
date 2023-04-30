using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskSelector : MonoBehaviour
{
    //[SerializeField] private Transform pointOfSpawn;

    Camera main;
    private void Awake()
    {
        main = Camera.main;
    }
    private void Update()
    {

        Vector3 mousePos = Vector3.zero;//Input.mousePosition;
        mousePos.y = 0f;
        mousePos = main.WorldToScreenPoint(mousePos);

        Debug.Log(mousePos - this.transform.position);
        Debug.DrawLine(this.transform.position, mousePos - this.transform.position, Color.blue);
        

        if (Input.GetMouseButton(0))
        {
            //Vector3 mousePos = Input.mousePosition;
            mousePos.z = 100;
            mousePos = main.WorldToScreenPoint(mousePos);

            Debug.DrawLine(main.transform.position, mousePos - main.transform.position, Color.blue);
        }
    }
}
