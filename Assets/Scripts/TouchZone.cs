using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchZone : MonoBehaviour
{
    public bool isTouched;

    // Start is called before the first frame update
    void Start()
    {
        EventTrigger eventTrigger = gameObject.AddComponent<EventTrigger>();

        EventTrigger.Entry entry_TouchDown = new EventTrigger.Entry();
        entry_TouchDown.eventID = EventTriggerType.PointerDown;
        entry_TouchDown.callback.AddListener((data) => { TouchDown(); });
        eventTrigger.triggers.Add(entry_TouchDown);

        EventTrigger.Entry entry_TouchUp = new EventTrigger.Entry();
        entry_TouchUp.eventID = EventTriggerType.PointerUp;
        entry_TouchUp.callback.AddListener((data) => { TouchUp(); });
        eventTrigger.triggers.Add(entry_TouchUp);
    }

    private void TouchDown()
    {
        isTouched = true;
    }

    private void TouchUp()
    {
        isTouched = false;
    }
}
