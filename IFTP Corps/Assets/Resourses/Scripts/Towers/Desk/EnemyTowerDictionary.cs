using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTowerDictionary : MonoBehaviour
{
    [SerializeField] private GameObject[] listOfTowers;
    [SerializeField] private GameObject[] listOfInimigos;

    private static Dictionary<string, GameObject> dicionarioDeTorres;
    private static Dictionary<string, GameObject> dicionarioDeInimigos;

    private void Awake()
    {
        SetDicionariodeTorres();
        SetDicionariodeInimigos();
    }

    private void SetDicionariodeInimigos()
    {
        dicionarioDeInimigos = new Dictionary<string, GameObject>();
        foreach (GameObject g in listOfInimigos)
        {
            dicionarioDeInimigos.Add(g.name, g);
            Debug.Log(g.name);
        }
    }

    private void SetDicionariodeTorres()
    {
        dicionarioDeTorres = new Dictionary<string, GameObject>();
        foreach (GameObject g in listOfTowers)
        {
            Debug.Log(g.name);
            dicionarioDeTorres.Add(g.name,g);
        }
    }

    public static Dictionary<string, GameObject> GetDicionaryDeTorres()
    {
        return dicionarioDeTorres;
    }

    public static Dictionary<string, GameObject> GetDicionaryDeInimigos()
    {
        return dicionarioDeInimigos;
    }
}
