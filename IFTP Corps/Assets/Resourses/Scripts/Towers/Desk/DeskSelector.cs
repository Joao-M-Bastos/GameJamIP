using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskSelector : MonoBehaviour
{
    //[SerializeField] private Transform pointOfSpawn;

    [SerializeField] private Transform pointZero;
    [SerializeField] private Transform pointFull;

    Camera main;
    private void Awake()
    {
        main = Camera.main;
    }
    private void Update()
    {

        Vector3 mousePos = Input.mousePosition;

        mousePos = main.ScreenToWorldPoint(mousePos);
         
        float temp = mousePos.x;

        mousePos.x = mousePos.y;

        mousePos.y = -temp;

        mousePos.z = mousePos.y;
        mousePos.y = 0f;

        mousePos += pointZero.position;

        Debug.Log(mousePos);
        Debug.DrawLine(this.transform.position, mousePos , Color.blue);
        

        if (Input.GetMouseButton(0))
        {
            //Vector3 mousePos = Input.mousePosition;
            mousePos.z = 100;
            mousePos = main.WorldToScreenPoint(mousePos);

            Debug.DrawLine(main.transform.position, mousePos - main.transform.position, Color.blue);
        }
    }
}
