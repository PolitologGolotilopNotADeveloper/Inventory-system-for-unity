using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Resourse : MonoBehaviour
{
    public int count = 0;
    public int maxCount = 64;
    public string name;
    public Sprite sprite;

    public void Start() {
        if(sprite==null){
            sprite=gameObject.GetComponent<SpriteRenderer>().sprite;
        }
    }

    public Resourse Take(){
        Destroy(gameObject);
        return gameObject.GetComponent<Resourse>();
    }
}
