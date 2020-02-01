using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : VectorCreature {

    
    void Start() {
        IdleInSpace(MotherNature.Environments["Lake"]);
    }

    
    override protected void UpdateCreature()
    {
        if (agent.lifetime > 6)
            GoDragonfly();
    }

    public void GoDragonfly() {
        GameObject dragon=Instantiate(MotherNature.Creatures["Dragonfly"], transform.position, transform.rotation);
        dragon.SetActive(true);
        dragon.GetComponent<Dragonfly>().agent = this.agent;
        Destroy(this.gameObject);
    }

}
