using UnityEngine;
using System.Collections;

public class ItemPickupObject : CoreObject
{

    private float currentRespawnTime;
    public float respawnTime;

    public string accessory;

    public string weapon;

	// Use this for initialization
	protected override void Start () {
        base.Start();
        currentRespawnTime = respawnTime;
	}
	
	// Update is called once per frame
	protected override void Update () {
        base.Update();
        currentRespawnTime += Time.deltaTime;
	}

    protected override void OnPlayerCollision(PlayerController player)
    {
        base.OnPlayerCollision(player);
        if (currentRespawnTime >= respawnTime && player.motor is BipedMotor)
        {
            if (accessory != null)
            {
                ((BipedStats)player.stats).accessory = accessory;
            }
            if(weapon != null)
            {
                ((BipedStats)player.stats).weapon = player.gameObject.AddComponent<Types.GetType(weapon, );
            }

            respawnTime = 0;
        }
    }
}
