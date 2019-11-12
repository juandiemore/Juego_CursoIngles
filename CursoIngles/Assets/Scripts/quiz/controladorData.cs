using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorData : MonoBehaviour
{
    public RoundData[] allRoundData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

public RoundData GetCurrentData(){
    return allRoundData[0];
}
}