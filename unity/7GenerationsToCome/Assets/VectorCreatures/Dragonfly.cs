using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragonfly : VectorCreature {

    
    void Start() {
        IdleInSpace(MotherNature.Environments["AnemonesSky"]);
    }

        
      
    override protected void UpdateCreature()
    {
      //  if (agent.lifetime > 20)
        //    GoFish();
    }

    public void GoFish() {
        GameObject dragon=Instantiate(MotherNature.Creatures["Fish"], transform.position, transform.rotation);
        dragon.GetComponent<Fish>().agent = SymAgent.Create("Fish"); //this.agent;
        dragon.SetActive(true);
        Destroy(this.gameObject);
    }

}
