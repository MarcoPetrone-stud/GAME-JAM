using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherNature : MonoBehaviour {

    public List<GameObject> creaturlist=new List<GameObject>(); //Si converte questa lista di creature inserite a mano
    public static Dictionary<string, GameObject> Creatures = new Dictionary<string, GameObject>(); //in questo bellissimo dizionario raggiungibile dinamicamente

    public List<Idlespace> environlist=new List<Idlespace>(); //Si converte questa lista di spazi inseriti a mano
    public static Dictionary<string, Idlespace> Environments = new Dictionary<string, Idlespace>(); //in questo bellissimo dizionario raggiungibile dinamicamente

    public float year = 120; //Un anno in tempo di gioco
    public int characterlife = 5; 
    public float elaspedTime = 0;

    public static MotherNature self;
    public float timescale; //definito dalla scena

    void Awake() {
        self = this;
        foreach (GameObject g in creaturlist) {
            Creatures.Add(g.name, g);
            g.SetActive(false);
        }

        foreach (Idlespace s in environlist) {
            Environments.Add(s.name, s);
            //g.SetActive(false);
        }



    }

    void Update() {
        elaspedTime += timescale * Time.deltaTime;
    }

}