using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Managers.Sound.Play("Bgm_CircusCharlie", Define.Sound.Bgm, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
