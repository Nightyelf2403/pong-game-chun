using UnityEngine;
using UnityEngine.EventSystems;
public class Scoreboard : MonoBehaviour
{
    public EventTrigger.TriggerEvent ScoreTrigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.ScoreTrigger.Invoke(eventData);
        }

    }
}
