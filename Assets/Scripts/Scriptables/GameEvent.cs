using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "GameEvent", menuName = "Scriptable/Game Event")]
public class GameEvent : ScriptableObject
{

    public UnityEvent gameEvent = new();


}