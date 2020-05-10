using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIStatsController : MonoBehaviour
{
    public int playerIndex;
    public Stats stats;
    public Slider slider;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateHealthBar() {
        slider.value = stats.currentHitPoints / stats.HitPoints;
    }

    void Dead() {
    }

    public void SetStats(Stats value) {
        stats = value;
        stats.OnDamaged += UpdateHealthBar;
        stats.OnHealed += UpdateHealthBar;
        stats.OnDead += UpdateHealthBar;
        stats.OnDead += Dead;
    }
}
