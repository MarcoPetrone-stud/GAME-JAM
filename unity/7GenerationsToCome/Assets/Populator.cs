using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Populator : MonoBehaviour
{
    void Start() {
        for (int i=0; i<3; i++) {
            GameObject g = Instantiate(MotherNature.Creatures["Fish"], transform.position + Random.insideUnitSphere * 2, Quaternion.identity);
            g.SetActive(true);
            g.GetComponent<Fish>().agent = SymAgent.Create("Fish", Random.Range(0, 2.0f));
          //  g.GetComponent<Fish>().IdleInSpace(GetComponent<Idlespace>());
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
