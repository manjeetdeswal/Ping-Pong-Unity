using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Scored : MonoBehaviour
{

    public EventTrigger.TriggerEvent scoreTrigger;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball != null)
        {

            BaseEventData data = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(data);
        }
        
    }
}
