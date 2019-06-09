using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "state")]
public class state : ScriptableObject
{
    [TextArea(14,10)] [SerializeField] string storyText;
    [SerializeField] state[] nextState;

    public string GetStateStory()
    {
        return storyText;
    }

    public state[] GetNextState()
    {
        return nextState;
    }
}
