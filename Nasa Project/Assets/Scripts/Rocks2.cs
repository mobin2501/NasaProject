using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocks2 : MonoBehaviour
{
    public Transform rock;
    public Vector3 add = new Vector3(1f, 0f, 0f);
    private void FixedUpdate()
    {
        rock.transform.position = rock.transform.position + add * Time.fixedDeltaTime;
        float y = rock.transform.position.y;
        if (rock.transform.position.x > 10)
        {
            rock.transform.position = new Vector3(-10, y, 0f);

        }
        if (rock.transform.position.x < -10)
        {
            rock.transform.position = new Vector3(10, y, 0f);

        }

    }
}
