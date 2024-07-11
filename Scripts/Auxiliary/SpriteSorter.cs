using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpriteSorter : MonoBehaviour
{
   private SpriteRenderer[] sprites;
   private static int minSortLayer = 3;
   private int sortLayer = minSortLayer;

    private void Start() {
        sprites = GameObject.FindObjectsOfType<SpriteRenderer>();
    }

    private void Update(){
        Array.Sort(sprites, delegate(SpriteRenderer go1, SpriteRenderer go2) {
                    return go1.gameObject.transform.position.y.CompareTo(go2.gameObject.transform.position.y);});

        foreach(SpriteRenderer sprite in sprites){
            sprite.sortingOrder = sortLayer;
            sortLayer+=1;
        }

        sortLayer=minSortLayer;
    }
}
