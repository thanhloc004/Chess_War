using UnityEngine.EventSystems;
using UnityEngine;

public class FloatingJoystick : Joystick
{
    private EntityTurn entityTurn;

    protected override void Start()
    {
        base.Start();
        entityTurn = GameObject.FindWithTag("Player").GetComponent<EntityTurn>();
        background.gameObject.SetActive(false);
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        background.anchoredPosition = ScreenPointToAnchoredPosition(eventData.position);
        background.gameObject.SetActive(true);
        base.OnPointerDown(eventData);
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        entityTurn.Rotation(Direction);
        background.gameObject.SetActive(false);
        base.OnPointerUp(eventData);
    }
}