using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [Serializable]
    public struct PlayerStats
    {
        public int movementSpeed;
        public int hitPoints;
        public bool hasHealthPotion;
    }

    //Use [SerializeField] attribute to ensure that the private field is serialized
    [SerializeField]
    private PlayerStats stats;
}
