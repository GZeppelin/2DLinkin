using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
public class ButtonState
{
    public bool value;
    public float holdTime = 0;
}


public class InputState : MonoBehaviour
{

    public Dictionary<Buttons,ButtonState> buttonsStates = new Dictionary<Buttons,ButtonState>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //  foreach(KeyValuePair<Buttons,ButtonState> kvp in buttonsStates)
      //  {
         //   Debug.Log("Button State" + kvp.Key + " " + kvp.Value.value);
       // }
    }

    public void SetButtonValue(Buttons key,bool value)
    {
        if (!buttonsStates.ContainsKey(key))
        {
           buttonsStates.Add(key, new ButtonState());

        }
        var state = buttonsStates[key];
        if(state.value && !value)
        {
           // Debug.Log("Button" + key +" has been released");
            state.holdTime = 0;
        }
        else if(state.value && value)
        {
            state.holdTime = state.holdTime + Time.deltaTime;
            //Debug.Log("Button" + key + " has been pressed for" + state.holdTime);
            // dsa ads
        }
        state.value = value;
    }
    public bool GetButtonValue(Buttons key)
    {
        if(buttonsStates.ContainsKey(key))
            return buttonsStates[key].value;
        else
            return false;
    }
}
