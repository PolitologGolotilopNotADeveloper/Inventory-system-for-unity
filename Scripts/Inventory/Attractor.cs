using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Attractor : MonoBehaviour
{
    [SerializeField] private Transform attractingPosition;
    private List<Resourse> resoursesInRange = new List<Resourse>();
    [SerializeField] private float speed = 1f;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.TryGetComponent<Resourse>(out Resourse resourse)){
            resoursesInRange.Add(resourse);
        }
    }

    private void Update(){
        foreach (Resourse resourse in resoursesInRange.ToList())
        {  
            try{
                Transform itemTransform = resourse.gameObject.GetComponent<Transform>();
                float step = speed * Time.deltaTime;
                itemTransform.position = Vector2.MoveTowards(itemTransform.position, attractingPosition.position, step);
            }
            catch{
                resoursesInRange.Remove(resourse);
            }
        }
    }
}
