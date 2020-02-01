using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorCreature : MonoBehaviour {

    public SymAgent agent;
    public float speed;
    Idlespace currentIdlespace;
    Vector3 targetpoint;

    void Start() {
        
    }

    protected virtual void UpdateCreature() {
    }

    
    void Update() {
        agent.lifetime += Time.deltaTime * MotherNature.self.timescale;
        if (currentIdlespace!=null) {
            if ((targetpoint - transform.position).magnitude < 0.3f)
                targetpoint = currentIdlespace.PickPoint();
            transform.Translate((targetpoint - transform.position).normalized * speed * MotherNature.self.timescale);
        }
        UpdateCreature();
    }

    public void IdleInSpace(Idlespace space) {
        currentIdlespace = space;
        targetpoint = space.PickPoint();
    }

    public void Kill() {
        agent.Destroy();
    }

}

