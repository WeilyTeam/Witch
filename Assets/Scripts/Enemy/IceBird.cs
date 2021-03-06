using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBird : BaseEnemy
{
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
        skin = Resources.Load<GameObject>("Prefab/Enemy/Bluebird");
        Hp = 100;
    }

    // Update is called once per frame
    new void Update()
    {
        Fire();
        IsDie();
        StatusCtl(status);
        //Debug.Log(Hp);
        //Debug.Log(status);
    }
    new void Fire()
    {
        if (IsinDistance() == true && attackIsAlready())
        {
            GameObject ice = new GameObject();
            Iceball iceball = ice.AddComponent<Iceball>();
            iceball.Init(character, this.gameObject);
        }
    }


}
