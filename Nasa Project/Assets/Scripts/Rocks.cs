using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocks : MonoBehaviour
{
    public Transform rock;
    public Vector3 add = new Vector3(0f, 1f, 0f);
    private void FixedUpdate()
    {
        rock.transform.position = rock.transform.position + add * Time.fixedDeltaTime;
        float x = rock.transform.position.x;
        if (rock.transform.position.y > 10)
        {
            rock.transform.position = new Vector3(x, -10f, 0f);
            Scoe.score = Scoe.score + 1;
            
         }
        if (rock.transform.position.y <-10)
        {
            rock.transform.position = new Vector3(x, 10f, 0f);
            Scoe.score = Scoe.score + 1;
        }

    }
}