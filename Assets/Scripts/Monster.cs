using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Monster : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    public Image m_Monster;

    [SerializeField]
    public Text m_Health;

    [SerializeField]
    public Text m_playerDmg;

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {

        int health = int.Parse(m_Health.text) - int.Parse(m_playerDmg.text);
        m_Health.text = health.ToString();
        Debug.Log("Pointer enter");
    }

}
