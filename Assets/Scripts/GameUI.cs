using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField]
    Text m_DmgText;

    [SerializeField]
    Text m_SpeDmgText;

    int dmg;

    int speDmg;

    public void OnUpgradeDmgClick()
    {
        dmg = int.Parse(m_DmgText.text);
        dmg++;
        m_DmgText.text = dmg.ToString();
    }

    public void OnUpgradeSpeDmgClick()
    {
        dmg = int.Parse(m_SpeDmgText.text);
        speDmg++;
        m_SpeDmgText.text = speDmg.ToString();
    }

    public void OnSpecialClick()
    {

    }
}
